

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class EMDHistogramCostExtractor
    //javadoc: EMDHistogramCostExtractor

    public class EMDHistogramCostExtractor : HistogramCostExtractor
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
shape_EMDHistogramCostExtractor_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal EMDHistogramCostExtractor (IntPtr addr) : base (addr) { }


        //
        // C++:  int getNormFlag()
        //

        //javadoc: EMDHistogramCostExtractor::getNormFlag()
        public int getNormFlag ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = shape_EMDHistogramCostExtractor_getNormFlag_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setNormFlag(int flag)
        //

        //javadoc: EMDHistogramCostExtractor::setNormFlag(flag)
        public void setNormFlag (int flag)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_EMDHistogramCostExtractor_setNormFlag_10(nativeObj, flag);
        
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



        // C++:  int getNormFlag()
        [DllImport (LIBNAME)]
        private static extern int shape_EMDHistogramCostExtractor_getNormFlag_10 (IntPtr nativeObj);

        // C++:  void setNormFlag(int flag)
        [DllImport (LIBNAME)]
        private static extern void shape_EMDHistogramCostExtractor_setNormFlag_10 (IntPtr nativeObj, int flag);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void shape_EMDHistogramCostExtractor_delete (IntPtr nativeObj);

    }
}
