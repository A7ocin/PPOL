using UnityEngine;
using UnityEngine.EventSystems;
using System;
using System.Collections;
using System.Collections.Generic;
using OpenCVForUnityExample;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif
using OpenCVForUnity;


// http://hyunkell.com/blog/rts-style-unit-selection-in-unity-5/
public static class Utilss
{


    public static Bounds GetViewportBounds(Camera camera, Vector3 screenPosition1, Vector3 screenPosition2)
    {
        var v1 = Camera.main.ScreenToViewportPoint(screenPosition1);
        var v2 = Camera.main.ScreenToViewportPoint(screenPosition2);
        var min = Vector3.Min(v1, v2);
        var max = Vector3.Max(v1, v2);
        min.z = camera.nearClipPlane;
        max.z = camera.farClipPlane;

        var bounds = new Bounds();
        bounds.SetMinMax(min, max);
        return bounds;
    }
}
// fine Utilss

public class Tracking : MonoBehaviour
{

    UnityEngine.XR.WSA.WebCam.VideoCapture cap;
    public bool SaveVideoElaborated;

    BackgroundSubtractorMOG2 backgroundSubstractorMOG2;
    Mat rgbMat;
    Mat fgmaskMat;
    Mat fgmaskMatRoi;
    Mat fgmaskMatDilate;
    Mat fgmaskMatDilateRoi;
    Mat blobMat;
    Mat roiHistMat;
    Texture2D texture;
    RenderTexture rt;
    OpenCVForUnity.Rect roiRect;
    TermCriteria termination;
    public int iter;
    public int Numiter = 100;

    public bool HueSat;

    Mat frame;
    Mat hsvMat;
    Mat dest;
    Mat mask_binary;
    Mat mask_binaryRoi;
    Mat roiHSVMat;
    int skipFrame;

    int ss;

    public CameraControllerPTZ cc;

    private int frameRate = 25;
    public string folder = "AcquisizioneVideo";
    private string blobparams_yml_filepath;

    float x_coordinate;
    float y_coordinate;

    public float x_coordinate_for_camera;
    public float y_coordinate_for_camera;

    public float height;
    public float width;
    private bool shouldStartCamShift = false;
    public bool CamShiftOn = false;

    bool isSelecting = false;
    bool clickOnTarget = false;
    Vector3 mousePosition1;

    //public int d = 60; //offset di selezione all'interno dello schermo


    // Use this for initialization
    void Start()
    {

        ss = 0;
        if (SaveVideoElaborated)
        {
            folder = folder + System.DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss");
            if (System.IO.Directory.Exists(folder))
            {
                System.IO.Directory.Delete(folder, true);
            }
            System.IO.Directory.CreateDirectory(folder);
        }
        x_coordinate = 0;
        y_coordinate = 0;

        skipFrame = 0;
        roiRect = null;

        termination = new TermCriteria(TermCriteria.EPS | TermCriteria.COUNT, 10, 1);


        #if UNITY_WEBGL && !UNITY_EDITOR
                            StartCoroutine(Utils.getFilePathAsync("blobparams.yml", (result) => {
                                blobparams_yml_filepath = result;
                            }));
        #else
                blobparams_yml_filepath = Utils.getFilePath("blobparams.yml");
                //Debug.Log(blobparams_yml_filepath);
        #endif

    }

    List<OpenCVForUnity.Rect> roiRect2;
    Point giu = new Point(0, 0);
    Point su = new Point(1, 1);
    Point giu2 = new Point(0, 0);
    Point su2 = new Point(1, 1);
    public int BackFrame = 50;

    public Color color1 = new Color(0.8f, 0.8f, 0.95f, 0.25f);
    public Color color2 = new Color(0.8f, 0.8f, 0.95f);

    public static Color onGuiColor;
    public static UnityEngine.Rect onGuiRect;

    public void OnGUI()
    {
        /* UnityEngine.Rect screenRect = new UnityEngine.Rect(d, d, Screen.width - 2 * d, Screen.height - 2 * d);

         if (screenRect.Contains(Input.mousePosition))
         {
             Utilss.DrawScreenRectBorder(screenRect, 2, new Color(0.8f, 0.8f, 0.95f));
             if (isSelecting)
             {
                 // Create a rect from both mouse positions
                 var rect = Utilss.GetScreenRect(mousePosition1, Input.mousePosition);
                 Utilss.DrawScreenRect(rect, new Color(0.8f, 0.8f, 0.95f, 0.25f));
                 Utilss.DrawScreenRectBorder(rect, 2, new Color(0.8f, 0.8f, 0.95f));
             }
             if (clickOnTarget)
             {

             }
         }*/
        foreach (OpenCVForUnity.Rect out_rect in output_ar)
        {
            Vector3 top_left_pos = new Vector3(out_rect.x, Screen.height - out_rect.y);
            Vector3 bottom_right_pos = new Vector3(out_rect.x + out_rect.width, Screen.height - (out_rect.y + out_rect.height));
            var rect = GetScreenRect(top_left_pos, bottom_right_pos);
            DrawScreenRect(rect, color1);
            //DrawScreenRectBorder(rect, 2, color2);
            GUI.color = onGuiColor;
            GUI.DrawTexture(onGuiRect, WhiteTexture);
            GUI.color = Color.white;
            // Top
            DrawScreenRect(new UnityEngine.Rect(rect.xMin, rect.yMin, rect.width, 2), color2);
            GUI.color = onGuiColor;
            GUI.DrawTexture(onGuiRect, WhiteTexture);
            GUI.color = Color.white;
            // Left
            DrawScreenRect(new UnityEngine.Rect(rect.xMin, rect.yMin, 2, rect.height), color2);
            GUI.color = onGuiColor;
            GUI.DrawTexture(onGuiRect, WhiteTexture);
            GUI.color = Color.white;
            // Right
            DrawScreenRect(new UnityEngine.Rect(rect.xMax - 2, rect.yMin, 2, rect.height), color2);
            GUI.color = onGuiColor;
            GUI.DrawTexture(onGuiRect, WhiteTexture);
            GUI.color = Color.white;
            // Bottom
            DrawScreenRect(new UnityEngine.Rect(rect.xMin, rect.yMax - 2, rect.width, 2), color2);
            GUI.color = onGuiColor;
            GUI.DrawTexture(onGuiRect, WhiteTexture);
            GUI.color = Color.white;
        }
    }
    //
    /*void a()
    {
        UnityEngine.Rect screenRect = new UnityEngine.Rect(d, d, Screen.width - 2 * d, Screen.height - 2 * d);

        if (Input.GetMouseButtonDown(0) && (Input.mousePosition.x >= d) && (Input.mousePosition.y >= d) && (Input.mousePosition.x <= Screen.width - d) && (Input.mousePosition.y <= Screen.height - d))
        {
            Debug.Log("mouse");
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (screenRect.Contains(Input.mousePosition)) giu = new Point(Input.mousePosition.x, cam.Camera.pixelRect.height - Input.mousePosition.y);
            if (screenRect.Contains(Input.mousePosition)) giu2 = new Point(Input.mousePosition.x, Input.mousePosition.y);
            isSelecting = true;
            mousePosition1 = Input.mousePosition;
        }
        if (Input.GetMouseButtonUp(0) && (Input.mousePosition.x >= d) && (Input.mousePosition.y >= d) && (Input.mousePosition.x <= Screen.width - d) && (Input.mousePosition.y <= Screen.height - d))
        {
            Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (screenRect.Contains(Input.mousePosition)) su = new Point(Input.mousePosition.x, cam.Camera.pixelRect.height - Input.mousePosition.y);
            if (screenRect.Contains(Input.mousePosition)) su2 = new Point(Input.mousePosition.x, Input.mousePosition.y);
            isSelecting = false;

            Debug.Log("dimensioni   rettangolo: " + giu + ", " + su);

            if (su == giu)
            {
                ss = 0;
                roiRect = BgSub();
                CamShiftOn = false;
                shouldStartCamShift = true;
            }
            else
            {
                OpenCVForUnity.Rect rettangolo = Imgproc.boundingRect(new MatOfPoint(giu, su));
                roiRect = rettangolo;
                skipFrame = BackFrame; //skip the part of backgroungMOG2 and BgSub()
                ss += ss;
            }

        }
    }*/

    // Update is called once per frame
    void Update()
    {

        //if (Input.GetMouseButton(0))
          //  Debug.Log(Input.mousePosition);

        dest = new OpenCVForUnity.Mat();
        output_ar = new List<OpenCVForUnity.Rect>();
        CurrentFrame();

        if (shouldStartCamShift)
        {
            shouldStartCamShift = false;
            CamShiftOn = true;
            Debug.Log("camshift = on");
        }

        bool backToStart = GetComponent<CameraControllerPTZ>().backToStart;
        
        Debug.Log("camera_in_position" + backToStart);

        if (!CamShiftOn  && backToStart)
        {

            if (skipFrame < BackFrame)
            {
                if (skipFrame == 0)
                {
                    backgroundSubstractorMOG2 = Video.createBackgroundSubtractorMOG2();
                }

                backgroundSubstractorMOG2.apply(rgbMat, fgmaskMat);
                //roiRect = BgSub();

                skipFrame = skipFrame + 1;
            }
            else
            {
                if (ss == 0) roiRect = BgSub();
                //Debug.Log(roiRect);
                if (roiRect != null)
                {
                    shouldStartCamShift = true;
                    Debug.Log("true");
                }
            }
            SaveMatToFile("rgbMat." + ss, rgbMat);
            Debug.Log("backsubtract");

        }

        if (CamShiftOn)
        {
            //a(); // permette selezione del target con il mouse cliccando e trascinando per creare un rettangolo

            hsvMat = new Mat(frame.rows(), frame.cols(), CvType.CV_8UC3);
            Imgproc.cvtColor(rgbMat, hsvMat, Imgproc.COLOR_RGBA2RGB);

            Imgproc.cvtColor(hsvMat, hsvMat, Imgproc.COLOR_RGB2HSV);

            //SaveMatToFile3("hsvMat", hsvMat);
            RunCamShift();
            iter++;
            if (iter > Numiter || roiRect.height > 2*(Screen.height/3))
            {
                CamShiftOn = false;
                skipFrame = 0;
            }

            output_ar.Add(roiRect);
            color1 = new Color(0.1f, 0.9f, 0.1f, 0.1f);
            color2 = new Color(0.1f, 0.9f, 0.1f);
        }

        if (shouldStartCamShift)
        {
            Debug.Log("Starting camshift");
            hsvMat = new Mat(frame.rows(), frame.cols(), CvType.CV_8UC3);
			/*roiHSVMat = new Mat ();
			SaveMatToFile ("roihsvmatpreRGB"+ss, dest);
			Imgproc.cvtColor(roiHSVMat, roiHSVMat, Imgproc.COLOR_RGBA2RGB);
			Imgproc.cvtColor(roiHSVMat, roiHSVMat, Imgproc.COLOR_RGB2HSV); //COLOR_RGB2HSV , COLOR_RGB2YCrCb*/
            Imgproc.cvtColor(dest, hsvMat, Imgproc.COLOR_RGBA2RGB);
            Imgproc.cvtColor(hsvMat, hsvMat, Imgproc.COLOR_RGB2HSV); //COLOR_RGB2HSV , COLOR_RGB2YCrCb
            iter = 0;
            //shouldStartCamShift = false;
            InitCamShift();
            //CamShiftOn = true;
            //Debug.Break();
        }

        if (!CamShiftOn)
        {
            x_coordinate = 0;
            y_coordinate = 0;
            height = 0;
            width = 0;
        }
        else
        {
            Debug.Log("passing coordinates to camera");
            height = (float)(roiRect.height);
            width = (float)(roiRect.width);
            x_coordinate_for_camera = (float)(roiRect.x + (roiRect.width / 2));
            y_coordinate_for_camera = (float)(roiRect.y + (roiRect.height / 2));
            //Debug.Log("rgbMat.size()" + rgbMat.size());

            //Debug.Log ("x_coordinate_for_camera" + x_coordinate_for_camera);

            //Debug.Log ("y_coordinate_for_camera" + y_coordinate_for_camera);

            //Debug.Log("height" + height);
            SaveMatToFile("rgbMat" + ss, rgbMat);
            //Debug.Log("width" + width + " , screen" + Screen.width);
        }



        //skipFrame = skipFrame + 1;
    }


    MatOfInt Ch;
    Mat Hue;
    Mat Sat;
    Mat Bri;
    Mat mask;
    Mat roiHSVMat1;
    Mat roiHSVMat2;
    Mat roiHSVMat3;
    List<Mat> planes0;
    List<Mat> planes1;
    List<Mat> Out;
    List<Mat> channel;

    private void RunCamShift()
    {
        //Debug.Log("qui");
        //Imgproc.rectangle(rgbMat, roiRect.tl(), roiRect.br(), new Scalar(255, 255, 255, 255), 2);
        using (Mat backProj = new Mat())
        {
            Imgproc.calcBackProject(new List<Mat>(new Mat[] { hsvMat }), new MatOfInt(1), roiHistMat, backProj, new MatOfFloat(100, 255), 1.0);


            SaveMatToFile("backProjBefore" + ss, backProj);



            Mat kernelD = new Mat(10, 10, CvType.CV_8UC1, new Scalar(255, 255, 255));
            Imgproc.dilate(backProj, backProj, kernelD);
			Mat new_back_proj = new Mat(frame.rows(), frame.cols(),CvType.CV_8UC1, new Scalar(255, 255, 255)) - backProj;
            //hs();

            
			RotatedRect r = Video.CamShift(backProj, roiRect, termination);
			SaveMatToFile("backProjAfter" + ss, new_back_proj);
            //SaveMatToFile("hsvMat" + ss, hsvMat);
        }
        Imgproc.rectangle(rgbMat, roiRect.tl(), roiRect.br(), new Scalar(0, 255, 0, 255), 2);

    }

    private void InitCamShift()
    {
		roiHSVMat = new Mat (hsvMat, roiRect);
		roiHistMat = new Mat ();
		//roiHSVMat = new Mat ();
		//roiHSVMat = hsvMat.submat (roiRect);
		SaveMatToFile ("hsvMatpre" + ss, hsvMat);
		SaveMatToFile ("roihsvmatpre" + ss, roiHSVMat);

		if (HueSat) {
			Hue_Sat ();
		} else {
			current ();
		}

		SaveMatToFile ("roiHSVMat" + ss, roiHSVMat);

    }


    //----save the frame Hue & Sat-----
    private void hs()
    {
        using (Mat maskMat = new Mat())
        {
            channel = new List<Mat>();
            Core.split(hsvMat, channel);

            roiHSVMat1 = new Mat(channel[0], roiRect);

            roiHSVMat2 = new Mat(channel[1], roiRect);

            roiHSVMat3 = new Mat(channel[2], roiRect);

            Core.addWeighted(channel[0], 1, channel[1], 1, 2, roiHSVMat);
            //Core.addWeighted(roiHSVMat, 1, channel[2], 1, 2, roiHSVMat);
            SaveMatToFile("roiHSVMat." + ss, roiHSVMat);

        }
    }
    //---------------
    //----old-----
    private void current()
    {
        using (Mat maskMat = new Mat())
        {
            Imgproc.calcHist(new List<Mat>(new Mat[] { roiHSVMat }), new MatOfInt(0), maskMat, roiHistMat, new MatOfInt(10), new MatOfFloat(0, 255));
            Core.normalize(roiHistMat, roiHistMat, 0, 255, Core.NORM_MINMAX);
            Imgproc.threshold(roiHistMat, roiHistMat, 123, 255, Imgproc.THRESH_BINARY);
            //Debug.Log ("roiHist " + roiHistMat.ToString ());
        }
    }
    //---------------

    //-------Hue e Sat ----
    private void Hue_Sat()
    {
        using (Mat maskMat = new Mat())
        {
            channel = new List<Mat>();
            Core.split(hsvMat, channel);
            Out = new List<Mat>(new Mat[] { channel[0], channel[1] });
            Core.merge(Out, hsvMat);
            roiHSVMat1 = new Mat(channel[0], roiRect);
            //SaveMatToFile("roiHSVMat1." + ss, roiHSVMat1);
            roiHSVMat2 = new Mat(channel[1], roiRect);
            //SaveMatToFile("roiHSVMat2." + ss, roiHSVMat2);
            planes1 = new List<Mat>(new Mat[] { roiHSVMat1, roiHSVMat2 });
            Core.addWeighted(roiHSVMat1, 1, roiHSVMat2, 1, 2, roiHSVMat);
            //Core.merge(planes1, roiHSVMat );

            Imgproc.calcHist(new List<Mat>(new Mat[] { roiHSVMat }), new MatOfInt(0), maskMat, roiHistMat, new MatOfInt(5), new MatOfFloat(100, 255));
            Core.normalize(roiHistMat, roiHistMat, 0, 255, Core.NORM_MINMAX);
            Imgproc.threshold(roiHistMat, roiHistMat, 123, 255, Imgproc.THRESH_BINARY);
        }
    }
    //--------------------



    public OpenCVForUnity.Rect output;
    static List<OpenCVForUnity.Rect> output_ar = new List<OpenCVForUnity.Rect>();

    private OpenCVForUnity.Rect BgSub()
    {
        backgroundSubstractorMOG2.apply(rgbMat, fgmaskMat);

        roiRect = null;
        fgmaskMatRoi = fgmaskMat;

        Mat kernelD = new Mat(40, 40, CvType.CV_8UC1, new Scalar(255, 255, 255));
        Mat kernelE = new Mat(20, 20, CvType.CV_8UC1, new Scalar(255, 255, 255));

        Mat kernelDRoi = new Mat(1, 1, CvType.CV_8UC1, new Scalar(255, 255, 255));
        Mat kernelERoi = new Mat(1, 1, CvType.CV_8UC1, new Scalar(255, 255, 255));

        Imgproc.dilate(fgmaskMat, fgmaskMatDilate, kernelD);
        Imgproc.erode(fgmaskMatDilate, fgmaskMatDilate, kernelE);

        Imgproc.dilate(fgmaskMatRoi, fgmaskMatDilateRoi, kernelDRoi);
        Imgproc.erode(fgmaskMatDilateRoi, fgmaskMatDilateRoi, kernelERoi);

        mask_binary = new OpenCVForUnity.Mat();
        mask_binaryRoi = new OpenCVForUnity.Mat();

        Imgproc.threshold(fgmaskMatDilate, mask_binary, 123, 255, Imgproc.THRESH_BINARY);
        Imgproc.threshold(fgmaskMatDilateRoi, mask_binaryRoi, 123, 255, Imgproc.THRESH_BINARY);

        List<MatOfPoint> contours = new List<MatOfPoint>();
        OpenCVForUnity.Mat hierarchy = new OpenCVForUnity.Mat();

        Imgproc.findContours(mask_binary, contours, hierarchy, Imgproc.RETR_EXTERNAL, Imgproc.CHAIN_APPROX_NONE);

        if (contours.Count == 0)
        {
            return null;
        }
        else
        {
            int i = 0;
            color1 = new Color(0.8f, 0.8f, 0.95f, 0.25f);
            color2 = new Color(0.8f, 0.8f, 0.95f);
            foreach (MatOfPoint contour in contours) 
            {
                //Debug.Log("number of target: " + i);
                MatOfPoint new_mat1 = new MatOfPoint(contour.toArray());
                output = Imgproc.boundingRect(new_mat1);
                rgbMat.copyTo(dest, mask_binaryRoi);
                //SaveMatToFile("mask_binary" + ss, mask_binary);
                //SaveMatToFile("mask_binaryRoi" + ss, mask_binaryRoi);
                Imgproc.rectangle(rgbMat, output.tl(), output.br(), new Scalar(255, 0, 0), 2);
                output_ar.Add(output);
                Vector3 top_left_pos = new Vector3(output.x, Screen.height - output.y);
                Vector3 bottom_right_pos = new Vector3(output.x + output.width, Screen.height - (output.y + output.height));
                UnityEngine.Rect check_pos = GetScreenRect(top_left_pos, bottom_right_pos);
                i++;
                if (Input.GetMouseButton(0) && check_pos.Contains(new Vector2(Input.mousePosition.x, Screen.height - Input.mousePosition.y)))
                {
                    Debug.Log("take it!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!");
                    //skipFrame = 50;
                    //shouldStartCamShift = true;
                    Debug.Log(output);
                    return output;
                }
                /*else
                {
                    MatOfPoint new_mat2 = new MatOfPoint(contours[0].toArray()); //prende il blob più grande, è il primo perchè la funzione findcontours mette in ordine dal più grande al più piccolo.
                    output = Imgproc.boundingRect(new_mat2);
                }*/
            }
            //OnGUI();
            return null;
        }
    }


    private void SaveMatToFile(String text, Mat saveMat)
    {
		if (SaveVideoElaborated)
		{
			texture = new Texture2D(saveMat.width(), saveMat.height(), TextureFormat.RGB24, false);

			Utils.matToTexture2D(saveMat, texture);

			byte[] bytes = texture.EncodeToPNG();

			string filename = string.Format("{0}/" + text + "_{1:D04}0.png", folder, Time.frameCount);
			System.IO.File.WriteAllBytes(filename, bytes);
		}

    }

    private void CurrentFrame()
    {
        rt = new RenderTexture((int)Camera.main.pixelRect.width, (int)Camera.main.pixelRect.height, 24);
        Camera.main.targetTexture = rt;

        //rt.antiAliasing = 8;

        Texture2D screenShot = new Texture2D(rt.width, rt.height, TextureFormat.RGB24, false);
        Camera.main.Render();
        RenderTexture.active = rt;
        screenShot.ReadPixels(new UnityEngine.Rect(0, 0, rt.width, rt.height), 0, 0);
        Camera.main.targetTexture = null;
        RenderTexture.active = null; // JC: added to avoid errors
        Destroy(rt);
        
        Debug.Log(screenShot.height + "   " + screenShot.width);
        frame = new OpenCVForUnity.Mat(screenShot.height, screenShot.width, CvType.CV_8UC3);

        Debug.Log(frame.rows()+ "  " +frame.cols());

        Utils.texture2DToMat(screenShot, frame);

        rgbMat = new Mat(frame.rows(), frame.cols(), CvType.CV_8UC3);
        fgmaskMat = new Mat(frame.rows(), frame.cols(), CvType.CV_8UC1);
        blobMat = new Mat(frame.rows(), frame.cols(), CvType.CV_8UC3);
        fgmaskMatDilate = new Mat(frame.rows(), frame.cols(), CvType.CV_8UC1);
        fgmaskMatRoi = new Mat(frame.rows(), frame.cols(), CvType.CV_8UC1);
        fgmaskMatDilateRoi = new Mat(frame.rows(), frame.cols(), CvType.CV_8UC1);

        rgbMat = frame;
    }

    
    static Texture2D _whiteTexture;
    public static Texture2D WhiteTexture
    {
        get
        {
            if (_whiteTexture == null)
            {
                _whiteTexture = new Texture2D(1, 1);
                _whiteTexture.SetPixel(0, 0, Color.white);
                _whiteTexture.Apply();
            }

            return _whiteTexture;
        }
    }

    private void DrawRect()
    {

    }

    private void DrawScreenRect(UnityEngine.Rect rect,Color color)
    {
        onGuiColor = color;
        onGuiRect = rect;
    }

    private static UnityEngine.Rect GetScreenRect(Vector3 screenPosition1, Vector3 screenPosition2)
    {
        // Move origin from bottom left to top left
        screenPosition1.y = Screen.height - screenPosition1.y;
        screenPosition2.y = Screen.height - screenPosition2.y;
        // Calculate corners
        var topLeft = Vector3.Min(screenPosition1, screenPosition2);
        var bottomRight = Vector3.Max(screenPosition1, screenPosition2);
        // Create Rect
        return UnityEngine.Rect.MinMaxRect(topLeft.x, topLeft.y, bottomRight.x, bottomRight.y);
    } 

    private void DrawScreenRectBorder(UnityEngine.Rect rect, float thickness, Color color)
    {/*
        // Top
        DrawScreenRect(new UnityEngine.Rect(rect.xMin, rect.yMin, rect.width, thickness), color);
        // Left
        DrawScreenRect(new UnityEngine.Rect(rect.xMin, rect.yMin, thickness, rect.height), color);
        // Right
        DrawScreenRect(new UnityEngine.Rect(rect.xMax - thickness, rect.yMin, thickness, rect.height), color);
        // Bottom
        DrawScreenRect(new UnityEngine.Rect(rect.xMin, rect.yMax - thickness, rect.width, thickness), color);*/
    }
}

