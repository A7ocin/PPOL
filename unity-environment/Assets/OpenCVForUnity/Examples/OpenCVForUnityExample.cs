﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

#if UNITY_5_3 || UNITY_5_3_OR_NEWER
using UnityEngine.SceneManagement;
#endif

namespace OpenCVForUnityExample
{
    public class OpenCVForUnityExample : MonoBehaviour
    {
        // Use this for initialization
        void Start ()
        {
            #if UNITY_WEBGL || UNITY_WSA_10_0
            GameObject.Find ("Canvas/SceneList/ScrollView/List/MainModulesGroup/MobileNetSSDExampleButton").GetComponent<Button> ().interactable = false;
            GameObject.Find ("Canvas/SceneList/ScrollView/List/MainModulesGroup/MobileNetSSDWebCamTextureExampleButton").GetComponent<Button> ().interactable = false;
            GameObject.Find ("Canvas/SceneList/ScrollView/List/MainModulesGroup/ResnetSSDFaceDetectionExampleButton").GetComponent<Button> ().interactable = false;
            GameObject.Find ("Canvas/SceneList/ScrollView/List/MainModulesGroup/TensorFlowWebCamTextureExampleButton").GetComponent<Button> ().interactable = false;
            GameObject.Find ("Canvas/SceneList/ScrollView/List/MainModulesGroup/YoloObjectDetectionExampleButton").GetComponent<Button> ().interactable = false;
            GameObject.Find ("Canvas/SceneList/ScrollView/List/MainModulesGroup/YoloObjectDetectionWebCamTextureExampleButton").GetComponent<Button> ().interactable = false;

            GameObject.Find ("Canvas/SceneList/ScrollView/List/ContribModulesGroup/TextDetectionExampleButton").GetComponent<Button> ().interactable = false;
            GameObject.Find ("Canvas/SceneList/ScrollView/List/ContribModulesGroup/TextRecognitionExampleButton").GetComponent<Button> ().interactable = false;
            #endif
        }
    
        // Update is called once per frame
        void Update ()
        {

        }

        public void OnShowLicenseButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("ShowLicense");
            #else
            Application.LoadLevel ("ShowLicense");
            #endif
        }

        public void OnTexture2DToMatExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("Texture2DToMatExample");
            #else
            Application.LoadLevel ("Texture2DToMatExample");
            #endif
        }

        public void OnThresholdExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("ThresholdExample");
            #else
            Application.LoadLevel ("ThresholdExample");
            #endif
        }

        public void OnDrawingExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("DrawingExample");
            #else
            Application.LoadLevel ("DrawingExample");
            #endif
        }

        public void OnConvexHullExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("ConvexHullExample");
            #else
            Application.LoadLevel ("ConvexHullExample");
            #endif
        }

        public void OnHoughLinesPExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("HoughLinesPExample");
            #else
            Application.LoadLevel ("HoughLinesPExample");
            #endif
        }

        public void OnFeature2DExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("Feature2DExample");
            #else
            Application.LoadLevel ("Feature2DExample");
            #endif
        }

        public void OnWrapPerspectiveExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("WrapPerspectiveExample");
            #else
            Application.LoadLevel ("WrapPerspectiveExample");
            #endif
        }

        public void OnFaceRecognizerExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("FaceRecognizerExample");
            #else
            Application.LoadLevel ("FaceRecognizerExample");
            #endif
        }

        public void OnFaceDetectionExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("FaceDetectionExample");
            #else
            Application.LoadLevel ("FaceDetectionExample");
            #endif
        }

        public void OnWebCamTextureToMatExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("WebCamTextureToMatExample");
            #else
            Application.LoadLevel ("WebCamTextureToMatExample");
            #endif
        }

        public void OnWebCamTextureToMatHelperExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("WebCamTextureToMatHelperExample");
            #else
            Application.LoadLevel ("WebCamTextureToMatHelperExample");
            #endif
        }

        public void OnFaceDetectionWebCamTextureExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("FaceDetectionWebCamTextureExample");
            #else
            Application.LoadLevel ("FaceDetectionWebCamTextureExample");
            #endif
        }

        public void OnAsynchronousFaceDetectionWebCamTextureExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("AsynchronousFaceDetectionWebCamTextureExample");
            #else
            Application.LoadLevel ("AsynchronousFaceDetectionWebCamTextureExample");
            #endif
        }

        public void OnOpticalFlowExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("OpticalFlowExample");
            #else
            Application.LoadLevel ("OpticalFlowExample");
            #endif
        }

        public void OnComicFilterExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("ComicFilterExample");
            #else
            Application.LoadLevel ("ComicFilterExample");
            #endif
        }

        public void OnCamShiftExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("CamShiftExample");
            #else
            Application.LoadLevel ("CamShiftExample");
            #endif
        }

        public void OnHandPoseEstimationExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("HandPoseEstimationExample");
            #else
            Application.LoadLevel ("HandPoseEstimationExample");
            #endif
        }

        public void OnMultiObjectTrackingBasedOnColorExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("MultiObjectTrackingBasedOnColorExample");
            #else
            Application.LoadLevel ("MultiObjectTrackingBasedOnColorExample");
            #endif
        }

        public void OnPlotExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("PlotExample");
            #else
            Application.LoadLevel ("PlotExample");
            #endif
        }

        public void OnSimpleBlobExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("SimpleBlobExample");
            #else
            Application.LoadLevel ("SimpleBlobExample");
            #endif
        }

        public void OnBackgroundSubtractorMOG2ExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("BackgroundSubtractorMOG2Example");
            #else
            Application.LoadLevel ("BackgroundSubtractorMOG2Example");
            #endif
        }

        public void OnVideoCaptureExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("VideoCaptureExample");
            #else
            Application.LoadLevel ("VideoCaptureExample");
            #endif
        }

        public void OnMatchTemplateExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("MatchTemplateExample");
            #else
            Application.LoadLevel ("MatchTemplateExample");
            #endif
        }

        public void OnStereoBMExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("StereoBMExample");
            #else
            Application.LoadLevel ("StereoBMExample");
            #endif
        }

        public void OnSeamlessCloneExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("SeamlessCloneExample");
            #else
            Application.LoadLevel ("SeamlessCloneExample");
            #endif
        }

        public void OnCircleDetectionExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("CircleDetectionExample");
            #else
            Application.LoadLevel ("CircleDetectionExample");
            #endif
        }

        public void OnSVMExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("SVMExample");
            #else
            Application.LoadLevel ("SVMExample");
            #endif
        }

        public void OnHOGDescriptorExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("HOGDescriptorExample");
            #else
            Application.LoadLevel ("HOGDescriptorExample");
            #endif
        }

        public void OnArUcoCreateMarkerExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("ArUcoCreateMarkerExample");
            #else
            Application.LoadLevel ("ArUcoCreateMarkerExample");
            #endif
        }

        public void OnArUcoExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("ArUcoExample");
            #else
            Application.LoadLevel ("ArUcoExample");
            #endif
        }

        public void OnArUcoWebCamTextureExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("ArUcoWebCamTextureExample");
            #else
            Application.LoadLevel ("ArUcoWebCamTextureExample");
            #endif
        }

        public void OnGrabCutExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("GrabCutExample");
            #else
            Application.LoadLevel ("GrabCutExample");
            #endif
        }

        public void OnInpaintExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("InpaintExample");
            #else
            Application.LoadLevel ("InpaintExample");
            #endif
        }

        public void OnMatchShapesExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("MatchShapesExample");
            #else
            Application.LoadLevel ("MatchShapesExample");
            #endif
        }

        public void OnMSERExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("MSERExample");
            #else
            Application.LoadLevel ("MSERExample");
            #endif
        }

        public void OnPolygonFilterExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("PolygonFilterExample");
            #else
            Application.LoadLevel ("PolygonFilterExample");
            #endif
        }

        public void OnConnectedComponentsExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("ConnectedComponentsExample");
            #else
            Application.LoadLevel ("ConnectedComponentsExample");
            #endif
        }

        public void OnGreenScreenExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("GreenScreenExample");
            #else
            Application.LoadLevel ("GreenScreenExample");
            #endif
        }

        public void OnTrackingExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("TrackingExample");
            #else
            Application.LoadLevel ("TrackingExample");
            #endif
        }

        public void OnPCAExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("PCAExample");
            #else
            Application.LoadLevel ("PCAExample");
            #endif
        }

        public void OnThinPlateSplineShapeTransformerExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("ThinPlateSplineShapeTransformerExample");
            #else
            Application.LoadLevel ("ThinPlateSplineShapeTransformerExample");
            #endif
        }

        public void OnVideoWriterExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("VideoWriterExample");
            #else
            Application.LoadLevel ("VideoWriterExample");
            #endif
        }


        public void OnTextDetectionExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("TextDetectionExample");
            #else
            Application.LoadLevel ("TextDetectionExample");
            #endif
        }

        public void OnTextRecognitionExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("TextRecognitionExample");
            #else
            Application.LoadLevel ("TextRecognitionExample");
            #endif
        }


        public void OnSegmentedWordRecognitionExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("SegmentedWordRecognitionExample");
            #else
            Application.LoadLevel ("SegmentedWordRecognitionExample");
            #endif
        }

        public void OnMobileNetSSDExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("MobileNetSSDExample");
            #else
            Application.LoadLevel ("MobileNetSSDExample");
            #endif
        }

        public void OnMobileNetSSDWebCamTextureExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("MobileNetSSDWebCamTextureExample");
            #else
            Application.LoadLevel ("MobileNetSSDWebCamTextureExample");
            #endif
        }

        public void OnResnetSSDFaceDetectionExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("ResnetSSDFaceDetectionExample");
            #else
            Application.LoadLevel ("ResnetSSDFaceDetectionExample");
            #endif
        }

        public void OnTensorFlowWebCamTextureExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("TensorFlowWebCamTextureExample");
            #else
            Application.LoadLevel ("TensorFlowWebCamTextureExample");
            #endif
        }

        public void OnYoloObjectDetectionExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("YoloObjectDetectionExample");
            #else
            Application.LoadLevel ("YoloObjectDetectionExample");
            #endif
        }

        public void OnYoloObjectDetectionWebCamTextureExampleButtonClick ()
        {
            #if UNITY_5_3 || UNITY_5_3_OR_NEWER
            SceneManager.LoadScene ("YoloObjectDetectionWebCamTextureExample");
            #else
            Application.LoadLevel ("YoloObjectDetectionWebCamTextureExample");
            #endif
        }
    }
}