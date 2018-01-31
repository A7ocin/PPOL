

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class CalibrateDebevec
    //javadoc: CalibrateDebevec

    public class CalibrateDebevec : CalibrateCRF
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
photo_CalibrateDebevec_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal CalibrateDebevec (IntPtr addr) : base (addr) { }


        //
        // C++:  bool getRandom()
        //

        //javadoc: CalibrateDebevec::getRandom()
        public bool getRandom ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = photo_CalibrateDebevec_getRandom_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  float getLambda()
        //

        //javadoc: CalibrateDebevec::getLambda()
        public float getLambda ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_CalibrateDebevec_getLambda_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getSamples()
        //

        //javadoc: CalibrateDebevec::getSamples()
        public int getSamples ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = photo_CalibrateDebevec_getSamples_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setLambda(float lambda)
        //

        //javadoc: CalibrateDebevec::setLambda(lambda)
        public void setLambda (float lambda)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_CalibrateDebevec_setLambda_10(nativeObj, lambda);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setRandom(bool random)
        //

        //javadoc: CalibrateDebevec::setRandom(random)
        public void setRandom (bool random)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_CalibrateDebevec_setRandom_10(nativeObj, random);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setSamples(int samples)
        //

        //javadoc: CalibrateDebevec::setSamples(samples)
        public void setSamples (int samples)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_CalibrateDebevec_setSamples_10(nativeObj, samples);
        
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



        // C++:  bool getRandom()
        [DllImport (LIBNAME)]
        private static extern bool photo_CalibrateDebevec_getRandom_10 (IntPtr nativeObj);

        // C++:  float getLambda()
        [DllImport (LIBNAME)]
        private static extern float photo_CalibrateDebevec_getLambda_10 (IntPtr nativeObj);

        // C++:  int getSamples()
        [DllImport (LIBNAME)]
        private static extern int photo_CalibrateDebevec_getSamples_10 (IntPtr nativeObj);

        // C++:  void setLambda(float lambda)
        [DllImport (LIBNAME)]
        private static extern void photo_CalibrateDebevec_setLambda_10 (IntPtr nativeObj, float lambda);

        // C++:  void setRandom(bool random)
        [DllImport (LIBNAME)]
        private static extern void photo_CalibrateDebevec_setRandom_10 (IntPtr nativeObj, bool random);

        // C++:  void setSamples(int samples)
        [DllImport (LIBNAME)]
        private static extern void photo_CalibrateDebevec_setSamples_10 (IntPtr nativeObj, int samples);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void photo_CalibrateDebevec_delete (IntPtr nativeObj);

    }
}
