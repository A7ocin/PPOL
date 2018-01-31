

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class LUCID
    //javadoc: LUCID

    public class LUCID : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_LUCID_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal LUCID (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_LUCID create(int lucid_kernel = 1, int blur_kernel = 2)
        //

        //javadoc: LUCID::create(lucid_kernel, blur_kernel)
        public static LUCID create (int lucid_kernel, int blur_kernel)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        LUCID retVal = new LUCID(xfeatures2d_LUCID_create_10(lucid_kernel, blur_kernel));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: LUCID::create()
        public static LUCID create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        LUCID retVal = new LUCID(xfeatures2d_LUCID_create_11());
        
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



        // C++: static Ptr_LUCID create(int lucid_kernel = 1, int blur_kernel = 2)
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_LUCID_create_10 (int lucid_kernel, int blur_kernel);
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_LUCID_create_11 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_LUCID_delete (IntPtr nativeObj);

    }
}
