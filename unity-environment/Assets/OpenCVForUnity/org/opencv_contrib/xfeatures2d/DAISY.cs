

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class DAISY
    //javadoc: DAISY

    public class DAISY : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_DAISY_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal DAISY (IntPtr addr) : base (addr) { }


        public const int NRM_NONE = 100;
        public const int NRM_PARTIAL = 101;
        public const int NRM_FULL = 102;
        public const int NRM_SIFT = 103;
        //
        // C++: static Ptr_DAISY create(float radius = 15, int q_radius = 3, int q_theta = 8, int q_hist = 8, int norm = DAISY::NRM_NONE, Mat H = Mat(), bool interpolation = true, bool use_orientation = false)
        //

        //javadoc: DAISY::create(radius, q_radius, q_theta, q_hist, norm, H, interpolation, use_orientation)
        public static DAISY create (float radius, int q_radius, int q_theta, int q_hist, int norm, Mat H, bool interpolation, bool use_orientation)
        {
            if (H != null) H.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DAISY retVal = new DAISY(xfeatures2d_DAISY_create_10(radius, q_radius, q_theta, q_hist, norm, H.nativeObj, interpolation, use_orientation));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: DAISY::create()
        public static DAISY create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DAISY retVal = new DAISY(xfeatures2d_DAISY_create_11());
        
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



        // C++: static Ptr_DAISY create(float radius = 15, int q_radius = 3, int q_theta = 8, int q_hist = 8, int norm = DAISY::NRM_NONE, Mat H = Mat(), bool interpolation = true, bool use_orientation = false)
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_10 (float radius, int q_radius, int q_theta, int q_hist, int norm, IntPtr H_nativeObj, bool interpolation, bool use_orientation);
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_DAISY_create_11 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_DAISY_delete (IntPtr nativeObj);

    }
}
