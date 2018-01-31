

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class SuperpixelLSC
    //javadoc: SuperpixelLSC

    public class SuperpixelLSC : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_SuperpixelLSC_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal SuperpixelLSC (IntPtr addr) : base (addr) { }


        //
        // C++:  int getNumberOfSuperpixels()
        //

        //javadoc: SuperpixelLSC::getNumberOfSuperpixels()
        public int getNumberOfSuperpixels ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = ximgproc_SuperpixelLSC_getNumberOfSuperpixels_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void enforceLabelConnectivity(int min_element_size = 20)
        //

        //javadoc: SuperpixelLSC::enforceLabelConnectivity(min_element_size)
        public void enforceLabelConnectivity (int min_element_size)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelLSC_enforceLabelConnectivity_10(nativeObj, min_element_size);
        
#else
            return;
#endif
            return;
        }

        //javadoc: SuperpixelLSC::enforceLabelConnectivity()
        public void enforceLabelConnectivity ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelLSC_enforceLabelConnectivity_11(nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getLabelContourMask(Mat& image, bool thick_line = true)
        //

        //javadoc: SuperpixelLSC::getLabelContourMask(image, thick_line)
        public void getLabelContourMask (Mat image, bool thick_line)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelLSC_getLabelContourMask_10(nativeObj, image.nativeObj, thick_line);
        
#else
            return;
#endif
            return;
        }

        //javadoc: SuperpixelLSC::getLabelContourMask(image)
        public void getLabelContourMask (Mat image)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelLSC_getLabelContourMask_11(nativeObj, image.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getLabels(Mat& labels_out)
        //

        //javadoc: SuperpixelLSC::getLabels(labels_out)
        public void getLabels (Mat labels_out)
        {
            ThrowIfDisposed ();
            if (labels_out != null) labels_out.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelLSC_getLabels_10(nativeObj, labels_out.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void iterate(int num_iterations = 10)
        //

        //javadoc: SuperpixelLSC::iterate(num_iterations)
        public void iterate (int num_iterations)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelLSC_iterate_10(nativeObj, num_iterations);
        
#else
            return;
#endif
            return;
        }

        //javadoc: SuperpixelLSC::iterate()
        public void iterate ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SuperpixelLSC_iterate_11(nativeObj);
        
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
        private static extern int ximgproc_SuperpixelLSC_getNumberOfSuperpixels_10 (IntPtr nativeObj);

        // C++:  void enforceLabelConnectivity(int min_element_size = 20)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelLSC_enforceLabelConnectivity_10 (IntPtr nativeObj, int min_element_size);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelLSC_enforceLabelConnectivity_11 (IntPtr nativeObj);

        // C++:  void getLabelContourMask(Mat& image, bool thick_line = true)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelLSC_getLabelContourMask_10 (IntPtr nativeObj, IntPtr image_nativeObj, bool thick_line);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelLSC_getLabelContourMask_11 (IntPtr nativeObj, IntPtr image_nativeObj);

        // C++:  void getLabels(Mat& labels_out)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelLSC_getLabels_10 (IntPtr nativeObj, IntPtr labels_out_nativeObj);

        // C++:  void iterate(int num_iterations = 10)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelLSC_iterate_10 (IntPtr nativeObj, int num_iterations);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelLSC_iterate_11 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SuperpixelLSC_delete (IntPtr nativeObj);

    }
}
