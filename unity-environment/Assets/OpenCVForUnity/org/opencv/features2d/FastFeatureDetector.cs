

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class FastFeatureDetector
    //javadoc: FastFeatureDetector

    public class FastFeatureDetector : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        features2d_FastFeatureDetector_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal FastFeatureDetector (IntPtr addr)
            : base (addr)
        {
        }


        public const int TYPE_5_8 = 0;
        public const int TYPE_7_12 = 1;
        public const int TYPE_9_16 = 2;
        public const int THRESHOLD = 10000;
        public const int NONMAX_SUPPRESSION = 10001;
        public const int FAST_N = 10002;
        //
        // C++: static Ptr_FastFeatureDetector create(int threshold = 10, bool nonmaxSuppression = true, int type = FastFeatureDetector::TYPE_9_16)
        //

        //javadoc: FastFeatureDetector::create(threshold, nonmaxSuppression, type)
        public static FastFeatureDetector create (int threshold, bool nonmaxSuppression, int type)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            FastFeatureDetector retVal = new FastFeatureDetector (features2d_FastFeatureDetector_create_10 (threshold, nonmaxSuppression, type));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: FastFeatureDetector::create()
        public static FastFeatureDetector create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            FastFeatureDetector retVal = new FastFeatureDetector (features2d_FastFeatureDetector_create_11 ());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  String getDefaultName()
        //

        //javadoc: FastFeatureDetector::getDefaultName()
        public override string getDefaultName ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            string retVal = Marshal.PtrToStringAnsi (features2d_FastFeatureDetector_getDefaultName_10 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool getNonmaxSuppression()
        //

        //javadoc: FastFeatureDetector::getNonmaxSuppression()
        public bool getNonmaxSuppression ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = features2d_FastFeatureDetector_getNonmaxSuppression_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  int getThreshold()
        //

        //javadoc: FastFeatureDetector::getThreshold()
        public int getThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_FastFeatureDetector_getThreshold_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getType()
        //

        //javadoc: FastFeatureDetector::getType()
        public int getType ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_FastFeatureDetector_getType_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setNonmaxSuppression(bool f)
        //

        //javadoc: FastFeatureDetector::setNonmaxSuppression(f)
        public void setNonmaxSuppression (bool f)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_FastFeatureDetector_setNonmaxSuppression_10 (nativeObj, f);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setThreshold(int threshold)
        //

        //javadoc: FastFeatureDetector::setThreshold(threshold)
        public void setThreshold (int threshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_FastFeatureDetector_setThreshold_10 (nativeObj, threshold);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setType(int type)
        //

        //javadoc: FastFeatureDetector::setType(type)
        public void setType (int type)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_FastFeatureDetector_setType_10 (nativeObj, type);
        
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



        // C++: static Ptr_FastFeatureDetector create(int threshold = 10, bool nonmaxSuppression = true, int type = FastFeatureDetector::TYPE_9_16)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_FastFeatureDetector_create_10 (int threshold, bool nonmaxSuppression, int type);

        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_FastFeatureDetector_create_11 ();

        // C++:  String getDefaultName()
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_FastFeatureDetector_getDefaultName_10 (IntPtr nativeObj);

        // C++:  bool getNonmaxSuppression()
        [DllImport (LIBNAME)]
        private static extern bool features2d_FastFeatureDetector_getNonmaxSuppression_10 (IntPtr nativeObj);

        // C++:  int getThreshold()
        [DllImport (LIBNAME)]
        private static extern int features2d_FastFeatureDetector_getThreshold_10 (IntPtr nativeObj);

        // C++:  int getType()
        [DllImport (LIBNAME)]
        private static extern int features2d_FastFeatureDetector_getType_10 (IntPtr nativeObj);

        // C++:  void setNonmaxSuppression(bool f)
        [DllImport (LIBNAME)]
        private static extern void features2d_FastFeatureDetector_setNonmaxSuppression_10 (IntPtr nativeObj, bool f);

        // C++:  void setThreshold(int threshold)
        [DllImport (LIBNAME)]
        private static extern void features2d_FastFeatureDetector_setThreshold_10 (IntPtr nativeObj, int threshold);

        // C++:  void setType(int type)
        [DllImport (LIBNAME)]
        private static extern void features2d_FastFeatureDetector_setType_10 (IntPtr nativeObj, int type);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_FastFeatureDetector_delete (IntPtr nativeObj);

    }
}
