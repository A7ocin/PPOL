

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class RTrees
    //javadoc: RTrees

    public class RTrees : DTrees
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        ml_RTrees_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal RTrees (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++:  Mat getVarImportance()
        //

        //javadoc: RTrees::getVarImportance()
        public Mat getVarImportance ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Mat retVal = new Mat (ml_RTrees_getVarImportance_10 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_RTrees create()
        //

        //javadoc: RTrees::create()
#pragma warning disable 0108
        public static RTrees create ()
        {
#pragma warning restore 0067
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            RTrees retVal = new RTrees (ml_RTrees_create_10 ());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_RTrees load(String filepath, String nodeName = String())
        //

        //javadoc: RTrees::load(filepath, nodeName)
        public static RTrees load (string filepath, string nodeName)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            RTrees retVal = new RTrees (ml_RTrees_load_10 (filepath, nodeName));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: RTrees::load(filepath)
        public static RTrees load (string filepath)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            RTrees retVal = new RTrees (ml_RTrees_load_11 (filepath));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  TermCriteria getTermCriteria()
        //

        //javadoc: RTrees::getTermCriteria()
        public TermCriteria getTermCriteria ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double[] tmpArray = new double[3];
            ml_RTrees_getTermCriteria_10 (nativeObj, tmpArray);
            TermCriteria retVal = new TermCriteria (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool getCalculateVarImportance()
        //

        //javadoc: RTrees::getCalculateVarImportance()
        public bool getCalculateVarImportance ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = ml_RTrees_getCalculateVarImportance_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  int getActiveVarCount()
        //

        //javadoc: RTrees::getActiveVarCount()
        public int getActiveVarCount ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = ml_RTrees_getActiveVarCount_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void getVotes(Mat samples, Mat& results, int flags)
        //

        //javadoc: RTrees::getVotes(samples, results, flags)
        public void getVotes (Mat samples, Mat results, int flags)
        {
            ThrowIfDisposed ();
            if (samples != null)
                samples.ThrowIfDisposed ();
            if (results != null)
                results.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            ml_RTrees_getVotes_10 (nativeObj, samples.nativeObj, results.nativeObj, flags);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setActiveVarCount(int val)
        //

        //javadoc: RTrees::setActiveVarCount(val)
        public void setActiveVarCount (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            ml_RTrees_setActiveVarCount_10 (nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setCalculateVarImportance(bool val)
        //

        //javadoc: RTrees::setCalculateVarImportance(val)
        public void setCalculateVarImportance (bool val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            ml_RTrees_setCalculateVarImportance_10 (nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setTermCriteria(TermCriteria val)
        //

        //javadoc: RTrees::setTermCriteria(val)
        public void setTermCriteria (TermCriteria val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            ml_RTrees_setTermCriteria_10 (nativeObj, val.type, val.maxCount, val.epsilon);
        
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



        // C++:  Mat getVarImportance()
        [DllImport (LIBNAME)]
        private static extern IntPtr ml_RTrees_getVarImportance_10 (IntPtr nativeObj);

        // C++: static Ptr_RTrees create()
        [DllImport (LIBNAME)]
        private static extern IntPtr ml_RTrees_create_10 ();

        // C++: static Ptr_RTrees load(String filepath, String nodeName = String())
        [DllImport (LIBNAME)]
        private static extern IntPtr ml_RTrees_load_10 (string filepath, string nodeName);

        [DllImport (LIBNAME)]
        private static extern IntPtr ml_RTrees_load_11 (string filepath);

        // C++:  TermCriteria getTermCriteria()
        [DllImport (LIBNAME)]
        private static extern void ml_RTrees_getTermCriteria_10 (IntPtr nativeObj, double[] retVal);

        // C++:  bool getCalculateVarImportance()
        [DllImport (LIBNAME)]
        private static extern bool ml_RTrees_getCalculateVarImportance_10 (IntPtr nativeObj);

        // C++:  int getActiveVarCount()
        [DllImport (LIBNAME)]
        private static extern int ml_RTrees_getActiveVarCount_10 (IntPtr nativeObj);

        // C++:  void getVotes(Mat samples, Mat& results, int flags)
        [DllImport (LIBNAME)]
        private static extern void ml_RTrees_getVotes_10 (IntPtr nativeObj, IntPtr samples_nativeObj, IntPtr results_nativeObj, int flags);

        // C++:  void setActiveVarCount(int val)
        [DllImport (LIBNAME)]
        private static extern void ml_RTrees_setActiveVarCount_10 (IntPtr nativeObj, int val);

        // C++:  void setCalculateVarImportance(bool val)
        [DllImport (LIBNAME)]
        private static extern void ml_RTrees_setCalculateVarImportance_10 (IntPtr nativeObj, bool val);

        // C++:  void setTermCriteria(TermCriteria val)
        [DllImport (LIBNAME)]
        private static extern void ml_RTrees_setTermCriteria_10 (IntPtr nativeObj, int val_type, int val_maxCount, double val_epsilon);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ml_RTrees_delete (IntPtr nativeObj);

    }
}
