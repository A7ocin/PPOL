

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Ximgproc
    //javadoc: Ximgproc

    public class Ximgproc
    {

        public const int THINNING_ZHANGSUEN = 0;
        public const int THINNING_GUOHALL = 1;
        public const int BINARIZATION_NIBLACK = 0;
        public const int BINARIZATION_SAUVOLA = 1;
        public const int BINARIZATION_WOLF = 2;
        public const int BINARIZATION_NICK = 3;
        public const int DTF_NC = 0;
        public const int DTF_IC = 1;
        public const int DTF_RF = 2;
        public const int GUIDED_FILTER = 3;
        public const int AM_FILTER = 4;
        public const int ARO_0_45 = 0;
        public const int ARO_45_90 = 1;
        public const int ARO_90_135 = 2;
        public const int ARO_315_0 = 3;
        public const int ARO_315_45 = 4;
        public const int ARO_45_135 = 5;
        public const int ARO_315_135 = 6;
        public const int ARO_CTR_HOR = 7;
        public const int ARO_CTR_VER = 8;
        public const int FHT_MIN = 0;
        public const int FHT_MAX = 1;
        public const int FHT_ADD = 2;
        public const int FHT_AVE = 3;
        public const int HDO_RAW = 0;
        public const int HDO_DESKEW = 1;
        public const int SLIC = 100;
        public const int SLICO = 101;
        public const int MSLIC = 102;
        public const int WMF_EXP = 1;
        public const int WMF_IV1 = 1 << 1;
        public const int WMF_IV2 = 1 << 2;
        public const int WMF_COS = 1 << 3;
        public const int WMF_JAC = 1 << 4;
        public const int WMF_OFF = 1 << 5;
        //
        // C++:  Ptr_AdaptiveManifoldFilter createAMFilter(double sigma_s, double sigma_r, bool adjust_outliers = false)
        //

        //javadoc: createAMFilter(sigma_s, sigma_r, adjust_outliers)
        public static AdaptiveManifoldFilter createAMFilter (double sigma_s, double sigma_r, bool adjust_outliers)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        AdaptiveManifoldFilter retVal = new AdaptiveManifoldFilter(ximgproc_Ximgproc_createAMFilter_10(sigma_s, sigma_r, adjust_outliers));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createAMFilter(sigma_s, sigma_r)
        public static AdaptiveManifoldFilter createAMFilter (double sigma_s, double sigma_r)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        AdaptiveManifoldFilter retVal = new AdaptiveManifoldFilter(ximgproc_Ximgproc_createAMFilter_11(sigma_s, sigma_r));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_ContourFitting createContourFitting(int ctr = 1024, int fd = 16)
        //

        //javadoc: createContourFitting(ctr, fd)
        public static ContourFitting createContourFitting (int ctr, int fd)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ContourFitting retVal = new ContourFitting(ximgproc_Ximgproc_createContourFitting_10(ctr, fd));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createContourFitting()
        public static ContourFitting createContourFitting ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ContourFitting retVal = new ContourFitting(ximgproc_Ximgproc_createContourFitting_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_DTFilter createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        //

        //javadoc: createDTFilter(guide, sigmaSpatial, sigmaColor, mode, numIters)
        public static DTFilter createDTFilter (Mat guide, double sigmaSpatial, double sigmaColor, int mode, int numIters)
        {
            if (guide != null) guide.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DTFilter retVal = new DTFilter(ximgproc_Ximgproc_createDTFilter_10(guide.nativeObj, sigmaSpatial, sigmaColor, mode, numIters));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createDTFilter(guide, sigmaSpatial, sigmaColor)
        public static DTFilter createDTFilter (Mat guide, double sigmaSpatial, double sigmaColor)
        {
            if (guide != null) guide.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DTFilter retVal = new DTFilter(ximgproc_Ximgproc_createDTFilter_11(guide.nativeObj, sigmaSpatial, sigmaColor));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_DisparityWLSFilter createDisparityWLSFilter(Ptr_StereoMatcher matcher_left)
        //

        // Unknown type 'Ptr_StereoMatcher' (I), skipping the function


        //
        // C++:  Ptr_DisparityWLSFilter createDisparityWLSFilterGeneric(bool use_confidence)
        //

        //javadoc: createDisparityWLSFilterGeneric(use_confidence)
        public static DisparityWLSFilter createDisparityWLSFilterGeneric (bool use_confidence)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DisparityWLSFilter retVal = new DisparityWLSFilter(ximgproc_Ximgproc_createDisparityWLSFilterGeneric_10(use_confidence));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_EdgeAwareInterpolator createEdgeAwareInterpolator()
        //

        //javadoc: createEdgeAwareInterpolator()
        public static EdgeAwareInterpolator createEdgeAwareInterpolator ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        EdgeAwareInterpolator retVal = new EdgeAwareInterpolator(ximgproc_Ximgproc_createEdgeAwareInterpolator_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_EdgeBoxes createEdgeBoxes(float alpha = 0.65f, float beta = 0.75f, float eta = 1, float minScore = 0.01f, int maxBoxes = 10000, float edgeMinMag = 0.1f, float edgeMergeThr = 0.5f, float clusterMinMag = 0.5f, float maxAspectRatio = 3, float minBoxArea = 1000, float gamma = 2, float kappa = 1.5f)
        //

        //javadoc: createEdgeBoxes(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio, minBoxArea, gamma, kappa)
        public static EdgeBoxes createEdgeBoxes (float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea, float gamma, float kappa)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = new EdgeBoxes(ximgproc_Ximgproc_createEdgeBoxes_10(alpha, beta, eta, minScore, maxBoxes, edgeMinMag, edgeMergeThr, clusterMinMag, maxAspectRatio, minBoxArea, gamma, kappa));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createEdgeBoxes()
        public static EdgeBoxes createEdgeBoxes ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        EdgeBoxes retVal = new EdgeBoxes(ximgproc_Ximgproc_createEdgeBoxes_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_FastGlobalSmootherFilter createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        //

        //javadoc: createFastGlobalSmootherFilter(guide, lambda, sigma_color, lambda_attenuation, num_iter)
        public static FastGlobalSmootherFilter createFastGlobalSmootherFilter (Mat guide, double lambda, double sigma_color, double lambda_attenuation, int num_iter)
        {
            if (guide != null) guide.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        FastGlobalSmootherFilter retVal = new FastGlobalSmootherFilter(ximgproc_Ximgproc_createFastGlobalSmootherFilter_10(guide.nativeObj, lambda, sigma_color, lambda_attenuation, num_iter));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createFastGlobalSmootherFilter(guide, lambda, sigma_color)
        public static FastGlobalSmootherFilter createFastGlobalSmootherFilter (Mat guide, double lambda, double sigma_color)
        {
            if (guide != null) guide.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        FastGlobalSmootherFilter retVal = new FastGlobalSmootherFilter(ximgproc_Ximgproc_createFastGlobalSmootherFilter_11(guide.nativeObj, lambda, sigma_color));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_FastLineDetector createFastLineDetector(int _length_threshold = 10, float _distance_threshold = 1.414213562f, double _canny_th1 = 50.0, double _canny_th2 = 50.0, int _canny_aperture_size = 3, bool _do_merge = false)
        //

        //javadoc: createFastLineDetector(_length_threshold, _distance_threshold, _canny_th1, _canny_th2, _canny_aperture_size, _do_merge)
        public static FastLineDetector createFastLineDetector (int _length_threshold, float _distance_threshold, double _canny_th1, double _canny_th2, int _canny_aperture_size, bool _do_merge)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        FastLineDetector retVal = new FastLineDetector(ximgproc_Ximgproc_createFastLineDetector_10(_length_threshold, _distance_threshold, _canny_th1, _canny_th2, _canny_aperture_size, _do_merge));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createFastLineDetector()
        public static FastLineDetector createFastLineDetector ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        FastLineDetector retVal = new FastLineDetector(ximgproc_Ximgproc_createFastLineDetector_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_GraphSegmentation createGraphSegmentation(double sigma = 0.5, float k = 300, int min_size = 100)
        //

        //javadoc: createGraphSegmentation(sigma, k, min_size)
        public static GraphSegmentation createGraphSegmentation (double sigma, float k, int min_size)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        GraphSegmentation retVal = new GraphSegmentation(ximgproc_Ximgproc_createGraphSegmentation_10(sigma, k, min_size));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createGraphSegmentation()
        public static GraphSegmentation createGraphSegmentation ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        GraphSegmentation retVal = new GraphSegmentation(ximgproc_Ximgproc_createGraphSegmentation_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_GuidedFilter createGuidedFilter(Mat guide, int radius, double eps)
        //

        //javadoc: createGuidedFilter(guide, radius, eps)
        public static GuidedFilter createGuidedFilter (Mat guide, int radius, double eps)
        {
            if (guide != null) guide.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        GuidedFilter retVal = new GuidedFilter(ximgproc_Ximgproc_createGuidedFilter_10(guide.nativeObj, radius, eps));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_RFFeatureGetter createRFFeatureGetter()
        //

        //javadoc: createRFFeatureGetter()
        public static RFFeatureGetter createRFFeatureGetter ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        RFFeatureGetter retVal = new RFFeatureGetter(ximgproc_Ximgproc_createRFFeatureGetter_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentation createSelectiveSearchSegmentation()
        //

        //javadoc: createSelectiveSearchSegmentation()
        public static SelectiveSearchSegmentation createSelectiveSearchSegmentation ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentation retVal = new SelectiveSearchSegmentation(ximgproc_Ximgproc_createSelectiveSearchSegmentation_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyColor createSelectiveSearchSegmentationStrategyColor()
        //

        //javadoc: createSelectiveSearchSegmentationStrategyColor()
        public static SelectiveSearchSegmentationStrategyColor createSelectiveSearchSegmentationStrategyColor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyColor retVal = new SelectiveSearchSegmentationStrategyColor(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyColor_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyFill createSelectiveSearchSegmentationStrategyFill()
        //

        //javadoc: createSelectiveSearchSegmentationStrategyFill()
        public static SelectiveSearchSegmentationStrategyFill createSelectiveSearchSegmentationStrategyFill ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyFill retVal = new SelectiveSearchSegmentationStrategyFill(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyFill_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3, Ptr_SelectiveSearchSegmentationStrategy s4)
        //

        //javadoc: createSelectiveSearchSegmentationStrategyMultiple(s1, s2, s3, s4)
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple (SelectiveSearchSegmentationStrategy s1, SelectiveSearchSegmentationStrategy s2, SelectiveSearchSegmentationStrategy s3, SelectiveSearchSegmentationStrategy s4)
        {
            if (s1 != null) s1.ThrowIfDisposed ();
            if (s2 != null) s2.ThrowIfDisposed ();
            if (s3 != null) s3.ThrowIfDisposed ();
            if (s4 != null) s4.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyMultiple retVal = new SelectiveSearchSegmentationStrategyMultiple(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_10(s1.getNativeObjAddr(), s2.getNativeObjAddr(), s3.getNativeObjAddr(), s4.getNativeObjAddr()));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3)
        //

        //javadoc: createSelectiveSearchSegmentationStrategyMultiple(s1, s2, s3)
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple (SelectiveSearchSegmentationStrategy s1, SelectiveSearchSegmentationStrategy s2, SelectiveSearchSegmentationStrategy s3)
        {
            if (s1 != null) s1.ThrowIfDisposed ();
            if (s2 != null) s2.ThrowIfDisposed ();
            if (s3 != null) s3.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyMultiple retVal = new SelectiveSearchSegmentationStrategyMultiple(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_11(s1.getNativeObjAddr(), s2.getNativeObjAddr(), s3.getNativeObjAddr()));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2)
        //

        //javadoc: createSelectiveSearchSegmentationStrategyMultiple(s1, s2)
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple (SelectiveSearchSegmentationStrategy s1, SelectiveSearchSegmentationStrategy s2)
        {
            if (s1 != null) s1.ThrowIfDisposed ();
            if (s2 != null) s2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyMultiple retVal = new SelectiveSearchSegmentationStrategyMultiple(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_12(s1.getNativeObjAddr(), s2.getNativeObjAddr()));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1)
        //

        //javadoc: createSelectiveSearchSegmentationStrategyMultiple(s1)
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple (SelectiveSearchSegmentationStrategy s1)
        {
            if (s1 != null) s1.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyMultiple retVal = new SelectiveSearchSegmentationStrategyMultiple(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_13(s1.getNativeObjAddr()));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple()
        //

        //javadoc: createSelectiveSearchSegmentationStrategyMultiple()
        public static SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyMultiple retVal = new SelectiveSearchSegmentationStrategyMultiple(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_14());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategySize createSelectiveSearchSegmentationStrategySize()
        //

        //javadoc: createSelectiveSearchSegmentationStrategySize()
        public static SelectiveSearchSegmentationStrategySize createSelectiveSearchSegmentationStrategySize ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategySize retVal = new SelectiveSearchSegmentationStrategySize(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategySize_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SelectiveSearchSegmentationStrategyTexture createSelectiveSearchSegmentationStrategyTexture()
        //

        //javadoc: createSelectiveSearchSegmentationStrategyTexture()
        public static SelectiveSearchSegmentationStrategyTexture createSelectiveSearchSegmentationStrategyTexture ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SelectiveSearchSegmentationStrategyTexture retVal = new SelectiveSearchSegmentationStrategyTexture(ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyTexture_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_StereoMatcher createRightMatcher(Ptr_StereoMatcher matcher_left)
        //

        // Return type 'Ptr_StereoMatcher' is not supported, skipping the function


        //
        // C++:  Ptr_StructuredEdgeDetection createStructuredEdgeDetection(String model, Ptr_RFFeatureGetter howToGetFeatures = Ptr<RFFeatureGetter>())
        //

        //javadoc: createStructuredEdgeDetection(model, howToGetFeatures)
        public static StructuredEdgeDetection createStructuredEdgeDetection (string model, RFFeatureGetter howToGetFeatures)
        {
            if (howToGetFeatures != null) howToGetFeatures.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        StructuredEdgeDetection retVal = new StructuredEdgeDetection(ximgproc_Ximgproc_createStructuredEdgeDetection_10(model, howToGetFeatures.getNativeObjAddr()));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createStructuredEdgeDetection(model)
        public static StructuredEdgeDetection createStructuredEdgeDetection (string model)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        StructuredEdgeDetection retVal = new StructuredEdgeDetection(ximgproc_Ximgproc_createStructuredEdgeDetection_11(model));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SuperpixelLSC createSuperpixelLSC(Mat image, int region_size = 10, float ratio = 0.075f)
        //

        //javadoc: createSuperpixelLSC(image, region_size, ratio)
        public static SuperpixelLSC createSuperpixelLSC (Mat image, int region_size, float ratio)
        {
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SuperpixelLSC retVal = new SuperpixelLSC(ximgproc_Ximgproc_createSuperpixelLSC_10(image.nativeObj, region_size, ratio));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createSuperpixelLSC(image)
        public static SuperpixelLSC createSuperpixelLSC (Mat image)
        {
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SuperpixelLSC retVal = new SuperpixelLSC(ximgproc_Ximgproc_createSuperpixelLSC_11(image.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SuperpixelSEEDS createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior = 2, int histogram_bins = 5, bool double_step = false)
        //

        //javadoc: createSuperpixelSEEDS(image_width, image_height, image_channels, num_superpixels, num_levels, prior, histogram_bins, double_step)
        public static SuperpixelSEEDS createSuperpixelSEEDS (int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior, int histogram_bins, bool double_step)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SuperpixelSEEDS retVal = new SuperpixelSEEDS(ximgproc_Ximgproc_createSuperpixelSEEDS_10(image_width, image_height, image_channels, num_superpixels, num_levels, prior, histogram_bins, double_step));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createSuperpixelSEEDS(image_width, image_height, image_channels, num_superpixels, num_levels)
        public static SuperpixelSEEDS createSuperpixelSEEDS (int image_width, int image_height, int image_channels, int num_superpixels, int num_levels)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SuperpixelSEEDS retVal = new SuperpixelSEEDS(ximgproc_Ximgproc_createSuperpixelSEEDS_11(image_width, image_height, image_channels, num_superpixels, num_levels));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_SuperpixelSLIC createSuperpixelSLIC(Mat image, int algorithm = SLICO, int region_size = 10, float ruler = 10.0f)
        //

        //javadoc: createSuperpixelSLIC(image, algorithm, region_size, ruler)
        public static SuperpixelSLIC createSuperpixelSLIC (Mat image, int algorithm, int region_size, float ruler)
        {
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SuperpixelSLIC retVal = new SuperpixelSLIC(ximgproc_Ximgproc_createSuperpixelSLIC_10(image.nativeObj, algorithm, region_size, ruler));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createSuperpixelSLIC(image)
        public static SuperpixelSLIC createSuperpixelSLIC (Mat image)
        {
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SuperpixelSLIC retVal = new SuperpixelSLIC(ximgproc_Ximgproc_createSuperpixelSLIC_11(image.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void PeiLinNormalization(Mat I, Mat& T)
        //

        //javadoc: PeiLinNormalization(I, T)
        public static void PeiLinNormalization (Mat I, Mat T)
        {
            if (I != null) I.ThrowIfDisposed ();
            if (T != null) T.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_PeiLinNormalization_10(I.nativeObj, T.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void amFilter(Mat joint, Mat src, Mat& dst, double sigma_s, double sigma_r, bool adjust_outliers = false)
        //

        //javadoc: amFilter(joint, src, dst, sigma_s, sigma_r, adjust_outliers)
        public static void amFilter (Mat joint, Mat src, Mat dst, double sigma_s, double sigma_r, bool adjust_outliers)
        {
            if (joint != null) joint.ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_amFilter_10(joint.nativeObj, src.nativeObj, dst.nativeObj, sigma_s, sigma_r, adjust_outliers);
        
#else
            return;
#endif
            return;
        }

        //javadoc: amFilter(joint, src, dst, sigma_s, sigma_r)
        public static void amFilter (Mat joint, Mat src, Mat dst, double sigma_s, double sigma_r)
        {
            if (joint != null) joint.ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_amFilter_11(joint.nativeObj, src.nativeObj, dst.nativeObj, sigma_s, sigma_r);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void anisotropicDiffusion(Mat src, Mat& dst, float alpha, float K, int niters)
        //

        //javadoc: anisotropicDiffusion(src, dst, alpha, K, niters)
        public static void anisotropicDiffusion (Mat src, Mat dst, float alpha, float K, int niters)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_anisotropicDiffusion_10(src.nativeObj, dst.nativeObj, alpha, K, niters);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void bilateralTextureFilter(Mat src, Mat& dst, int fr = 3, int numIter = 1, double sigmaAlpha = -1., double sigmaAvg = -1.)
        //

        //javadoc: bilateralTextureFilter(src, dst, fr, numIter, sigmaAlpha, sigmaAvg)
        public static void bilateralTextureFilter (Mat src, Mat dst, int fr, int numIter, double sigmaAlpha, double sigmaAvg)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_bilateralTextureFilter_10(src.nativeObj, dst.nativeObj, fr, numIter, sigmaAlpha, sigmaAvg);
        
#else
            return;
#endif
            return;
        }

        //javadoc: bilateralTextureFilter(src, dst)
        public static void bilateralTextureFilter (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_bilateralTextureFilter_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void contourSampling(Mat src, Mat& _out, int nbElt)
        //

        //javadoc: contourSampling(src, _out, nbElt)
        public static void contourSampling (Mat src, Mat _out, int nbElt)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (_out != null) _out.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_contourSampling_10(src.nativeObj, _out.nativeObj, nbElt);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void covarianceEstimation(Mat src, Mat& dst, int windowRows, int windowCols)
        //

        //javadoc: covarianceEstimation(src, dst, windowRows, windowCols)
        public static void covarianceEstimation (Mat src, Mat dst, int windowRows, int windowCols)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_covarianceEstimation_10(src.nativeObj, dst.nativeObj, windowRows, windowCols);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void dtFilter(Mat guide, Mat src, Mat& dst, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        //

        //javadoc: dtFilter(guide, src, dst, sigmaSpatial, sigmaColor, mode, numIters)
        public static void dtFilter (Mat guide, Mat src, Mat dst, double sigmaSpatial, double sigmaColor, int mode, int numIters)
        {
            if (guide != null) guide.ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_dtFilter_10(guide.nativeObj, src.nativeObj, dst.nativeObj, sigmaSpatial, sigmaColor, mode, numIters);
        
#else
            return;
#endif
            return;
        }

        //javadoc: dtFilter(guide, src, dst, sigmaSpatial, sigmaColor)
        public static void dtFilter (Mat guide, Mat src, Mat dst, double sigmaSpatial, double sigmaColor)
        {
            if (guide != null) guide.ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_dtFilter_11(guide.nativeObj, src.nativeObj, dst.nativeObj, sigmaSpatial, sigmaColor);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void fastGlobalSmootherFilter(Mat guide, Mat src, Mat& dst, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        //

        //javadoc: fastGlobalSmootherFilter(guide, src, dst, lambda, sigma_color, lambda_attenuation, num_iter)
        public static void fastGlobalSmootherFilter (Mat guide, Mat src, Mat dst, double lambda, double sigma_color, double lambda_attenuation, int num_iter)
        {
            if (guide != null) guide.ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fastGlobalSmootherFilter_10(guide.nativeObj, src.nativeObj, dst.nativeObj, lambda, sigma_color, lambda_attenuation, num_iter);
        
#else
            return;
#endif
            return;
        }

        //javadoc: fastGlobalSmootherFilter(guide, src, dst, lambda, sigma_color)
        public static void fastGlobalSmootherFilter (Mat guide, Mat src, Mat dst, double lambda, double sigma_color)
        {
            if (guide != null) guide.ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fastGlobalSmootherFilter_11(guide.nativeObj, src.nativeObj, dst.nativeObj, lambda, sigma_color);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void fourierDescriptor(Mat src, Mat& dst, int nbElt = -1, int nbFD = -1)
        //

        //javadoc: fourierDescriptor(src, dst, nbElt, nbFD)
        public static void fourierDescriptor (Mat src, Mat dst, int nbElt, int nbFD)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fourierDescriptor_10(src.nativeObj, dst.nativeObj, nbElt, nbFD);
        
#else
            return;
#endif
            return;
        }

        //javadoc: fourierDescriptor(src, dst)
        public static void fourierDescriptor (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_fourierDescriptor_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void guidedFilter(Mat guide, Mat src, Mat& dst, int radius, double eps, int dDepth = -1)
        //

        //javadoc: guidedFilter(guide, src, dst, radius, eps, dDepth)
        public static void guidedFilter (Mat guide, Mat src, Mat dst, int radius, double eps, int dDepth)
        {
            if (guide != null) guide.ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_guidedFilter_10(guide.nativeObj, src.nativeObj, dst.nativeObj, radius, eps, dDepth);
        
#else
            return;
#endif
            return;
        }

        //javadoc: guidedFilter(guide, src, dst, radius, eps)
        public static void guidedFilter (Mat guide, Mat src, Mat dst, int radius, double eps)
        {
            if (guide != null) guide.ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_guidedFilter_11(guide.nativeObj, src.nativeObj, dst.nativeObj, radius, eps);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void jointBilateralFilter(Mat joint, Mat src, Mat& dst, int d, double sigmaColor, double sigmaSpace, int borderType = BORDER_DEFAULT)
        //

        //javadoc: jointBilateralFilter(joint, src, dst, d, sigmaColor, sigmaSpace, borderType)
        public static void jointBilateralFilter (Mat joint, Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, int borderType)
        {
            if (joint != null) joint.ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_jointBilateralFilter_10(joint.nativeObj, src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace, borderType);
        
#else
            return;
#endif
            return;
        }

        //javadoc: jointBilateralFilter(joint, src, dst, d, sigmaColor, sigmaSpace)
        public static void jointBilateralFilter (Mat joint, Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace)
        {
            if (joint != null) joint.ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_jointBilateralFilter_11(joint.nativeObj, src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void l0Smooth(Mat src, Mat& dst, double lambda = 0.02, double kappa = 2.0)
        //

        //javadoc: l0Smooth(src, dst, lambda, kappa)
        public static void l0Smooth (Mat src, Mat dst, double lambda, double kappa)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_l0Smooth_10(src.nativeObj, dst.nativeObj, lambda, kappa);
        
#else
            return;
#endif
            return;
        }

        //javadoc: l0Smooth(src, dst)
        public static void l0Smooth (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_l0Smooth_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void niBlackThreshold(Mat _src, Mat& _dst, double maxValue, int type, int blockSize, double k, int binarizationMethod = BINARIZATION_NIBLACK)
        //

        //javadoc: niBlackThreshold(_src, _dst, maxValue, type, blockSize, k, binarizationMethod)
        public static void niBlackThreshold (Mat _src, Mat _dst, double maxValue, int type, int blockSize, double k, int binarizationMethod)
        {
            if (_src != null) _src.ThrowIfDisposed ();
            if (_dst != null) _dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_niBlackThreshold_10(_src.nativeObj, _dst.nativeObj, maxValue, type, blockSize, k, binarizationMethod);
        
#else
            return;
#endif
            return;
        }

        //javadoc: niBlackThreshold(_src, _dst, maxValue, type, blockSize, k)
        public static void niBlackThreshold (Mat _src, Mat _dst, double maxValue, int type, int blockSize, double k)
        {
            if (_src != null) _src.ThrowIfDisposed ();
            if (_dst != null) _dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_niBlackThreshold_11(_src.nativeObj, _dst.nativeObj, maxValue, type, blockSize, k);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void rollingGuidanceFilter(Mat src, Mat& dst, int d = -1, double sigmaColor = 25, double sigmaSpace = 3, int numOfIter = 4, int borderType = BORDER_DEFAULT)
        //

        //javadoc: rollingGuidanceFilter(src, dst, d, sigmaColor, sigmaSpace, numOfIter, borderType)
        public static void rollingGuidanceFilter (Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, int numOfIter, int borderType)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_rollingGuidanceFilter_10(src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace, numOfIter, borderType);
        
#else
            return;
#endif
            return;
        }

        //javadoc: rollingGuidanceFilter(src, dst, d, sigmaColor, sigmaSpace, numOfIter)
        public static void rollingGuidanceFilter (Mat src, Mat dst, int d, double sigmaColor, double sigmaSpace, int numOfIter)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_rollingGuidanceFilter_11(src.nativeObj, dst.nativeObj, d, sigmaColor, sigmaSpace, numOfIter);
        
#else
            return;
#endif
            return;
        }

        //javadoc: rollingGuidanceFilter(src, dst)
        public static void rollingGuidanceFilter (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_rollingGuidanceFilter_12(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void thinning(Mat src, Mat& dst, int thinningType = THINNING_ZHANGSUEN)
        //

        //javadoc: thinning(src, dst, thinningType)
        public static void thinning (Mat src, Mat dst, int thinningType)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_thinning_10(src.nativeObj, dst.nativeObj, thinningType);
        
#else
            return;
#endif
            return;
        }

        //javadoc: thinning(src, dst)
        public static void thinning (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_thinning_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void transformFD(Mat src, Mat t, Mat& dst, bool fdContour = true)
        //

        //javadoc: transformFD(src, t, dst, fdContour)
        public static void transformFD (Mat src, Mat t, Mat dst, bool fdContour)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (t != null) t.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_transformFD_10(src.nativeObj, t.nativeObj, dst.nativeObj, fdContour);
        
#else
            return;
#endif
            return;
        }

        //javadoc: transformFD(src, t, dst)
        public static void transformFD (Mat src, Mat t, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (t != null) t.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_transformFD_11(src.nativeObj, t.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void weightedMedianFilter(Mat joint, Mat src, Mat& dst, int r, double sigma = 25.5, int weightType = WMF_EXP, Mat mask = Mat())
        //

        //javadoc: weightedMedianFilter(joint, src, dst, r, sigma, weightType, mask)
        public static void weightedMedianFilter (Mat joint, Mat src, Mat dst, int r, double sigma, int weightType, Mat mask)
        {
            if (joint != null) joint.ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_weightedMedianFilter_10(joint.nativeObj, src.nativeObj, dst.nativeObj, r, sigma, weightType, mask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: weightedMedianFilter(joint, src, dst, r, sigma, weightType)
        public static void weightedMedianFilter (Mat joint, Mat src, Mat dst, int r, double sigma, int weightType)
        {
            if (joint != null) joint.ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_weightedMedianFilter_11(joint.nativeObj, src.nativeObj, dst.nativeObj, r, sigma, weightType);
        
#else
            return;
#endif
            return;
        }

        //javadoc: weightedMedianFilter(joint, src, dst, r)
        public static void weightedMedianFilter (Mat joint, Mat src, Mat dst, int r)
        {
            if (joint != null) joint.ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_Ximgproc_weightedMedianFilter_12(joint.nativeObj, src.nativeObj, dst.nativeObj, r);
        
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



        // C++:  Ptr_AdaptiveManifoldFilter createAMFilter(double sigma_s, double sigma_r, bool adjust_outliers = false)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createAMFilter_10 (double sigma_s, double sigma_r, bool adjust_outliers);
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createAMFilter_11 (double sigma_s, double sigma_r);

        // C++:  Ptr_ContourFitting createContourFitting(int ctr = 1024, int fd = 16)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createContourFitting_10 (int ctr, int fd);
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createContourFitting_11 ();

        // C++:  Ptr_DTFilter createDTFilter(Mat guide, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDTFilter_10 (IntPtr guide_nativeObj, double sigmaSpatial, double sigmaColor, int mode, int numIters);
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDTFilter_11 (IntPtr guide_nativeObj, double sigmaSpatial, double sigmaColor);

        // C++:  Ptr_DisparityWLSFilter createDisparityWLSFilterGeneric(bool use_confidence)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createDisparityWLSFilterGeneric_10 (bool use_confidence);

        // C++:  Ptr_EdgeAwareInterpolator createEdgeAwareInterpolator()
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeAwareInterpolator_10 ();

        // C++:  Ptr_EdgeBoxes createEdgeBoxes(float alpha = 0.65f, float beta = 0.75f, float eta = 1, float minScore = 0.01f, int maxBoxes = 10000, float edgeMinMag = 0.1f, float edgeMergeThr = 0.5f, float clusterMinMag = 0.5f, float maxAspectRatio = 3, float minBoxArea = 1000, float gamma = 2, float kappa = 1.5f)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_10 (float alpha, float beta, float eta, float minScore, int maxBoxes, float edgeMinMag, float edgeMergeThr, float clusterMinMag, float maxAspectRatio, float minBoxArea, float gamma, float kappa);
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createEdgeBoxes_11 ();

        // C++:  Ptr_FastGlobalSmootherFilter createFastGlobalSmootherFilter(Mat guide, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastGlobalSmootherFilter_10 (IntPtr guide_nativeObj, double lambda, double sigma_color, double lambda_attenuation, int num_iter);
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastGlobalSmootherFilter_11 (IntPtr guide_nativeObj, double lambda, double sigma_color);

        // C++:  Ptr_FastLineDetector createFastLineDetector(int _length_threshold = 10, float _distance_threshold = 1.414213562f, double _canny_th1 = 50.0, double _canny_th2 = 50.0, int _canny_aperture_size = 3, bool _do_merge = false)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_10 (int _length_threshold, float _distance_threshold, double _canny_th1, double _canny_th2, int _canny_aperture_size, bool _do_merge);
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createFastLineDetector_11 ();

        // C++:  Ptr_GraphSegmentation createGraphSegmentation(double sigma = 0.5, float k = 300, int min_size = 100)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGraphSegmentation_10 (double sigma, float k, int min_size);
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGraphSegmentation_11 ();

        // C++:  Ptr_GuidedFilter createGuidedFilter(Mat guide, int radius, double eps)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createGuidedFilter_10 (IntPtr guide_nativeObj, int radius, double eps);

        // C++:  Ptr_RFFeatureGetter createRFFeatureGetter()
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createRFFeatureGetter_10 ();

        // C++:  Ptr_SelectiveSearchSegmentation createSelectiveSearchSegmentation()
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentation_10 ();

        // C++:  Ptr_SelectiveSearchSegmentationStrategyColor createSelectiveSearchSegmentationStrategyColor()
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyColor_10 ();

        // C++:  Ptr_SelectiveSearchSegmentationStrategyFill createSelectiveSearchSegmentationStrategyFill()
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyFill_10 ();

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3, Ptr_SelectiveSearchSegmentationStrategy s4)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_10 (IntPtr s1_nativeObj, IntPtr s2_nativeObj, IntPtr s3_nativeObj, IntPtr s4_nativeObj);

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2, Ptr_SelectiveSearchSegmentationStrategy s3)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_11 (IntPtr s1_nativeObj, IntPtr s2_nativeObj, IntPtr s3_nativeObj);

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1, Ptr_SelectiveSearchSegmentationStrategy s2)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_12 (IntPtr s1_nativeObj, IntPtr s2_nativeObj);

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple(Ptr_SelectiveSearchSegmentationStrategy s1)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_13 (IntPtr s1_nativeObj);

        // C++:  Ptr_SelectiveSearchSegmentationStrategyMultiple createSelectiveSearchSegmentationStrategyMultiple()
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyMultiple_14 ();

        // C++:  Ptr_SelectiveSearchSegmentationStrategySize createSelectiveSearchSegmentationStrategySize()
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategySize_10 ();

        // C++:  Ptr_SelectiveSearchSegmentationStrategyTexture createSelectiveSearchSegmentationStrategyTexture()
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSelectiveSearchSegmentationStrategyTexture_10 ();

        // C++:  Ptr_StructuredEdgeDetection createStructuredEdgeDetection(String model, Ptr_RFFeatureGetter howToGetFeatures = Ptr<RFFeatureGetter>())
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createStructuredEdgeDetection_10 (string model, IntPtr howToGetFeatures_nativeObj);
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createStructuredEdgeDetection_11 (string model);

        // C++:  Ptr_SuperpixelLSC createSuperpixelLSC(Mat image, int region_size = 10, float ratio = 0.075f)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelLSC_10 (IntPtr image_nativeObj, int region_size, float ratio);
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelLSC_11 (IntPtr image_nativeObj);

        // C++:  Ptr_SuperpixelSEEDS createSuperpixelSEEDS(int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior = 2, int histogram_bins = 5, bool double_step = false)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSEEDS_10 (int image_width, int image_height, int image_channels, int num_superpixels, int num_levels, int prior, int histogram_bins, bool double_step);
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSEEDS_11 (int image_width, int image_height, int image_channels, int num_superpixels, int num_levels);

        // C++:  Ptr_SuperpixelSLIC createSuperpixelSLIC(Mat image, int algorithm = SLICO, int region_size = 10, float ruler = 10.0f)
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSLIC_10 (IntPtr image_nativeObj, int algorithm, int region_size, float ruler);
        [DllImport (LIBNAME)]
        private static extern IntPtr ximgproc_Ximgproc_createSuperpixelSLIC_11 (IntPtr image_nativeObj);

        // C++:  void PeiLinNormalization(Mat I, Mat& T)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_PeiLinNormalization_10 (IntPtr I_nativeObj, IntPtr T_nativeObj);

        // C++:  void amFilter(Mat joint, Mat src, Mat& dst, double sigma_s, double sigma_r, bool adjust_outliers = false)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_amFilter_10 (IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma_s, double sigma_r, bool adjust_outliers);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_amFilter_11 (IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigma_s, double sigma_r);

        // C++:  void anisotropicDiffusion(Mat src, Mat& dst, float alpha, float K, int niters)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_anisotropicDiffusion_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, float alpha, float K, int niters);

        // C++:  void bilateralTextureFilter(Mat src, Mat& dst, int fr = 3, int numIter = 1, double sigmaAlpha = -1., double sigmaAvg = -1.)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int fr, int numIter, double sigmaAlpha, double sigmaAvg);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_bilateralTextureFilter_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void contourSampling(Mat src, Mat& _out, int nbElt)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_contourSampling_10 (IntPtr src_nativeObj, IntPtr _out_nativeObj, int nbElt);

        // C++:  void covarianceEstimation(Mat src, Mat& dst, int windowRows, int windowCols)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_covarianceEstimation_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int windowRows, int windowCols);

        // C++:  void dtFilter(Mat guide, Mat src, Mat& dst, double sigmaSpatial, double sigmaColor, int mode = DTF_NC, int numIters = 3)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_dtFilter_10 (IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigmaSpatial, double sigmaColor, int mode, int numIters);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_dtFilter_11 (IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double sigmaSpatial, double sigmaColor);

        // C++:  void fastGlobalSmootherFilter(Mat guide, Mat src, Mat& dst, double lambda, double sigma_color, double lambda_attenuation = 0.25, int num_iter = 3)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastGlobalSmootherFilter_10 (IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double sigma_color, double lambda_attenuation, int num_iter);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_fastGlobalSmootherFilter_11 (IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double sigma_color);

        // C++:  void fourierDescriptor(Mat src, Mat& dst, int nbElt = -1, int nbFD = -1)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_fourierDescriptor_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int nbElt, int nbFD);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_fourierDescriptor_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void guidedFilter(Mat guide, Mat src, Mat& dst, int radius, double eps, int dDepth = -1)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_guidedFilter_10 (IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int radius, double eps, int dDepth);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_guidedFilter_11 (IntPtr guide_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int radius, double eps);

        // C++:  void jointBilateralFilter(Mat joint, Mat src, Mat& dst, int d, double sigmaColor, double sigmaSpace, int borderType = BORDER_DEFAULT)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_jointBilateralFilter_10 (IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int borderType);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_jointBilateralFilter_11 (IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace);

        // C++:  void l0Smooth(Mat src, Mat& dst, double lambda = 0.02, double kappa = 2.0)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_l0Smooth_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double lambda, double kappa);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_l0Smooth_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void niBlackThreshold(Mat _src, Mat& _dst, double maxValue, int type, int blockSize, double k, int binarizationMethod = BINARIZATION_NIBLACK)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_niBlackThreshold_10 (IntPtr _src_nativeObj, IntPtr _dst_nativeObj, double maxValue, int type, int blockSize, double k, int binarizationMethod);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_niBlackThreshold_11 (IntPtr _src_nativeObj, IntPtr _dst_nativeObj, double maxValue, int type, int blockSize, double k);

        // C++:  void rollingGuidanceFilter(Mat src, Mat& dst, int d = -1, double sigmaColor = 25, double sigmaSpace = 3, int numOfIter = 4, int borderType = BORDER_DEFAULT)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int numOfIter, int borderType);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int d, double sigmaColor, double sigmaSpace, int numOfIter);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_rollingGuidanceFilter_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void thinning(Mat src, Mat& dst, int thinningType = THINNING_ZHANGSUEN)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_thinning_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int thinningType);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_thinning_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void transformFD(Mat src, Mat t, Mat& dst, bool fdContour = true)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_transformFD_10 (IntPtr src_nativeObj, IntPtr t_nativeObj, IntPtr dst_nativeObj, bool fdContour);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_transformFD_11 (IntPtr src_nativeObj, IntPtr t_nativeObj, IntPtr dst_nativeObj);

        // C++:  void weightedMedianFilter(Mat joint, Mat src, Mat& dst, int r, double sigma = 25.5, int weightType = WMF_EXP, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_weightedMedianFilter_10 (IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int r, double sigma, int weightType, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_weightedMedianFilter_11 (IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int r, double sigma, int weightType);
        [DllImport (LIBNAME)]
        private static extern void ximgproc_Ximgproc_weightedMedianFilter_12 (IntPtr joint_nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj, int r);

    }
}
