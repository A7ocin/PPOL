

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class AverageHash
    //javadoc: AverageHash

    public class AverageHash : ImgHashBase
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
img_1hash_AverageHash_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal AverageHash (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_AverageHash create()
        //

        //javadoc: AverageHash::create()
        public static AverageHash create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        AverageHash retVal = new AverageHash(img_1hash_AverageHash_create_10());
        
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



        // C++: static Ptr_AverageHash create()
        [DllImport (LIBNAME)]
        private static extern IntPtr img_1hash_AverageHash_create_10 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void img_1hash_AverageHash_delete (IntPtr nativeObj);

    }
}
