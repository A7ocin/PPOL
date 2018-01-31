

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class AffineTransformer
    //javadoc: AffineTransformer

    public class AffineTransformer : ShapeTransformer
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
shape_AffineTransformer_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal AffineTransformer (IntPtr addr) : base (addr) { }


        //
        // C++:  bool getFullAffine()
        //

        //javadoc: AffineTransformer::getFullAffine()
        public bool getFullAffine ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = shape_AffineTransformer_getFullAffine_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  void setFullAffine(bool fullAffine)
        //

        //javadoc: AffineTransformer::setFullAffine(fullAffine)
        public void setFullAffine (bool fullAffine)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_AffineTransformer_setFullAffine_10(nativeObj, fullAffine);
        
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



        // C++:  bool getFullAffine()
        [DllImport (LIBNAME)]
        private static extern bool shape_AffineTransformer_getFullAffine_10 (IntPtr nativeObj);

        // C++:  void setFullAffine(bool fullAffine)
        [DllImport (LIBNAME)]
        private static extern void shape_AffineTransformer_setFullAffine_10 (IntPtr nativeObj, bool fullAffine);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void shape_AffineTransformer_delete (IntPtr nativeObj);

    }
}
