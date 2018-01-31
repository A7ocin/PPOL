

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class Tracker
    //javadoc: Tracker

    public class Tracker : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
tracking_Tracker_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal Tracker (IntPtr addr) : base (addr) { }


        //
        // C++:  bool init(Mat image, Rect2d boundingBox)
        //

        //javadoc: Tracker::init(image, boundingBox)
        public bool init (Mat image, Rect2d boundingBox)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = tracking_Tracker_init_10(nativeObj, image.nativeObj, boundingBox.x, boundingBox.y, boundingBox.width, boundingBox.height);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool update(Mat image, Rect2d& boundingBox)
        //

        //javadoc: Tracker::update(image, boundingBox)
        public bool update (Mat image, Rect2d boundingBox)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        double[] boundingBox_out = new double[4];
        bool retVal = tracking_Tracker_update_10(nativeObj, image.nativeObj, boundingBox_out);
        if(boundingBox!=null){ boundingBox.x = boundingBox_out[0]; boundingBox.y = boundingBox_out[1]; boundingBox.width = boundingBox_out[2]; boundingBox.height = boundingBox_out[3]; } 
#else
            return false;
#endif
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  bool init(Mat image, Rect2d boundingBox)
        [DllImport (LIBNAME)]
        private static extern bool tracking_Tracker_init_10 (IntPtr nativeObj, IntPtr image_nativeObj, double boundingBox_x, double boundingBox_y, double boundingBox_width, double boundingBox_height);

        // C++:  bool update(Mat image, Rect2d& boundingBox)
        [DllImport (LIBNAME)]
        private static extern bool tracking_Tracker_update_10 (IntPtr nativeObj, IntPtr image_nativeObj, double[] boundingBox_out);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void tracking_Tracker_delete (IntPtr nativeObj);

    }
}
