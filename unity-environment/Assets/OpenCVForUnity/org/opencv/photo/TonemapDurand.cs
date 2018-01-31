

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class TonemapDurand
    //javadoc: TonemapDurand

    public class TonemapDurand : Tonemap
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
photo_TonemapDurand_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal TonemapDurand (IntPtr addr) : base (addr) { }


        //
        // C++:  float getContrast()
        //

        //javadoc: TonemapDurand::getContrast()
        public float getContrast ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapDurand_getContrast_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getSaturation()
        //

        //javadoc: TonemapDurand::getSaturation()
        public float getSaturation ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapDurand_getSaturation_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getSigmaColor()
        //

        //javadoc: TonemapDurand::getSigmaColor()
        public float getSigmaColor ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapDurand_getSigmaColor_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getSigmaSpace()
        //

        //javadoc: TonemapDurand::getSigmaSpace()
        public float getSigmaSpace ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapDurand_getSigmaSpace_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setContrast(float contrast)
        //

        //javadoc: TonemapDurand::setContrast(contrast)
        public void setContrast (float contrast)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapDurand_setContrast_10(nativeObj, contrast);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setSaturation(float saturation)
        //

        //javadoc: TonemapDurand::setSaturation(saturation)
        public void setSaturation (float saturation)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapDurand_setSaturation_10(nativeObj, saturation);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setSigmaColor(float sigma_color)
        //

        //javadoc: TonemapDurand::setSigmaColor(sigma_color)
        public void setSigmaColor (float sigma_color)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapDurand_setSigmaColor_10(nativeObj, sigma_color);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setSigmaSpace(float sigma_space)
        //

        //javadoc: TonemapDurand::setSigmaSpace(sigma_space)
        public void setSigmaSpace (float sigma_space)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapDurand_setSigmaSpace_10(nativeObj, sigma_space);
        
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



        // C++:  float getContrast()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapDurand_getContrast_10 (IntPtr nativeObj);

        // C++:  float getSaturation()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapDurand_getSaturation_10 (IntPtr nativeObj);

        // C++:  float getSigmaColor()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapDurand_getSigmaColor_10 (IntPtr nativeObj);

        // C++:  float getSigmaSpace()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapDurand_getSigmaSpace_10 (IntPtr nativeObj);

        // C++:  void setContrast(float contrast)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapDurand_setContrast_10 (IntPtr nativeObj, float contrast);

        // C++:  void setSaturation(float saturation)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapDurand_setSaturation_10 (IntPtr nativeObj, float saturation);

        // C++:  void setSigmaColor(float sigma_color)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapDurand_setSigmaColor_10 (IntPtr nativeObj, float sigma_color);

        // C++:  void setSigmaSpace(float sigma_space)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapDurand_setSigmaSpace_10 (IntPtr nativeObj, float sigma_space);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapDurand_delete (IntPtr nativeObj);

    }
}
