

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class javaDescriptorExtractor
    //javadoc: javaDescriptorExtractor
    [Obsolete ("This method is deprecated.")]
    public class DescriptorExtractor : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        features2d_DescriptorExtractor_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal DescriptorExtractor (IntPtr addr)
            : base (addr)
        {
        }


        public IntPtr getNativeObjAddr ()
        {
            return nativeObj;
        }

        private const int OPPONENTEXTRACTOR = 1000;
        public const int SIFT = 1;
        public const int SURF = 2;
        public const int ORB = 3;
        public const int BRIEF = 4;
        public const int BRISK = 5;
        public const int FREAK = 6;
        public const int AKAZE = 7;
        public const int OPPONENT_SIFT = OPPONENTEXTRACTOR + SIFT;
        public const int OPPONENT_SURF = OPPONENTEXTRACTOR + SURF;
        public const int OPPONENT_ORB = OPPONENTEXTRACTOR + ORB;
        public const int OPPONENT_BRIEF = OPPONENTEXTRACTOR + BRIEF;
        public const int OPPONENT_BRISK = OPPONENTEXTRACTOR + BRISK;
        public const int OPPONENT_FREAK = OPPONENTEXTRACTOR + FREAK;
        public const int OPPONENT_AKAZE = OPPONENTEXTRACTOR + AKAZE;
        //
        // C++: static Ptr_javaDescriptorExtractor create(int extractorType)
        //

        //javadoc: javaDescriptorExtractor::create(extractorType)
        public static DescriptorExtractor create (int extractorType)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            DescriptorExtractor retVal = new DescriptorExtractor (features2d_DescriptorExtractor_create_10 (extractorType));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool empty()
        //

        //javadoc: javaDescriptorExtractor::empty()
        public bool empty ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = features2d_DescriptorExtractor_empty_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  int descriptorSize()
        //

        //javadoc: javaDescriptorExtractor::descriptorSize()
        public int descriptorSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_DescriptorExtractor_descriptorSize_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int descriptorType()
        //

        //javadoc: javaDescriptorExtractor::descriptorType()
        public int descriptorType ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_DescriptorExtractor_descriptorType_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void compute(Mat image, vector_KeyPoint& keypoints, Mat descriptors)
        //

        //javadoc: javaDescriptorExtractor::compute(image, keypoints, descriptors)
        public void compute (Mat image, MatOfKeyPoint keypoints, Mat descriptors)
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
            features2d_DescriptorExtractor_compute_10 (nativeObj, image.nativeObj, keypoints_mat.nativeObj, descriptors.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void compute(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat& descriptors)
        //

        //javadoc: javaDescriptorExtractor::compute(images, keypoints, descriptors)
        public void compute (List<Mat> images, List<MatOfKeyPoint> keypoints, List<Mat> descriptors)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat images_mat = Converters.vector_Mat_to_Mat (images);
            List<Mat> keypoints_tmplm = new List<Mat> ((keypoints != null) ? keypoints.Count : 0);
            Mat keypoints_mat = Converters.vector_vector_KeyPoint_to_Mat (keypoints, keypoints_tmplm);
            Mat descriptors_mat = new Mat ();
            features2d_DescriptorExtractor_compute_11 (nativeObj, images_mat.nativeObj, keypoints_mat.nativeObj, descriptors_mat.nativeObj);
            Converters.Mat_to_vector_vector_KeyPoint (keypoints_mat, keypoints);
            keypoints_mat.release ();
            Converters.Mat_to_vector_Mat (descriptors_mat, descriptors);
            descriptors_mat.release ();
#else
            return;
#endif
            return;
        }


        //
        // C++:  void read(String fileName)
        //

        //javadoc: javaDescriptorExtractor::read(fileName)
        public void read (string fileName)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_DescriptorExtractor_read_10 (nativeObj, fileName);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void write(String fileName)
        //

        //javadoc: javaDescriptorExtractor::write(fileName)
        public void write (string fileName)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_DescriptorExtractor_write_10 (nativeObj, fileName);
        
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



        // C++: static Ptr_javaDescriptorExtractor create(int extractorType)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_DescriptorExtractor_create_10 (int extractorType);

        // C++:  bool empty()
        [DllImport (LIBNAME)]
        private static extern bool features2d_DescriptorExtractor_empty_10 (IntPtr nativeObj);

        // C++:  int descriptorSize()
        [DllImport (LIBNAME)]
        private static extern int features2d_DescriptorExtractor_descriptorSize_10 (IntPtr nativeObj);

        // C++:  int descriptorType()
        [DllImport (LIBNAME)]
        private static extern int features2d_DescriptorExtractor_descriptorType_10 (IntPtr nativeObj);

        // C++:  void compute(Mat image, vector_KeyPoint& keypoints, Mat descriptors)
        [DllImport (LIBNAME)]
        private static extern void features2d_DescriptorExtractor_compute_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_nativeObj);

        // C++:  void compute(vector_Mat images, vector_vector_KeyPoint& keypoints, vector_Mat& descriptors)
        [DllImport (LIBNAME)]
        private static extern void features2d_DescriptorExtractor_compute_11 (IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr keypoints_mat_nativeObj, IntPtr descriptors_mat_nativeObj);

        // C++:  void read(String fileName)
        [DllImport (LIBNAME)]
        private static extern void features2d_DescriptorExtractor_read_10 (IntPtr nativeObj, string fileName);

        // C++:  void write(String fileName)
        [DllImport (LIBNAME)]
        private static extern void features2d_DescriptorExtractor_write_10 (IntPtr nativeObj, string fileName);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_DescriptorExtractor_delete (IntPtr nativeObj);

    }
}
