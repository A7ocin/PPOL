

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class PhaseUnwrapping
    //javadoc: PhaseUnwrapping

    public class PhaseUnwrapping : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
phase_1unwrapping_PhaseUnwrapping_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal PhaseUnwrapping (IntPtr addr) : base (addr) { }


        //
        // C++:  void unwrapPhaseMap(Mat wrappedPhaseMap, Mat& unwrappedPhaseMap, Mat shadowMask = Mat())
        //

        //javadoc: PhaseUnwrapping::unwrapPhaseMap(wrappedPhaseMap, unwrappedPhaseMap, shadowMask)
        public void unwrapPhaseMap (Mat wrappedPhaseMap, Mat unwrappedPhaseMap, Mat shadowMask)
        {
            ThrowIfDisposed ();
            if (wrappedPhaseMap != null) wrappedPhaseMap.ThrowIfDisposed ();
            if (unwrappedPhaseMap != null) unwrappedPhaseMap.ThrowIfDisposed ();
            if (shadowMask != null) shadowMask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        phase_1unwrapping_PhaseUnwrapping_unwrapPhaseMap_10(nativeObj, wrappedPhaseMap.nativeObj, unwrappedPhaseMap.nativeObj, shadowMask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: PhaseUnwrapping::unwrapPhaseMap(wrappedPhaseMap, unwrappedPhaseMap)
        public void unwrapPhaseMap (Mat wrappedPhaseMap, Mat unwrappedPhaseMap)
        {
            ThrowIfDisposed ();
            if (wrappedPhaseMap != null) wrappedPhaseMap.ThrowIfDisposed ();
            if (unwrappedPhaseMap != null) unwrappedPhaseMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        phase_1unwrapping_PhaseUnwrapping_unwrapPhaseMap_11(nativeObj, wrappedPhaseMap.nativeObj, unwrappedPhaseMap.nativeObj);
        
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



        // C++:  void unwrapPhaseMap(Mat wrappedPhaseMap, Mat& unwrappedPhaseMap, Mat shadowMask = Mat())
        [DllImport (LIBNAME)]
        private static extern void phase_1unwrapping_PhaseUnwrapping_unwrapPhaseMap_10 (IntPtr nativeObj, IntPtr wrappedPhaseMap_nativeObj, IntPtr unwrappedPhaseMap_nativeObj, IntPtr shadowMask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void phase_1unwrapping_PhaseUnwrapping_unwrapPhaseMap_11 (IntPtr nativeObj, IntPtr wrappedPhaseMap_nativeObj, IntPtr unwrappedPhaseMap_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void phase_1unwrapping_PhaseUnwrapping_delete (IntPtr nativeObj);

    }
}
