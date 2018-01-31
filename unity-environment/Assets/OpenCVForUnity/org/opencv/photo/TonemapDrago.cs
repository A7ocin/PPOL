

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class TonemapDrago
    //javadoc: TonemapDrago

    public class TonemapDrago : Tonemap
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
photo_TonemapDrago_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal TonemapDrago (IntPtr addr) : base (addr) { }


        //
        // C++:  float getBias()
        //

        //javadoc: TonemapDrago::getBias()
        public float getBias ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapDrago_getBias_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getSaturation()
        //

        //javadoc: TonemapDrago::getSaturation()
        public float getSaturation ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapDrago_getSaturation_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setBias(float bias)
        //

        //javadoc: TonemapDrago::setBias(bias)
        public void setBias (float bias)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapDrago_setBias_10(nativeObj, bias);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setSaturation(float saturation)
        //

        //javadoc: TonemapDrago::setSaturation(saturation)
        public void setSaturation (float saturation)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapDrago_setSaturation_10(nativeObj, saturation);
        
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



        // C++:  float getBias()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapDrago_getBias_10 (IntPtr nativeObj);

        // C++:  float getSaturation()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapDrago_getSaturation_10 (IntPtr nativeObj);

        // C++:  void setBias(float bias)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapDrago_setBias_10 (IntPtr nativeObj, float bias);

        // C++:  void setSaturation(float saturation)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapDrago_setSaturation_10 (IntPtr nativeObj, float saturation);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapDrago_delete (IntPtr nativeObj);

    }
}
