

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class ColorMomentHash
    //javadoc: ColorMomentHash

    public class ColorMomentHash : ImgHashBase
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
img_1hash_ColorMomentHash_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal ColorMomentHash (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_ColorMomentHash create()
        //

        //javadoc: ColorMomentHash::create()
        public static ColorMomentHash create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ColorMomentHash retVal = new ColorMomentHash(img_1hash_ColorMomentHash_create_10());
        
#else
            return null;
#endif
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_ColorMomentHash create()
        [DllImport (LIBNAME)]
        private static extern IntPtr img_1hash_ColorMomentHash_create_10 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void img_1hash_ColorMomentHash_delete (IntPtr nativeObj);

    }
}
