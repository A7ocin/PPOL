

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class WhiteBalancer
    //javadoc: WhiteBalancer

    public class WhiteBalancer : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xphoto_WhiteBalancer_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal WhiteBalancer (IntPtr addr) : base (addr) { }


        //
        // C++:  void balanceWhite(Mat src, Mat& dst)
        //

        //javadoc: WhiteBalancer::balanceWhite(src, dst)
        public void balanceWhite (Mat src, Mat dst)
        {
            ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_WhiteBalancer_balanceWhite_10(nativeObj, src.nativeObj, dst.nativeObj);
        
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



        // C++:  void balanceWhite(Mat src, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void xphoto_WhiteBalancer_balanceWhite_10 (IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void xphoto_WhiteBalancer_delete (IntPtr nativeObj);

    }
}
