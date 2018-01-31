

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class VGG
    //javadoc: VGG

    public class VGG : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        xfeatures2d_VGG_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal VGG (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++: static Ptr_VGG create(int desc = VGG::VGG_120, float isigma = 1.4f, bool img_normalize = true, bool use_scale_orientation = true, float scale_factor = 6.25f, bool dsc_normalize = false)
        //

        //javadoc: VGG::create(desc, isigma, img_normalize, use_scale_orientation, scale_factor, dsc_normalize)
        public static VGG create (int desc, float isigma, bool img_normalize, bool use_scale_orientation, float scale_factor, bool dsc_normalize)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            VGG retVal = new VGG (xfeatures2d_VGG_create_10 (desc, isigma, img_normalize, use_scale_orientation, scale_factor, dsc_normalize));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: VGG::create()
        public static VGG create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            VGG retVal = new VGG (xfeatures2d_VGG_create_11 ());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void compute(Mat image, vector_KeyPoint keypoints, Mat& descriptors)
        //

        //javadoc: VGG::compute(image, keypoints, descriptors)
        public override void compute (Mat image, MatOfKeyPoint keypoints, Mat descriptors)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (keypoints != null)
                keypoints.ThrowIfDisposed ();
            if (descriptors != null)
                descriptors.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat keypoints_mat = keypoints;
            xfeatures2d_VGG_compute_10 (nativeObj, image.nativeObj, keypoints_mat.nativeObj, descriptors.nativeObj);
        
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



        // C++: static Ptr_VGG create(int desc = VGG::VGG_120, float isigma = 1.4f, bool img_normalize = true, bool use_scale_orientation = true, float scale_factor = 6.25f, bool dsc_normalize = false)
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_10 (int desc, float isigma, bool img_normalize, bool use_scale_orientation, float scale_factor, bool dsc_normalize);

        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_VGG_create_11 ();

        // C++:  void compute(Mat image, vector_KeyPoint keypoints, Mat& descriptors)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_VGG_compute_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_VGG_delete (IntPtr nativeObj);

    }
}
