

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class BriefDescriptorExtractor
    //javadoc: BriefDescriptorExtractor

    public class BriefDescriptorExtractor : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_BriefDescriptorExtractor_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal BriefDescriptorExtractor (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_BriefDescriptorExtractor create(int bytes = 32, bool use_orientation = false)
        //

        //javadoc: BriefDescriptorExtractor::create(bytes, use_orientation)
        public static BriefDescriptorExtractor create (int bytes, bool use_orientation)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BriefDescriptorExtractor retVal = new BriefDescriptorExtractor(xfeatures2d_BriefDescriptorExtractor_create_10(bytes, use_orientation));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: BriefDescriptorExtractor::create()
        public static BriefDescriptorExtractor create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BriefDescriptorExtractor retVal = new BriefDescriptorExtractor(xfeatures2d_BriefDescriptorExtractor_create_11());
        
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



        // C++: static Ptr_BriefDescriptorExtractor create(int bytes = 32, bool use_orientation = false)
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_BriefDescriptorExtractor_create_10 (int bytes, bool use_orientation);
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_BriefDescriptorExtractor_create_11 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_BriefDescriptorExtractor_delete (IntPtr nativeObj);

    }
}
