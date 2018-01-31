

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class PHash
    //javadoc: PHash

    public class PHash : ImgHashBase
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
img_1hash_PHash_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal PHash (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_PHash create()
        //

        //javadoc: PHash::create()
        public static PHash create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        PHash retVal = new PHash(img_1hash_PHash_create_10());
        
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



        // C++: static Ptr_PHash create()
        [DllImport (LIBNAME)]
        private static extern IntPtr img_1hash_PHash_create_10 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void img_1hash_PHash_delete (IntPtr nativeObj);

    }
}
