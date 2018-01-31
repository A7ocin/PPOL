

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Objdetect
    //javadoc: Objdetect

    public class Objdetect
    {

        public const int CASCADE_DO_CANNY_PRUNING = 1;
        public const int CASCADE_SCALE_IMAGE = 2;
        public const int CASCADE_FIND_BIGGEST_OBJECT = 4;
        public const int CASCADE_DO_ROUGH_SEARCH = 8;
        //
        // C++:  void groupRectangles(vector_Rect& rectList, vector_int& weights, int groupThreshold, double eps = 0.2)
        //

        //javadoc: groupRectangles(rectList, weights, groupThreshold, eps)
        public static void groupRectangles (MatOfRect rectList, MatOfInt weights, int groupThreshold, double eps)
        {
            if (rectList != null) rectList.ThrowIfDisposed ();
            if (weights != null) weights.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat rectList_mat = rectList;
        Mat weights_mat = weights;
        objdetect_Objdetect_groupRectangles_10(rectList_mat.nativeObj, weights_mat.nativeObj, groupThreshold, eps);
        
#else
            return;
#endif
            return;
        }

        //javadoc: groupRectangles(rectList, weights, groupThreshold)
        public static void groupRectangles (MatOfRect rectList, MatOfInt weights, int groupThreshold)
        {
            if (rectList != null) rectList.ThrowIfDisposed ();
            if (weights != null) weights.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat rectList_mat = rectList;
        Mat weights_mat = weights;
        objdetect_Objdetect_groupRectangles_11(rectList_mat.nativeObj, weights_mat.nativeObj, groupThreshold);
        
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



        // C++:  void groupRectangles(vector_Rect& rectList, vector_int& weights, int groupThreshold, double eps = 0.2)
        [DllImport (LIBNAME)]
        private static extern void objdetect_Objdetect_groupRectangles_10 (IntPtr rectList_mat_nativeObj, IntPtr weights_mat_nativeObj, int groupThreshold, double eps);
        [DllImport (LIBNAME)]
        private static extern void objdetect_Objdetect_groupRectangles_11 (IntPtr rectList_mat_nativeObj, IntPtr weights_mat_nativeObj, int groupThreshold);

    }
}
