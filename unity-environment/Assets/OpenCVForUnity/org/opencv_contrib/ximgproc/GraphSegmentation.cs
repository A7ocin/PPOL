

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class GraphSegmentation
    //javadoc: GraphSegmentation

    public class GraphSegmentation : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_GraphSegmentation_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal GraphSegmentation (IntPtr addr) : base (addr) { }


        //
        // C++:  double getSigma()
        //

        //javadoc: GraphSegmentation::getSigma()
        public double getSigma ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = ximgproc_GraphSegmentation_getSigma_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getK()
        //

        //javadoc: GraphSegmentation::getK()
        public float getK ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_GraphSegmentation_getK_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMinSize()
        //

        //javadoc: GraphSegmentation::getMinSize()
        public int getMinSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = ximgproc_GraphSegmentation_getMinSize_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void processImage(Mat src, Mat& dst)
        //

        //javadoc: GraphSegmentation::processImage(src, dst)
        public void processImage (Mat src, Mat dst)
        {
            ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_GraphSegmentation_processImage_10(nativeObj, src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setK(float k)
        //

        //javadoc: GraphSegmentation::setK(k)
        public void setK (float k)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_GraphSegmentation_setK_10(nativeObj, k);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMinSize(int min_size)
        //

        //javadoc: GraphSegmentation::setMinSize(min_size)
        public void setMinSize (int min_size)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_GraphSegmentation_setMinSize_10(nativeObj, min_size);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setSigma(double sigma)
        //

        //javadoc: GraphSegmentation::setSigma(sigma)
        public void setSigma (double sigma)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_GraphSegmentation_setSigma_10(nativeObj, sigma);
        
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



        // C++:  double getSigma()
        [DllImport (LIBNAME)]
        private static extern double ximgproc_GraphSegmentation_getSigma_10 (IntPtr nativeObj);

        // C++:  float getK()
        [DllImport (LIBNAME)]
        private static extern float ximgproc_GraphSegmentation_getK_10 (IntPtr nativeObj);

        // C++:  int getMinSize()
        [DllImport (LIBNAME)]
        private static extern int ximgproc_GraphSegmentation_getMinSize_10 (IntPtr nativeObj);

        // C++:  void processImage(Mat src, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_GraphSegmentation_processImage_10 (IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void setK(float k)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_GraphSegmentation_setK_10 (IntPtr nativeObj, float k);

        // C++:  void setMinSize(int min_size)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_GraphSegmentation_setMinSize_10 (IntPtr nativeObj, int min_size);

        // C++:  void setSigma(double sigma)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_GraphSegmentation_setSigma_10 (IntPtr nativeObj, double sigma);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_GraphSegmentation_delete (IntPtr nativeObj);

    }
}
