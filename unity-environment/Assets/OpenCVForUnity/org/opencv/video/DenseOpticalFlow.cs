

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class DenseOpticalFlow
    //javadoc: DenseOpticalFlow

    public class DenseOpticalFlow : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
video_DenseOpticalFlow_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal DenseOpticalFlow (IntPtr addr) : base (addr) { }


        //
        // C++:  void calc(Mat I0, Mat I1, Mat& flow)
        //

        //javadoc: DenseOpticalFlow::calc(I0, I1, flow)
        public void calc (Mat I0, Mat I1, Mat flow)
        {
            ThrowIfDisposed ();
            if (I0 != null) I0.ThrowIfDisposed ();
            if (I1 != null) I1.ThrowIfDisposed ();
            if (flow != null) flow.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DenseOpticalFlow_calc_10(nativeObj, I0.nativeObj, I1.nativeObj, flow.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void collectGarbage()
        //

        //javadoc: DenseOpticalFlow::collectGarbage()
        public void collectGarbage ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DenseOpticalFlow_collectGarbage_10(nativeObj);
        
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



        // C++:  void calc(Mat I0, Mat I1, Mat& flow)
        [DllImport (LIBNAME)]
        private static extern void video_DenseOpticalFlow_calc_10 (IntPtr nativeObj, IntPtr I0_nativeObj, IntPtr I1_nativeObj, IntPtr flow_nativeObj);

        // C++:  void collectGarbage()
        [DllImport (LIBNAME)]
        private static extern void video_DenseOpticalFlow_collectGarbage_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void video_DenseOpticalFlow_delete (IntPtr nativeObj);

    }
}
