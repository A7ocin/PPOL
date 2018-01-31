

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class VariationalRefinement
    //javadoc: VariationalRefinement

    public class VariationalRefinement : DenseOpticalFlow
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
optflow_VariationalRefinement_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal VariationalRefinement (IntPtr addr) : base (addr) { }


        //
        // C++:  float getAlpha()
        //

        //javadoc: VariationalRefinement::getAlpha()
        public float getAlpha ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = optflow_VariationalRefinement_getAlpha_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getDelta()
        //

        //javadoc: VariationalRefinement::getDelta()
        public float getDelta ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = optflow_VariationalRefinement_getDelta_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getGamma()
        //

        //javadoc: VariationalRefinement::getGamma()
        public float getGamma ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = optflow_VariationalRefinement_getGamma_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getOmega()
        //

        //javadoc: VariationalRefinement::getOmega()
        public float getOmega ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = optflow_VariationalRefinement_getOmega_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getFixedPointIterations()
        //

        //javadoc: VariationalRefinement::getFixedPointIterations()
        public int getFixedPointIterations ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = optflow_VariationalRefinement_getFixedPointIterations_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getSorIterations()
        //

        //javadoc: VariationalRefinement::getSorIterations()
        public int getSorIterations ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = optflow_VariationalRefinement_getSorIterations_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void calcUV(Mat I0, Mat I1, Mat& flow_u, Mat& flow_v)
        //

        //javadoc: VariationalRefinement::calcUV(I0, I1, flow_u, flow_v)
        public void calcUV (Mat I0, Mat I1, Mat flow_u, Mat flow_v)
        {
            ThrowIfDisposed ();
            if (I0 != null) I0.ThrowIfDisposed ();
            if (I1 != null) I1.ThrowIfDisposed ();
            if (flow_u != null) flow_u.ThrowIfDisposed ();
            if (flow_v != null) flow_v.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_VariationalRefinement_calcUV_10(nativeObj, I0.nativeObj, I1.nativeObj, flow_u.nativeObj, flow_v.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setAlpha(float val)
        //

        //javadoc: VariationalRefinement::setAlpha(val)
        public void setAlpha (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_VariationalRefinement_setAlpha_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setDelta(float val)
        //

        //javadoc: VariationalRefinement::setDelta(val)
        public void setDelta (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_VariationalRefinement_setDelta_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setFixedPointIterations(int val)
        //

        //javadoc: VariationalRefinement::setFixedPointIterations(val)
        public void setFixedPointIterations (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_VariationalRefinement_setFixedPointIterations_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setGamma(float val)
        //

        //javadoc: VariationalRefinement::setGamma(val)
        public void setGamma (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_VariationalRefinement_setGamma_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setOmega(float val)
        //

        //javadoc: VariationalRefinement::setOmega(val)
        public void setOmega (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_VariationalRefinement_setOmega_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setSorIterations(int val)
        //

        //javadoc: VariationalRefinement::setSorIterations(val)
        public void setSorIterations (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_VariationalRefinement_setSorIterations_10(nativeObj, val);
        
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



        // C++:  float getAlpha()
        [DllImport (LIBNAME)]
        private static extern float optflow_VariationalRefinement_getAlpha_10 (IntPtr nativeObj);

        // C++:  float getDelta()
        [DllImport (LIBNAME)]
        private static extern float optflow_VariationalRefinement_getDelta_10 (IntPtr nativeObj);

        // C++:  float getGamma()
        [DllImport (LIBNAME)]
        private static extern float optflow_VariationalRefinement_getGamma_10 (IntPtr nativeObj);

        // C++:  float getOmega()
        [DllImport (LIBNAME)]
        private static extern float optflow_VariationalRefinement_getOmega_10 (IntPtr nativeObj);

        // C++:  int getFixedPointIterations()
        [DllImport (LIBNAME)]
        private static extern int optflow_VariationalRefinement_getFixedPointIterations_10 (IntPtr nativeObj);

        // C++:  int getSorIterations()
        [DllImport (LIBNAME)]
        private static extern int optflow_VariationalRefinement_getSorIterations_10 (IntPtr nativeObj);

        // C++:  void calcUV(Mat I0, Mat I1, Mat& flow_u, Mat& flow_v)
        [DllImport (LIBNAME)]
        private static extern void optflow_VariationalRefinement_calcUV_10 (IntPtr nativeObj, IntPtr I0_nativeObj, IntPtr I1_nativeObj, IntPtr flow_u_nativeObj, IntPtr flow_v_nativeObj);

        // C++:  void setAlpha(float val)
        [DllImport (LIBNAME)]
        private static extern void optflow_VariationalRefinement_setAlpha_10 (IntPtr nativeObj, float val);

        // C++:  void setDelta(float val)
        [DllImport (LIBNAME)]
        private static extern void optflow_VariationalRefinement_setDelta_10 (IntPtr nativeObj, float val);

        // C++:  void setFixedPointIterations(int val)
        [DllImport (LIBNAME)]
        private static extern void optflow_VariationalRefinement_setFixedPointIterations_10 (IntPtr nativeObj, int val);

        // C++:  void setGamma(float val)
        [DllImport (LIBNAME)]
        private static extern void optflow_VariationalRefinement_setGamma_10 (IntPtr nativeObj, float val);

        // C++:  void setOmega(float val)
        [DllImport (LIBNAME)]
        private static extern void optflow_VariationalRefinement_setOmega_10 (IntPtr nativeObj, float val);

        // C++:  void setSorIterations(int val)
        [DllImport (LIBNAME)]
        private static extern void optflow_VariationalRefinement_setSorIterations_10 (IntPtr nativeObj, int val);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void optflow_VariationalRefinement_delete (IntPtr nativeObj);

    }
}
