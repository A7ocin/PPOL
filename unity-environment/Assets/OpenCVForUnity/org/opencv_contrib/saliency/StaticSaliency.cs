

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class StaticSaliency
    //javadoc: StaticSaliency

    public class StaticSaliency : Saliency
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
saliency_StaticSaliency_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal StaticSaliency (IntPtr addr) : base (addr) { }


        //
        // C++:  bool computeBinaryMap(Mat _saliencyMap, Mat& _binaryMap)
        //

        //javadoc: StaticSaliency::computeBinaryMap(_saliencyMap, _binaryMap)
        public bool computeBinaryMap (Mat _saliencyMap, Mat _binaryMap)
        {
            ThrowIfDisposed ();
            if (_saliencyMap != null) _saliencyMap.ThrowIfDisposed ();
            if (_binaryMap != null) _binaryMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = saliency_StaticSaliency_computeBinaryMap_10(nativeObj, _saliencyMap.nativeObj, _binaryMap.nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  bool computeBinaryMap(Mat _saliencyMap, Mat& _binaryMap)
        [DllImport (LIBNAME)]
        private static extern bool saliency_StaticSaliency_computeBinaryMap_10 (IntPtr nativeObj, IntPtr _saliencyMap_nativeObj, IntPtr _binaryMap_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void saliency_StaticSaliency_delete (IntPtr nativeObj);

    }
}
