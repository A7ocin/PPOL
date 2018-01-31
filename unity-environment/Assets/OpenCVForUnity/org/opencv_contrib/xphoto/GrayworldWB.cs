

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class GrayworldWB
    //javadoc: GrayworldWB

    public class GrayworldWB : WhiteBalancer
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xphoto_GrayworldWB_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal GrayworldWB (IntPtr addr) : base (addr) { }


        //
        // C++:  float getSaturationThreshold()
        //

        //javadoc: GrayworldWB::getSaturationThreshold()
        public float getSaturationThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_GrayworldWB_getSaturationThreshold_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setSaturationThreshold(float val)
        //

        //javadoc: GrayworldWB::setSaturationThreshold(val)
        public void setSaturationThreshold (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_GrayworldWB_setSaturationThreshold_10(nativeObj, val);
        
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



        // C++:  float getSaturationThreshold()
        [DllImport (LIBNAME)]
        private static extern float xphoto_GrayworldWB_getSaturationThreshold_10 (IntPtr nativeObj);

        // C++:  void setSaturationThreshold(float val)
        [DllImport (LIBNAME)]
        private static extern void xphoto_GrayworldWB_setSaturationThreshold_10 (IntPtr nativeObj, float val);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void xphoto_GrayworldWB_delete (IntPtr nativeObj);

    }
}
