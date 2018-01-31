using UnityEngine;
using System.Collections.Generic;

public class CamerasManager : MonoBehaviour {

   public bool enableVideoSave;
   //public bool enableDataSave;

   public string folder = "AcquisizioneVideo";
   public int frameRate = 25;

   public List<CameraType> cameras = new List<CameraType>();

   // inizializzazione
   void Start() {
      if(enableVideoSave) {
         Time.captureFramerate = frameRate;

         if(cameras.Count > 0) {
            // crea la cartella principale nella quale verranno create una sottocartella per ogni telecamera
            folder = folder + System.DateTime.Now.ToString("_yyyy-MM-dd_HH-mm-ss");
            if(System.IO.Directory.Exists(folder)) {
               System.IO.Directory.Delete(folder, true);
            }
            System.IO.Directory.CreateDirectory(folder);

            // crea una sottocartella per ogni telecamera
            for(int i = 0; i < cameras.Count; ++i) {
               if(cameras[i].Camera) {
                  cameras[i].Folder = string.Format("{0}/{1}_{2}x{3}_{4}fps",
                                                     folder,
                                                     cameras[i].Name,
                                                     cameras[i].Camera.rect.width,
                                                     cameras[i].Camera.rect.height,
                                                     frameRate);
                  System.IO.Directory.CreateDirectory(cameras[i].Folder);
               }
            }
         }
      }
   }

   // funzione chiamata dopo Update()
   void LateUpdate() {
      if(enableVideoSave) {
         // per ogni telecamera
         for(int i = 0; i < cameras.Count; ++i) {
            if(cameras[i].Camera) {
               RenderTexture rt = new RenderTexture((int) cameras[i].Camera.rect.width, (int) cameras[i].Camera.rect.height, 24);
               cameras[i].Camera.targetTexture = rt;

               rt.antiAliasing = 8;

               Texture2D screenShot = new Texture2D(rt.width, rt.height, TextureFormat.RGB24, false);
               cameras[i].Camera.Render();
               RenderTexture.active = rt;
               screenShot.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
               cameras[i].Camera.targetTexture = null;
               RenderTexture.active = null; 
               Destroy(rt);
               
               byte[] bytes = screenShot.EncodeToPNG();

               string filename = string.Format("{0}/frame_{1:D04}.png", cameras[i].Folder, Time.frameCount);
               System.IO.File.WriteAllBytes(filename, bytes);
               Destroy(screenShot);
               }
         }
      }
   }
}

[System.Serializable]
public class CameraType {
   public string Name;
   public Camera Camera;
   public string Folder;

   public CameraType(string _Name) {
      Name = _Name;
   }
}
