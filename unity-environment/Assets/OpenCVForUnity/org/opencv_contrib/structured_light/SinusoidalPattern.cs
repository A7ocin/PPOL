

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class SinusoidalPattern
    //javadoc: SinusoidalPattern

    public class SinusoidalPattern : StructuredLightPattern
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
structured_1light_SinusoidalPattern_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal SinusoidalPattern (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_SinusoidalPattern create(Ptr_SinusoidalPattern_Params parameters = makePtr<SinusoidalPattern::Params>())
        //

        //javadoc: SinusoidalPattern::create()
        public static SinusoidalPattern create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SinusoidalPattern retVal = new SinusoidalPattern(structured_1light_SinusoidalPattern_create_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void computeDataModulationTerm(vector_Mat patternImages, Mat& dataModulationTerm, Mat shadowMask)
        //

        //javadoc: SinusoidalPattern::computeDataModulationTerm(patternImages, dataModulationTerm, shadowMask)
        public void computeDataModulationTerm (List<Mat> patternImages, Mat dataModulationTerm, Mat shadowMask)
        {
            ThrowIfDisposed ();
            if (dataModulationTerm != null) dataModulationTerm.ThrowIfDisposed ();
            if (shadowMask != null) shadowMask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat patternImages_mat = Converters.vector_Mat_to_Mat(patternImages);
        structured_1light_SinusoidalPattern_computeDataModulationTerm_10(nativeObj, patternImages_mat.nativeObj, dataModulationTerm.nativeObj, shadowMask.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void computePhaseMap(vector_Mat patternImages, Mat& wrappedPhaseMap, Mat& shadowMask = Mat(), Mat fundamental = Mat())
        //

        //javadoc: SinusoidalPattern::computePhaseMap(patternImages, wrappedPhaseMap, shadowMask, fundamental)
        public void computePhaseMap (List<Mat> patternImages, Mat wrappedPhaseMap, Mat shadowMask, Mat fundamental)
        {
            ThrowIfDisposed ();
            if (wrappedPhaseMap != null) wrappedPhaseMap.ThrowIfDisposed ();
            if (shadowMask != null) shadowMask.ThrowIfDisposed ();
            if (fundamental != null) fundamental.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat patternImages_mat = Converters.vector_Mat_to_Mat(patternImages);
        structured_1light_SinusoidalPattern_computePhaseMap_10(nativeObj, patternImages_mat.nativeObj, wrappedPhaseMap.nativeObj, shadowMask.nativeObj, fundamental.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: SinusoidalPattern::computePhaseMap(patternImages, wrappedPhaseMap)
        public void computePhaseMap (List<Mat> patternImages, Mat wrappedPhaseMap)
        {
            ThrowIfDisposed ();
            if (wrappedPhaseMap != null) wrappedPhaseMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat patternImages_mat = Converters.vector_Mat_to_Mat(patternImages);
        structured_1light_SinusoidalPattern_computePhaseMap_11(nativeObj, patternImages_mat.nativeObj, wrappedPhaseMap.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void findProCamMatches(Mat projUnwrappedPhaseMap, Mat camUnwrappedPhaseMap, vector_Mat& matches)
        //

        //javadoc: SinusoidalPattern::findProCamMatches(projUnwrappedPhaseMap, camUnwrappedPhaseMap, matches)
        public void findProCamMatches (Mat projUnwrappedPhaseMap, Mat camUnwrappedPhaseMap, List<Mat> matches)
        {
            ThrowIfDisposed ();
            if (projUnwrappedPhaseMap != null) projUnwrappedPhaseMap.ThrowIfDisposed ();
            if (camUnwrappedPhaseMap != null) camUnwrappedPhaseMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat matches_mat = new Mat();
        structured_1light_SinusoidalPattern_findProCamMatches_10(nativeObj, projUnwrappedPhaseMap.nativeObj, camUnwrappedPhaseMap.nativeObj, matches_mat.nativeObj);
        Converters.Mat_to_vector_Mat(matches_mat, matches);
        matches_mat.release();
#else
            return;
#endif
            return;
        }


        //
        // C++:  void unwrapPhaseMap(vector_Mat wrappedPhaseMap, Mat& unwrappedPhaseMap, Size camSize, Mat shadowMask = Mat())
        //

        //javadoc: SinusoidalPattern::unwrapPhaseMap(wrappedPhaseMap, unwrappedPhaseMap, camSize, shadowMask)
        public void unwrapPhaseMap (List<Mat> wrappedPhaseMap, Mat unwrappedPhaseMap, Size camSize, Mat shadowMask)
        {
            ThrowIfDisposed ();
            if (unwrappedPhaseMap != null) unwrappedPhaseMap.ThrowIfDisposed ();
            if (shadowMask != null) shadowMask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat wrappedPhaseMap_mat = Converters.vector_Mat_to_Mat(wrappedPhaseMap);
        structured_1light_SinusoidalPattern_unwrapPhaseMap_10(nativeObj, wrappedPhaseMap_mat.nativeObj, unwrappedPhaseMap.nativeObj, camSize.width, camSize.height, shadowMask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: SinusoidalPattern::unwrapPhaseMap(wrappedPhaseMap, unwrappedPhaseMap, camSize)
        public void unwrapPhaseMap (List<Mat> wrappedPhaseMap, Mat unwrappedPhaseMap, Size camSize)
        {
            ThrowIfDisposed ();
            if (unwrappedPhaseMap != null) unwrappedPhaseMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat wrappedPhaseMap_mat = Converters.vector_Mat_to_Mat(wrappedPhaseMap);
        structured_1light_SinusoidalPattern_unwrapPhaseMap_11(nativeObj, wrappedPhaseMap_mat.nativeObj, unwrappedPhaseMap.nativeObj, camSize.width, camSize.height);
        
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



        // C++: static Ptr_SinusoidalPattern create(Ptr_SinusoidalPattern_Params parameters = makePtr<SinusoidalPattern::Params>())
        [DllImport (LIBNAME)]
        private static extern IntPtr structured_1light_SinusoidalPattern_create_10 ();

        // C++:  void computeDataModulationTerm(vector_Mat patternImages, Mat& dataModulationTerm, Mat shadowMask)
        [DllImport (LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_computeDataModulationTerm_10 (IntPtr nativeObj, IntPtr patternImages_mat_nativeObj, IntPtr dataModulationTerm_nativeObj, IntPtr shadowMask_nativeObj);

        // C++:  void computePhaseMap(vector_Mat patternImages, Mat& wrappedPhaseMap, Mat& shadowMask = Mat(), Mat fundamental = Mat())
        [DllImport (LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_computePhaseMap_10 (IntPtr nativeObj, IntPtr patternImages_mat_nativeObj, IntPtr wrappedPhaseMap_nativeObj, IntPtr shadowMask_nativeObj, IntPtr fundamental_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_computePhaseMap_11 (IntPtr nativeObj, IntPtr patternImages_mat_nativeObj, IntPtr wrappedPhaseMap_nativeObj);

        // C++:  void findProCamMatches(Mat projUnwrappedPhaseMap, Mat camUnwrappedPhaseMap, vector_Mat& matches)
        [DllImport (LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_findProCamMatches_10 (IntPtr nativeObj, IntPtr projUnwrappedPhaseMap_nativeObj, IntPtr camUnwrappedPhaseMap_nativeObj, IntPtr matches_mat_nativeObj);

        // C++:  void unwrapPhaseMap(vector_Mat wrappedPhaseMap, Mat& unwrappedPhaseMap, Size camSize, Mat shadowMask = Mat())
        [DllImport (LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_unwrapPhaseMap_10 (IntPtr nativeObj, IntPtr wrappedPhaseMap_mat_nativeObj, IntPtr unwrappedPhaseMap_nativeObj, double camSize_width, double camSize_height, IntPtr shadowMask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_unwrapPhaseMap_11 (IntPtr nativeObj, IntPtr wrappedPhaseMap_mat_nativeObj, IntPtr unwrappedPhaseMap_nativeObj, double camSize_width, double camSize_height);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void structured_1light_SinusoidalPattern_delete (IntPtr nativeObj);

    }
}
