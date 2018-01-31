

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class TrackerMedianFlow
    //javadoc: TrackerMedianFlow

    public class TrackerMedianFlow : Tracker
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
tracking_TrackerMedianFlow_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal TrackerMedianFlow (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_TrackerMedianFlow create()
        //

        //javadoc: TrackerMedianFlow::create()
        public static TrackerMedianFlow create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        TrackerMedianFlow retVal = new TrackerMedianFlow(tracking_TrackerMedianFlow_create_10());
        
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



        // C++: static Ptr_TrackerMedianFlow create()
        [DllImport (LIBNAME)]
        private static extern IntPtr tracking_TrackerMedianFlow_create_10 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void tracking_TrackerMedianFlow_delete (IntPtr nativeObj);

    }
}
