

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class CalibrateRobertson
    //javadoc: CalibrateRobertson

    public class CalibrateRobertson : CalibrateCRF
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
photo_CalibrateRobertson_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal CalibrateRobertson (IntPtr addr) : base (addr) { }


        //
        // C++:  Mat getRadiance()
        //

        //javadoc: CalibrateRobertson::getRadiance()
        public Mat getRadiance ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(photo_CalibrateRobertson_getRadiance_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  float getThreshold()
        //

        //javadoc: CalibrateRobertson::getThreshold()
        public float getThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_CalibrateRobertson_getThreshold_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMaxIter()
        //

        //javadoc: CalibrateRobertson::getMaxIter()
        public int getMaxIter ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = photo_CalibrateRobertson_getMaxIter_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setMaxIter(int max_iter)
        //

        //javadoc: CalibrateRobertson::setMaxIter(max_iter)
        public void setMaxIter (int max_iter)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_CalibrateRobertson_setMaxIter_10(nativeObj, max_iter);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setThreshold(float threshold)
        //

        //javadoc: CalibrateRobertson::setThreshold(threshold)
        public void setThreshold (float threshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_CalibrateRobertson_setThreshold_10(nativeObj, threshold);
        
#else
            return;
#endif
            return;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  Mat getRadiance()
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_CalibrateRobertson_getRadiance_10 (IntPtr nativeObj);

        // C++:  float getThreshold()
        [DllImport (LIBNAME)]
        private static extern float photo_CalibrateRobertson_getThreshold_10 (IntPtr nativeObj);

        // C++:  int getMaxIter()
        [DllImport (LIBNAME)]
        private static extern int photo_CalibrateRobertson_getMaxIter_10 (IntPtr nativeObj);

        // C++:  void setMaxIter(int max_iter)
        [DllImport (LIBNAME)]
        private static extern void photo_CalibrateRobertson_setMaxIter_10 (IntPtr nativeObj, int max_iter);

        // C++:  void setThreshold(float threshold)
        [DllImport (LIBNAME)]
        private static extern void photo_CalibrateRobertson_setThreshold_10 (IntPtr nativeObj, float threshold);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void photo_CalibrateRobertson_delete (IntPtr nativeObj);

    }
}
