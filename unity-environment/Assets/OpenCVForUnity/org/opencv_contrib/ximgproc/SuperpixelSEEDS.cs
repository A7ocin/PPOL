

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class SuperpixelSEEDS
    //javadoc: SuperpixelSEEDS

    public class SuperpixelSEEDS : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_SuperpixelSEEDS_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal SuperpixelSEEDS (IntPtr addr) : base (addr) { }


        //
        // C++:  int getNumberOfSuperpixels()
        //

        //javadoc: SuperpixelSEEDS::getNumberOfSuperpixels()
        public int getNumberOfSuperpixels ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = ximgproc_SuperpixelSEEDS_getNumberOfSuperpixels_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void getLabelContourMask(Mat& image, bool thick_line = false)
        //

        //javadoc: SuperpixelSEEDS::getLabelContourMask(image, thick_line)
        public void getLabelContourMask (Mat image, bool thick_line)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelSEEDS_getLabelContourMask_10(nativeObj, image.nativeObj, thick_line);
        
#else
            return;
#endif
            return;
        }

        //javadoc: SuperpixelSEEDS::getLabelContourMask(image)
        public void getLabelContourMask (Mat image)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelSEEDS_getLabelContourMask_11(nativeObj, image.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getLabels(Mat& labels_out)
        //

        //javadoc: SuperpixelSEEDS::getLabels(labels_out)
        public void getLabels (Mat labels_out)
        {
            ThrowIfDisposed ();
            if (labels_out != null) labels_out.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelSEEDS_getLabels_10(nativeObj, labels_out.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void iterate(Mat img, int num_iterations = 4)
        //

        //javadoc: SuperpixelSEEDS::iterate(img, num_iterations)
        public void iterate (Mat img, int num_iterations)
        {
            ThrowIfDisposed ();
            if (img != null) img.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelSEEDS_iterate_10(nativeObj, img.nativeObj, num_iterations);
        
#else
            return;
#endif
            return;
        }

        //javadoc: SuperpixelSEEDS::iterate(img)
        public void iterate (Mat img)
        {
            ThrowIfDisposed ();
            if (img != null) img.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelSEEDS_iterate_11(nativeObj, img.nativeObj);
        
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



        // C++:  int getNumberOfSuperpixels()
        [DllImport (LIBNAME)]
        private static extern int ximgproc_SuperpixelSEEDS_getNumberOfSuperpixels_10 (IntPtr nativeObj);

        // C++:  void getLabelContourMask(Mat& image, bool thick_line = false)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelSEEDS_getLabelContourMask_10 (IntPtr nativeObj, IntPtr image_nativeObj, bool thick_line);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelSEEDS_getLabelContourMask_11 (IntPtr nativeObj, IntPtr image_nativeObj);

        // C++:  void getLabels(Mat& labels_out)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelSEEDS_getLabels_10 (IntPtr nativeObj, IntPtr labels_out_nativeObj);

        // C++:  void iterate(Mat img, int num_iterations = 4)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelSEEDS_iterate_10 (IntPtr nativeObj, IntPtr img_nativeObj, int num_iterations);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelSEEDS_iterate_11 (IntPtr nativeObj, IntPtr img_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelSEEDS_delete (IntPtr nativeObj);

    }
}
