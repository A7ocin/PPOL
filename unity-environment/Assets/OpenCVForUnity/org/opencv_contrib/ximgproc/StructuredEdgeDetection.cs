

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class StructuredEdgeDetection
    //javadoc: StructuredEdgeDetection

    public class StructuredEdgeDetection : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_StructuredEdgeDetection_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal StructuredEdgeDetection (IntPtr addr) : base (addr) { }


        //
        // C++:  void computeOrientation(Mat _src, Mat& _dst)
        //

        //javadoc: StructuredEdgeDetection::computeOrientation(_src, _dst)
        public void computeOrientation (Mat _src, Mat _dst)
        {
            ThrowIfDisposed ();
            if (_src != null) _src.ThrowIfDisposed ();
            if (_dst != null) _dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_StructuredEdgeDetection_computeOrientation_10(nativeObj, _src.nativeObj, _dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void detectEdges(Mat _src, Mat& _dst)
        //

        //javadoc: StructuredEdgeDetection::detectEdges(_src, _dst)
        public void detectEdges (Mat _src, Mat _dst)
        {
            ThrowIfDisposed ();
            if (_src != null) _src.ThrowIfDisposed ();
            if (_dst != null) _dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_StructuredEdgeDetection_detectEdges_10(nativeObj, _src.nativeObj, _dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void edgesNms(Mat edge_image, Mat orientation_image, Mat& _dst, int r = 2, int s = 0, float m = 1, bool isParallel = true)
        //

        //javadoc: StructuredEdgeDetection::edgesNms(edge_image, orientation_image, _dst, r, s, m, isParallel)
        public void edgesNms (Mat edge_image, Mat orientation_image, Mat _dst, int r, int s, float m, bool isParallel)
        {
            ThrowIfDisposed ();
            if (edge_image != null) edge_image.ThrowIfDisposed ();
            if (orientation_image != null) orientation_image.ThrowIfDisposed ();
            if (_dst != null) _dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_StructuredEdgeDetection_edgesNms_10(nativeObj, edge_image.nativeObj, orientation_image.nativeObj, _dst.nativeObj, r, s, m, isParallel);
        
#else
            return;
#endif
            return;
        }

        //javadoc: StructuredEdgeDetection::edgesNms(edge_image, orientation_image, _dst)
        public void edgesNms (Mat edge_image, Mat orientation_image, Mat _dst)
        {
            ThrowIfDisposed ();
            if (edge_image != null) edge_image.ThrowIfDisposed ();
            if (orientation_image != null) orientation_image.ThrowIfDisposed ();
            if (_dst != null) _dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_StructuredEdgeDetection_edgesNms_11(nativeObj, edge_image.nativeObj, orientation_image.nativeObj, _dst.nativeObj);
        
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



        // C++:  void computeOrientation(Mat _src, Mat& _dst)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_StructuredEdgeDetection_computeOrientation_10 (IntPtr nativeObj, IntPtr _src_nativeObj, IntPtr _dst_nativeObj);

        // C++:  void detectEdges(Mat _src, Mat& _dst)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_StructuredEdgeDetection_detectEdges_10 (IntPtr nativeObj, IntPtr _src_nativeObj, IntPtr _dst_nativeObj);

        // C++:  void edgesNms(Mat edge_image, Mat orientation_image, Mat& _dst, int r = 2, int s = 0, float m = 1, bool isParallel = true)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_StructuredEdgeDetection_edgesNms_10 (IntPtr nativeObj, IntPtr edge_image_nativeObj, IntPtr orientation_image_nativeObj, IntPtr _dst_nativeObj, int r, int s, float m, bool isParallel);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_StructuredEdgeDetection_edgesNms_11 (IntPtr nativeObj, IntPtr edge_image_nativeObj, IntPtr orientation_image_nativeObj, IntPtr _dst_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_StructuredEdgeDetection_delete (IntPtr nativeObj);

    }
}
