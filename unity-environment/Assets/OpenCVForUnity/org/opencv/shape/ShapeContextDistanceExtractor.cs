

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class ShapeContextDistanceExtractor
    //javadoc: ShapeContextDistanceExtractor

    public class ShapeContextDistanceExtractor : ShapeDistanceExtractor
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
shape_ShapeContextDistanceExtractor_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal ShapeContextDistanceExtractor (IntPtr addr) : base (addr) { }


        //
        // C++:  Ptr_HistogramCostExtractor getCostExtractor()
        //

        //javadoc: ShapeContextDistanceExtractor::getCostExtractor()
        public HistogramCostExtractor getCostExtractor ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        HistogramCostExtractor retVal = new HistogramCostExtractor(shape_ShapeContextDistanceExtractor_getCostExtractor_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_ShapeTransformer getTransformAlgorithm()
        //

        //javadoc: ShapeContextDistanceExtractor::getTransformAlgorithm()
        public ShapeTransformer getTransformAlgorithm ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ShapeTransformer retVal = new ShapeTransformer(shape_ShapeContextDistanceExtractor_getTransformAlgorithm_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool getRotationInvariant()
        //

        //javadoc: ShapeContextDistanceExtractor::getRotationInvariant()
        public bool getRotationInvariant ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = shape_ShapeContextDistanceExtractor_getRotationInvariant_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  float getBendingEnergyWeight()
        //

        //javadoc: ShapeContextDistanceExtractor::getBendingEnergyWeight()
        public float getBendingEnergyWeight ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = shape_ShapeContextDistanceExtractor_getBendingEnergyWeight_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getImageAppearanceWeight()
        //

        //javadoc: ShapeContextDistanceExtractor::getImageAppearanceWeight()
        public float getImageAppearanceWeight ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = shape_ShapeContextDistanceExtractor_getImageAppearanceWeight_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getInnerRadius()
        //

        //javadoc: ShapeContextDistanceExtractor::getInnerRadius()
        public float getInnerRadius ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = shape_ShapeContextDistanceExtractor_getInnerRadius_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getOuterRadius()
        //

        //javadoc: ShapeContextDistanceExtractor::getOuterRadius()
        public float getOuterRadius ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = shape_ShapeContextDistanceExtractor_getOuterRadius_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getShapeContextWeight()
        //

        //javadoc: ShapeContextDistanceExtractor::getShapeContextWeight()
        public float getShapeContextWeight ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = shape_ShapeContextDistanceExtractor_getShapeContextWeight_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getStdDev()
        //

        //javadoc: ShapeContextDistanceExtractor::getStdDev()
        public float getStdDev ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = shape_ShapeContextDistanceExtractor_getStdDev_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getAngularBins()
        //

        //javadoc: ShapeContextDistanceExtractor::getAngularBins()
        public int getAngularBins ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = shape_ShapeContextDistanceExtractor_getAngularBins_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getIterations()
        //

        //javadoc: ShapeContextDistanceExtractor::getIterations()
        public int getIterations ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = shape_ShapeContextDistanceExtractor_getIterations_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getRadialBins()
        //

        //javadoc: ShapeContextDistanceExtractor::getRadialBins()
        public int getRadialBins ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = shape_ShapeContextDistanceExtractor_getRadialBins_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void getImages(Mat& image1, Mat& image2)
        //

        //javadoc: ShapeContextDistanceExtractor::getImages(image1, image2)
        public void getImages (Mat image1, Mat image2)
        {
            ThrowIfDisposed ();
            if (image1 != null) image1.ThrowIfDisposed ();
            if (image2 != null) image2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_getImages_10(nativeObj, image1.nativeObj, image2.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setAngularBins(int nAngularBins)
        //

        //javadoc: ShapeContextDistanceExtractor::setAngularBins(nAngularBins)
        public void setAngularBins (int nAngularBins)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_setAngularBins_10(nativeObj, nAngularBins);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setBendingEnergyWeight(float bendingEnergyWeight)
        //

        //javadoc: ShapeContextDistanceExtractor::setBendingEnergyWeight(bendingEnergyWeight)
        public void setBendingEnergyWeight (float bendingEnergyWeight)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_setBendingEnergyWeight_10(nativeObj, bendingEnergyWeight);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setCostExtractor(Ptr_HistogramCostExtractor comparer)
        //

        //javadoc: ShapeContextDistanceExtractor::setCostExtractor(comparer)
        public void setCostExtractor (HistogramCostExtractor comparer)
        {
            ThrowIfDisposed ();
            if (comparer != null) comparer.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_setCostExtractor_10(nativeObj, comparer.getNativeObjAddr());
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setImageAppearanceWeight(float imageAppearanceWeight)
        //

        //javadoc: ShapeContextDistanceExtractor::setImageAppearanceWeight(imageAppearanceWeight)
        public void setImageAppearanceWeight (float imageAppearanceWeight)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_setImageAppearanceWeight_10(nativeObj, imageAppearanceWeight);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setImages(Mat image1, Mat image2)
        //

        //javadoc: ShapeContextDistanceExtractor::setImages(image1, image2)
        public void setImages (Mat image1, Mat image2)
        {
            ThrowIfDisposed ();
            if (image1 != null) image1.ThrowIfDisposed ();
            if (image2 != null) image2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_setImages_10(nativeObj, image1.nativeObj, image2.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setInnerRadius(float innerRadius)
        //

        //javadoc: ShapeContextDistanceExtractor::setInnerRadius(innerRadius)
        public void setInnerRadius (float innerRadius)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_setInnerRadius_10(nativeObj, innerRadius);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setIterations(int iterations)
        //

        //javadoc: ShapeContextDistanceExtractor::setIterations(iterations)
        public void setIterations (int iterations)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_setIterations_10(nativeObj, iterations);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setOuterRadius(float outerRadius)
        //

        //javadoc: ShapeContextDistanceExtractor::setOuterRadius(outerRadius)
        public void setOuterRadius (float outerRadius)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_setOuterRadius_10(nativeObj, outerRadius);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setRadialBins(int nRadialBins)
        //

        //javadoc: ShapeContextDistanceExtractor::setRadialBins(nRadialBins)
        public void setRadialBins (int nRadialBins)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_setRadialBins_10(nativeObj, nRadialBins);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setRotationInvariant(bool rotationInvariant)
        //

        //javadoc: ShapeContextDistanceExtractor::setRotationInvariant(rotationInvariant)
        public void setRotationInvariant (bool rotationInvariant)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_setRotationInvariant_10(nativeObj, rotationInvariant);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setShapeContextWeight(float shapeContextWeight)
        //

        //javadoc: ShapeContextDistanceExtractor::setShapeContextWeight(shapeContextWeight)
        public void setShapeContextWeight (float shapeContextWeight)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_setShapeContextWeight_10(nativeObj, shapeContextWeight);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setStdDev(float sigma)
        //

        //javadoc: ShapeContextDistanceExtractor::setStdDev(sigma)
        public void setStdDev (float sigma)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_setStdDev_10(nativeObj, sigma);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setTransformAlgorithm(Ptr_ShapeTransformer transformer)
        //

        //javadoc: ShapeContextDistanceExtractor::setTransformAlgorithm(transformer)
        public void setTransformAlgorithm (ShapeTransformer transformer)
        {
            ThrowIfDisposed ();
            if (transformer != null) transformer.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ShapeContextDistanceExtractor_setTransformAlgorithm_10(nativeObj, transformer.getNativeObjAddr());
        
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



        // C++:  Ptr_HistogramCostExtractor getCostExtractor()
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_ShapeContextDistanceExtractor_getCostExtractor_10 (IntPtr nativeObj);

        // C++:  Ptr_ShapeTransformer getTransformAlgorithm()
        [DllImport (LIBNAME)]
        private static extern IntPtr shape_ShapeContextDistanceExtractor_getTransformAlgorithm_10 (IntPtr nativeObj);

        // C++:  bool getRotationInvariant()
        [DllImport (LIBNAME)]
        private static extern bool shape_ShapeContextDistanceExtractor_getRotationInvariant_10 (IntPtr nativeObj);

        // C++:  float getBendingEnergyWeight()
        [DllImport (LIBNAME)]
        private static extern float shape_ShapeContextDistanceExtractor_getBendingEnergyWeight_10 (IntPtr nativeObj);

        // C++:  float getImageAppearanceWeight()
        [DllImport (LIBNAME)]
        private static extern float shape_ShapeContextDistanceExtractor_getImageAppearanceWeight_10 (IntPtr nativeObj);

        // C++:  float getInnerRadius()
        [DllImport (LIBNAME)]
        private static extern float shape_ShapeContextDistanceExtractor_getInnerRadius_10 (IntPtr nativeObj);

        // C++:  float getOuterRadius()
        [DllImport (LIBNAME)]
        private static extern float shape_ShapeContextDistanceExtractor_getOuterRadius_10 (IntPtr nativeObj);

        // C++:  float getShapeContextWeight()
        [DllImport (LIBNAME)]
        private static extern float shape_ShapeContextDistanceExtractor_getShapeContextWeight_10 (IntPtr nativeObj);

        // C++:  float getStdDev()
        [DllImport (LIBNAME)]
        private static extern float shape_ShapeContextDistanceExtractor_getStdDev_10 (IntPtr nativeObj);

        // C++:  int getAngularBins()
        [DllImport (LIBNAME)]
        private static extern int shape_ShapeContextDistanceExtractor_getAngularBins_10 (IntPtr nativeObj);

        // C++:  int getIterations()
        [DllImport (LIBNAME)]
        private static extern int shape_ShapeContextDistanceExtractor_getIterations_10 (IntPtr nativeObj);

        // C++:  int getRadialBins()
        [DllImport (LIBNAME)]
        private static extern int shape_ShapeContextDistanceExtractor_getRadialBins_10 (IntPtr nativeObj);

        // C++:  void getImages(Mat& image1, Mat& image2)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_getImages_10 (IntPtr nativeObj, IntPtr image1_nativeObj, IntPtr image2_nativeObj);

        // C++:  void setAngularBins(int nAngularBins)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_setAngularBins_10 (IntPtr nativeObj, int nAngularBins);

        // C++:  void setBendingEnergyWeight(float bendingEnergyWeight)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_setBendingEnergyWeight_10 (IntPtr nativeObj, float bendingEnergyWeight);

        // C++:  void setCostExtractor(Ptr_HistogramCostExtractor comparer)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_setCostExtractor_10 (IntPtr nativeObj, IntPtr comparer_nativeObj);

        // C++:  void setImageAppearanceWeight(float imageAppearanceWeight)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_setImageAppearanceWeight_10 (IntPtr nativeObj, float imageAppearanceWeight);

        // C++:  void setImages(Mat image1, Mat image2)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_setImages_10 (IntPtr nativeObj, IntPtr image1_nativeObj, IntPtr image2_nativeObj);

        // C++:  void setInnerRadius(float innerRadius)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_setInnerRadius_10 (IntPtr nativeObj, float innerRadius);

        // C++:  void setIterations(int iterations)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_setIterations_10 (IntPtr nativeObj, int iterations);

        // C++:  void setOuterRadius(float outerRadius)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_setOuterRadius_10 (IntPtr nativeObj, float outerRadius);

        // C++:  void setRadialBins(int nRadialBins)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_setRadialBins_10 (IntPtr nativeObj, int nRadialBins);

        // C++:  void setRotationInvariant(bool rotationInvariant)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_setRotationInvariant_10 (IntPtr nativeObj, bool rotationInvariant);

        // C++:  void setShapeContextWeight(float shapeContextWeight)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_setShapeContextWeight_10 (IntPtr nativeObj, float shapeContextWeight);

        // C++:  void setStdDev(float sigma)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_setStdDev_10 (IntPtr nativeObj, float sigma);

        // C++:  void setTransformAlgorithm(Ptr_ShapeTransformer transformer)
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_setTransformAlgorithm_10 (IntPtr nativeObj, IntPtr transformer_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void shape_ShapeContextDistanceExtractor_delete (IntPtr nativeObj);

    }
}
