

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class SVMSGD
    //javadoc: SVMSGD

    public class SVMSGD : StatModel
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ml_SVMSGD_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal SVMSGD (IntPtr addr) : base (addr) { }


        public const int SGD = 0;
        public const int ASGD = 1;
        public const int SOFT_MARGIN = 0;
        public const int HARD_MARGIN = 1;
        //
        // C++:  Mat getWeights()
        //

        //javadoc: SVMSGD::getWeights()
        public Mat getWeights ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(ml_SVMSGD_getWeights_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_SVMSGD create()
        //

        //javadoc: SVMSGD::create()
        public static SVMSGD create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SVMSGD retVal = new SVMSGD(ml_SVMSGD_create_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_SVMSGD load(String filepath, String nodeName = String())
        //

        //javadoc: SVMSGD::load(filepath, nodeName)
        public static SVMSGD load (string filepath, string nodeName)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SVMSGD retVal = new SVMSGD(ml_SVMSGD_load_10(filepath, nodeName));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: SVMSGD::load(filepath)
        public static SVMSGD load (string filepath)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SVMSGD retVal = new SVMSGD(ml_SVMSGD_load_11(filepath));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  TermCriteria getTermCriteria()
        //

        //javadoc: SVMSGD::getTermCriteria()
        public TermCriteria getTermCriteria ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[3];
ml_SVMSGD_getTermCriteria_10(nativeObj, tmpArray);
TermCriteria retVal = new TermCriteria (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  float getInitialStepSize()
        //

        //javadoc: SVMSGD::getInitialStepSize()
        public float getInitialStepSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ml_SVMSGD_getInitialStepSize_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getMarginRegularization()
        //

        //javadoc: SVMSGD::getMarginRegularization()
        public float getMarginRegularization ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ml_SVMSGD_getMarginRegularization_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getShift()
        //

        //javadoc: SVMSGD::getShift()
        public float getShift ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ml_SVMSGD_getShift_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getStepDecreasingPower()
        //

        //javadoc: SVMSGD::getStepDecreasingPower()
        public float getStepDecreasingPower ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ml_SVMSGD_getStepDecreasingPower_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMarginType()
        //

        //javadoc: SVMSGD::getMarginType()
        public int getMarginType ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = ml_SVMSGD_getMarginType_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getSvmsgdType()
        //

        //javadoc: SVMSGD::getSvmsgdType()
        public int getSvmsgdType ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = ml_SVMSGD_getSvmsgdType_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setInitialStepSize(float InitialStepSize)
        //

        //javadoc: SVMSGD::setInitialStepSize(InitialStepSize)
        public void setInitialStepSize (float InitialStepSize)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_SVMSGD_setInitialStepSize_10(nativeObj, InitialStepSize);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMarginRegularization(float marginRegularization)
        //

        //javadoc: SVMSGD::setMarginRegularization(marginRegularization)
        public void setMarginRegularization (float marginRegularization)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_SVMSGD_setMarginRegularization_10(nativeObj, marginRegularization);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMarginType(int marginType)
        //

        //javadoc: SVMSGD::setMarginType(marginType)
        public void setMarginType (int marginType)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_SVMSGD_setMarginType_10(nativeObj, marginType);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setOptimalParameters(int svmsgdType = SVMSGD::ASGD, int marginType = SVMSGD::SOFT_MARGIN)
        //

        //javadoc: SVMSGD::setOptimalParameters(svmsgdType, marginType)
        public void setOptimalParameters (int svmsgdType, int marginType)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_SVMSGD_setOptimalParameters_10(nativeObj, svmsgdType, marginType);
        
#else
            return;
#endif
            return;
        }

        //javadoc: SVMSGD::setOptimalParameters()
        public void setOptimalParameters ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_SVMSGD_setOptimalParameters_11(nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setStepDecreasingPower(float stepDecreasingPower)
        //

        //javadoc: SVMSGD::setStepDecreasingPower(stepDecreasingPower)
        public void setStepDecreasingPower (float stepDecreasingPower)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_SVMSGD_setStepDecreasingPower_10(nativeObj, stepDecreasingPower);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setSvmsgdType(int svmsgdType)
        //

        //javadoc: SVMSGD::setSvmsgdType(svmsgdType)
        public void setSvmsgdType (int svmsgdType)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_SVMSGD_setSvmsgdType_10(nativeObj, svmsgdType);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setTermCriteria(TermCriteria val)
        //

        //javadoc: SVMSGD::setTermCriteria(val)
        public void setTermCriteria (TermCriteria val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_SVMSGD_setTermCriteria_10(nativeObj, val.type, val.maxCount, val.epsilon);
        
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



        // C++:  Mat getWeights()
        [DllImport (LIBNAME)]
        private static extern IntPtr ml_SVMSGD_getWeights_10 (IntPtr nativeObj);

        // C++: static Ptr_SVMSGD create()
        [DllImport (LIBNAME)]
        private static extern IntPtr ml_SVMSGD_create_10 ();

        // C++: static Ptr_SVMSGD load(String filepath, String nodeName = String())
        [DllImport (LIBNAME)]
        private static extern IntPtr ml_SVMSGD_load_10 (string filepath, string nodeName);
        [DllImport (LIBNAME)]
        private static extern IntPtr ml_SVMSGD_load_11 (string filepath);

        // C++:  TermCriteria getTermCriteria()
        [DllImport (LIBNAME)]
        private static extern void ml_SVMSGD_getTermCriteria_10 (IntPtr nativeObj, double[] retVal);

        // C++:  float getInitialStepSize()
        [DllImport (LIBNAME)]
        private static extern float ml_SVMSGD_getInitialStepSize_10 (IntPtr nativeObj);

        // C++:  float getMarginRegularization()
        [DllImport (LIBNAME)]
        private static extern float ml_SVMSGD_getMarginRegularization_10 (IntPtr nativeObj);

        // C++:  float getShift()
        [DllImport (LIBNAME)]
        private static extern float ml_SVMSGD_getShift_10 (IntPtr nativeObj);

        // C++:  float getStepDecreasingPower()
        [DllImport (LIBNAME)]
        private static extern float ml_SVMSGD_getStepDecreasingPower_10 (IntPtr nativeObj);

        // C++:  int getMarginType()
        [DllImport (LIBNAME)]
        private static extern int ml_SVMSGD_getMarginType_10 (IntPtr nativeObj);

        // C++:  int getSvmsgdType()
        [DllImport (LIBNAME)]
        private static extern int ml_SVMSGD_getSvmsgdType_10 (IntPtr nativeObj);

        // C++:  void setInitialStepSize(float InitialStepSize)
        [DllImport (LIBNAME)]
        private static extern void ml_SVMSGD_setInitialStepSize_10 (IntPtr nativeObj, float InitialStepSize);

        // C++:  void setMarginRegularization(float marginRegularization)
        [DllImport (LIBNAME)]
        private static extern void ml_SVMSGD_setMarginRegularization_10 (IntPtr nativeObj, float marginRegularization);

        // C++:  void setMarginType(int marginType)
        [DllImport (LIBNAME)]
        private static extern void ml_SVMSGD_setMarginType_10 (IntPtr nativeObj, int marginType);

        // C++:  void setOptimalParameters(int svmsgdType = SVMSGD::ASGD, int marginType = SVMSGD::SOFT_MARGIN)
        [DllImport (LIBNAME)]
        private static extern void ml_SVMSGD_setOptimalParameters_10 (IntPtr nativeObj, int svmsgdType, int marginType);
        [DllImport (LIBNAME)]
        private static extern void ml_SVMSGD_setOptimalParameters_11 (IntPtr nativeObj);

        // C++:  void setStepDecreasingPower(float stepDecreasingPower)
        [DllImport (LIBNAME)]
        private static extern void ml_SVMSGD_setStepDecreasingPower_10 (IntPtr nativeObj, float stepDecreasingPower);

        // C++:  void setSvmsgdType(int svmsgdType)
        [DllImport (LIBNAME)]
        private static extern void ml_SVMSGD_setSvmsgdType_10 (IntPtr nativeObj, int svmsgdType);

        // C++:  void setTermCriteria(TermCriteria val)
        [DllImport (LIBNAME)]
        private static extern void ml_SVMSGD_setTermCriteria_10 (IntPtr nativeObj, int val_type, int val_maxCount, double val_epsilon);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ml_SVMSGD_delete (IntPtr nativeObj);

    }
}
