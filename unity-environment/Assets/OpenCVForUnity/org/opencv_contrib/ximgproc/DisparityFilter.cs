

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class DisparityFilter
    //javadoc: DisparityFilter

    public class DisparityFilter : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_DisparityFilter_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal DisparityFilter (IntPtr addr) : base (addr) { }


        //
        // C++:  void filter(Mat disparity_map_left, Mat left_view, Mat& filtered_disparity_map, Mat disparity_map_right = Mat(), Rect ROI = Rect(), Mat right_view = Mat())
        //

        //javadoc: DisparityFilter::filter(disparity_map_left, left_view, filtered_disparity_map, disparity_map_right, ROI, right_view)
        public void filter (Mat disparity_map_left, Mat left_view, Mat filtered_disparity_map, Mat disparity_map_right, Rect ROI, Mat right_view)
        {
            ThrowIfDisposed ();
            if (disparity_map_left != null) disparity_map_left.ThrowIfDisposed ();
            if (left_view != null) left_view.ThrowIfDisposed ();
            if (filtered_disparity_map != null) filtered_disparity_map.ThrowIfDisposed ();
            if (disparity_map_right != null) disparity_map_right.ThrowIfDisposed ();
            if (right_view != null) right_view.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_DisparityFilter_filter_10(nativeObj, disparity_map_left.nativeObj, left_view.nativeObj, filtered_disparity_map.nativeObj, disparity_map_right.nativeObj, ROI.x, ROI.y, ROI.width, ROI.height, right_view.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: DisparityFilter::filter(disparity_map_left, left_view, filtered_disparity_map)
        public void filter (Mat disparity_map_left, Mat left_view, Mat filtered_disparity_map)
        {
            ThrowIfDisposed ();
            if (disparity_map_left != null) disparity_map_left.ThrowIfDisposed ();
            if (left_view != null) left_view.ThrowIfDisposed ();
            if (filtered_disparity_map != null) filtered_disparity_map.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_DisparityFilter_filter_11(nativeObj, disparity_map_left.nativeObj, left_view.nativeObj, filtered_disparity_map.nativeObj);
        
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



        // C++:  void filter(Mat disparity_map_left, Mat left_view, Mat& filtered_disparity_map, Mat disparity_map_right = Mat(), Rect ROI = Rect(), Mat right_view = Mat())
        [DllImport (LIBNAME)]
        private static extern void ximgproc_DisparityFilter_filter_10 (IntPtr nativeObj, IntPtr disparity_map_left_nativeObj, IntPtr left_view_nativeObj, IntPtr filtered_disparity_map_nativeObj, IntPtr disparity_map_right_nativeObj, int ROI_x, int ROI_y, int ROI_width, int ROI_height, IntPtr right_view_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_DisparityFilter_filter_11 (IntPtr nativeObj, IntPtr disparity_map_left_nativeObj, IntPtr left_view_nativeObj, IntPtr filtered_disparity_map_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_DisparityFilter_delete (IntPtr nativeObj);

    }
}
