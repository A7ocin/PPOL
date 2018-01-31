

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class RFFeatureGetter
    //javadoc: RFFeatureGetter

    public class RFFeatureGetter : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_RFFeatureGetter_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal RFFeatureGetter (IntPtr addr) : base (addr) { }


        //
        // C++:  void getFeatures(Mat src, Mat features, int gnrmRad, int gsmthRad, int shrink, int outNum, int gradNum)
        //

        //javadoc: RFFeatureGetter::getFeatures(src, features, gnrmRad, gsmthRad, shrink, outNum, gradNum)
        public void getFeatures (Mat src, Mat features, int gnrmRad, int gsmthRad, int shrink, int outNum, int gradNum)
        {
            ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (features != null) features.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_RFFeatureGetter_getFeatures_10(nativeObj, src.nativeObj, features.nativeObj, gnrmRad, gsmthRad, shrink, outNum, gradNum);
        
#else
            return;
#endif
            return;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  void getFeatures(Mat src, Mat features, int gnrmRad, int gsmthRad, int shrink, int outNum, int gradNum)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_RFFeatureGetter_getFeatures_10 (IntPtr nativeObj, IntPtr src_nativeObj, IntPtr features_nativeObj, int gnrmRad, int gsmthRad, int shrink, int outNum, int gradNum);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_RFFeatureGetter_delete (IntPtr nativeObj);

    }
}
