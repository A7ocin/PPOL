

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class KNearest
    //javadoc: KNearest

    public class KNearest : StatModel
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ml_KNearest_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal KNearest (IntPtr addr) : base (addr) { }


        public const int BRUTE_FORCE = 1;
        public const int KDTREE = 2;
        //
        // C++: static Ptr_KNearest create()
        //

        //javadoc: KNearest::create()
        public static KNearest create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        KNearest retVal = new KNearest(ml_KNearest_create_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool getIsClassifier()
        //

        //javadoc: KNearest::getIsClassifier()
        public bool getIsClassifier ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = ml_KNearest_getIsClassifier_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  float findNearest(Mat samples, int k, Mat& results, Mat& neighborResponses = Mat(), Mat& dist = Mat())
        //

        //javadoc: KNearest::findNearest(samples, k, results, neighborResponses, dist)
        public float findNearest (Mat samples, int k, Mat results, Mat neighborResponses, Mat dist)
        {
            ThrowIfDisposed ();
            if (samples != null) samples.ThrowIfDisposed ();
            if (results != null) results.ThrowIfDisposed ();
            if (neighborResponses != null) neighborResponses.ThrowIfDisposed ();
            if (dist != null) dist.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ml_KNearest_findNearest_10(nativeObj, samples.nativeObj, k, results.nativeObj, neighborResponses.nativeObj, dist.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }

        //javadoc: KNearest::findNearest(samples, k, results)
        public float findNearest (Mat samples, int k, Mat results)
        {
            ThrowIfDisposed ();
            if (samples != null) samples.ThrowIfDisposed ();
            if (results != null) results.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ml_KNearest_findNearest_11(nativeObj, samples.nativeObj, k, results.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getAlgorithmType()
        //

        //javadoc: KNearest::getAlgorithmType()
        public int getAlgorithmType ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = ml_KNearest_getAlgorithmType_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getDefaultK()
        //

        //javadoc: KNearest::getDefaultK()
        public int getDefaultK ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = ml_KNearest_getDefaultK_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getEmax()
        //

        //javadoc: KNearest::getEmax()
        public int getEmax ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = ml_KNearest_getEmax_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setAlgorithmType(int val)
        //

        //javadoc: KNearest::setAlgorithmType(val)
        public void setAlgorithmType (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_KNearest_setAlgorithmType_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setDefaultK(int val)
        //

        //javadoc: KNearest::setDefaultK(val)
        public void setDefaultK (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_KNearest_setDefaultK_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setEmax(int val)
        //

        //javadoc: KNearest::setEmax(val)
        public void setEmax (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_KNearest_setEmax_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setIsClassifier(bool val)
        //

        //javadoc: KNearest::setIsClassifier(val)
        public void setIsClassifier (bool val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ml_KNearest_setIsClassifier_10(nativeObj, val);
        
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



        // C++: static Ptr_KNearest create()
        [DllImport (LIBNAME)]
        private static extern IntPtr ml_KNearest_create_10 ();

        // C++:  bool getIsClassifier()
        [DllImport (LIBNAME)]
        private static extern bool ml_KNearest_getIsClassifier_10 (IntPtr nativeObj);

        // C++:  float findNearest(Mat samples, int k, Mat& results, Mat& neighborResponses = Mat(), Mat& dist = Mat())
        [DllImport (LIBNAME)]
        private static extern float ml_KNearest_findNearest_10 (IntPtr nativeObj, IntPtr samples_nativeObj, int k, IntPtr results_nativeObj, IntPtr neighborResponses_nativeObj, IntPtr dist_nativeObj);
        [DllImport (LIBNAME)]
        private static extern float ml_KNearest_findNearest_11 (IntPtr nativeObj, IntPtr samples_nativeObj, int k, IntPtr results_nativeObj);

        // C++:  int getAlgorithmType()
        [DllImport (LIBNAME)]
        private static extern int ml_KNearest_getAlgorithmType_10 (IntPtr nativeObj);

        // C++:  int getDefaultK()
        [DllImport (LIBNAME)]
        private static extern int ml_KNearest_getDefaultK_10 (IntPtr nativeObj);

        // C++:  int getEmax()
        [DllImport (LIBNAME)]
        private static extern int ml_KNearest_getEmax_10 (IntPtr nativeObj);

        // C++:  void setAlgorithmType(int val)
        [DllImport (LIBNAME)]
        private static extern void ml_KNearest_setAlgorithmType_10 (IntPtr nativeObj, int val);

        // C++:  void setDefaultK(int val)
        [DllImport (LIBNAME)]
        private static extern void ml_KNearest_setDefaultK_10 (IntPtr nativeObj, int val);

        // C++:  void setEmax(int val)
        [DllImport (LIBNAME)]
        private static extern void ml_KNearest_setEmax_10 (IntPtr nativeObj, int val);

        // C++:  void setIsClassifier(bool val)
        [DllImport (LIBNAME)]
        private static extern void ml_KNearest_setIsClassifier_10 (IntPtr nativeObj, bool val);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ml_KNearest_delete (IntPtr nativeObj);

    }
}
