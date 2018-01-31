

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class BFMatcher
    //javadoc: BFMatcher

    public class BFMatcher : DescriptorMatcher
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
features2d_BFMatcher_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal BFMatcher (IntPtr addr) : base (addr) { }


        //
        // C++:   BFMatcher(int normType = NORM_L2, bool crossCheck = false)
        //

        //javadoc: BFMatcher::BFMatcher(normType, crossCheck)
        public BFMatcher (int normType, bool crossCheck) :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        base( features2d_BFMatcher_BFMatcher_10(normType, crossCheck) )
        
#else
            base (IntPtr.Zero)
#endif
        {

            return;

        }

        //javadoc: BFMatcher::BFMatcher()
        public BFMatcher () :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        base( features2d_BFMatcher_BFMatcher_11() )
        
#else
            base (IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++: static Ptr_BFMatcher create(int normType = NORM_L2, bool crossCheck = false)
        //

        //javadoc: BFMatcher::create(normType, crossCheck)
        public static BFMatcher create (int normType, bool crossCheck)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BFMatcher retVal = new BFMatcher(features2d_BFMatcher_create_10(normType, crossCheck));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: BFMatcher::create()
        public static BFMatcher create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BFMatcher retVal = new BFMatcher(features2d_BFMatcher_create_11());
        
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



        // C++:   BFMatcher(int normType = NORM_L2, bool crossCheck = false)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_BFMatcher_10 (int normType, bool crossCheck);
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_BFMatcher_11 ();

        // C++: static Ptr_BFMatcher create(int normType = NORM_L2, bool crossCheck = false)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_create_10 (int normType, bool crossCheck);
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BFMatcher_create_11 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_BFMatcher_delete (IntPtr nativeObj);

    }
}
