

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class BoostDesc
    //javadoc: BoostDesc

    public class BoostDesc : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_BoostDesc_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal BoostDesc (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_BoostDesc create(int desc = BoostDesc::BINBOOST_256, bool use_scale_orientation = true, float scale_factor = 6.25f)
        //

        //javadoc: BoostDesc::create(desc, use_scale_orientation, scale_factor)
        public static BoostDesc create (int desc, bool use_scale_orientation, float scale_factor)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BoostDesc retVal = new BoostDesc(xfeatures2d_BoostDesc_create_10(desc, use_scale_orientation, scale_factor));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: BoostDesc::create()
        public static BoostDesc create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BoostDesc retVal = new BoostDesc(xfeatures2d_BoostDesc_create_11());
        
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



        // C++: static Ptr_BoostDesc create(int desc = BoostDesc::BINBOOST_256, bool use_scale_orientation = true, float scale_factor = 6.25f)
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_BoostDesc_create_10 (int desc, bool use_scale_orientation, float scale_factor);
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_BoostDesc_create_11 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_BoostDesc_delete (IntPtr nativeObj);

    }
}
