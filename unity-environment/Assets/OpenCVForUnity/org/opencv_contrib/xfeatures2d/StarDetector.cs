

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class StarDetector
    //javadoc: StarDetector

    public class StarDetector : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_StarDetector_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal StarDetector (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_StarDetector create(int maxSize = 45, int responseThreshold = 30, int lineThresholdProjected = 10, int lineThresholdBinarized = 8, int suppressNonmaxSize = 5)
        //

        //javadoc: StarDetector::create(maxSize, responseThreshold, lineThresholdProjected, lineThresholdBinarized, suppressNonmaxSize)
        public static StarDetector create (int maxSize, int responseThreshold, int lineThresholdProjected, int lineThresholdBinarized, int suppressNonmaxSize)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        StarDetector retVal = new StarDetector(xfeatures2d_StarDetector_create_10(maxSize, responseThreshold, lineThresholdProjected, lineThresholdBinarized, suppressNonmaxSize));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: StarDetector::create()
        public static StarDetector create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        StarDetector retVal = new StarDetector(xfeatures2d_StarDetector_create_11());
        
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



        // C++: static Ptr_StarDetector create(int maxSize = 45, int responseThreshold = 30, int lineThresholdProjected = 10, int lineThresholdBinarized = 8, int suppressNonmaxSize = 5)
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_10 (int maxSize, int responseThreshold, int lineThresholdProjected, int lineThresholdBinarized, int suppressNonmaxSize);
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_StarDetector_create_11 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_StarDetector_delete (IntPtr nativeObj);

    }
}
