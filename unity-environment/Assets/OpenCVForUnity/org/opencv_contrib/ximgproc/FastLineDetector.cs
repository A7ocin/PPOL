

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class FastLineDetector
    //javadoc: FastLineDetector

    public class FastLineDetector : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_FastLineDetector_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal FastLineDetector (IntPtr addr) : base (addr) { }


        //
        // C++:  void detect(Mat _image, Mat& _lines)
        //

        //javadoc: FastLineDetector::detect(_image, _lines)
        public void detect (Mat _image, Mat _lines)
        {
            ThrowIfDisposed ();
            if (_image != null) _image.ThrowIfDisposed ();
            if (_lines != null) _lines.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_FastLineDetector_detect_10(nativeObj, _image.nativeObj, _lines.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void drawSegments(Mat& _image, Mat lines, bool draw_arrow = false)
        //

        //javadoc: FastLineDetector::drawSegments(_image, lines, draw_arrow)
        public void drawSegments (Mat _image, Mat lines, bool draw_arrow)
        {
            ThrowIfDisposed ();
            if (_image != null) _image.ThrowIfDisposed ();
            if (lines != null) lines.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_FastLineDetector_drawSegments_10(nativeObj, _image.nativeObj, lines.nativeObj, draw_arrow);
        
#else
            return;
#endif
            return;
        }

        //javadoc: FastLineDetector::drawSegments(_image, lines)
        public void drawSegments (Mat _image, Mat lines)
        {
            ThrowIfDisposed ();
            if (_image != null) _image.ThrowIfDisposed ();
            if (lines != null) lines.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_FastLineDetector_drawSegments_11(nativeObj, _image.nativeObj, lines.nativeObj);
        
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



        // C++:  void detect(Mat _image, Mat& _lines)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_FastLineDetector_detect_10 (IntPtr nativeObj, IntPtr _image_nativeObj, IntPtr _lines_nativeObj);

        // C++:  void drawSegments(Mat& _image, Mat lines, bool draw_arrow = false)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_FastLineDetector_drawSegments_10 (IntPtr nativeObj, IntPtr _image_nativeObj, IntPtr lines_nativeObj, bool draw_arrow);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_FastLineDetector_drawSegments_11 (IntPtr nativeObj, IntPtr _image_nativeObj, IntPtr lines_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_FastLineDetector_delete (IntPtr nativeObj);

    }
}
