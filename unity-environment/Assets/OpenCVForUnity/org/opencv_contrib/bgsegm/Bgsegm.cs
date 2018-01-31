

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Bgsegm
    //javadoc: Bgsegm

    public class Bgsegm
    {

        //
        // C++:  Ptr_BackgroundSubtractorCNT createBackgroundSubtractorCNT(int minPixelStability = 15, bool useHistory = true, int maxPixelStability = 15*60, bool isParallel = true)
        //

        //javadoc: createBackgroundSubtractorCNT(minPixelStability, useHistory, maxPixelStability, isParallel)
        public static BackgroundSubtractorCNT createBackgroundSubtractorCNT (int minPixelStability, bool useHistory, int maxPixelStability, bool isParallel)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorCNT retVal = new BackgroundSubtractorCNT(bgsegm_Bgsegm_createBackgroundSubtractorCNT_10(minPixelStability, useHistory, maxPixelStability, isParallel));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createBackgroundSubtractorCNT()
        public static BackgroundSubtractorCNT createBackgroundSubtractorCNT ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorCNT retVal = new BackgroundSubtractorCNT(bgsegm_Bgsegm_createBackgroundSubtractorCNT_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_BackgroundSubtractorGMG createBackgroundSubtractorGMG(int initializationFrames = 120, double decisionThreshold = 0.8)
        //

        //javadoc: createBackgroundSubtractorGMG(initializationFrames, decisionThreshold)
        public static BackgroundSubtractorGMG createBackgroundSubtractorGMG (int initializationFrames, double decisionThreshold)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGMG retVal = new BackgroundSubtractorGMG(bgsegm_Bgsegm_createBackgroundSubtractorGMG_10(initializationFrames, decisionThreshold));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createBackgroundSubtractorGMG()
        public static BackgroundSubtractorGMG createBackgroundSubtractorGMG ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorGMG retVal = new BackgroundSubtractorGMG(bgsegm_Bgsegm_createBackgroundSubtractorGMG_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_BackgroundSubtractorMOG createBackgroundSubtractorMOG(int history = 200, int nmixtures = 5, double backgroundRatio = 0.7, double noiseSigma = 0)
        //

        //javadoc: createBackgroundSubtractorMOG(history, nmixtures, backgroundRatio, noiseSigma)
        public static BackgroundSubtractorMOG createBackgroundSubtractorMOG (int history, int nmixtures, double backgroundRatio, double noiseSigma)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorMOG retVal = new BackgroundSubtractorMOG(bgsegm_Bgsegm_createBackgroundSubtractorMOG_10(history, nmixtures, backgroundRatio, noiseSigma));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createBackgroundSubtractorMOG()
        public static BackgroundSubtractorMOG createBackgroundSubtractorMOG ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BackgroundSubtractorMOG retVal = new BackgroundSubtractorMOG(bgsegm_Bgsegm_createBackgroundSubtractorMOG_11());
        
#else
            return null;
#endif
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  Ptr_BackgroundSubtractorCNT createBackgroundSubtractorCNT(int minPixelStability = 15, bool useHistory = true, int maxPixelStability = 15*60, bool isParallel = true)
        [DllImport (LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorCNT_10 (int minPixelStability, bool useHistory, int maxPixelStability, bool isParallel);
        [DllImport (LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorCNT_11 ();

        // C++:  Ptr_BackgroundSubtractorGMG createBackgroundSubtractorGMG(int initializationFrames = 120, double decisionThreshold = 0.8)
        [DllImport (LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGMG_10 (int initializationFrames, double decisionThreshold);
        [DllImport (LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorGMG_11 ();

        // C++:  Ptr_BackgroundSubtractorMOG createBackgroundSubtractorMOG(int history = 200, int nmixtures = 5, double backgroundRatio = 0.7, double noiseSigma = 0)
        [DllImport (LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorMOG_10 (int history, int nmixtures, double backgroundRatio, double noiseSigma);
        [DllImport (LIBNAME)]
        private static extern IntPtr bgsegm_Bgsegm_createBackgroundSubtractorMOG_11 ();

    }
}
