

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class RidgeDetectionFilter
    //javadoc: RidgeDetectionFilter

    public class RidgeDetectionFilter : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_RidgeDetectionFilter_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal RidgeDetectionFilter (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_RidgeDetectionFilter create(int ddepth = CV_32FC1, int dx = 1, int dy = 1, int ksize = 3, int out_dtype = CV_8UC1, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
        //

        //javadoc: RidgeDetectionFilter::create(ddepth, dx, dy, ksize, out_dtype, scale, delta, borderType)
        public static RidgeDetectionFilter create (int ddepth, int dx, int dy, int ksize, int out_dtype, double scale, double delta, int borderType)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        RidgeDetectionFilter retVal = new RidgeDetectionFilter(ximgproc_RidgeDetectionFilter_create_10(ddepth, dx, dy, ksize, out_dtype, scale, delta, borderType));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: RidgeDetectionFilter::create(ddepth, dx, dy, ksize, out_dtype, scale, delta)
        public static RidgeDetectionFilter create (int ddepth, int dx, int dy, int ksize, int out_dtype, double scale, double delta)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        RidgeDetectionFilter retVal = new RidgeDetectionFilter(ximgproc_RidgeDetectionFilter_create_11(ddepth, dx, dy, ksize, out_dtype, scale, delta));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: RidgeDetectionFilter::create()
        public static RidgeDetectionFilter create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        RidgeDetectionFilter retVal = new RidgeDetectionFilter(ximgproc_RidgeDetectionFilter_create_12());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void getRidgeFilteredImage(Mat _img, Mat& _out)
        //

        //javadoc: RidgeDetectionFilter::getRidgeFilteredImage(_img, _out)
        public void getRidgeFilteredImage (Mat _img, Mat _out)
        {
            ThrowIfDisposed ();
            if (_img != null) _img.ThrowIfDisposed ();
            if (_out != null) _out.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_RidgeDetectionFilter_getRidgeFilteredImage_10(nativeObj, _img.nativeObj, _out.nativeObj);
        
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



        // C++: static Ptr_RidgeDetectionFilter create(int ddepth = CV_32FC1, int dx = 1, int dy = 1, int ksize = 3, int out_dtype = CV_8UC1, double scale = 1, double delta = 0, int borderType = BORDER_DEFAULT)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_10 (int ddepth, int dx, int dy, int ksize, int out_dtype, double scale, double delta, int borderType);
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_11 (int ddepth, int dx, int dy, int ksize, int out_dtype, double scale, double delta);
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_RidgeDetectionFilter_create_12 ();

        // C++:  void getRidgeFilteredImage(Mat _img, Mat& _out)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_RidgeDetectionFilter_getRidgeFilteredImage_10 (IntPtr nativeObj, IntPtr _img_nativeObj, IntPtr _out_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_RidgeDetectionFilter_delete (IntPtr nativeObj);

    }
}
