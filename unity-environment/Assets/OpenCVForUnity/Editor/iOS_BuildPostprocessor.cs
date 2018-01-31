#if (UNITY_5 || UNITY_5_3_OR_NEWER) && UNITY_IOS
using UnityEngine;
using UnityEditor;
using UnityEditor.Callbacks;
using UnityEditor.iOS.Xcode;

#if UNITY_2017_2_OR_NEWER
using UnityEditor.iOS.Xcode.Extensions;
#endif
using System;
using System.Collections;
using System.IO;

namespace OpenCVForUnity
{
    public class iOS_BuildPostprocessor : MonoBehaviour
    {
        [PostProcessBuild]
        public static void OnPostprocessBuild (BuildTarget buildTarget, string path)
        {
            if (buildTarget == BuildTarget.iOS) {

#if UNITY_5_0 || UNITY_5_1 || UNITY5_2
                                string projPath = path + "/Unity-iPhone.xcodeproj/project.pbxproj";
#else
                string projPath = PBXProject.GetPBXProjectPath (path);
#endif
            
                PBXProject proj = new PBXProject ();
                proj.ReadFromString (System.IO.File.ReadAllText (projPath));
                    
#if UNITY_5_0 || UNITY_5_1 || UNITY5_2
                                string target = proj.TargetGuidByName ("Unity-iPhone");
#else
                string target = proj.TargetGuidByName (PBXProject.GetUnityTargetName ());
#endif


#if UNITY_2017_2_OR_NEWER
                string frameworkPath = "Frameworks/OpenCVForUnity/Plugins/iOS/opencv2.framework";
                string fileGuid = proj.FindFileGuidByProjectPath(frameworkPath);

                proj.AddFileToBuild(target, fileGuid);
                proj.AddFileToEmbedFrameworks(target, fileGuid);
                foreach (var configName in proj.BuildConfigNames()) {
                    var configGuid = proj.BuildConfigByName(target, configName);
                    proj.SetBuildPropertyForConfig(configGuid, "LD_RUNPATH_SEARCH_PATHS", "$(inherited) @executable_path/Frameworks");
                }
#else
                Debug.LogError ("If the version of Unity is less than 2017.2, you have to set opencv2.framework to Embedded Binaries manually.");
#endif

                File.WriteAllText (projPath, proj.WriteToString ());

#if UNITY_5_5_OR_NEWER
                if((int)Convert.ToDecimal(PlayerSettings.iOS.targetOSVersionString) < 8){
#else
                if ((int)PlayerSettings.iOS.targetOSVersion < (int)iOSTargetOSVersion.iOS_8_0) {
#endif
                    Debug.LogError ("Please set Target minimum iOS Version to 8.0 or higher.");
                }

            }
        }
    }
}
#endif