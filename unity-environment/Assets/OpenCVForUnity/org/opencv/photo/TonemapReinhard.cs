

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class TonemapReinhard
    //javadoc: TonemapReinhard

    public class TonemapReinhard : Tonemap
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
photo_TonemapReinhard_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal TonemapReinhard (IntPtr addr) : base (addr) { }


        //
        // C++:  float getColorAdaptation()
        //

        //javadoc: TonemapReinhard::getColorAdaptation()
        public float getColorAdaptation ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapReinhard_getColorAdaptation_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getIntensity()
        //

        //javadoc: TonemapReinhard::getIntensity()
        public float getIntensity ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapReinhard_getIntensity_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getLightAdaptation()
        //

        //javadoc: TonemapReinhard::getLightAdaptation()
        public float getLightAdaptation ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = photo_TonemapReinhard_getLightAdaptation_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setColorAdaptation(float color_adapt)
        //

        //javadoc: TonemapReinhard::setColorAdaptation(color_adapt)
        public void setColorAdaptation (float color_adapt)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapReinhard_setColorAdaptation_10(nativeObj, color_adapt);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setIntensity(float intensity)
        //

        //javadoc: TonemapReinhard::setIntensity(intensity)
        public void setIntensity (float intensity)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapReinhard_setIntensity_10(nativeObj, intensity);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setLightAdaptation(float light_adapt)
        //

        //javadoc: TonemapReinhard::setLightAdaptation(light_adapt)
        public void setLightAdaptation (float light_adapt)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_TonemapReinhard_setLightAdaptation_10(nativeObj, light_adapt);
        
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



        // C++:  float getColorAdaptation()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapReinhard_getColorAdaptation_10 (IntPtr nativeObj);

        // C++:  float getIntensity()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapReinhard_getIntensity_10 (IntPtr nativeObj);

        // C++:  float getLightAdaptation()
        [DllImport (LIBNAME)]
        private static extern float photo_TonemapReinhard_getLightAdaptation_10 (IntPtr nativeObj);

        // C++:  void setColorAdaptation(float color_adapt)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapReinhard_setColorAdaptation_10 (IntPtr nativeObj, float color_adapt);

        // C++:  void setIntensity(float intensity)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapReinhard_setIntensity_10 (IntPtr nativeObj, float intensity);

        // C++:  void setLightAdaptation(float light_adapt)
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapReinhard_setLightAdaptation_10 (IntPtr nativeObj, float light_adapt);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void photo_TonemapReinhard_delete (IntPtr nativeObj);

    }
}
