

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class GuidedFilter
    //javadoc: GuidedFilter

    public class GuidedFilter : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_GuidedFilter_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal GuidedFilter (IntPtr addr) : base (addr) { }


        //
        // C++:  void filter(Mat src, Mat& dst, int dDepth = -1)
        //

        //javadoc: GuidedFilter::filter(src, dst, dDepth)
        public void filter (Mat src, Mat dst, int dDepth)
        {
            ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_GuidedFilter_filter_10(nativeObj, src.nativeObj, dst.nativeObj, dDepth);
        
#else
            return;
#endif
            return;
        }

        //javadoc: GuidedFilter::filter(src, dst)
        public void filter (Mat src, Mat dst)
        {
            ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_GuidedFilter_filter_11(nativeObj, src.nativeObj, dst.nativeObj);
        
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



        // C++:  void filter(Mat src, Mat& dst, int dDepth = -1)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_GuidedFilter_filter_10 (IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int dDepth);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_GuidedFilter_filter_11 (IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_GuidedFilter_delete (IntPtr nativeObj);

    }
}
