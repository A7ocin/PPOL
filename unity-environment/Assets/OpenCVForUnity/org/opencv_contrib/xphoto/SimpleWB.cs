

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class SimpleWB
    //javadoc: SimpleWB

    public class SimpleWB : WhiteBalancer
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xphoto_SimpleWB_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal SimpleWB (IntPtr addr) : base (addr) { }


        //
        // C++:  float getInputMax()
        //

        //javadoc: SimpleWB::getInputMax()
        public float getInputMax ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_SimpleWB_getInputMax_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getInputMin()
        //

        //javadoc: SimpleWB::getInputMin()
        public float getInputMin ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_SimpleWB_getInputMin_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getOutputMax()
        //

        //javadoc: SimpleWB::getOutputMax()
        public float getOutputMax ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_SimpleWB_getOutputMax_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getOutputMin()
        //

        //javadoc: SimpleWB::getOutputMin()
        public float getOutputMin ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_SimpleWB_getOutputMin_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getP()
        //

        //javadoc: SimpleWB::getP()
        public float getP ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_SimpleWB_getP_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setInputMax(float val)
        //

        //javadoc: SimpleWB::setInputMax(val)
        public void setInputMax (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_SimpleWB_setInputMax_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setInputMin(float val)
        //

        //javadoc: SimpleWB::setInputMin(val)
        public void setInputMin (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_SimpleWB_setInputMin_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setOutputMax(float val)
        //

        //javadoc: SimpleWB::setOutputMax(val)
        public void setOutputMax (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_SimpleWB_setOutputMax_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setOutputMin(float val)
        //

        //javadoc: SimpleWB::setOutputMin(val)
        public void setOutputMin (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_SimpleWB_setOutputMin_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setP(float val)
        //

        //javadoc: SimpleWB::setP(val)
        public void setP (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_SimpleWB_setP_10(nativeObj, val);
        
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



        // C++:  float getInputMax()
        [DllImport (LIBNAME)]
        private static extern float xphoto_SimpleWB_getInputMax_10 (IntPtr nativeObj);

        // C++:  float getInputMin()
        [DllImport (LIBNAME)]
        private static extern float xphoto_SimpleWB_getInputMin_10 (IntPtr nativeObj);

        // C++:  float getOutputMax()
        [DllImport (LIBNAME)]
        private static extern float xphoto_SimpleWB_getOutputMax_10 (IntPtr nativeObj);

        // C++:  float getOutputMin()
        [DllImport (LIBNAME)]
        private static extern float xphoto_SimpleWB_getOutputMin_10 (IntPtr nativeObj);

        // C++:  float getP()
        [DllImport (LIBNAME)]
        private static extern float xphoto_SimpleWB_getP_10 (IntPtr nativeObj);

        // C++:  void setInputMax(float val)
        [DllImport (LIBNAME)]
        private static extern void xphoto_SimpleWB_setInputMax_10 (IntPtr nativeObj, float val);

        // C++:  void setInputMin(float val)
        [DllImport (LIBNAME)]
        private static extern void xphoto_SimpleWB_setInputMin_10 (IntPtr nativeObj, float val);

        // C++:  void setOutputMax(float val)
        [DllImport (LIBNAME)]
        private static extern void xphoto_SimpleWB_setOutputMax_10 (IntPtr nativeObj, float val);

        // C++:  void setOutputMin(float val)
        [DllImport (LIBNAME)]
        private static extern void xphoto_SimpleWB_setOutputMin_10 (IntPtr nativeObj, float val);

        // C++:  void setP(float val)
        [DllImport (LIBNAME)]
        private static extern void xphoto_SimpleWB_setP_10 (IntPtr nativeObj, float val);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void xphoto_SimpleWB_delete (IntPtr nativeObj);

    }
}
