

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class TrackerTLD
    //javadoc: TrackerTLD

    public class TrackerTLD : Tracker
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
tracking_TrackerTLD_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal TrackerTLD (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_TrackerTLD create()
        //

        //javadoc: TrackerTLD::create()
        public static TrackerTLD create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        TrackerTLD retVal = new TrackerTLD(tracking_TrackerTLD_create_10());
        
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



        // C++: static Ptr_TrackerTLD create()
        [DllImport (LIBNAME)]
        private static extern IntPtr tracking_TrackerTLD_create_10 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void tracking_TrackerTLD_delete (IntPtr nativeObj);

    }
}
