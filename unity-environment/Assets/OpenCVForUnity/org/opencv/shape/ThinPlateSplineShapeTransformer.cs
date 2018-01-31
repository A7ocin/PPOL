

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class ThinPlateSplineShapeTransformer
    //javadoc: ThinPlateSplineShapeTransformer

    public class ThinPlateSplineShapeTransformer : ShapeTransformer
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
shape_ThinPlateSplineShapeTransformer_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal ThinPlateSplineShapeTransformer (IntPtr addr) : base (addr) { }


        //
        // C++:  double getRegularizationParameter()
        //

        //javadoc: ThinPlateSplineShapeTransformer::getRegularizationParameter()
        public double getRegularizationParameter ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = shape_ThinPlateSplineShapeTransformer_getRegularizationParameter_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setRegularizationParameter(double beta)
        //

        //javadoc: ThinPlateSplineShapeTransformer::setRegularizationParameter(beta)
        public void setRegularizationParameter (double beta)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        shape_ThinPlateSplineShapeTransformer_setRegularizationParameter_10(nativeObj, beta);
        
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



        // C++:  double getRegularizationParameter()
        [DllImport (LIBNAME)]
        private static extern double shape_ThinPlateSplineShapeTransformer_getRegularizationParameter_10 (IntPtr nativeObj);

        // C++:  void setRegularizationParameter(double beta)
        [DllImport (LIBNAME)]
        private static extern void shape_ThinPlateSplineShapeTransformer_setRegularizationParameter_10 (IntPtr nativeObj, double beta);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void shape_ThinPlateSplineShapeTransformer_delete (IntPtr nativeObj);

    }
}
