

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class javaFeatureDetector
    //javadoc: javaFeatureDetector
    //[Obsolete ("This method is deprecated.")]
    public class FeatureDetector : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        features2d_FeatureDetector_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal FeatureDetector (IntPtr addr)
            : base (addr)
        {
        }


        public IntPtr getNativeObjAddr ()
        {
            return nativeObj;
        }

        private const int GRIDDETECTOR = 1000;
        private const int PYRAMIDDETECTOR = 2000;
        private const int DYNAMICDETECTOR = 3000;
        public const int FAST = 1;
        //        public const int STAR = 2;
        //        public const int SIFT = 3;
        //        public const int SURF = 4;
        public const int ORB = 5;
        public const int MSER = 6;
        public const int GFTT = 7;
        public const int HARRIS = 8;
        public const int SIMPLEBLOB = 9;
        //        public const int DENSE = 10;
        public const int BRISK = 11;
        public const int AKAZE = 12;
        public const int GRID_FAST = GRIDDETECTOR + FAST;
        //        public const int GRID_STAR = GRIDDETECTOR + STAR;
        //        public const int GRID_SIFT = GRIDDETECTOR + SIFT;
        //        public const int GRID_SURF = GRIDDETECTOR + SURF;
        public const int GRID_ORB = GRIDDETECTOR + ORB;
        public const int GRID_MSER = GRIDDETECTOR + MSER;
        public const int GRID_GFTT = GRIDDETECTOR + GFTT;
        public const int GRID_HARRIS = GRIDDETECTOR + HARRIS;
        public const int GRID_SIMPLEBLOB = GRIDDETECTOR + SIMPLEBLOB;
        //        public const int GRID_DENSE = GRIDDETECTOR + DENSE;
        public const int GRID_BRISK = GRIDDETECTOR + BRISK;
        public const int GRID_AKAZE = GRIDDETECTOR + AKAZE;
        public const int PYRAMID_FAST = PYRAMIDDETECTOR + FAST;
        //        public const int PYRAMID_STAR = PYRAMIDDETECTOR + STAR;
        //        public const int PYRAMID_SIFT = PYRAMIDDETECTOR + SIFT;
        //        public const int PYRAMID_SURF = PYRAMIDDETECTOR + SURF;
        public const int PYRAMID_ORB = PYRAMIDDETECTOR + ORB;
        public const int PYRAMID_MSER = PYRAMIDDETECTOR + MSER;
        public const int PYRAMID_GFTT = PYRAMIDDETECTOR + GFTT;
        public const int PYRAMID_HARRIS = PYRAMIDDETECTOR + HARRIS;
        public const int PYRAMID_SIMPLEBLOB = PYRAMIDDETECTOR + SIMPLEBLOB;
        //        public const int PYRAMID_DENSE = PYRAMIDDETECTOR + DENSE;
        public const int PYRAMID_BRISK = PYRAMIDDETECTOR + BRISK;
        public const int PYRAMID_AKAZE = PYRAMIDDETECTOR + AKAZE;
        public const int DYNAMIC_FAST = DYNAMICDETECTOR + FAST;
        //        public const int DYNAMIC_STAR = DYNAMICDETECTOR + STAR;
        //        public const int DYNAMIC_SIFT = DYNAMICDETECTOR + SIFT;
        //        public const int DYNAMIC_SURF = DYNAMICDETECTOR + SURF;
        public const int DYNAMIC_ORB = DYNAMICDETECTOR + ORB;
        public const int DYNAMIC_MSER = DYNAMICDETECTOR + MSER;
        public const int DYNAMIC_GFTT = DYNAMICDETECTOR + GFTT;
        public const int DYNAMIC_HARRIS = DYNAMICDETECTOR + HARRIS;
        public const int DYNAMIC_SIMPLEBLOB = DYNAMICDETECTOR + SIMPLEBLOB;
        //        public const int DYNAMIC_DENSE = DYNAMICDETECTOR + DENSE;
        public const int DYNAMIC_BRISK = DYNAMICDETECTOR + BRISK;
        public const int DYNAMIC_AKAZE = DYNAMICDETECTOR + AKAZE;
        //
        // C++: static Ptr_javaFeatureDetector create(int detectorType)
        //

        //javadoc: javaFeatureDetector::create(detectorType)
        //[System.Obsolete ("This method is deprecated.")]
        public static FeatureDetector create (int detectorType)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            FeatureDetector retVal = new FeatureDetector (features2d_FeatureDetector_create_10 (detectorType));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool empty()
        //

        //javadoc: javaFeatureDetector::empty()
        public bool empty ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = features2d_FeatureDetector_empty_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  void detect(Mat image, vector_KeyPoint& keypoints, Mat mask = Mat())
        //

        //javadoc: javaFeatureDetector::detect(image, keypoints, mask)
        public void detect (Mat image, MatOfKeyPoint keypoints, Mat mask)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (keypoints != null)
                keypoints.ThrowIfDisposed ();
            if (mask != null)
                mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat keypoints_mat = keypoints;
            features2d_FeatureDetector_detect_10 (nativeObj, image.nativeObj, keypoints_mat.nativeObj, mask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: javaFeatureDetector::detect(image, keypoints)
        public void detect (Mat image, MatOfKeyPoint keypoints)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (keypoints != null)
                keypoints.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat keypoints_mat = keypoints;
            features2d_FeatureDetector_detect_11 (nativeObj, image.nativeObj, keypoints_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void detect(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat masks = std::vector<Mat>())
        //

        //javadoc: javaFeatureDetector::detect(images, keypoints, masks)
        public void detect (List<Mat> images, List<MatOfKeyPoint> keypoints, List<Mat> masks)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat images_mat = Converters.vector_Mat_to_Mat (images);
            Mat keypoints_mat = new Mat ();
            Mat masks_mat = Converters.vector_Mat_to_Mat (masks);
            features2d_FeatureDetector_detect_12 (nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj, masks_mat.nativeObj);
            Converters.Mat_to_vector_vector_KeyPoint (keypoints_mat, keypoints);
            keypoints_mat.release ();
#else
            return;
#endif
            return;
        }

        //javadoc: javaFeatureDetector::detect(images, keypoints)
        public void detect (List<Mat> images, List<MatOfKeyPoint> keypoints)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat images_mat = Converters.vector_Mat_to_Mat (images);
            Mat keypoints_mat = new Mat ();
            features2d_FeatureDetector_detect_13 (nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj);
            Converters.Mat_to_vector_vector_KeyPoint (keypoints_mat, keypoints);
            keypoints_mat.release ();
#else
            return;
#endif
            return;
        }


        //
        // C++:  void read(String fileName)
        //

        //javadoc: javaFeatureDetector::read(fileName)
        public void read (string fileName)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_FeatureDetector_read_10 (nativeObj, fileName);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void write(String fileName)
        //

        //javadoc: javaFeatureDetector::write(fileName)
        public void write (string fileName)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_FeatureDetector_write_10 (nativeObj, fileName);
        
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



        // C++: static Ptr_javaFeatureDetector create(int detectorType)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_FeatureDetector_create_10 (int detectorType);

        // C++:  bool empty()
        [DllImport (LIBNAME)]
        private static extern bool features2d_FeatureDetector_empty_10 (IntPtr nativeObj);

        // C++:  void detect(Mat image, vector_KeyPoint& keypoints, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern void features2d_FeatureDetector_detect_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr mask_nativeObj);

        [DllImport (LIBNAME)]
        private static extern void features2d_FeatureDetector_detect_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj);

        // C++:  void detect(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat masks = std::vector<Mat>())
        [DllImport (LIBNAME)]
        private static extern void features2d_FeatureDetector_detect_12 (IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr masks_mat_nativeObj);

        [DllImport (LIBNAME)]
        private static extern void features2d_FeatureDetector_detect_13 (IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj);

        // C++:  void read(String fileName)
        [DllImport (LIBNAME)]
        private static extern void features2d_FeatureDetector_read_10 (IntPtr nativeObj, string fileName);

        // C++:  void write(String fileName)
        [DllImport (LIBNAME)]
        private static extern void features2d_FeatureDetector_write_10 (IntPtr nativeObj, string fileName);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_FeatureDetector_delete (IntPtr nativeObj);

    }
}
