

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class Tonemap
    //javadoc: Tonemap

    public class Tonemap : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
photo_Tonemap_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal Tonemap (IntPtr addr) : base (addr) { }


        //
        // C++:  float getGamma()
        //

        //javadoc: Tonemap::getGamma()
        public float getGamma ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_Tonemap_getGamma_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void process(Mat src, Mat& dst)
        //

        //javadoc: Tonemap::process(src, dst)
        public void process (Mat src, Mat dst)
        {
            ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Tonemap_process_10(nativeObj, src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setGamma(float gamma)
        //

        //javadoc: Tonemap::setGamma(gamma)
        public void setGamma (float gamma)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Tonemap_setGamma_10(nativeObj, gamma);
        
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



        // C++:  float getGamma()
        [DllImport (LIBNAME)]
        private static extern float photo_Tonemap_getGamma_10 (IntPtr nativeObj);

        // C++:  void process(Mat src, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void photo_Tonemap_process_10 (IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void setGamma(float gamma)
        [DllImport (LIBNAME)]
        private static extern void photo_Tonemap_setGamma_10 (IntPtr nativeObj, float gamma);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void photo_Tonemap_delete (IntPtr nativeObj);

    }
}
