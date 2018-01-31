

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class FarnebackOpticalFlow
    //javadoc: FarnebackOpticalFlow

    public class FarnebackOpticalFlow : DenseOpticalFlow
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
video_FarnebackOpticalFlow_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal FarnebackOpticalFlow (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_FarnebackOpticalFlow create(int numLevels = 5, double pyrScale = 0.5, bool fastPyramids = false, int winSize = 13, int numIters = 10, int polyN = 5, double polySigma = 1.1, int flags = 0)
        //

        //javadoc: FarnebackOpticalFlow::create(numLevels, pyrScale, fastPyramids, winSize, numIters, polyN, polySigma, flags)
        public static FarnebackOpticalFlow create (int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters, int polyN, double polySigma, int flags)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        FarnebackOpticalFlow retVal = new FarnebackOpticalFlow(video_FarnebackOpticalFlow_create_10(numLevels, pyrScale, fastPyramids, winSize, numIters, polyN, polySigma, flags));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: FarnebackOpticalFlow::create()
        public static FarnebackOpticalFlow create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        FarnebackOpticalFlow retVal = new FarnebackOpticalFlow(video_FarnebackOpticalFlow_create_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool getFastPyramids()
        //

        //javadoc: FarnebackOpticalFlow::getFastPyramids()
        public bool getFastPyramids ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = video_FarnebackOpticalFlow_getFastPyramids_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  double getPolySigma()
        //

        //javadoc: FarnebackOpticalFlow::getPolySigma()
        public double getPolySigma ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_FarnebackOpticalFlow_getPolySigma_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getPyrScale()
        //

        //javadoc: FarnebackOpticalFlow::getPyrScale()
        public double getPyrScale ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_FarnebackOpticalFlow_getPyrScale_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getFlags()
        //

        //javadoc: FarnebackOpticalFlow::getFlags()
        public int getFlags ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_FarnebackOpticalFlow_getFlags_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNumIters()
        //

        //javadoc: FarnebackOpticalFlow::getNumIters()
        public int getNumIters ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_FarnebackOpticalFlow_getNumIters_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNumLevels()
        //

        //javadoc: FarnebackOpticalFlow::getNumLevels()
        public int getNumLevels ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_FarnebackOpticalFlow_getNumLevels_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getPolyN()
        //

        //javadoc: FarnebackOpticalFlow::getPolyN()
        public int getPolyN ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_FarnebackOpticalFlow_getPolyN_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getWinSize()
        //

        //javadoc: FarnebackOpticalFlow::getWinSize()
        public int getWinSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_FarnebackOpticalFlow_getWinSize_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setFastPyramids(bool fastPyramids)
        //

        //javadoc: FarnebackOpticalFlow::setFastPyramids(fastPyramids)
        public void setFastPyramids (bool fastPyramids)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setFastPyramids_10(nativeObj, fastPyramids);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setFlags(int flags)
        //

        //javadoc: FarnebackOpticalFlow::setFlags(flags)
        public void setFlags (int flags)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setFlags_10(nativeObj, flags);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setNumIters(int numIters)
        //

        //javadoc: FarnebackOpticalFlow::setNumIters(numIters)
        public void setNumIters (int numIters)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setNumIters_10(nativeObj, numIters);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setNumLevels(int numLevels)
        //

        //javadoc: FarnebackOpticalFlow::setNumLevels(numLevels)
        public void setNumLevels (int numLevels)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setNumLevels_10(nativeObj, numLevels);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPolyN(int polyN)
        //

        //javadoc: FarnebackOpticalFlow::setPolyN(polyN)
        public void setPolyN (int polyN)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setPolyN_10(nativeObj, polyN);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPolySigma(double polySigma)
        //

        //javadoc: FarnebackOpticalFlow::setPolySigma(polySigma)
        public void setPolySigma (double polySigma)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setPolySigma_10(nativeObj, polySigma);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPyrScale(double pyrScale)
        //

        //javadoc: FarnebackOpticalFlow::setPyrScale(pyrScale)
        public void setPyrScale (double pyrScale)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setPyrScale_10(nativeObj, pyrScale);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWinSize(int winSize)
        //

        //javadoc: FarnebackOpticalFlow::setWinSize(winSize)
        public void setWinSize (int winSize)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_FarnebackOpticalFlow_setWinSize_10(nativeObj, winSize);
        
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



        // C++: static Ptr_FarnebackOpticalFlow create(int numLevels = 5, double pyrScale = 0.5, bool fastPyramids = false, int winSize = 13, int numIters = 10, int polyN = 5, double polySigma = 1.1, int flags = 0)
        [DllImport (LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_10 (int numLevels, double pyrScale, bool fastPyramids, int winSize, int numIters, int polyN, double polySigma, int flags);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_FarnebackOpticalFlow_create_11 ();

        // C++:  bool getFastPyramids()
        [DllImport (LIBNAME)]
        private static extern bool video_FarnebackOpticalFlow_getFastPyramids_10 (IntPtr nativeObj);

        // C++:  double getPolySigma()
        [DllImport (LIBNAME)]
        private static extern double video_FarnebackOpticalFlow_getPolySigma_10 (IntPtr nativeObj);

        // C++:  double getPyrScale()
        [DllImport (LIBNAME)]
        private static extern double video_FarnebackOpticalFlow_getPyrScale_10 (IntPtr nativeObj);

        // C++:  int getFlags()
        [DllImport (LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getFlags_10 (IntPtr nativeObj);

        // C++:  int getNumIters()
        [DllImport (LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getNumIters_10 (IntPtr nativeObj);

        // C++:  int getNumLevels()
        [DllImport (LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getNumLevels_10 (IntPtr nativeObj);

        // C++:  int getPolyN()
        [DllImport (LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getPolyN_10 (IntPtr nativeObj);

        // C++:  int getWinSize()
        [DllImport (LIBNAME)]
        private static extern int video_FarnebackOpticalFlow_getWinSize_10 (IntPtr nativeObj);

        // C++:  void setFastPyramids(bool fastPyramids)
        [DllImport (LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setFastPyramids_10 (IntPtr nativeObj, bool fastPyramids);

        // C++:  void setFlags(int flags)
        [DllImport (LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setFlags_10 (IntPtr nativeObj, int flags);

        // C++:  void setNumIters(int numIters)
        [DllImport (LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setNumIters_10 (IntPtr nativeObj, int numIters);

        // C++:  void setNumLevels(int numLevels)
        [DllImport (LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setNumLevels_10 (IntPtr nativeObj, int numLevels);

        // C++:  void setPolyN(int polyN)
        [DllImport (LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setPolyN_10 (IntPtr nativeObj, int polyN);

        // C++:  void setPolySigma(double polySigma)
        [DllImport (LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setPolySigma_10 (IntPtr nativeObj, double polySigma);

        // C++:  void setPyrScale(double pyrScale)
        [DllImport (LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setPyrScale_10 (IntPtr nativeObj, double pyrScale);

        // C++:  void setWinSize(int winSize)
        [DllImport (LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_setWinSize_10 (IntPtr nativeObj, int winSize);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void video_FarnebackOpticalFlow_delete (IntPtr nativeObj);

    }
}
