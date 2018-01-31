

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class CalibrateCRF
    //javadoc: CalibrateCRF

    public class CalibrateCRF : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
photo_CalibrateCRF_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal CalibrateCRF (IntPtr addr) : base (addr) { }


        //
        // C++:  void process(vector_Mat src, Mat& dst, Mat times)
        //

        //javadoc: CalibrateCRF::process(src, dst, times)
        public void process (List<Mat> src, Mat dst, Mat times)
        {
            ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (times != null) times.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat src_mat = Converters.vector_Mat_to_Mat(src);
        photo_CalibrateCRF_process_10(nativeObj, src_mat.nativeObj, dst.nativeObj, times.nativeObj);
        
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



        // C++:  void process(vector_Mat src, Mat& dst, Mat times)
        [DllImport (LIBNAME)]
        private static extern void photo_CalibrateCRF_process_10 (IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_nativeObj, IntPtr times_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void photo_CalibrateCRF_delete (IntPtr nativeObj);

    }
}
