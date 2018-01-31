

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class BOWImgDescriptorExtractor
    //javadoc: BOWImgDescriptorExtractor

    public class BOWImgDescriptorExtractor : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
features2d_BOWImgDescriptorExtractor_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal BOWImgDescriptorExtractor (IntPtr addr) : base (addr) { }


        public IntPtr getNativeObjAddr () { return nativeObj; }

        //
        // C++:   BOWImgDescriptorExtractor(Ptr_DescriptorExtractor dextractor, Ptr_DescriptorMatcher dmatcher)
        //

        // Unknown type 'Ptr_DescriptorExtractor' (I), skipping the function


        //
        // C++:  Mat getVocabulary()
        //

        //javadoc: BOWImgDescriptorExtractor::getVocabulary()
        public Mat getVocabulary ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(features2d_BOWImgDescriptorExtractor_getVocabulary_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  int descriptorSize()
        //

        //javadoc: BOWImgDescriptorExtractor::descriptorSize()
        public int descriptorSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = features2d_BOWImgDescriptorExtractor_descriptorSize_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int descriptorType()
        //

        //javadoc: BOWImgDescriptorExtractor::descriptorType()
        public int descriptorType ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = features2d_BOWImgDescriptorExtractor_descriptorType_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void compute2(Mat image, vector_KeyPoint keypoints, Mat& imgDescriptor)
        //

        //javadoc: BOWImgDescriptorExtractor::compute2(image, keypoints, imgDescriptor)
        public void compute (Mat image, MatOfKeyPoint keypoints, Mat imgDescriptor)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (keypoints != null) keypoints.ThrowIfDisposed ();
            if (imgDescriptor != null) imgDescriptor.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat keypoints_mat = keypoints;
        features2d_BOWImgDescriptorExtractor_compute_10(nativeObj, image.nativeObj, keypoints_mat.nativeObj, imgDescriptor.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setVocabulary(Mat vocabulary)
        //

        //javadoc: BOWImgDescriptorExtractor::setVocabulary(vocabulary)
        public void setVocabulary (Mat vocabulary)
        {
            ThrowIfDisposed ();
            if (vocabulary != null) vocabulary.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        features2d_BOWImgDescriptorExtractor_setVocabulary_10(nativeObj, vocabulary.nativeObj);
        
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



        // C++:  Mat getVocabulary()
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BOWImgDescriptorExtractor_getVocabulary_10 (IntPtr nativeObj);

        // C++:  int descriptorSize()
        [DllImport (LIBNAME)]
        private static extern int features2d_BOWImgDescriptorExtractor_descriptorSize_10 (IntPtr nativeObj);

        // C++:  int descriptorType()
        [DllImport (LIBNAME)]
        private static extern int features2d_BOWImgDescriptorExtractor_descriptorType_10 (IntPtr nativeObj);

        // C++:  void compute2(Mat image, vector_KeyPoint keypoints, Mat& imgDescriptor)
        [DllImport (LIBNAME)]
        private static extern void features2d_BOWImgDescriptorExtractor_compute_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr imgDescriptor_nativeObj);

        // C++:  void setVocabulary(Mat vocabulary)
        [DllImport (LIBNAME)]
        private static extern void features2d_BOWImgDescriptorExtractor_setVocabulary_10 (IntPtr nativeObj, IntPtr vocabulary_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_BOWImgDescriptorExtractor_delete (IntPtr nativeObj);

    }
}
