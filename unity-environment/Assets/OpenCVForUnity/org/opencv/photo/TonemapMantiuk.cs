

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class TonemapMantiuk
    //javadoc: TonemapMantiuk

    public class TonemapMantiuk : Tonemap
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
photo_TonemapMantiuk_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal TonemapMantiuk (IntPtr addr) : base (addr) { }


        //
        // C++:  float getSaturation()
        //

        //javadoc: TonemapMantiuk::getSaturation()
        public float getSaturation ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapMantiuk_getSaturation_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getScale()
        //

        //javadoc: TonemapMantiuk::getScale()
        public float getScale ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapMantiuk_getScale_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setSaturation(float saturation)
        //

        //javadoc: TonemapMantiuk::setSaturation(saturation)
        public void setSaturation (float saturation)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapMantiuk_setSaturation_10(nativeObj, saturation);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setScale(float scale)
        //

        //javadoc: TonemapMantiuk::setScale(scale)
        public void setScale (float scale)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapMantiuk_setScale_10(nativeObj, scale);
        
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



        // C++:  float getSaturation()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapMantiuk_getSaturation_10 (IntPtr nativeObj);

        // C++:  float getScale()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapMantiuk_getScale_10 (IntPtr nativeObj);

        // C++:  void setSaturation(float saturation)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapMantiuk_setSaturation_10 (IntPtr nativeObj, float saturation);

        // C++:  void setScale(float scale)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapMantiuk_setScale_10 (IntPtr nativeObj, float scale);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapMantiuk_delete (IntPtr nativeObj);

    }
}
