

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Xphoto
    //javadoc: Xphoto

    public class Xphoto
    {

        public const int HAAR = 0;
        public const int BM3D_STEPALL = 0;
        public const int BM3D_STEP1 = 1;
        public const int BM3D_STEP2 = 2;
        public const int INPAINT_SHIFTMAP = 0;
        //
        // C++:  Ptr_GrayworldWB createGrayworldWB()
        //

        //javadoc: createGrayworldWB()
        public static GrayworldWB createGrayworldWB ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        GrayworldWB retVal = new GrayworldWB(xphoto_Xphoto_createGrayworldWB_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_LearningBasedWB createLearningBasedWB(String path_to_model = String())
        //

        //javadoc: createLearningBasedWB(path_to_model)
        public static LearningBasedWB createLearningBasedWB (string path_to_model)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        LearningBasedWB retVal = new LearningBasedWB(xphoto_Xphoto_createLearningBasedWB_10(path_to_model));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createLearningBasedWB()
        public static LearningBasedWB createLearningBasedWB ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        LearningBasedWB retVal = new LearningBasedWB(xphoto_Xphoto_createLearningBasedWB_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SimpleWB createSimpleWB()
        //

        //javadoc: createSimpleWB()
        public static SimpleWB createSimpleWB ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SimpleWB retVal = new SimpleWB(xphoto_Xphoto_createSimpleWB_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void applyChannelGains(Mat src, Mat& dst, float gainB, float gainG, float gainR)
        //

        //javadoc: applyChannelGains(src, dst, gainB, gainG, gainR)
        public static void applyChannelGains (Mat src, Mat dst, float gainB, float gainG, float gainR)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_applyChannelGains_10(src.nativeObj, dst.nativeObj, gainB, gainG, gainR);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void bm3dDenoising(Mat src, Mat& dst, float h = 1, int templateWindowSize = 4, int searchWindowSize = 16, int blockMatchingStep1 = 2500, int blockMatchingStep2 = 400, int groupSize = 8, int slidingStep = 1, float beta = 2.0f, int normType = cv::NORM_L2, int step = cv::xphoto::BM3D_STEPALL, int transformType = cv::xphoto::HAAR)
        //

        //javadoc: bm3dDenoising(src, dst, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType, step, transformType)
        public static void bm3dDenoising (Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType, int step, int transformType)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_10(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType, step, transformType);
        
#else
            return;
#endif
            return;
        }

        //javadoc: bm3dDenoising(src, dst)
        public static void bm3dDenoising (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void bm3dDenoising(Mat src, Mat& dstStep1, Mat& dstStep2, float h = 1, int templateWindowSize = 4, int searchWindowSize = 16, int blockMatchingStep1 = 2500, int blockMatchingStep2 = 400, int groupSize = 8, int slidingStep = 1, float beta = 2.0f, int normType = cv::NORM_L2, int step = cv::xphoto::BM3D_STEPALL, int transformType = cv::xphoto::HAAR)
        //

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType, step, transformType)
        public static void bm3dDenoising (Mat src, Mat dstStep1, Mat dstStep2, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType, int step, int transformType)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed ();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_12(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj, h, templateWindowSize, searchWindowSize, blockMatchingStep1, blockMatchingStep2, groupSize, slidingStep, beta, normType, step, transformType);
        
#else
            return;
#endif
            return;
        }

        //javadoc: bm3dDenoising(src, dstStep1, dstStep2)
        public static void bm3dDenoising (Mat src, Mat dstStep1, Mat dstStep2)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dstStep1 != null) dstStep1.ThrowIfDisposed ();
            if (dstStep2 != null) dstStep2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_bm3dDenoising_13(src.nativeObj, dstStep1.nativeObj, dstStep2.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void dctDenoising(Mat src, Mat dst, double sigma, int psize = 16)
        //

        //javadoc: dctDenoising(src, dst, sigma, psize)
        public static void dctDenoising (Mat src, Mat dst, double sigma, int psize)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_dctDenoising_10(src.nativeObj, dst.nativeObj, sigma, psize);
        
#else
            return;
#endif
            return;
        }

        //javadoc: dctDenoising(src, dst, sigma)
        public static void dctDenoising (Mat src, Mat dst, double sigma)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_dctDenoising_11(src.nativeObj, dst.nativeObj, sigma);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void inpaint(Mat src, Mat mask, Mat dst, int algorithmType)
        //

        //javadoc: inpaint(src, mask, dst, algorithmType)
        public static void inpaint (Mat src, Mat mask, Mat dst, int algorithmType)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_Xphoto_inpaint_10(src.nativeObj, mask.nativeObj, dst.nativeObj, algorithmType);
        
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



        // C++:  Ptr_GrayworldWB createGrayworldWB()
        [DllImport (LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createGrayworldWB_10 ();

        // C++:  Ptr_LearningBasedWB createLearningBasedWB(String path_to_model = String())
        [DllImport (LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createLearningBasedWB_10 (string path_to_model);
        [DllImport (LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createLearningBasedWB_11 ();

        // C++:  Ptr_SimpleWB createSimpleWB()
        [DllImport (LIBNAME)]
        private static extern IntPtr xphoto_Xphoto_createSimpleWB_10 ();

        // C++:  void applyChannelGains(Mat src, Mat& dst, float gainB, float gainG, float gainR)
        [DllImport (LIBNAME)]
        private static extern void xphoto_Xphoto_applyChannelGains_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, float gainB, float gainG, float gainR);

        // C++:  void bm3dDenoising(Mat src, Mat& dst, float h = 1, int templateWindowSize = 4, int searchWindowSize = 16, int blockMatchingStep1 = 2500, int blockMatchingStep2 = 400, int groupSize = 8, int slidingStep = 1, float beta = 2.0f, int normType = cv::NORM_L2, int step = cv::xphoto::BM3D_STEPALL, int transformType = cv::xphoto::HAAR)
        [DllImport (LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType, int step, int transformType);
        [DllImport (LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void bm3dDenoising(Mat src, Mat& dstStep1, Mat& dstStep2, float h = 1, int templateWindowSize = 4, int searchWindowSize = 16, int blockMatchingStep1 = 2500, int blockMatchingStep2 = 400, int groupSize = 8, int slidingStep = 1, float beta = 2.0f, int normType = cv::NORM_L2, int step = cv::xphoto::BM3D_STEPALL, int transformType = cv::xphoto::HAAR)
        [DllImport (LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_12 (IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj, float h, int templateWindowSize, int searchWindowSize, int blockMatchingStep1, int blockMatchingStep2, int groupSize, int slidingStep, float beta, int normType, int step, int transformType);
        [DllImport (LIBNAME)]
        private static extern void xphoto_Xphoto_bm3dDenoising_13 (IntPtr src_nativeObj, IntPtr dstStep1_nativeObj, IntPtr dstStep2_nativeObj);

        // C++:  void dctDenoising(Mat src, Mat dst, double sigma, int psize = 16)
        [DllImport (LIBNAME)]
        private static extern void xphoto_Xphoto_dctDenoising_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma, int psize);
        [DllImport (LIBNAME)]
        private static extern void xphoto_Xphoto_dctDenoising_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma);

        // C++:  void inpaint(Mat src, Mat mask, Mat dst, int algorithmType)
        [DllImport (LIBNAME)]
        private static extern void xphoto_Xphoto_inpaint_10 (IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, int algorithmType);

    }
}
