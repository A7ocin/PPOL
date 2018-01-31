

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class HausdorffDistanceExtractor
    //javadoc: HausdorffDistanceExtractor

    public class HausdorffDistanceExtractor : ShapeDistanceExtractor
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
shape_HausdorffDistanceExtractor_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal HausdorffDistanceExtractor (IntPtr addr) : base (addr) { }


        //
        // C++:  float getRankProportion()
        //

        //javadoc: HausdorffDistanceExtractor::getRankProportion()
        public float getRankProportion ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = shape_HausdorffDistanceExtractor_getRankProportion_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getDistanceFlag()
        //

        //javadoc: HausdorffDistanceExtractor::getDistanceFlag()
        public int getDistanceFlag ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = shape_HausdorffDistanceExtractor_getDistanceFlag_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setDistanceFlag(int distanceFlag)
        //

        //javadoc: HausdorffDistanceExtractor::setDistanceFlag(distanceFlag)
        public void setDistanceFlag (int distanceFlag)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_HausdorffDistanceExtractor_setDistanceFlag_10(nativeObj, distanceFlag);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setRankProportion(float rankProportion)
        //

        //javadoc: HausdorffDistanceExtractor::setRankProportion(rankProportion)
        public void setRankProportion (float rankProportion)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_HausdorffDistanceExtractor_setRankProportion_10(nativeObj, rankProportion);
        
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



        // C++:  float getRankProportion()
        [DllImport (LIBNAME)]
        private static extern float shape_HausdorffDistanceExtractor_getRankProportion_10 (IntPtr nativeObj);

        // C++:  int getDistanceFlag()
        [DllImport (LIBNAME)]
        private static extern int shape_HausdorffDistanceExtractor_getDistanceFlag_10 (IntPtr nativeObj);

        // C++:  void setDistanceFlag(int distanceFlag)
        [DllImport (LIBNAME)]
        private static extern void shape_HausdorffDistanceExtractor_setDistanceFlag_10 (IntPtr nativeObj, int distanceFlag);

        // C++:  void setRankProportion(float rankProportion)
        [DllImport (LIBNAME)]
        private static extern void shape_HausdorffDistanceExtractor_setRankProportion_10 (IntPtr nativeObj, float rankProportion);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void shape_HausdorffDistanceExtractor_delete (IntPtr nativeObj);

    }
}
