

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Shape
    //javadoc: Shape

    public class Shape
    {

        //
        // C++:  Ptr_AffineTransformer createAffineTransformer(bool fullAffine)
        //

        //javadoc: createAffineTransformer(fullAffine)
        public static AffineTransformer createAffineTransformer (bool fullAffine)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        AffineTransformer retVal = new AffineTransformer(shape_Shape_createAffineTransformer_10(fullAffine));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_HausdorffDistanceExtractor createHausdorffDistanceExtractor(int distanceFlag = cv::NORM_L2, float rankProp = 0.6f)
        //

        //javadoc: createHausdorffDistanceExtractor(distanceFlag, rankProp)
        public static HausdorffDistanceExtractor createHausdorffDistanceExtractor (int distanceFlag, float rankProp)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HausdorffDistanceExtractor retVal = new HausdorffDistanceExtractor(shape_Shape_createHausdorffDistanceExtractor_10(distanceFlag, rankProp));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createHausdorffDistanceExtractor()
        public static HausdorffDistanceExtractor createHausdorffDistanceExtractor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HausdorffDistanceExtractor retVal = new HausdorffDistanceExtractor(shape_Shape_createHausdorffDistanceExtractor_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_HistogramCostExtractor createChiHistogramCostExtractor(int nDummies = 25, float defaultCost = 0.2f)
        //

        //javadoc: createChiHistogramCostExtractor(nDummies, defaultCost)
        public static HistogramCostExtractor createChiHistogramCostExtractor (int nDummies, float defaultCost)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = new HistogramCostExtractor(shape_Shape_createChiHistogramCostExtractor_10(nDummies, defaultCost));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createChiHistogramCostExtractor()
        public static HistogramCostExtractor createChiHistogramCostExtractor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = new HistogramCostExtractor(shape_Shape_createChiHistogramCostExtractor_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_HistogramCostExtractor createEMDHistogramCostExtractor(int flag = DIST_L2, int nDummies = 25, float defaultCost = 0.2f)
        //

        //javadoc: createEMDHistogramCostExtractor(flag, nDummies, defaultCost)
        public static HistogramCostExtractor createEMDHistogramCostExtractor (int flag, int nDummies, float defaultCost)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = new HistogramCostExtractor(shape_Shape_createEMDHistogramCostExtractor_10(flag, nDummies, defaultCost));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createEMDHistogramCostExtractor()
        public static HistogramCostExtractor createEMDHistogramCostExtractor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = new HistogramCostExtractor(shape_Shape_createEMDHistogramCostExtractor_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_HistogramCostExtractor createEMDL1HistogramCostExtractor(int nDummies = 25, float defaultCost = 0.2f)
        //

        //javadoc: createEMDL1HistogramCostExtractor(nDummies, defaultCost)
        public static HistogramCostExtractor createEMDL1HistogramCostExtractor (int nDummies, float defaultCost)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = new HistogramCostExtractor(shape_Shape_createEMDL1HistogramCostExtractor_10(nDummies, defaultCost));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createEMDL1HistogramCostExtractor()
        public static HistogramCostExtractor createEMDL1HistogramCostExtractor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = new HistogramCostExtractor(shape_Shape_createEMDL1HistogramCostExtractor_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_HistogramCostExtractor createNormHistogramCostExtractor(int flag = DIST_L2, int nDummies = 25, float defaultCost = 0.2f)
        //

        //javadoc: createNormHistogramCostExtractor(flag, nDummies, defaultCost)
        public static HistogramCostExtractor createNormHistogramCostExtractor (int flag, int nDummies, float defaultCost)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = new HistogramCostExtractor(shape_Shape_createNormHistogramCostExtractor_10(flag, nDummies, defaultCost));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createNormHistogramCostExtractor()
        public static HistogramCostExtractor createNormHistogramCostExtractor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = new HistogramCostExtractor(shape_Shape_createNormHistogramCostExtractor_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_ShapeContextDistanceExtractor createShapeContextDistanceExtractor(int nAngularBins = 12, int nRadialBins = 4, float innerRadius = 0.2f, float outerRadius = 2, int iterations = 3, Ptr_HistogramCostExtractor comparer = createChiHistogramCostExtractor(), Ptr_ShapeTransformer transformer = createThinPlateSplineShapeTransformer())
        //

        //javadoc: createShapeContextDistanceExtractor(nAngularBins, nRadialBins, innerRadius, outerRadius, iterations, comparer, transformer)
        public static ShapeContextDistanceExtractor createShapeContextDistanceExtractor (int nAngularBins, int nRadialBins, float innerRadius, float outerRadius, int iterations, HistogramCostExtractor comparer, ShapeTransformer transformer)
        {
            if (comparer != null) comparer.ThrowIfDisposed ();
            if (transformer != null) transformer.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ShapeContextDistanceExtractor retVal = new ShapeContextDistanceExtractor(shape_Shape_createShapeContextDistanceExtractor_10(nAngularBins, nRadialBins, innerRadius, outerRadius, iterations, comparer.getNativeObjAddr(), transformer.getNativeObjAddr()));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createShapeContextDistanceExtractor()
        public static ShapeContextDistanceExtractor createShapeContextDistanceExtractor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ShapeContextDistanceExtractor retVal = new ShapeContextDistanceExtractor(shape_Shape_createShapeContextDistanceExtractor_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_ThinPlateSplineShapeTransformer createThinPlateSplineShapeTransformer(double regularizationParameter = 0)
        //

        //javadoc: createThinPlateSplineShapeTransformer(regularizationParameter)
        public static ThinPlateSplineShapeTransformer createThinPlateSplineShapeTransformer (double regularizationParameter)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ThinPlateSplineShapeTransformer retVal = new ThinPlateSplineShapeTransformer(shape_Shape_createThinPlateSplineShapeTransformer_10(regularizationParameter));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createThinPlateSplineShapeTransformer()
        public static ThinPlateSplineShapeTransformer createThinPlateSplineShapeTransformer ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ThinPlateSplineShapeTransformer retVal = new ThinPlateSplineShapeTransformer(shape_Shape_createThinPlateSplineShapeTransformer_11());
        
#else
            return null;
#endif
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  Ptr_AffineTransformer createAffineTransformer(bool fullAffine)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createAffineTransformer_10 (bool fullAffine);

        // C++:  Ptr_HausdorffDistanceExtractor createHausdorffDistanceExtractor(int distanceFlag = cv::NORM_L2, float rankProp = 0.6f)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createHausdorffDistanceExtractor_10 (int distanceFlag, float rankProp);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createHausdorffDistanceExtractor_11 ();

        // C++:  Ptr_HistogramCostExtractor createChiHistogramCostExtractor(int nDummies = 25, float defaultCost = 0.2f)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createChiHistogramCostExtractor_10 (int nDummies, float defaultCost);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createChiHistogramCostExtractor_11 ();

        // C++:  Ptr_HistogramCostExtractor createEMDHistogramCostExtractor(int flag = DIST_L2, int nDummies = 25, float defaultCost = 0.2f)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createEMDHistogramCostExtractor_10 (int flag, int nDummies, float defaultCost);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createEMDHistogramCostExtractor_11 ();

        // C++:  Ptr_HistogramCostExtractor createEMDL1HistogramCostExtractor(int nDummies = 25, float defaultCost = 0.2f)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createEMDL1HistogramCostExtractor_10 (int nDummies, float defaultCost);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createEMDL1HistogramCostExtractor_11 ();

        // C++:  Ptr_HistogramCostExtractor createNormHistogramCostExtractor(int flag = DIST_L2, int nDummies = 25, float defaultCost = 0.2f)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createNormHistogramCostExtractor_10 (int flag, int nDummies, float defaultCost);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createNormHistogramCostExtractor_11 ();

        // C++:  Ptr_ShapeContextDistanceExtractor createShapeContextDistanceExtractor(int nAngularBins = 12, int nRadialBins = 4, float innerRadius = 0.2f, float outerRadius = 2, int iterations = 3, Ptr_HistogramCostExtractor comparer = createChiHistogramCostExtractor(), Ptr_ShapeTransformer transformer = createThinPlateSplineShapeTransformer())
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createShapeContextDistanceExtractor_10 (int nAngularBins, int nRadialBins, float innerRadius, float outerRadius, int iterations, IntPtr comparer_nativeObj, IntPtr transformer_nativeObj);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createShapeContextDistanceExtractor_11 ();

        // C++:  Ptr_ThinPlateSplineShapeTransformer createThinPlateSplineShapeTransformer(double regularizationParameter = 0)
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createThinPlateSplineShapeTransformer_10 (double regularizationParameter);
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_Shape_createThinPlateSplineShapeTransformer_11 ();

    }
}
