

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class LogisticRegression
    //javadoc: LogisticRegression

    public class LogisticRegression : StatModel
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        ml_LogisticRegression_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal LogisticRegression (IntPtr addr)
            : base (addr)
        {
        }


        public const int REG_DISABLE = -1;
        public const int REG_L1 = 0;
        public const int REG_L2 = 1;
        public const int BATCH = 0;
        public const int MINI_BATCH = 1;
        //
        // C++:  Mat get_learnt_thetas()
        //

        //javadoc: LogisticRegression::get_learnt_thetas()
        public Mat get_learnt_thetas ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Mat retVal = new Mat (ml_LogisticRegression_get_1learnt_1thetas_10 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_LogisticRegression create()
        //

        //javadoc: LogisticRegression::create()
        public static LogisticRegression create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            LogisticRegression retVal = new LogisticRegression (ml_LogisticRegression_create_10 ());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_LogisticRegression load(String filepath, String nodeName = String())
        //

        //javadoc: LogisticRegression::load(filepath, nodeName)
        public static LogisticRegression load (string filepath, string nodeName)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            LogisticRegression retVal = new LogisticRegression (ml_LogisticRegression_load_10 (filepath, nodeName));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: LogisticRegression::load(filepath)
        public static LogisticRegression load (string filepath)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            LogisticRegression retVal = new LogisticRegression (ml_LogisticRegression_load_11 (filepath));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  TermCriteria getTermCriteria()
        //

        //javadoc: LogisticRegression::getTermCriteria()
        public TermCriteria getTermCriteria ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double[] tmpArray = new double[3];
            ml_LogisticRegression_getTermCriteria_10 (nativeObj, tmpArray);
            TermCriteria retVal = new TermCriteria (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  double getLearningRate()
        //

        //javadoc: LogisticRegression::getLearningRate()
        public double getLearningRate ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = ml_LogisticRegression_getLearningRate_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float predict(Mat samples, Mat& results = Mat(), int flags = 0)
        //

        //javadoc: LogisticRegression::predict(samples, results, flags)
        public override float predict (Mat samples, Mat results, int flags)
        {
            ThrowIfDisposed ();
            if (samples != null)
                samples.ThrowIfDisposed ();
            if (results != null)
                results.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            float retVal = ml_LogisticRegression_predict_10 (nativeObj, samples.nativeObj, results.nativeObj, flags);
        
#else
            return -1;
#endif
            return retVal;
        }

        //javadoc: LogisticRegression::predict(samples)
        public override float predict (Mat samples)
        {
            ThrowIfDisposed ();
            if (samples != null)
                samples.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            float retVal = ml_LogisticRegression_predict_11 (nativeObj, samples.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getIterations()
        //

        //javadoc: LogisticRegression::getIterations()
        public int getIterations ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = ml_LogisticRegression_getIterations_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMiniBatchSize()
        //

        //javadoc: LogisticRegression::getMiniBatchSize()
        public int getMiniBatchSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = ml_LogisticRegression_getMiniBatchSize_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getRegularization()
        //

        //javadoc: LogisticRegression::getRegularization()
        public int getRegularization ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = ml_LogisticRegression_getRegularization_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getTrainMethod()
        //

        //javadoc: LogisticRegression::getTrainMethod()
        public int getTrainMethod ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = ml_LogisticRegression_getTrainMethod_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setIterations(int val)
        //

        //javadoc: LogisticRegression::setIterations(val)
        public void setIterations (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            ml_LogisticRegression_setIterations_10 (nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setLearningRate(double val)
        //

        //javadoc: LogisticRegression::setLearningRate(val)
        public void setLearningRate (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            ml_LogisticRegression_setLearningRate_10 (nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMiniBatchSize(int val)
        //

        //javadoc: LogisticRegression::setMiniBatchSize(val)
        public void setMiniBatchSize (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            ml_LogisticRegression_setMiniBatchSize_10 (nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setRegularization(int val)
        //

        //javadoc: LogisticRegression::setRegularization(val)
        public void setRegularization (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            ml_LogisticRegression_setRegularization_10 (nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setTermCriteria(TermCriteria val)
        //

        //javadoc: LogisticRegression::setTermCriteria(val)
        public void setTermCriteria (TermCriteria val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            ml_LogisticRegression_setTermCriteria_10 (nativeObj, val.type, val.maxCount, val.epsilon);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setTrainMethod(int val)
        //

        //javadoc: LogisticRegression::setTrainMethod(val)
        public void setTrainMethod (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            ml_LogisticRegression_setTrainMethod_10 (nativeObj, val);
        
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



        // C++:  Mat get_learnt_thetas()
        [DllImport (LIBNAME)]
        private static extern IntPtr ml_LogisticRegression_get_1learnt_1thetas_10 (IntPtr nativeObj);

        // C++: static Ptr_LogisticRegression create()
        [DllImport (LIBNAME)]
        private static extern IntPtr ml_LogisticRegression_create_10 ();

        // C++: static Ptr_LogisticRegression load(String filepath, String nodeName = String())
        [DllImport (LIBNAME)]
        private static extern IntPtr ml_LogisticRegression_load_10 (string filepath, string nodeName);

        [DllImport (LIBNAME)]
        private static extern IntPtr ml_LogisticRegression_load_11 (string filepath);

        // C++:  TermCriteria getTermCriteria()
        [DllImport (LIBNAME)]
        private static extern void ml_LogisticRegression_getTermCriteria_10 (IntPtr nativeObj, double[] retVal);

        // C++:  double getLearningRate()
        [DllImport (LIBNAME)]
        private static extern double ml_LogisticRegression_getLearningRate_10 (IntPtr nativeObj);

        // C++:  float predict(Mat samples, Mat& results = Mat(), int flags = 0)
        [DllImport (LIBNAME)]
        private static extern float ml_LogisticRegression_predict_10 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj, int flags);

        [DllImport (LIBNAME)]
        private static extern float ml_LogisticRegression_predict_11 (IntPtr nativeObj, IntPtr samples_nativeObj);

        // C++:  int getIterations()
        [DllImport (LIBNAME)]
        private static extern int ml_LogisticRegression_getIterations_10 (IntPtr nativeObj);

        // C++:  int getMiniBatchSize()
        [DllImport (LIBNAME)]
        private static extern int ml_LogisticRegression_getMiniBatchSize_10 (IntPtr nativeObj);

        // C++:  int getRegularization()
        [DllImport (LIBNAME)]
        private static extern int ml_LogisticRegression_getRegularization_10 (IntPtr nativeObj);

        // C++:  int getTrainMethod()
        [DllImport (LIBNAME)]
        private static extern int ml_LogisticRegression_getTrainMethod_10 (IntPtr nativeObj);

        // C++:  void setIterations(int val)
        [DllImport (LIBNAME)]
        private static extern void ml_LogisticRegression_setIterations_10 (IntPtr nativeObj, int val);

        // C++:  void setLearningRate(double val)
        [DllImport (LIBNAME)]
        private static extern void ml_LogisticRegression_setLearningRate_10 (IntPtr nativeObj, double val);

        // C++:  void setMiniBatchSize(int val)
        [DllImport (LIBNAME)]
        private static extern void ml_LogisticRegression_setMiniBatchSize_10 (IntPtr nativeObj, int val);

        // C++:  void setRegularization(int val)
        [DllImport (LIBNAME)]
        private static extern void ml_LogisticRegression_setRegularization_10 (IntPtr nativeObj, int val);

        // C++:  void setTermCriteria(TermCriteria val)
        [DllImport (LIBNAME)]
        private static extern void ml_LogisticRegression_setTermCriteria_10 (IntPtr nativeObj, int val_type, int val_maxCount, double val_epsilon);

        // C++:  void setTrainMethod(int val)
        [DllImport (LIBNAME)]
        private static extern void ml_LogisticRegression_setTrainMethod_10 (IntPtr nativeObj, int val);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ml_LogisticRegression_delete (IntPtr nativeObj);

    }
}
