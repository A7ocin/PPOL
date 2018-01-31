

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class HarrisLaplaceFeatureDetector
    //javadoc: HarrisLaplaceFeatureDetector

    public class HarrisLaplaceFeatureDetector : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_HarrisLaplaceFeatureDetector_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal HarrisLaplaceFeatureDetector (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_HarrisLaplaceFeatureDetector create(int numOctaves = 6, float corn_thresh = 0.01f, float DOG_thresh = 0.01f, int maxCorners = 5000, int num_layers = 4)
        //

        //javadoc: HarrisLaplaceFeatureDetector::create(numOctaves, corn_thresh, DOG_thresh, maxCorners, num_layers)
        public static HarrisLaplaceFeatureDetector create (int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners, int num_layers)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HarrisLaplaceFeatureDetector retVal = new HarrisLaplaceFeatureDetector(xfeatures2d_HarrisLaplaceFeatureDetector_create_10(numOctaves, corn_thresh, DOG_thresh, maxCorners, num_layers));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: HarrisLaplaceFeatureDetector::create()
        public static HarrisLaplaceFeatureDetector create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HarrisLaplaceFeatureDetector retVal = new HarrisLaplaceFeatureDetector(xfeatures2d_HarrisLaplaceFeatureDetector_create_11());
        
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



        // C++: static Ptr_HarrisLaplaceFeatureDetector create(int numOctaves = 6, float corn_thresh = 0.01f, float DOG_thresh = 0.01f, int maxCorners = 5000, int num_layers = 4)
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_10 (int numOctaves, float corn_thresh, float DOG_thresh, int maxCorners, int num_layers);
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_HarrisLaplaceFeatureDetector_create_11 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_HarrisLaplaceFeatureDetector_delete (IntPtr nativeObj);

    }
}
