

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class SelectiveSearchSegmentationStrategy
    //javadoc: SelectiveSearchSegmentationStrategy

    public class SelectiveSearchSegmentationStrategy : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_SelectiveSearchSegmentationStrategy_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal SelectiveSearchSegmentationStrategy (IntPtr addr) : base (addr) { }


        //
        // C++:  float get(int r1, int r2)
        //

        //javadoc: SelectiveSearchSegmentationStrategy::get(r1, r2)
        public float get (int r1, int r2)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_SelectiveSearchSegmentationStrategy_get_10(nativeObj, r1, r2);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void merge(int r1, int r2)
        //

        //javadoc: SelectiveSearchSegmentationStrategy::merge(r1, r2)
        public void merge (int r1, int r2)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentationStrategy_merge_10(nativeObj, r1, r2);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setImage(Mat img, Mat regions, Mat sizes, int image_id = -1)
        //

        //javadoc: SelectiveSearchSegmentationStrategy::setImage(img, regions, sizes, image_id)
        public void setImage (Mat img, Mat regions, Mat sizes, int image_id)
        {
            ThrowIfDisposed ();
            if (img != null) img.ThrowIfDisposed ();
            if (regions != null) regions.ThrowIfDisposed ();
            if (sizes != null) sizes.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentationStrategy_setImage_10(nativeObj, img.nativeObj, regions.nativeObj, sizes.nativeObj, image_id);
        
#else
            return;
#endif
            return;
        }

        //javadoc: SelectiveSearchSegmentationStrategy::setImage(img, regions, sizes)
        public void setImage (Mat img, Mat regions, Mat sizes)
        {
            ThrowIfDisposed ();
            if (img != null) img.ThrowIfDisposed ();
            if (regions != null) regions.ThrowIfDisposed ();
            if (sizes != null) sizes.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_SelectiveSearchSegmentationStrategy_setImage_11(nativeObj, img.nativeObj, regions.nativeObj, sizes.nativeObj);
        
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



        // C++:  float get(int r1, int r2)
        [DllImport (LIBNAME)]
        private static extern float ximgproc_SelectiveSearchSegmentationStrategy_get_10 (IntPtr nativeObj, int r1, int r2);

        // C++:  void merge(int r1, int r2)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategy_merge_10 (IntPtr nativeObj, int r1, int r2);

        // C++:  void setImage(Mat img, Mat regions, Mat sizes, int image_id = -1)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategy_setImage_10 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr regions_nativeObj, IntPtr sizes_nativeObj, int image_id);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategy_setImage_11 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr regions_nativeObj, IntPtr sizes_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_SelectiveSearchSegmentationStrategy_delete (IntPtr nativeObj);

    }
}
