#if !UNITY_WEBGL && !UNITY_WSA_10_0

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class DictValue
    //javadoc: DictValue

    public class DictValue : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        dnn_DictValue_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal DictValue (IntPtr addr)
            : base (addr)
        {
        }


        public IntPtr getNativeObjAddr ()
        {
            return nativeObj;
        }

        //
        // C++:   DictValue(String s)
        //

        //javadoc: DictValue::DictValue(s)
        public DictValue (string s)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            nativeObj = dnn_DictValue_DictValue_10 (s);
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:   DictValue(double p)
        //

        //javadoc: DictValue::DictValue(p)
        public DictValue (double p)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            nativeObj = dnn_DictValue_DictValue_11 (p);
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:   DictValue(int i)
        //

        //javadoc: DictValue::DictValue(i)
        public DictValue (int i)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            nativeObj = dnn_DictValue_DictValue_12 (i);
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:  String getStringValue(int idx = -1)
        //

        //javadoc: DictValue::getStringValue(idx)
        public string getStringValue (int idx)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            string retVal = Marshal.PtrToStringAnsi (dnn_DictValue_getStringValue_10 (nativeObj, idx));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: DictValue::getStringValue()
        public string getStringValue ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            string retVal = Marshal.PtrToStringAnsi (dnn_DictValue_getStringValue_11 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool isInt()
        //

        //javadoc: DictValue::isInt()
        public bool isInt ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = dnn_DictValue_isInt_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool isReal()
        //

        //javadoc: DictValue::isReal()
        public bool isReal ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = dnn_DictValue_isReal_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool isString()
        //

        //javadoc: DictValue::isString()
        public bool isString ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = dnn_DictValue_isString_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  double getRealValue(int idx = -1)
        //

        //javadoc: DictValue::getRealValue(idx)
        public double getRealValue (int idx)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = dnn_DictValue_getRealValue_10 (nativeObj, idx);
        
#else
            return -1;
#endif
            return retVal;
        }

        //javadoc: DictValue::getRealValue()
        public double getRealValue ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = dnn_DictValue_getRealValue_11 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getIntValue(int idx = -1)
        //

        //javadoc: DictValue::getIntValue(idx)
        public int getIntValue (int idx)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = dnn_DictValue_getIntValue_10 (nativeObj, idx);
        
#else
            return -1;
#endif
            return retVal;
        }

        //javadoc: DictValue::getIntValue()
        public int getIntValue ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = dnn_DictValue_getIntValue_11 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";

#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   DictValue(String s)
        [DllImport (LIBNAME)]
        private static extern IntPtr dnn_DictValue_DictValue_10 (string s);

        // C++:   DictValue(double p)
        [DllImport (LIBNAME)]
        private static extern IntPtr dnn_DictValue_DictValue_11 (double p);

        // C++:   DictValue(int i)
        [DllImport (LIBNAME)]
        private static extern IntPtr dnn_DictValue_DictValue_12 (int i);

        // C++:  String getStringValue(int idx = -1)
        [DllImport (LIBNAME)]
        private static extern IntPtr dnn_DictValue_getStringValue_10 (IntPtr nativeObj, int idx);

        [DllImport (LIBNAME)]
        private static extern IntPtr dnn_DictValue_getStringValue_11 (IntPtr nativeObj);

        // C++:  bool isInt()
        [DllImport (LIBNAME)]
        private static extern bool dnn_DictValue_isInt_10 (IntPtr nativeObj);

        // C++:  bool isReal()
        [DllImport (LIBNAME)]
        private static extern bool dnn_DictValue_isReal_10 (IntPtr nativeObj);

        // C++:  bool isString()
        [DllImport (LIBNAME)]
        private static extern bool dnn_DictValue_isString_10 (IntPtr nativeObj);

        // C++:  double getRealValue(int idx = -1)
        [DllImport (LIBNAME)]
        private static extern double dnn_DictValue_getRealValue_10 (IntPtr nativeObj, int idx);

        [DllImport (LIBNAME)]
        private static extern double dnn_DictValue_getRealValue_11 (IntPtr nativeObj);

        // C++:  int getIntValue(int idx = -1)
        [DllImport (LIBNAME)]
        private static extern int dnn_DictValue_getIntValue_10 (IntPtr nativeObj, int idx);

        [DllImport (LIBNAME)]
        private static extern int dnn_DictValue_getIntValue_11 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void dnn_DictValue_delete (IntPtr nativeObj);

    }
}
#endif
