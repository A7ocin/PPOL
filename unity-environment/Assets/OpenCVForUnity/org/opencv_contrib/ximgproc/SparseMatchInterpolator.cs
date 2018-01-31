

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class SparseMatchInterpolator
    //javadoc: SparseMatchInterpolator

    public class SparseMatchInterpolator : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_SparseMatchInterpolator_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal SparseMatchInterpolator (IntPtr addr) : base (addr) { }


        //
        // C++:  void interpolate(Mat from_image, Mat from_points, Mat to_image, Mat to_points, Mat& dense_flow)
        //

        //javadoc: SparseMatchInterpolator::interpolate(from_image, from_points, to_image, to_points, dense_flow)
        public void interpolate (Mat from_image, Mat from_points, Mat to_image, Mat to_points, Mat dense_flow)
        {
            ThrowIfDisposed ();
            if (from_image != null) from_image.ThrowIfDisposed ();
            if (from_points != null) from_points.ThrowIfDisposed ();
            if (to_image != null) to_image.ThrowIfDisposed ();
            if (to_points != null) to_points.ThrowIfDisposed ();
            if (dense_flow != null) dense_flow.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SparseMatchInterpolator_interpolate_10(nativeObj, from_image.nativeObj, from_points.nativeObj, to_image.nativeObj, to_points.nativeObj, dense_flow.nativeObj);
        
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



        // C++:  void interpolate(Mat from_image, Mat from_points, Mat to_image, Mat to_points, Mat& dense_flow)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SparseMatchInterpolator_interpolate_10 (IntPtr nativeObj, IntPtr from_image_nativeObj, IntPtr from_points_nativeObj, IntPtr to_image_nativeObj, IntPtr to_points_nativeObj, IntPtr dense_flow_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SparseMatchInterpolator_delete (IntPtr nativeObj);

    }
}
