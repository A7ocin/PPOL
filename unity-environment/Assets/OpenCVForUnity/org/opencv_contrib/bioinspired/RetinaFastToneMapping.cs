

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class RetinaFastToneMapping
    //javadoc: RetinaFastToneMapping

    public class RetinaFastToneMapping : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
bioinspired_RetinaFastToneMapping_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal RetinaFastToneMapping (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_RetinaFastToneMapping create(Size inputSize)
        //

        //javadoc: RetinaFastToneMapping::create(inputSize)
        public static RetinaFastToneMapping create (Size inputSize)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        RetinaFastToneMapping retVal = new RetinaFastToneMapping(bioinspired_RetinaFastToneMapping_create_10(inputSize.width, inputSize.height));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void applyFastToneMapping(Mat inputImage, Mat& outputToneMappedImage)
        //

        //javadoc: RetinaFastToneMapping::applyFastToneMapping(inputImage, outputToneMappedImage)
        public void applyFastToneMapping (Mat inputImage, Mat outputToneMappedImage)
        {
            ThrowIfDisposed ();
            if (inputImage != null) inputImage.ThrowIfDisposed ();
            if (outputToneMappedImage != null) outputToneMappedImage.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_RetinaFastToneMapping_applyFastToneMapping_10(nativeObj, inputImage.nativeObj, outputToneMappedImage.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setup(float photoreceptorsNeighborhoodRadius = 3.f, float ganglioncellsNeighborhoodRadius = 1.f, float meanLuminanceModulatorK = 1.f)
        //

        //javadoc: RetinaFastToneMapping::setup(photoreceptorsNeighborhoodRadius, ganglioncellsNeighborhoodRadius, meanLuminanceModulatorK)
        public void setup (float photoreceptorsNeighborhoodRadius, float ganglioncellsNeighborhoodRadius, float meanLuminanceModulatorK)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_RetinaFastToneMapping_setup_10(nativeObj, photoreceptorsNeighborhoodRadius, ganglioncellsNeighborhoodRadius, meanLuminanceModulatorK);
        
#else
            return;
#endif
            return;
        }

        //javadoc: RetinaFastToneMapping::setup()
        public void setup ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_RetinaFastToneMapping_setup_11(nativeObj);
        
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



        // C++: static Ptr_RetinaFastToneMapping create(Size inputSize)
        [DllImport (LIBNAME)]
        private static extern IntPtr bioinspired_RetinaFastToneMapping_create_10 (double inputSize_width, double inputSize_height);

        // C++:  void applyFastToneMapping(Mat inputImage, Mat& outputToneMappedImage)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_applyFastToneMapping_10 (IntPtr nativeObj, IntPtr inputImage_nativeObj, IntPtr outputToneMappedImage_nativeObj);

        // C++:  void setup(float photoreceptorsNeighborhoodRadius = 3.f, float ganglioncellsNeighborhoodRadius = 1.f, float meanLuminanceModulatorK = 1.f)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_setup_10 (IntPtr nativeObj, float photoreceptorsNeighborhoodRadius, float ganglioncellsNeighborhoodRadius, float meanLuminanceModulatorK);
        [DllImport (LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_setup_11 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void bioinspired_RetinaFastToneMapping_delete (IntPtr nativeObj);

    }
}
