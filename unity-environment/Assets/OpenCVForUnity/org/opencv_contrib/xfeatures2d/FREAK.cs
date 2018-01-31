

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class FREAK
    //javadoc: FREAK

    public class FREAK : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_FREAK_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal FREAK (IntPtr addr) : base (addr) { }


        public const int NB_SCALES = 64;
        public const int NB_PAIRS = 512;
        public const int NB_ORIENPAIRS = 45;
        //
        // C++: static Ptr_FREAK create(bool orientationNormalized = true, bool scaleNormalized = true, float patternScale = 22.0f, int nOctaves = 4, vector_int selectedPairs = std::vector<int>())
        //

        //javadoc: FREAK::create(orientationNormalized, scaleNormalized, patternScale, nOctaves, selectedPairs)
        public static FREAK create (bool orientationNormalized, bool scaleNormalized, float patternScale, int nOctaves, MatOfInt selectedPairs)
        {
            if (selectedPairs != null) selectedPairs.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat selectedPairs_mat = selectedPairs;
        FREAK retVal = new FREAK(xfeatures2d_FREAK_create_10(orientationNormalized, scaleNormalized, patternScale, nOctaves, selectedPairs_mat.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: FREAK::create()
        public static FREAK create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        FREAK retVal = new FREAK(xfeatures2d_FREAK_create_11());
        
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



        // C++: static Ptr_FREAK create(bool orientationNormalized = true, bool scaleNormalized = true, float patternScale = 22.0f, int nOctaves = 4, vector_int selectedPairs = std::vector<int>())
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_10 (bool orientationNormalized, bool scaleNormalized, float patternScale, int nOctaves, IntPtr selectedPairs_mat_nativeObj);
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_FREAK_create_11 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_FREAK_delete (IntPtr nativeObj);

    }
}
