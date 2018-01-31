

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class HistogramPhaseUnwrapping
    //javadoc: HistogramPhaseUnwrapping

    public class HistogramPhaseUnwrapping : PhaseUnwrapping
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
phase_1unwrapping_HistogramPhaseUnwrapping_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal HistogramPhaseUnwrapping (IntPtr addr) : base (addr) { }


        //
        // C++:  void getInverseReliabilityMap(Mat& reliabilityMap)
        //

        //javadoc: HistogramPhaseUnwrapping::getInverseReliabilityMap(reliabilityMap)
        public void getInverseReliabilityMap (Mat reliabilityMap)
        {
            ThrowIfDisposed ();
            if (reliabilityMap != null) reliabilityMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        phase_1unwrapping_HistogramPhaseUnwrapping_getInverseReliabilityMap_10(nativeObj, reliabilityMap.nativeObj);
        
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



        // C++:  void getInverseReliabilityMap(Mat& reliabilityMap)
        [DllImport (LIBNAME)]
        private static extern void phase_1unwrapping_HistogramPhaseUnwrapping_getInverseReliabilityMap_10 (IntPtr nativeObj, IntPtr reliabilityMap_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void phase_1unwrapping_HistogramPhaseUnwrapping_delete (IntPtr nativeObj);

    }
}
