

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class DualTVL1OpticalFlow
    //javadoc: DualTVL1OpticalFlow

    public class DualTVL1OpticalFlow : DenseOpticalFlow
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
video_DualTVL1OpticalFlow_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal DualTVL1OpticalFlow (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_DualTVL1OpticalFlow create(double tau = 0.25, double lambda = 0.15, double theta = 0.3, int nscales = 5, int warps = 5, double epsilon = 0.01, int innnerIterations = 30, int outerIterations = 10, double scaleStep = 0.8, double gamma = 0.0, int medianFiltering = 5, bool useInitialFlow = false)
        //

        //javadoc: DualTVL1OpticalFlow::create(tau, lambda, theta, nscales, warps, epsilon, innnerIterations, outerIterations, scaleStep, gamma, medianFiltering, useInitialFlow)
        public static DualTVL1OpticalFlow create (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations, int outerIterations, double scaleStep, double gamma, int medianFiltering, bool useInitialFlow)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = new DualTVL1OpticalFlow(video_DualTVL1OpticalFlow_create_10(tau, lambda, theta, nscales, warps, epsilon, innnerIterations, outerIterations, scaleStep, gamma, medianFiltering, useInitialFlow));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: DualTVL1OpticalFlow::create()
        public static DualTVL1OpticalFlow create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DualTVL1OpticalFlow retVal = new DualTVL1OpticalFlow(video_DualTVL1OpticalFlow_create_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool getUseInitialFlow()
        //

        //javadoc: DualTVL1OpticalFlow::getUseInitialFlow()
        public bool getUseInitialFlow ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = video_DualTVL1OpticalFlow_getUseInitialFlow_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  double getEpsilon()
        //

        //javadoc: DualTVL1OpticalFlow::getEpsilon()
        public double getEpsilon ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_DualTVL1OpticalFlow_getEpsilon_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getGamma()
        //

        //javadoc: DualTVL1OpticalFlow::getGamma()
        public double getGamma ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_DualTVL1OpticalFlow_getGamma_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getLambda()
        //

        //javadoc: DualTVL1OpticalFlow::getLambda()
        public double getLambda ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_DualTVL1OpticalFlow_getLambda_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getScaleStep()
        //

        //javadoc: DualTVL1OpticalFlow::getScaleStep()
        public double getScaleStep ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_DualTVL1OpticalFlow_getScaleStep_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getTau()
        //

        //javadoc: DualTVL1OpticalFlow::getTau()
        public double getTau ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_DualTVL1OpticalFlow_getTau_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getTheta()
        //

        //javadoc: DualTVL1OpticalFlow::getTheta()
        public double getTheta ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_DualTVL1OpticalFlow_getTheta_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getInnerIterations()
        //

        //javadoc: DualTVL1OpticalFlow::getInnerIterations()
        public int getInnerIterations ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_DualTVL1OpticalFlow_getInnerIterations_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMedianFiltering()
        //

        //javadoc: DualTVL1OpticalFlow::getMedianFiltering()
        public int getMedianFiltering ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_DualTVL1OpticalFlow_getMedianFiltering_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getOuterIterations()
        //

        //javadoc: DualTVL1OpticalFlow::getOuterIterations()
        public int getOuterIterations ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_DualTVL1OpticalFlow_getOuterIterations_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getScalesNumber()
        //

        //javadoc: DualTVL1OpticalFlow::getScalesNumber()
        public int getScalesNumber ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_DualTVL1OpticalFlow_getScalesNumber_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getWarpingsNumber()
        //

        //javadoc: DualTVL1OpticalFlow::getWarpingsNumber()
        public int getWarpingsNumber ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_DualTVL1OpticalFlow_getWarpingsNumber_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setEpsilon(double val)
        //

        //javadoc: DualTVL1OpticalFlow::setEpsilon(val)
        public void setEpsilon (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setEpsilon_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setGamma(double val)
        //

        //javadoc: DualTVL1OpticalFlow::setGamma(val)
        public void setGamma (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setGamma_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setInnerIterations(int val)
        //

        //javadoc: DualTVL1OpticalFlow::setInnerIterations(val)
        public void setInnerIterations (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setInnerIterations_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setLambda(double val)
        //

        //javadoc: DualTVL1OpticalFlow::setLambda(val)
        public void setLambda (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setLambda_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMedianFiltering(int val)
        //

        //javadoc: DualTVL1OpticalFlow::setMedianFiltering(val)
        public void setMedianFiltering (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setMedianFiltering_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setOuterIterations(int val)
        //

        //javadoc: DualTVL1OpticalFlow::setOuterIterations(val)
        public void setOuterIterations (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setOuterIterations_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setScaleStep(double val)
        //

        //javadoc: DualTVL1OpticalFlow::setScaleStep(val)
        public void setScaleStep (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setScaleStep_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setScalesNumber(int val)
        //

        //javadoc: DualTVL1OpticalFlow::setScalesNumber(val)
        public void setScalesNumber (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setScalesNumber_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setTau(double val)
        //

        //javadoc: DualTVL1OpticalFlow::setTau(val)
        public void setTau (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setTau_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setTheta(double val)
        //

        //javadoc: DualTVL1OpticalFlow::setTheta(val)
        public void setTheta (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setTheta_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setUseInitialFlow(bool val)
        //

        //javadoc: DualTVL1OpticalFlow::setUseInitialFlow(val)
        public void setUseInitialFlow (bool val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setUseInitialFlow_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWarpingsNumber(int val)
        //

        //javadoc: DualTVL1OpticalFlow::setWarpingsNumber(val)
        public void setWarpingsNumber (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_DualTVL1OpticalFlow_setWarpingsNumber_10(nativeObj, val);
        
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



        // C++: static Ptr_DualTVL1OpticalFlow create(double tau = 0.25, double lambda = 0.15, double theta = 0.3, int nscales = 5, int warps = 5, double epsilon = 0.01, int innnerIterations = 30, int outerIterations = 10, double scaleStep = 0.8, double gamma = 0.0, int medianFiltering = 5, bool useInitialFlow = false)
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_10 (double tau, double lambda, double theta, int nscales, int warps, double epsilon, int innnerIterations, int outerIterations, double scaleStep, double gamma, int medianFiltering, bool useInitialFlow);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_DualTVL1OpticalFlow_create_11 ();

        // C++:  bool getUseInitialFlow()
        [DllImport (LIBNAME)]
        private static extern bool video_DualTVL1OpticalFlow_getUseInitialFlow_10 (IntPtr nativeObj);

        // C++:  double getEpsilon()
        [DllImport (LIBNAME)]
        private static extern double video_DualTVL1OpticalFlow_getEpsilon_10 (IntPtr nativeObj);

        // C++:  double getGamma()
        [DllImport (LIBNAME)]
        private static extern double video_DualTVL1OpticalFlow_getGamma_10 (IntPtr nativeObj);

        // C++:  double getLambda()
        [DllImport (LIBNAME)]
        private static extern double video_DualTVL1OpticalFlow_getLambda_10 (IntPtr nativeObj);

        // C++:  double getScaleStep()
        [DllImport (LIBNAME)]
        private static extern double video_DualTVL1OpticalFlow_getScaleStep_10 (IntPtr nativeObj);

        // C++:  double getTau()
        [DllImport (LIBNAME)]
        private static extern double video_DualTVL1OpticalFlow_getTau_10 (IntPtr nativeObj);

        // C++:  double getTheta()
        [DllImport (LIBNAME)]
        private static extern double video_DualTVL1OpticalFlow_getTheta_10 (IntPtr nativeObj);

        // C++:  int getInnerIterations()
        [DllImport (LIBNAME)]
        private static extern int video_DualTVL1OpticalFlow_getInnerIterations_10 (IntPtr nativeObj);

        // C++:  int getMedianFiltering()
        [DllImport (LIBNAME)]
        private static extern int video_DualTVL1OpticalFlow_getMedianFiltering_10 (IntPtr nativeObj);

        // C++:  int getOuterIterations()
        [DllImport (LIBNAME)]
        private static extern int video_DualTVL1OpticalFlow_getOuterIterations_10 (IntPtr nativeObj);

        // C++:  int getScalesNumber()
        [DllImport (LIBNAME)]
        private static extern int video_DualTVL1OpticalFlow_getScalesNumber_10 (IntPtr nativeObj);

        // C++:  int getWarpingsNumber()
        [DllImport (LIBNAME)]
        private static extern int video_DualTVL1OpticalFlow_getWarpingsNumber_10 (IntPtr nativeObj);

        // C++:  void setEpsilon(double val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setEpsilon_10 (IntPtr nativeObj, double val);

        // C++:  void setGamma(double val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setGamma_10 (IntPtr nativeObj, double val);

        // C++:  void setInnerIterations(int val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setInnerIterations_10 (IntPtr nativeObj, int val);

        // C++:  void setLambda(double val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setLambda_10 (IntPtr nativeObj, double val);

        // C++:  void setMedianFiltering(int val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setMedianFiltering_10 (IntPtr nativeObj, int val);

        // C++:  void setOuterIterations(int val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setOuterIterations_10 (IntPtr nativeObj, int val);

        // C++:  void setScaleStep(double val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setScaleStep_10 (IntPtr nativeObj, double val);

        // C++:  void setScalesNumber(int val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setScalesNumber_10 (IntPtr nativeObj, int val);

        // C++:  void setTau(double val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setTau_10 (IntPtr nativeObj, double val);

        // C++:  void setTheta(double val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setTheta_10 (IntPtr nativeObj, double val);

        // C++:  void setUseInitialFlow(bool val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setUseInitialFlow_10 (IntPtr nativeObj, bool val);

        // C++:  void setWarpingsNumber(int val)
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_setWarpingsNumber_10 (IntPtr nativeObj, int val);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void video_DualTVL1OpticalFlow_delete (IntPtr nativeObj);

    }
}
