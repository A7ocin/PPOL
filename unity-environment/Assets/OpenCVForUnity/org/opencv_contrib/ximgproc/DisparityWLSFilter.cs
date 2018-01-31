

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class DisparityWLSFilter
    //javadoc: DisparityWLSFilter

    public class DisparityWLSFilter : DisparityFilter
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_DisparityWLSFilter_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal DisparityWLSFilter (IntPtr addr) : base (addr) { }


        //
        // C++:  Mat getConfidenceMap()
        //

        //javadoc: DisparityWLSFilter::getConfidenceMap()
        public Mat getConfidenceMap ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ximgproc_DisparityWLSFilter_getConfidenceMap_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Rect getROI()
        //

        //javadoc: DisparityWLSFilter::getROI()
        public Rect getROI ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[4];
ximgproc_DisparityWLSFilter_getROI_10(nativeObj, tmpArray);
Rect retVal = new Rect (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  double getLambda()
        //

        //javadoc: DisparityWLSFilter::getLambda()
        public double getLambda ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = ximgproc_DisparityWLSFilter_getLambda_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getSigmaColor()
        //

        //javadoc: DisparityWLSFilter::getSigmaColor()
        public double getSigmaColor ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = ximgproc_DisparityWLSFilter_getSigmaColor_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getDepthDiscontinuityRadius()
        //

        //javadoc: DisparityWLSFilter::getDepthDiscontinuityRadius()
        public int getDepthDiscontinuityRadius ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = ximgproc_DisparityWLSFilter_getDepthDiscontinuityRadius_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getLRCthresh()
        //

        //javadoc: DisparityWLSFilter::getLRCthresh()
        public int getLRCthresh ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = ximgproc_DisparityWLSFilter_getLRCthresh_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setDepthDiscontinuityRadius(int _disc_radius)
        //

        //javadoc: DisparityWLSFilter::setDepthDiscontinuityRadius(_disc_radius)
        public void setDepthDiscontinuityRadius (int _disc_radius)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_DisparityWLSFilter_setDepthDiscontinuityRadius_10(nativeObj, _disc_radius);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setLRCthresh(int _LRC_thresh)
        //

        //javadoc: DisparityWLSFilter::setLRCthresh(_LRC_thresh)
        public void setLRCthresh (int _LRC_thresh)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_DisparityWLSFilter_setLRCthresh_10(nativeObj, _LRC_thresh);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setLambda(double _lambda)
        //

        //javadoc: DisparityWLSFilter::setLambda(_lambda)
        public void setLambda (double _lambda)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_DisparityWLSFilter_setLambda_10(nativeObj, _lambda);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setSigmaColor(double _sigma_color)
        //

        //javadoc: DisparityWLSFilter::setSigmaColor(_sigma_color)
        public void setSigmaColor (double _sigma_color)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_DisparityWLSFilter_setSigmaColor_10(nativeObj, _sigma_color);
        
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



        // C++:  Mat getConfidenceMap()
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_DisparityWLSFilter_getConfidenceMap_10 (IntPtr nativeObj);

        // C++:  Rect getROI()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_getROI_10 (IntPtr nativeObj, double[] retVal);

        // C++:  double getLambda()
        [DllImport (LIBNAME)]
        private static extern double ximgproc_DisparityWLSFilter_getLambda_10 (IntPtr nativeObj);

        // C++:  double getSigmaColor()
        [DllImport (LIBNAME)]
        private static extern double ximgproc_DisparityWLSFilter_getSigmaColor_10 (IntPtr nativeObj);

        // C++:  int getDepthDiscontinuityRadius()
        [DllImport (LIBNAME)]
        private static extern int ximgproc_DisparityWLSFilter_getDepthDiscontinuityRadius_10 (IntPtr nativeObj);

        // C++:  int getLRCthresh()
        [DllImport (LIBNAME)]
        private static extern int ximgproc_DisparityWLSFilter_getLRCthresh_10 (IntPtr nativeObj);

        // C++:  void setDepthDiscontinuityRadius(int _disc_radius)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_setDepthDiscontinuityRadius_10 (IntPtr nativeObj, int _disc_radius);

        // C++:  void setLRCthresh(int _LRC_thresh)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_setLRCthresh_10 (IntPtr nativeObj, int _LRC_thresh);

        // C++:  void setLambda(double _lambda)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_setLambda_10 (IntPtr nativeObj, double _lambda);

        // C++:  void setSigmaColor(double _sigma_color)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_setSigmaColor_10 (IntPtr nativeObj, double _sigma_color);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_DisparityWLSFilter_delete (IntPtr nativeObj);

    }
}
