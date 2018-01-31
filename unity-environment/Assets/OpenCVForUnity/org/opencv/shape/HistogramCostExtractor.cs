

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class HistogramCostExtractor
    //javadoc: HistogramCostExtractor

    public class HistogramCostExtractor : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
shape_HistogramCostExtractor_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal HistogramCostExtractor (IntPtr addr) : base (addr) { }


        //
        // C++:  float getDefaultCost()
        //

        //javadoc: HistogramCostExtractor::getDefaultCost()
        public float getDefaultCost ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = shape_HistogramCostExtractor_getDefaultCost_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNDummies()
        //

        //javadoc: HistogramCostExtractor::getNDummies()
        public int getNDummies ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = shape_HistogramCostExtractor_getNDummies_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void buildCostMatrix(Mat descriptors1, Mat descriptors2, Mat& costMatrix)
        //

        //javadoc: HistogramCostExtractor::buildCostMatrix(descriptors1, descriptors2, costMatrix)
        public void buildCostMatrix (Mat descriptors1, Mat descriptors2, Mat costMatrix)
        {
            ThrowIfDisposed ();
            if (descriptors1 != null) descriptors1.ThrowIfDisposed ();
            if (descriptors2 != null) descriptors2.ThrowIfDisposed ();
            if (costMatrix != null) costMatrix.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_HistogramCostExtractor_buildCostMatrix_10(nativeObj, descriptors1.nativeObj, descriptors2.nativeObj, costMatrix.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setDefaultCost(float defaultCost)
        //

        //javadoc: HistogramCostExtractor::setDefaultCost(defaultCost)
        public void setDefaultCost (float defaultCost)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_HistogramCostExtractor_setDefaultCost_10(nativeObj, defaultCost);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setNDummies(int nDummies)
        //

        //javadoc: HistogramCostExtractor::setNDummies(nDummies)
        public void setNDummies (int nDummies)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_HistogramCostExtractor_setNDummies_10(nativeObj, nDummies);
        
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



        // C++:  float getDefaultCost()
        [DllImport (LIBNAME)]
        private static extern float shape_HistogramCostExtractor_getDefaultCost_10 (IntPtr nativeObj);

        // C++:  int getNDummies()
        [DllImport (LIBNAME)]
        private static extern int shape_HistogramCostExtractor_getNDummies_10 (IntPtr nativeObj);

        // C++:  void buildCostMatrix(Mat descriptors1, Mat descriptors2, Mat& costMatrix)
        [DllImport (LIBNAME)]
        private static extern void shape_HistogramCostExtractor_buildCostMatrix_10 (IntPtr nativeObj, IntPtr descriptors1_nativeObj, IntPtr descriptors2_nativeObj, IntPtr costMatrix_nativeObj);

        // C++:  void setDefaultCost(float defaultCost)
        [DllImport (LIBNAME)]
        private static extern void shape_HistogramCostExtractor_setDefaultCost_10 (IntPtr nativeObj, float defaultCost);

        // C++:  void setNDummies(int nDummies)
        [DllImport (LIBNAME)]
        private static extern void shape_HistogramCostExtractor_setNDummies_10 (IntPtr nativeObj, int nDummies);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void shape_HistogramCostExtractor_delete (IntPtr nativeObj);

    }
}
