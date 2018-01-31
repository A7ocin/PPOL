

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class FlannBasedMatcher
    //javadoc: FlannBasedMatcher

    public class FlannBasedMatcher : DescriptorMatcher
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
features2d_FlannBasedMatcher_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal FlannBasedMatcher (IntPtr addr) : base (addr) { }


        //
        // C++:   FlannBasedMatcher(Ptr_flann_IndexParams indexParams = makePtr<flann::KDTreeIndexParams>(), Ptr_flann_SearchParams searchParams = makePtr<flann::SearchParams>())
        //

        //javadoc: FlannBasedMatcher::FlannBasedMatcher()
        public FlannBasedMatcher () :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        base( features2d_FlannBasedMatcher_FlannBasedMatcher_10() )
        
#else
            base (IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++: static Ptr_FlannBasedMatcher create()
        //

        //javadoc: FlannBasedMatcher::create()
        public static FlannBasedMatcher create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        FlannBasedMatcher retVal = new FlannBasedMatcher(features2d_FlannBasedMatcher_create_10());
        
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



        // C++:   FlannBasedMatcher(Ptr_flann_IndexParams indexParams = makePtr<flann::KDTreeIndexParams>(), Ptr_flann_SearchParams searchParams = makePtr<flann::SearchParams>())
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_FlannBasedMatcher_FlannBasedMatcher_10 ();

        // C++: static Ptr_FlannBasedMatcher create()
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_FlannBasedMatcher_create_10 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_FlannBasedMatcher_delete (IntPtr nativeObj);

    }
}
