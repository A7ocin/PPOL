

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class PCTSignatures
    //javadoc: PCTSignatures

    public class PCTSignatures : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xfeatures2d_PCTSignatures_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal PCTSignatures (IntPtr addr) : base (addr) { }


        public const int L0_25 = 0;
        public const int L0_5 = 1;
        public const int L1 = 2;
        public const int L2 = 3;
        public const int L2SQUARED = 4;
        public const int L5 = 5;
        public const int L_INFINITY = 6;
        public const int UNIFORM = 0;
        public const int REGULAR = 1;
        public const int NORMAL = 2;
        public const int MINUS = 0;
        public const int GAUSSIAN = 1;
        public const int HEURISTIC = 2;
        //
        // C++: static Ptr_PCTSignatures create(int initSampleCount = 2000, int initSeedCount = 400, int pointDistribution = 0)
        //

        //javadoc: PCTSignatures::create(initSampleCount, initSeedCount, pointDistribution)
        public static PCTSignatures create (int initSampleCount, int initSeedCount, int pointDistribution)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        PCTSignatures retVal = new PCTSignatures(xfeatures2d_PCTSignatures_create_10(initSampleCount, initSeedCount, pointDistribution));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: PCTSignatures::create()
        public static PCTSignatures create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        PCTSignatures retVal = new PCTSignatures(xfeatures2d_PCTSignatures_create_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_PCTSignatures create(vector_Point2f initSamplingPoints, int initSeedCount)
        //

        //javadoc: PCTSignatures::create(initSamplingPoints, initSeedCount)
        public static PCTSignatures create (MatOfPoint2f initSamplingPoints, int initSeedCount)
        {
            if (initSamplingPoints != null) initSamplingPoints.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat initSamplingPoints_mat = initSamplingPoints;
        PCTSignatures retVal = new PCTSignatures(xfeatures2d_PCTSignatures_create_12(initSamplingPoints_mat.nativeObj, initSeedCount));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_PCTSignatures create(vector_Point2f initSamplingPoints, vector_int initClusterSeedIndexes)
        //

        //javadoc: PCTSignatures::create(initSamplingPoints, initClusterSeedIndexes)
        public static PCTSignatures create (MatOfPoint2f initSamplingPoints, MatOfInt initClusterSeedIndexes)
        {
            if (initSamplingPoints != null) initSamplingPoints.ThrowIfDisposed ();
            if (initClusterSeedIndexes != null) initClusterSeedIndexes.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat initSamplingPoints_mat = initSamplingPoints;
        Mat initClusterSeedIndexes_mat = initClusterSeedIndexes;
        PCTSignatures retVal = new PCTSignatures(xfeatures2d_PCTSignatures_create_13(initSamplingPoints_mat.nativeObj, initClusterSeedIndexes_mat.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  float getDropThreshold()
        //

        //javadoc: PCTSignatures::getDropThreshold()
        public float getDropThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getDropThreshold_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getJoiningDistance()
        //

        //javadoc: PCTSignatures::getJoiningDistance()
        public float getJoiningDistance ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getJoiningDistance_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getWeightA()
        //

        //javadoc: PCTSignatures::getWeightA()
        public float getWeightA ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightA_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getWeightB()
        //

        //javadoc: PCTSignatures::getWeightB()
        public float getWeightB ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightB_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getWeightContrast()
        //

        //javadoc: PCTSignatures::getWeightContrast()
        public float getWeightContrast ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightContrast_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getWeightEntropy()
        //

        //javadoc: PCTSignatures::getWeightEntropy()
        public float getWeightEntropy ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightEntropy_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getWeightL()
        //

        //javadoc: PCTSignatures::getWeightL()
        public float getWeightL ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightL_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getWeightX()
        //

        //javadoc: PCTSignatures::getWeightX()
        public float getWeightX ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightX_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getWeightY()
        //

        //javadoc: PCTSignatures::getWeightY()
        public float getWeightY ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xfeatures2d_PCTSignatures_getWeightY_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getClusterMinSize()
        //

        //javadoc: PCTSignatures::getClusterMinSize()
        public int getClusterMinSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getClusterMinSize_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getDistanceFunction()
        //

        //javadoc: PCTSignatures::getDistanceFunction()
        public int getDistanceFunction ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getDistanceFunction_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getGrayscaleBits()
        //

        //javadoc: PCTSignatures::getGrayscaleBits()
        public int getGrayscaleBits ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getGrayscaleBits_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getInitSeedCount()
        //

        //javadoc: PCTSignatures::getInitSeedCount()
        public int getInitSeedCount ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getInitSeedCount_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getIterationCount()
        //

        //javadoc: PCTSignatures::getIterationCount()
        public int getIterationCount ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getIterationCount_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMaxClustersCount()
        //

        //javadoc: PCTSignatures::getMaxClustersCount()
        public int getMaxClustersCount ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getMaxClustersCount_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getSampleCount()
        //

        //javadoc: PCTSignatures::getSampleCount()
        public int getSampleCount ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getSampleCount_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getWindowRadius()
        //

        //javadoc: PCTSignatures::getWindowRadius()
        public int getWindowRadius ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = xfeatures2d_PCTSignatures_getWindowRadius_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  vector_Point2f getSamplingPoints()
        //

        //javadoc: PCTSignatures::getSamplingPoints()
        public MatOfPoint2f getSamplingPoints ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MatOfPoint2f retVal = MatOfPoint2f.fromNativeAddr(xfeatures2d_PCTSignatures_getSamplingPoints_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  vector_int getInitSeedIndexes()
        //

        //javadoc: PCTSignatures::getInitSeedIndexes()
        public MatOfInt getInitSeedIndexes ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MatOfInt retVal = MatOfInt.fromNativeAddr(xfeatures2d_PCTSignatures_getInitSeedIndexes_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void computeSignature(Mat image, Mat& signature)
        //

        //javadoc: PCTSignatures::computeSignature(image, signature)
        public void computeSignature (Mat image, Mat signature)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (signature != null) signature.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_computeSignature_10(nativeObj, image.nativeObj, signature.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void computeSignatures(vector_Mat images, vector_Mat signatures)
        //

        //javadoc: PCTSignatures::computeSignatures(images, signatures)
        public void computeSignatures (List<Mat> images, List<Mat> signatures)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat images_mat = Converters.vector_Mat_to_Mat(images);
        Mat signatures_mat = Converters.vector_Mat_to_Mat(signatures);
        xfeatures2d_PCTSignatures_computeSignatures_10(nativeObj, images_mat.nativeObj, signatures_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: static void drawSignature(Mat source, Mat signature, Mat& result, float radiusToShorterSideRatio = 1.0 / 8, int borderThickness = 1)
        //

        //javadoc: PCTSignatures::drawSignature(source, signature, result, radiusToShorterSideRatio, borderThickness)
        public static void drawSignature (Mat source, Mat signature, Mat result, float radiusToShorterSideRatio, int borderThickness)
        {
            if (source != null) source.ThrowIfDisposed ();
            if (signature != null) signature.ThrowIfDisposed ();
            if (result != null) result.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_drawSignature_10(source.nativeObj, signature.nativeObj, result.nativeObj, radiusToShorterSideRatio, borderThickness);
        
#else
            return;
#endif
            return;
        }

        //javadoc: PCTSignatures::drawSignature(source, signature, result)
        public static void drawSignature (Mat source, Mat signature, Mat result)
        {
            if (source != null) source.ThrowIfDisposed ();
            if (signature != null) signature.ThrowIfDisposed ();
            if (result != null) result.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_drawSignature_11(source.nativeObj, signature.nativeObj, result.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: static void generateInitPoints(vector_Point2f initPoints, int count, int pointDistribution)
        //

        //javadoc: PCTSignatures::generateInitPoints(initPoints, count, pointDistribution)
        public static void generateInitPoints (MatOfPoint2f initPoints, int count, int pointDistribution)
        {
            if (initPoints != null) initPoints.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat initPoints_mat = initPoints;
        xfeatures2d_PCTSignatures_generateInitPoints_10(initPoints_mat.nativeObj, count, pointDistribution);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setClusterMinSize(int clusterMinSize)
        //

        //javadoc: PCTSignatures::setClusterMinSize(clusterMinSize)
        public void setClusterMinSize (int clusterMinSize)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setClusterMinSize_10(nativeObj, clusterMinSize);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setDistanceFunction(int distanceFunction)
        //

        //javadoc: PCTSignatures::setDistanceFunction(distanceFunction)
        public void setDistanceFunction (int distanceFunction)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setDistanceFunction_10(nativeObj, distanceFunction);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setDropThreshold(float dropThreshold)
        //

        //javadoc: PCTSignatures::setDropThreshold(dropThreshold)
        public void setDropThreshold (float dropThreshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setDropThreshold_10(nativeObj, dropThreshold);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setGrayscaleBits(int grayscaleBits)
        //

        //javadoc: PCTSignatures::setGrayscaleBits(grayscaleBits)
        public void setGrayscaleBits (int grayscaleBits)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setGrayscaleBits_10(nativeObj, grayscaleBits);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setInitSeedIndexes(vector_int initSeedIndexes)
        //

        //javadoc: PCTSignatures::setInitSeedIndexes(initSeedIndexes)
        public void setInitSeedIndexes (MatOfInt initSeedIndexes)
        {
            ThrowIfDisposed ();
            if (initSeedIndexes != null) initSeedIndexes.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat initSeedIndexes_mat = initSeedIndexes;
        xfeatures2d_PCTSignatures_setInitSeedIndexes_10(nativeObj, initSeedIndexes_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setIterationCount(int iterationCount)
        //

        //javadoc: PCTSignatures::setIterationCount(iterationCount)
        public void setIterationCount (int iterationCount)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setIterationCount_10(nativeObj, iterationCount);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setJoiningDistance(float joiningDistance)
        //

        //javadoc: PCTSignatures::setJoiningDistance(joiningDistance)
        public void setJoiningDistance (float joiningDistance)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setJoiningDistance_10(nativeObj, joiningDistance);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMaxClustersCount(int maxClustersCount)
        //

        //javadoc: PCTSignatures::setMaxClustersCount(maxClustersCount)
        public void setMaxClustersCount (int maxClustersCount)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setMaxClustersCount_10(nativeObj, maxClustersCount);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setSamplingPoints(vector_Point2f samplingPoints)
        //

        //javadoc: PCTSignatures::setSamplingPoints(samplingPoints)
        public void setSamplingPoints (MatOfPoint2f samplingPoints)
        {
            ThrowIfDisposed ();
            if (samplingPoints != null) samplingPoints.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat samplingPoints_mat = samplingPoints;
        xfeatures2d_PCTSignatures_setSamplingPoints_10(nativeObj, samplingPoints_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setTranslation(int idx, float value)
        //

        //javadoc: PCTSignatures::setTranslation(idx, value)
        public void setTranslation (int idx, float value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setTranslation_10(nativeObj, idx, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setTranslations(vector_float translations)
        //

        //javadoc: PCTSignatures::setTranslations(translations)
        public void setTranslations (MatOfFloat translations)
        {
            ThrowIfDisposed ();
            if (translations != null) translations.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat translations_mat = translations;
        xfeatures2d_PCTSignatures_setTranslations_10(nativeObj, translations_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWeight(int idx, float value)
        //

        //javadoc: PCTSignatures::setWeight(idx, value)
        public void setWeight (int idx, float value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeight_10(nativeObj, idx, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWeightA(float weight)
        //

        //javadoc: PCTSignatures::setWeightA(weight)
        public void setWeightA (float weight)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightA_10(nativeObj, weight);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWeightB(float weight)
        //

        //javadoc: PCTSignatures::setWeightB(weight)
        public void setWeightB (float weight)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightB_10(nativeObj, weight);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWeightContrast(float weight)
        //

        //javadoc: PCTSignatures::setWeightContrast(weight)
        public void setWeightContrast (float weight)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightContrast_10(nativeObj, weight);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWeightEntropy(float weight)
        //

        //javadoc: PCTSignatures::setWeightEntropy(weight)
        public void setWeightEntropy (float weight)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightEntropy_10(nativeObj, weight);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWeightL(float weight)
        //

        //javadoc: PCTSignatures::setWeightL(weight)
        public void setWeightL (float weight)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightL_10(nativeObj, weight);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWeightX(float weight)
        //

        //javadoc: PCTSignatures::setWeightX(weight)
        public void setWeightX (float weight)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightX_10(nativeObj, weight);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWeightY(float weight)
        //

        //javadoc: PCTSignatures::setWeightY(weight)
        public void setWeightY (float weight)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWeightY_10(nativeObj, weight);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWeights(vector_float weights)
        //

        //javadoc: PCTSignatures::setWeights(weights)
        public void setWeights (MatOfFloat weights)
        {
            ThrowIfDisposed ();
            if (weights != null) weights.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat weights_mat = weights;
        xfeatures2d_PCTSignatures_setWeights_10(nativeObj, weights_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWindowRadius(int radius)
        //

        //javadoc: PCTSignatures::setWindowRadius(radius)
        public void setWindowRadius (int radius)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xfeatures2d_PCTSignatures_setWindowRadius_10(nativeObj, radius);
        
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



        // C++: static Ptr_PCTSignatures create(int initSampleCount = 2000, int initSeedCount = 400, int pointDistribution = 0)
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_10 (int initSampleCount, int initSeedCount, int pointDistribution);
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_11 ();

        // C++: static Ptr_PCTSignatures create(vector_Point2f initSamplingPoints, int initSeedCount)
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_12 (IntPtr initSamplingPoints_mat_nativeObj, int initSeedCount);

        // C++: static Ptr_PCTSignatures create(vector_Point2f initSamplingPoints, vector_int initClusterSeedIndexes)
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_create_13 (IntPtr initSamplingPoints_mat_nativeObj, IntPtr initClusterSeedIndexes_mat_nativeObj);

        // C++:  float getDropThreshold()
        [DllImport (LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getDropThreshold_10 (IntPtr nativeObj);

        // C++:  float getJoiningDistance()
        [DllImport (LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getJoiningDistance_10 (IntPtr nativeObj);

        // C++:  float getWeightA()
        [DllImport (LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightA_10 (IntPtr nativeObj);

        // C++:  float getWeightB()
        [DllImport (LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightB_10 (IntPtr nativeObj);

        // C++:  float getWeightContrast()
        [DllImport (LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightContrast_10 (IntPtr nativeObj);

        // C++:  float getWeightEntropy()
        [DllImport (LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightEntropy_10 (IntPtr nativeObj);

        // C++:  float getWeightL()
        [DllImport (LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightL_10 (IntPtr nativeObj);

        // C++:  float getWeightX()
        [DllImport (LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightX_10 (IntPtr nativeObj);

        // C++:  float getWeightY()
        [DllImport (LIBNAME)]
        private static extern float xfeatures2d_PCTSignatures_getWeightY_10 (IntPtr nativeObj);

        // C++:  int getClusterMinSize()
        [DllImport (LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getClusterMinSize_10 (IntPtr nativeObj);

        // C++:  int getDistanceFunction()
        [DllImport (LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getDistanceFunction_10 (IntPtr nativeObj);

        // C++:  int getGrayscaleBits()
        [DllImport (LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getGrayscaleBits_10 (IntPtr nativeObj);

        // C++:  int getInitSeedCount()
        [DllImport (LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getInitSeedCount_10 (IntPtr nativeObj);

        // C++:  int getIterationCount()
        [DllImport (LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getIterationCount_10 (IntPtr nativeObj);

        // C++:  int getMaxClustersCount()
        [DllImport (LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getMaxClustersCount_10 (IntPtr nativeObj);

        // C++:  int getSampleCount()
        [DllImport (LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getSampleCount_10 (IntPtr nativeObj);

        // C++:  int getWindowRadius()
        [DllImport (LIBNAME)]
        private static extern int xfeatures2d_PCTSignatures_getWindowRadius_10 (IntPtr nativeObj);

        // C++:  vector_Point2f getSamplingPoints()
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_getSamplingPoints_10 (IntPtr nativeObj);

        // C++:  vector_int getInitSeedIndexes()
        [DllImport (LIBNAME)]
        private static extern IntPtr xfeatures2d_PCTSignatures_getInitSeedIndexes_10 (IntPtr nativeObj);

        // C++:  void computeSignature(Mat image, Mat& signature)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_computeSignature_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr signature_nativeObj);

        // C++:  void computeSignatures(vector_Mat images, vector_Mat signatures)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_computeSignatures_10 (IntPtr nativeObj, IntPtr images_mat_nativeObj, IntPtr signatures_mat_nativeObj);

        // C++: static void drawSignature(Mat source, Mat signature, Mat& result, float radiusToShorterSideRatio = 1.0 / 8, int borderThickness = 1)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_drawSignature_10 (IntPtr source_nativeObj, IntPtr signature_nativeObj, IntPtr result_nativeObj, float radiusToShorterSideRatio, int borderThickness);
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_drawSignature_11 (IntPtr source_nativeObj, IntPtr signature_nativeObj, IntPtr result_nativeObj);

        // C++: static void generateInitPoints(vector_Point2f initPoints, int count, int pointDistribution)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_generateInitPoints_10 (IntPtr initPoints_mat_nativeObj, int count, int pointDistribution);

        // C++:  void setClusterMinSize(int clusterMinSize)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setClusterMinSize_10 (IntPtr nativeObj, int clusterMinSize);

        // C++:  void setDistanceFunction(int distanceFunction)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setDistanceFunction_10 (IntPtr nativeObj, int distanceFunction);

        // C++:  void setDropThreshold(float dropThreshold)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setDropThreshold_10 (IntPtr nativeObj, float dropThreshold);

        // C++:  void setGrayscaleBits(int grayscaleBits)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setGrayscaleBits_10 (IntPtr nativeObj, int grayscaleBits);

        // C++:  void setInitSeedIndexes(vector_int initSeedIndexes)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setInitSeedIndexes_10 (IntPtr nativeObj, IntPtr initSeedIndexes_mat_nativeObj);

        // C++:  void setIterationCount(int iterationCount)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setIterationCount_10 (IntPtr nativeObj, int iterationCount);

        // C++:  void setJoiningDistance(float joiningDistance)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setJoiningDistance_10 (IntPtr nativeObj, float joiningDistance);

        // C++:  void setMaxClustersCount(int maxClustersCount)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setMaxClustersCount_10 (IntPtr nativeObj, int maxClustersCount);

        // C++:  void setSamplingPoints(vector_Point2f samplingPoints)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setSamplingPoints_10 (IntPtr nativeObj, IntPtr samplingPoints_mat_nativeObj);

        // C++:  void setTranslation(int idx, float value)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setTranslation_10 (IntPtr nativeObj, int idx, float value);

        // C++:  void setTranslations(vector_float translations)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setTranslations_10 (IntPtr nativeObj, IntPtr translations_mat_nativeObj);

        // C++:  void setWeight(int idx, float value)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeight_10 (IntPtr nativeObj, int idx, float value);

        // C++:  void setWeightA(float weight)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightA_10 (IntPtr nativeObj, float weight);

        // C++:  void setWeightB(float weight)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightB_10 (IntPtr nativeObj, float weight);

        // C++:  void setWeightContrast(float weight)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightContrast_10 (IntPtr nativeObj, float weight);

        // C++:  void setWeightEntropy(float weight)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightEntropy_10 (IntPtr nativeObj, float weight);

        // C++:  void setWeightL(float weight)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightL_10 (IntPtr nativeObj, float weight);

        // C++:  void setWeightX(float weight)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightX_10 (IntPtr nativeObj, float weight);

        // C++:  void setWeightY(float weight)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeightY_10 (IntPtr nativeObj, float weight);

        // C++:  void setWeights(vector_float weights)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWeights_10 (IntPtr nativeObj, IntPtr weights_mat_nativeObj);

        // C++:  void setWindowRadius(int radius)
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_setWindowRadius_10 (IntPtr nativeObj, int radius);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void xfeatures2d_PCTSignatures_delete (IntPtr nativeObj);

    }
}
