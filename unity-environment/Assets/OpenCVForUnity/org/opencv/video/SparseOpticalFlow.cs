

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class SparseOpticalFlow
    //javadoc: SparseOpticalFlow

    public class SparseOpticalFlow : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
video_SparseOpticalFlow_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal SparseOpticalFlow (IntPtr addr) : base (addr) { }


        //
        // C++:  void calc(Mat prevImg, Mat nextImg, Mat prevPts, Mat& nextPts, Mat& status, Mat& err = cv::Mat())
        //

        //javadoc: SparseOpticalFlow::calc(prevImg, nextImg, prevPts, nextPts, status, err)
        public void calc (Mat prevImg, Mat nextImg, Mat prevPts, Mat nextPts, Mat status, Mat err)
        {
            ThrowIfDisposed ();
            if (prevImg != null) prevImg.ThrowIfDisposed ();
            if (nextImg != null) nextImg.ThrowIfDisposed ();
            if (prevPts != null) prevPts.ThrowIfDisposed ();
            if (nextPts != null) nextPts.ThrowIfDisposed ();
            if (status != null) status.ThrowIfDisposed ();
            if (err != null) err.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_SparseOpticalFlow_calc_10(nativeObj, prevImg.nativeObj, nextImg.nativeObj, prevPts.nativeObj, nextPts.nativeObj, status.nativeObj, err.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: SparseOpticalFlow::calc(prevImg, nextImg, prevPts, nextPts, status)
        public void calc (Mat prevImg, Mat nextImg, Mat prevPts, Mat nextPts, Mat status)
        {
            ThrowIfDisposed ();
            if (prevImg != null) prevImg.ThrowIfDisposed ();
            if (nextImg != null) nextImg.ThrowIfDisposed ();
            if (prevPts != null) prevPts.ThrowIfDisposed ();
            if (nextPts != null) nextPts.ThrowIfDisposed ();
            if (status != null) status.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_SparseOpticalFlow_calc_11(nativeObj, prevImg.nativeObj, nextImg.nativeObj, prevPts.nativeObj, nextPts.nativeObj, status.nativeObj);
        
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



        // C++:  void calc(Mat prevImg, Mat nextImg, Mat prevPts, Mat& nextPts, Mat& status, Mat& err = cv::Mat())
        [DllImport (LIBNAME)]
        private static extern void video_SparseOpticalFlow_calc_10 (IntPtr nativeObj, IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_nativeObj, IntPtr nextPts_nativeObj, IntPtr status_nativeObj, IntPtr err_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void video_SparseOpticalFlow_calc_11 (IntPtr nativeObj, IntPtr prevImg_nativeObj, IntPtr nextImg_nativeObj, IntPtr prevPts_nativeObj, IntPtr nextPts_nativeObj, IntPtr status_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void video_SparseOpticalFlow_delete (IntPtr nativeObj);

    }
}
