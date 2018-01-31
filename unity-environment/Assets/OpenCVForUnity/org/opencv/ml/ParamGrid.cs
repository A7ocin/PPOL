

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class ParamGrid
    //javadoc: ParamGrid

    public class ParamGrid : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ml_ParamGrid_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal ParamGrid (IntPtr addr) : base (addr) { }


        public IntPtr getNativeObjAddr () { return nativeObj; }

        //
        // C++: static Ptr_ParamGrid create(double minVal = 0., double maxVal = 0., double logstep = 1.)
        //

        //javadoc: ParamGrid::create(minVal, maxVal, logstep)
        public static ParamGrid create (double minVal, double maxVal, double logstep)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ParamGrid retVal = new ParamGrid(ml_ParamGrid_create_10(minVal, maxVal, logstep));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: ParamGrid::create()
        public static ParamGrid create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ParamGrid retVal = new ParamGrid(ml_ParamGrid_create_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: double ParamGrid::minVal
        //

        //javadoc: ParamGrid::get_minVal()
        public double get_minVal ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = ml_ParamGrid_get_1minVal_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void ParamGrid::minVal
        //

        //javadoc: ParamGrid::set_minVal(minVal)
        public void set_minVal (double minVal)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_ParamGrid_set_1minVal_10(nativeObj, minVal);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: double ParamGrid::maxVal
        //

        //javadoc: ParamGrid::get_maxVal()
        public double get_maxVal ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = ml_ParamGrid_get_1maxVal_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void ParamGrid::maxVal
        //

        //javadoc: ParamGrid::set_maxVal(maxVal)
        public void set_maxVal (double maxVal)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_ParamGrid_set_1maxVal_10(nativeObj, maxVal);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: double ParamGrid::logStep
        //

        //javadoc: ParamGrid::get_logStep()
        public double get_logStep ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = ml_ParamGrid_get_1logStep_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void ParamGrid::logStep
        //

        //javadoc: ParamGrid::set_logStep(logStep)
        public void set_logStep (double logStep)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_ParamGrid_set_1logStep_10(nativeObj, logStep);
        
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



        // C++: static Ptr_ParamGrid create(double minVal = 0., double maxVal = 0., double logstep = 1.)
        [DllImport (LIBNAME)]
        private static extern IntPtr ml_ParamGrid_create_10 (double minVal, double maxVal, double logstep);
        [DllImport (LIBNAME)]
        private static extern IntPtr ml_ParamGrid_create_11 ();

        // C++: double ParamGrid::minVal
        [DllImport (LIBNAME)]
        private static extern double ml_ParamGrid_get_1minVal_10 (IntPtr nativeObj);

        // C++: void ParamGrid::minVal
        [DllImport (LIBNAME)]
        private static extern void ml_ParamGrid_set_1minVal_10 (IntPtr nativeObj, double minVal);

        // C++: double ParamGrid::maxVal
        [DllImport (LIBNAME)]
        private static extern double ml_ParamGrid_get_1maxVal_10 (IntPtr nativeObj);

        // C++: void ParamGrid::maxVal
        [DllImport (LIBNAME)]
        private static extern void ml_ParamGrid_set_1maxVal_10 (IntPtr nativeObj, double maxVal);

        // C++: double ParamGrid::logStep
        [DllImport (LIBNAME)]
        private static extern double ml_ParamGrid_get_1logStep_10 (IntPtr nativeObj);

        // C++: void ParamGrid::logStep
        [DllImport (LIBNAME)]
        private static extern void ml_ParamGrid_set_1logStep_10 (IntPtr nativeObj, double logStep);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ml_ParamGrid_delete (IntPtr nativeObj);

    }
}
