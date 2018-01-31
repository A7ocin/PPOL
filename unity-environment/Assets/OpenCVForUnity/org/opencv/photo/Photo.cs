

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Photo
    //javadoc: Photo

    public class Photo
    {

        private const int CV_INPAINT_NS = 0;
        private const int CV_INPAINT_TELEA = 1;
        public const int INPAINT_NS = 0;
        public const int INPAINT_TELEA = 1;
        public const int NORMAL_CLONE = 1;
        public const int MIXED_CLONE = 2;
        public const int MONOCHROME_TRANSFER = 3;
        public const int RECURS_FILTER = 1;
        public const int NORMCONV_FILTER = 2;
        public const int LDR_SIZE = 256;
        //
        // C++:  Ptr_AlignMTB createAlignMTB(int max_bits = 6, int exclude_range = 4, bool cut = true)
        //

        //javadoc: createAlignMTB(max_bits, exclude_range, cut)
        public static AlignMTB createAlignMTB (int max_bits, int exclude_range, bool cut)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        AlignMTB retVal = new AlignMTB(photo_Photo_createAlignMTB_10(max_bits, exclude_range, cut));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createAlignMTB()
        public static AlignMTB createAlignMTB ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        AlignMTB retVal = new AlignMTB(photo_Photo_createAlignMTB_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_CalibrateDebevec createCalibrateDebevec(int samples = 70, float lambda = 10.0f, bool random = false)
        //

        //javadoc: createCalibrateDebevec(samples, lambda, random)
        public static CalibrateDebevec createCalibrateDebevec (int samples, float lambda, bool random)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        CalibrateDebevec retVal = new CalibrateDebevec(photo_Photo_createCalibrateDebevec_10(samples, lambda, random));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createCalibrateDebevec()
        public static CalibrateDebevec createCalibrateDebevec ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        CalibrateDebevec retVal = new CalibrateDebevec(photo_Photo_createCalibrateDebevec_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_CalibrateRobertson createCalibrateRobertson(int max_iter = 30, float threshold = 0.01f)
        //

        //javadoc: createCalibrateRobertson(max_iter, threshold)
        public static CalibrateRobertson createCalibrateRobertson (int max_iter, float threshold)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        CalibrateRobertson retVal = new CalibrateRobertson(photo_Photo_createCalibrateRobertson_10(max_iter, threshold));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createCalibrateRobertson()
        public static CalibrateRobertson createCalibrateRobertson ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        CalibrateRobertson retVal = new CalibrateRobertson(photo_Photo_createCalibrateRobertson_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_MergeDebevec createMergeDebevec()
        //

        //javadoc: createMergeDebevec()
        public static MergeDebevec createMergeDebevec ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MergeDebevec retVal = new MergeDebevec(photo_Photo_createMergeDebevec_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_MergeMertens createMergeMertens(float contrast_weight = 1.0f, float saturation_weight = 1.0f, float exposure_weight = 0.0f)
        //

        //javadoc: createMergeMertens(contrast_weight, saturation_weight, exposure_weight)
        public static MergeMertens createMergeMertens (float contrast_weight, float saturation_weight, float exposure_weight)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MergeMertens retVal = new MergeMertens(photo_Photo_createMergeMertens_10(contrast_weight, saturation_weight, exposure_weight));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createMergeMertens()
        public static MergeMertens createMergeMertens ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MergeMertens retVal = new MergeMertens(photo_Photo_createMergeMertens_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_MergeRobertson createMergeRobertson()
        //

        //javadoc: createMergeRobertson()
        public static MergeRobertson createMergeRobertson ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MergeRobertson retVal = new MergeRobertson(photo_Photo_createMergeRobertson_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_Tonemap createTonemap(float gamma = 1.0f)
        //

        //javadoc: createTonemap(gamma)
        public static Tonemap createTonemap (float gamma)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Tonemap retVal = new Tonemap(photo_Photo_createTonemap_10(gamma));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createTonemap()
        public static Tonemap createTonemap ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Tonemap retVal = new Tonemap(photo_Photo_createTonemap_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_TonemapDrago createTonemapDrago(float gamma = 1.0f, float saturation = 1.0f, float bias = 0.85f)
        //

        //javadoc: createTonemapDrago(gamma, saturation, bias)
        public static TonemapDrago createTonemapDrago (float gamma, float saturation, float bias)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        TonemapDrago retVal = new TonemapDrago(photo_Photo_createTonemapDrago_10(gamma, saturation, bias));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createTonemapDrago()
        public static TonemapDrago createTonemapDrago ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        TonemapDrago retVal = new TonemapDrago(photo_Photo_createTonemapDrago_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_TonemapDurand createTonemapDurand(float gamma = 1.0f, float contrast = 4.0f, float saturation = 1.0f, float sigma_space = 2.0f, float sigma_color = 2.0f)
        //

        //javadoc: createTonemapDurand(gamma, contrast, saturation, sigma_space, sigma_color)
        public static TonemapDurand createTonemapDurand (float gamma, float contrast, float saturation, float sigma_space, float sigma_color)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        TonemapDurand retVal = new TonemapDurand(photo_Photo_createTonemapDurand_10(gamma, contrast, saturation, sigma_space, sigma_color));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createTonemapDurand()
        public static TonemapDurand createTonemapDurand ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        TonemapDurand retVal = new TonemapDurand(photo_Photo_createTonemapDurand_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_TonemapMantiuk createTonemapMantiuk(float gamma = 1.0f, float scale = 0.7f, float saturation = 1.0f)
        //

        //javadoc: createTonemapMantiuk(gamma, scale, saturation)
        public static TonemapMantiuk createTonemapMantiuk (float gamma, float scale, float saturation)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        TonemapMantiuk retVal = new TonemapMantiuk(photo_Photo_createTonemapMantiuk_10(gamma, scale, saturation));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createTonemapMantiuk()
        public static TonemapMantiuk createTonemapMantiuk ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        TonemapMantiuk retVal = new TonemapMantiuk(photo_Photo_createTonemapMantiuk_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_TonemapReinhard createTonemapReinhard(float gamma = 1.0f, float intensity = 0.0f, float light_adapt = 1.0f, float color_adapt = 0.0f)
        //

        //javadoc: createTonemapReinhard(gamma, intensity, light_adapt, color_adapt)
        public static TonemapReinhard createTonemapReinhard (float gamma, float intensity, float light_adapt, float color_adapt)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        TonemapReinhard retVal = new TonemapReinhard(photo_Photo_createTonemapReinhard_10(gamma, intensity, light_adapt, color_adapt));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createTonemapReinhard()
        public static TonemapReinhard createTonemapReinhard ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        TonemapReinhard retVal = new TonemapReinhard(photo_Photo_createTonemapReinhard_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void colorChange(Mat src, Mat mask, Mat& dst, float red_mul = 1.0f, float green_mul = 1.0f, float blue_mul = 1.0f)
        //

        //javadoc: colorChange(src, mask, dst, red_mul, green_mul, blue_mul)
        public static void colorChange (Mat src, Mat mask, Mat dst, float red_mul, float green_mul, float blue_mul)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_colorChange_10(src.nativeObj, mask.nativeObj, dst.nativeObj, red_mul, green_mul, blue_mul);
        
#else
            return;
#endif
            return;
        }

        //javadoc: colorChange(src, mask, dst)
        public static void colorChange (Mat src, Mat mask, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_colorChange_11(src.nativeObj, mask.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void decolor(Mat src, Mat& grayscale, Mat& color_boost)
        //

        //javadoc: decolor(src, grayscale, color_boost)
        public static void decolor (Mat src, Mat grayscale, Mat color_boost)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (grayscale != null) grayscale.ThrowIfDisposed ();
            if (color_boost != null) color_boost.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_decolor_10(src.nativeObj, grayscale.nativeObj, color_boost.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void denoise_TVL1(vector_Mat observations, Mat result, double lambda = 1.0, int niters = 30)
        //

        //javadoc: denoise_TVL1(observations, result, lambda, niters)
        public static void denoise_TVL1 (List<Mat> observations, Mat result, double lambda, int niters)
        {
            if (result != null) result.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat observations_mat = Converters.vector_Mat_to_Mat(observations);
        photo_Photo_denoise_1TVL1_10(observations_mat.nativeObj, result.nativeObj, lambda, niters);
        
#else
            return;
#endif
            return;
        }

        //javadoc: denoise_TVL1(observations, result)
        public static void denoise_TVL1 (List<Mat> observations, Mat result)
        {
            if (result != null) result.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat observations_mat = Converters.vector_Mat_to_Mat(observations);
        photo_Photo_denoise_1TVL1_11(observations_mat.nativeObj, result.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void detailEnhance(Mat src, Mat& dst, float sigma_s = 10, float sigma_r = 0.15f)
        //

        //javadoc: detailEnhance(src, dst, sigma_s, sigma_r)
        public static void detailEnhance (Mat src, Mat dst, float sigma_s, float sigma_r)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_detailEnhance_10(src.nativeObj, dst.nativeObj, sigma_s, sigma_r);
        
#else
            return;
#endif
            return;
        }

        //javadoc: detailEnhance(src, dst)
        public static void detailEnhance (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_detailEnhance_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void edgePreservingFilter(Mat src, Mat& dst, int flags = 1, float sigma_s = 60, float sigma_r = 0.4f)
        //

        //javadoc: edgePreservingFilter(src, dst, flags, sigma_s, sigma_r)
        public static void edgePreservingFilter (Mat src, Mat dst, int flags, float sigma_s, float sigma_r)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_edgePreservingFilter_10(src.nativeObj, dst.nativeObj, flags, sigma_s, sigma_r);
        
#else
            return;
#endif
            return;
        }

        //javadoc: edgePreservingFilter(src, dst)
        public static void edgePreservingFilter (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_edgePreservingFilter_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void fastNlMeansDenoising(Mat src, Mat& dst, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        //javadoc: fastNlMeansDenoising(src, dst, h, templateWindowSize, searchWindowSize)
        public static void fastNlMeansDenoising (Mat src, Mat dst, float h, int templateWindowSize, int searchWindowSize)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_fastNlMeansDenoising_10(src.nativeObj, dst.nativeObj, h, templateWindowSize, searchWindowSize);
        
#else
            return;
#endif
            return;
        }

        //javadoc: fastNlMeansDenoising(src, dst)
        public static void fastNlMeansDenoising (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_fastNlMeansDenoising_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void fastNlMeansDenoising(Mat src, Mat& dst, vector_float h, int templateWindowSize = 7, int searchWindowSize = 21, int normType = NORM_L2)
        //

        //javadoc: fastNlMeansDenoising(src, dst, h, templateWindowSize, searchWindowSize, normType)
        public static void fastNlMeansDenoising (Mat src, Mat dst, MatOfFloat h, int templateWindowSize, int searchWindowSize, int normType)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (h != null) h.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat h_mat = h;
        photo_Photo_fastNlMeansDenoising_12(src.nativeObj, dst.nativeObj, h_mat.nativeObj, templateWindowSize, searchWindowSize, normType);
        
#else
            return;
#endif
            return;
        }

        //javadoc: fastNlMeansDenoising(src, dst, h)
        public static void fastNlMeansDenoising (Mat src, Mat dst, MatOfFloat h)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (h != null) h.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat h_mat = h;
        photo_Photo_fastNlMeansDenoising_13(src.nativeObj, dst.nativeObj, h_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void fastNlMeansDenoisingColored(Mat src, Mat& dst, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        //javadoc: fastNlMeansDenoisingColored(src, dst, h, hColor, templateWindowSize, searchWindowSize)
        public static void fastNlMeansDenoisingColored (Mat src, Mat dst, float h, float hColor, int templateWindowSize, int searchWindowSize)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_fastNlMeansDenoisingColored_10(src.nativeObj, dst.nativeObj, h, hColor, templateWindowSize, searchWindowSize);
        
#else
            return;
#endif
            return;
        }

        //javadoc: fastNlMeansDenoisingColored(src, dst)
        public static void fastNlMeansDenoisingColored (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_fastNlMeansDenoisingColored_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void fastNlMeansDenoisingColoredMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        //javadoc: fastNlMeansDenoisingColoredMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h, hColor, templateWindowSize, searchWindowSize)
        public static void fastNlMeansDenoisingColoredMulti (List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize, int searchWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        photo_Photo_fastNlMeansDenoisingColoredMulti_10(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, hColor, templateWindowSize, searchWindowSize);
        
#else
            return;
#endif
            return;
        }

        //javadoc: fastNlMeansDenoisingColoredMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize)
        public static void fastNlMeansDenoisingColoredMulti (List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        photo_Photo_fastNlMeansDenoisingColoredMulti_11(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        //

        //javadoc: fastNlMeansDenoisingMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h, templateWindowSize, searchWindowSize)
        public static void fastNlMeansDenoisingMulti (List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize, int searchWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        photo_Photo_fastNlMeansDenoisingMulti_10(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h, templateWindowSize, searchWindowSize);
        
#else
            return;
#endif
            return;
        }

        //javadoc: fastNlMeansDenoisingMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize)
        public static void fastNlMeansDenoisingMulti (List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize)
        {
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        photo_Photo_fastNlMeansDenoisingMulti_11(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, vector_float h, int templateWindowSize = 7, int searchWindowSize = 21, int normType = NORM_L2)
        //

        //javadoc: fastNlMeansDenoisingMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h, templateWindowSize, searchWindowSize, normType)
        public static void fastNlMeansDenoisingMulti (List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, MatOfFloat h, int templateWindowSize, int searchWindowSize, int normType)
        {
            if (dst != null) dst.ThrowIfDisposed ();
            if (h != null) h.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        Mat h_mat = h;
        photo_Photo_fastNlMeansDenoisingMulti_12(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h_mat.nativeObj, templateWindowSize, searchWindowSize, normType);
        
#else
            return;
#endif
            return;
        }

        //javadoc: fastNlMeansDenoisingMulti(srcImgs, dst, imgToDenoiseIndex, temporalWindowSize, h)
        public static void fastNlMeansDenoisingMulti (List<Mat> srcImgs, Mat dst, int imgToDenoiseIndex, int temporalWindowSize, MatOfFloat h)
        {
            if (dst != null) dst.ThrowIfDisposed ();
            if (h != null) h.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat srcImgs_mat = Converters.vector_Mat_to_Mat(srcImgs);
        Mat h_mat = h;
        photo_Photo_fastNlMeansDenoisingMulti_13(srcImgs_mat.nativeObj, dst.nativeObj, imgToDenoiseIndex, temporalWindowSize, h_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void illuminationChange(Mat src, Mat mask, Mat& dst, float alpha = 0.2f, float beta = 0.4f)
        //

        //javadoc: illuminationChange(src, mask, dst, alpha, beta)
        public static void illuminationChange (Mat src, Mat mask, Mat dst, float alpha, float beta)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_illuminationChange_10(src.nativeObj, mask.nativeObj, dst.nativeObj, alpha, beta);
        
#else
            return;
#endif
            return;
        }

        //javadoc: illuminationChange(src, mask, dst)
        public static void illuminationChange (Mat src, Mat mask, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_illuminationChange_11(src.nativeObj, mask.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void inpaint(Mat src, Mat inpaintMask, Mat& dst, double inpaintRadius, int flags)
        //

        //javadoc: inpaint(src, inpaintMask, dst, inpaintRadius, flags)
        public static void inpaint (Mat src, Mat inpaintMask, Mat dst, double inpaintRadius, int flags)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (inpaintMask != null) inpaintMask.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_inpaint_10(src.nativeObj, inpaintMask.nativeObj, dst.nativeObj, inpaintRadius, flags);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void pencilSketch(Mat src, Mat& dst1, Mat& dst2, float sigma_s = 60, float sigma_r = 0.07f, float shade_factor = 0.02f)
        //

        //javadoc: pencilSketch(src, dst1, dst2, sigma_s, sigma_r, shade_factor)
        public static void pencilSketch (Mat src, Mat dst1, Mat dst2, float sigma_s, float sigma_r, float shade_factor)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst1 != null) dst1.ThrowIfDisposed ();
            if (dst2 != null) dst2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_pencilSketch_10(src.nativeObj, dst1.nativeObj, dst2.nativeObj, sigma_s, sigma_r, shade_factor);
        
#else
            return;
#endif
            return;
        }

        //javadoc: pencilSketch(src, dst1, dst2)
        public static void pencilSketch (Mat src, Mat dst1, Mat dst2)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst1 != null) dst1.ThrowIfDisposed ();
            if (dst2 != null) dst2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_pencilSketch_11(src.nativeObj, dst1.nativeObj, dst2.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void seamlessClone(Mat src, Mat dst, Mat mask, Point p, Mat& blend, int flags)
        //

        //javadoc: seamlessClone(src, dst, mask, p, blend, flags)
        public static void seamlessClone (Mat src, Mat dst, Mat mask, Point p, Mat blend, int flags)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
            if (blend != null) blend.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_seamlessClone_10(src.nativeObj, dst.nativeObj, mask.nativeObj, p.x, p.y, blend.nativeObj, flags);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void stylization(Mat src, Mat& dst, float sigma_s = 60, float sigma_r = 0.45f)
        //

        //javadoc: stylization(src, dst, sigma_s, sigma_r)
        public static void stylization (Mat src, Mat dst, float sigma_s, float sigma_r)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_stylization_10(src.nativeObj, dst.nativeObj, sigma_s, sigma_r);
        
#else
            return;
#endif
            return;
        }

        //javadoc: stylization(src, dst)
        public static void stylization (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_stylization_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void textureFlattening(Mat src, Mat mask, Mat& dst, float low_threshold = 30, float high_threshold = 45, int kernel_size = 3)
        //

        //javadoc: textureFlattening(src, mask, dst, low_threshold, high_threshold, kernel_size)
        public static void textureFlattening (Mat src, Mat mask, Mat dst, float low_threshold, float high_threshold, int kernel_size)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_textureFlattening_10(src.nativeObj, mask.nativeObj, dst.nativeObj, low_threshold, high_threshold, kernel_size);
        
#else
            return;
#endif
            return;
        }

        //javadoc: textureFlattening(src, mask, dst)
        public static void textureFlattening (Mat src, Mat mask, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        photo_Photo_textureFlattening_11(src.nativeObj, mask.nativeObj, dst.nativeObj);
        
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



        // C++:  Ptr_AlignMTB createAlignMTB(int max_bits = 6, int exclude_range = 4, bool cut = true)
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createAlignMTB_10 (int max_bits, int exclude_range, bool cut);
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createAlignMTB_11 ();

        // C++:  Ptr_CalibrateDebevec createCalibrateDebevec(int samples = 70, float lambda = 10.0f, bool random = false)
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateDebevec_10 (int samples, float lambda, bool random);
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateDebevec_11 ();

        // C++:  Ptr_CalibrateRobertson createCalibrateRobertson(int max_iter = 30, float threshold = 0.01f)
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateRobertson_10 (int max_iter, float threshold);
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createCalibrateRobertson_11 ();

        // C++:  Ptr_MergeDebevec createMergeDebevec()
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeDebevec_10 ();

        // C++:  Ptr_MergeMertens createMergeMertens(float contrast_weight = 1.0f, float saturation_weight = 1.0f, float exposure_weight = 0.0f)
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeMertens_10 (float contrast_weight, float saturation_weight, float exposure_weight);
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeMertens_11 ();

        // C++:  Ptr_MergeRobertson createMergeRobertson()
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createMergeRobertson_10 ();

        // C++:  Ptr_Tonemap createTonemap(float gamma = 1.0f)
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemap_10 (float gamma);
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemap_11 ();

        // C++:  Ptr_TonemapDrago createTonemapDrago(float gamma = 1.0f, float saturation = 1.0f, float bias = 0.85f)
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapDrago_10 (float gamma, float saturation, float bias);
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapDrago_11 ();

        // C++:  Ptr_TonemapDurand createTonemapDurand(float gamma = 1.0f, float contrast = 4.0f, float saturation = 1.0f, float sigma_space = 2.0f, float sigma_color = 2.0f)
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapDurand_10 (float gamma, float contrast, float saturation, float sigma_space, float sigma_color);
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapDurand_11 ();

        // C++:  Ptr_TonemapMantiuk createTonemapMantiuk(float gamma = 1.0f, float scale = 0.7f, float saturation = 1.0f)
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapMantiuk_10 (float gamma, float scale, float saturation);
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapMantiuk_11 ();

        // C++:  Ptr_TonemapReinhard createTonemapReinhard(float gamma = 1.0f, float intensity = 0.0f, float light_adapt = 1.0f, float color_adapt = 0.0f)
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapReinhard_10 (float gamma, float intensity, float light_adapt, float color_adapt);
        [DllImport (LIBNAME)]
        private static extern IntPtr photo_Photo_createTonemapReinhard_11 ();

        // C++:  void colorChange(Mat src, Mat mask, Mat& dst, float red_mul = 1.0f, float green_mul = 1.0f, float blue_mul = 1.0f)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_colorChange_10 (IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float red_mul, float green_mul, float blue_mul);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_colorChange_11 (IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj);

        // C++:  void decolor(Mat src, Mat& grayscale, Mat& color_boost)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_decolor_10 (IntPtr src_nativeObj, IntPtr grayscale_nativeObj, IntPtr color_boost_nativeObj);

        // C++:  void denoise_TVL1(vector_Mat observations, Mat result, double lambda = 1.0, int niters = 30)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_denoise_1TVL1_10 (IntPtr observations_mat_nativeObj, IntPtr result_nativeObj, double lambda, int niters);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_denoise_1TVL1_11 (IntPtr observations_mat_nativeObj, IntPtr result_nativeObj);

        // C++:  void detailEnhance(Mat src, Mat& dst, float sigma_s = 10, float sigma_r = 0.15f)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_detailEnhance_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, float sigma_s, float sigma_r);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_detailEnhance_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void edgePreservingFilter(Mat src, Mat& dst, int flags = 1, float sigma_s = 60, float sigma_r = 0.4f)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_edgePreservingFilter_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags, float sigma_s, float sigma_r);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_edgePreservingFilter_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void fastNlMeansDenoising(Mat src, Mat& dst, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, int templateWindowSize, int searchWindowSize);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void fastNlMeansDenoising(Mat src, Mat& dst, vector_float h, int templateWindowSize = 7, int searchWindowSize = 21, int normType = NORM_L2)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr h_mat_nativeObj, int templateWindowSize, int searchWindowSize, int normType);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoising_13 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr h_mat_nativeObj);

        // C++:  void fastNlMeansDenoisingColored(Mat src, Mat& dst, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColored_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, float h, float hColor, int templateWindowSize, int searchWindowSize);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColored_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void fastNlMeansDenoisingColoredMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, float hColor = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColoredMulti_10 (IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, float hColor, int templateWindowSize, int searchWindowSize);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingColoredMulti_11 (IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize);

        // C++:  void fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, float h = 3, int templateWindowSize = 7, int searchWindowSize = 21)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_10 (IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, float h, int templateWindowSize, int searchWindowSize);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_11 (IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize);

        // C++:  void fastNlMeansDenoisingMulti(vector_Mat srcImgs, Mat& dst, int imgToDenoiseIndex, int temporalWindowSize, vector_float h, int templateWindowSize = 7, int searchWindowSize = 21, int normType = NORM_L2)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_12 (IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, IntPtr h_mat_nativeObj, int templateWindowSize, int searchWindowSize, int normType);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_fastNlMeansDenoisingMulti_13 (IntPtr srcImgs_mat_nativeObj, IntPtr dst_nativeObj, int imgToDenoiseIndex, int temporalWindowSize, IntPtr h_mat_nativeObj);

        // C++:  void illuminationChange(Mat src, Mat mask, Mat& dst, float alpha = 0.2f, float beta = 0.4f)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_illuminationChange_10 (IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float alpha, float beta);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_illuminationChange_11 (IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj);

        // C++:  void inpaint(Mat src, Mat inpaintMask, Mat& dst, double inpaintRadius, int flags)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_inpaint_10 (IntPtr src_nativeObj, IntPtr inpaintMask_nativeObj, IntPtr dst_nativeObj, double inpaintRadius, int flags);

        // C++:  void pencilSketch(Mat src, Mat& dst1, Mat& dst2, float sigma_s = 60, float sigma_r = 0.07f, float shade_factor = 0.02f)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_pencilSketch_10 (IntPtr src_nativeObj, IntPtr dst1_nativeObj, IntPtr dst2_nativeObj, float sigma_s, float sigma_r, float shade_factor);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_pencilSketch_11 (IntPtr src_nativeObj, IntPtr dst1_nativeObj, IntPtr dst2_nativeObj);

        // C++:  void seamlessClone(Mat src, Mat dst, Mat mask, Point p, Mat& blend, int flags)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_seamlessClone_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj, double p_x, double p_y, IntPtr blend_nativeObj, int flags);

        // C++:  void stylization(Mat src, Mat& dst, float sigma_s = 60, float sigma_r = 0.45f)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_stylization_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, float sigma_s, float sigma_r);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_stylization_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void textureFlattening(Mat src, Mat mask, Mat& dst, float low_threshold = 30, float high_threshold = 45, int kernel_size = 3)
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_textureFlattening_10 (IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj, float low_threshold, float high_threshold, int kernel_size);
        [DllImport (LIBNAME)]
        private static extern void photo_Photo_textureFlattening_11 (IntPtr src_nativeObj, IntPtr mask_nativeObj, IntPtr dst_nativeObj);

    }
}
