

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class Retina
    //javadoc: Retina

    public class Retina : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
bioinspired_Retina_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal Retina (IntPtr addr) : base (addr) { }


        //
        // C++:  Mat getMagnoRAW()
        //

        //javadoc: Retina::getMagnoRAW()
        public Mat getMagnoRAW ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(bioinspired_Retina_getMagnoRAW_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Mat getParvoRAW()
        //

        //javadoc: Retina::getParvoRAW()
        public Mat getParvoRAW ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(bioinspired_Retina_getParvoRAW_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_Retina create(Size inputSize, bool colorMode, int colorSamplingMethod = RETINA_COLOR_BAYER, bool useRetinaLogSampling = false, float reductionFactor = 1.0f, float samplingStrenght = 10.0f)
        //

        //javadoc: Retina::create(inputSize, colorMode, colorSamplingMethod, useRetinaLogSampling, reductionFactor, samplingStrenght)
        public static Retina create (Size inputSize, bool colorMode, int colorSamplingMethod, bool useRetinaLogSampling, float reductionFactor, float samplingStrenght)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Retina retVal = new Retina(bioinspired_Retina_create_10(inputSize.width, inputSize.height, colorMode, colorSamplingMethod, useRetinaLogSampling, reductionFactor, samplingStrenght));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: Retina::create(inputSize, colorMode)
        public static Retina create (Size inputSize, bool colorMode)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Retina retVal = new Retina(bioinspired_Retina_create_11(inputSize.width, inputSize.height, colorMode));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_Retina create(Size inputSize)
        //

        //javadoc: Retina::create(inputSize)
        public static Retina create (Size inputSize)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Retina retVal = new Retina(bioinspired_Retina_create_12(inputSize.width, inputSize.height));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Size getInputSize()
        //

        //javadoc: Retina::getInputSize()
        public Size getInputSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
bioinspired_Retina_getInputSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Size getOutputSize()
        //

        //javadoc: Retina::getOutputSize()
        public Size getOutputSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
bioinspired_Retina_getOutputSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  String printSetup()
        //

        //javadoc: Retina::printSetup()
        public string printSetup ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (bioinspired_Retina_printSetup_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void activateContoursProcessing(bool activate)
        //

        //javadoc: Retina::activateContoursProcessing(activate)
        public void activateContoursProcessing (bool activate)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_activateContoursProcessing_10(nativeObj, activate);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void activateMovingContoursProcessing(bool activate)
        //

        //javadoc: Retina::activateMovingContoursProcessing(activate)
        public void activateMovingContoursProcessing (bool activate)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_activateMovingContoursProcessing_10(nativeObj, activate);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void applyFastToneMapping(Mat inputImage, Mat& outputToneMappedImage)
        //

        //javadoc: Retina::applyFastToneMapping(inputImage, outputToneMappedImage)
        public void applyFastToneMapping (Mat inputImage, Mat outputToneMappedImage)
        {
            ThrowIfDisposed ();
            if (inputImage != null) inputImage.ThrowIfDisposed ();
            if (outputToneMappedImage != null) outputToneMappedImage.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_applyFastToneMapping_10(nativeObj, inputImage.nativeObj, outputToneMappedImage.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void clearBuffers()
        //

        //javadoc: Retina::clearBuffers()
        public void clearBuffers ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_clearBuffers_10(nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getMagno(Mat& retinaOutput_magno)
        //

        //javadoc: Retina::getMagno(retinaOutput_magno)
        public void getMagno (Mat retinaOutput_magno)
        {
            ThrowIfDisposed ();
            if (retinaOutput_magno != null) retinaOutput_magno.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_getMagno_10(nativeObj, retinaOutput_magno.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getMagnoRAW(Mat& retinaOutput_magno)
        //

        //javadoc: Retina::getMagnoRAW(retinaOutput_magno)
        public void getMagnoRAW (Mat retinaOutput_magno)
        {
            ThrowIfDisposed ();
            if (retinaOutput_magno != null) retinaOutput_magno.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_getMagnoRAW_11(nativeObj, retinaOutput_magno.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getParvo(Mat& retinaOutput_parvo)
        //

        //javadoc: Retina::getParvo(retinaOutput_parvo)
        public void getParvo (Mat retinaOutput_parvo)
        {
            ThrowIfDisposed ();
            if (retinaOutput_parvo != null) retinaOutput_parvo.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_getParvo_10(nativeObj, retinaOutput_parvo.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getParvoRAW(Mat& retinaOutput_parvo)
        //

        //javadoc: Retina::getParvoRAW(retinaOutput_parvo)
        public void getParvoRAW (Mat retinaOutput_parvo)
        {
            ThrowIfDisposed ();
            if (retinaOutput_parvo != null) retinaOutput_parvo.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_getParvoRAW_11(nativeObj, retinaOutput_parvo.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void run(Mat inputImage)
        //

        //javadoc: Retina::run(inputImage)
        public void run (Mat inputImage)
        {
            ThrowIfDisposed ();
            if (inputImage != null) inputImage.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_run_10(nativeObj, inputImage.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setColorSaturation(bool saturateColors = true, float colorSaturationValue = 4.0f)
        //

        //javadoc: Retina::setColorSaturation(saturateColors, colorSaturationValue)
        public void setColorSaturation (bool saturateColors, float colorSaturationValue)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setColorSaturation_10(nativeObj, saturateColors, colorSaturationValue);
        
#else
            return;
#endif
            return;
        }

        //javadoc: Retina::setColorSaturation()
        public void setColorSaturation ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setColorSaturation_11(nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setup(String retinaParameterFile = "", bool applyDefaultSetupOnFailure = true)
        //

        //javadoc: Retina::setup(retinaParameterFile, applyDefaultSetupOnFailure)
        public void setup (string retinaParameterFile, bool applyDefaultSetupOnFailure)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setup_10(nativeObj, retinaParameterFile, applyDefaultSetupOnFailure);
        
#else
            return;
#endif
            return;
        }

        //javadoc: Retina::setup()
        public void setup ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setup_11(nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setupIPLMagnoChannel(bool normaliseOutput = true, float parasolCells_beta = 0.f, float parasolCells_tau = 0.f, float parasolCells_k = 7.f, float amacrinCellsTemporalCutFrequency = 1.2f, float V0CompressionParameter = 0.95f, float localAdaptintegration_tau = 0.f, float localAdaptintegration_k = 7.f)
        //

        //javadoc: Retina::setupIPLMagnoChannel(normaliseOutput, parasolCells_beta, parasolCells_tau, parasolCells_k, amacrinCellsTemporalCutFrequency, V0CompressionParameter, localAdaptintegration_tau, localAdaptintegration_k)
        public void setupIPLMagnoChannel (bool normaliseOutput, float parasolCells_beta, float parasolCells_tau, float parasolCells_k, float amacrinCellsTemporalCutFrequency, float V0CompressionParameter, float localAdaptintegration_tau, float localAdaptintegration_k)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupIPLMagnoChannel_10(nativeObj, normaliseOutput, parasolCells_beta, parasolCells_tau, parasolCells_k, amacrinCellsTemporalCutFrequency, V0CompressionParameter, localAdaptintegration_tau, localAdaptintegration_k);
        
#else
            return;
#endif
            return;
        }

        //javadoc: Retina::setupIPLMagnoChannel()
        public void setupIPLMagnoChannel ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupIPLMagnoChannel_11(nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setupOPLandIPLParvoChannel(bool colorMode = true, bool normaliseOutput = true, float photoreceptorsLocalAdaptationSensitivity = 0.7f, float photoreceptorsTemporalConstant = 0.5f, float photoreceptorsSpatialConstant = 0.53f, float horizontalCellsGain = 0.f, float HcellsTemporalConstant = 1.f, float HcellsSpatialConstant = 7.f, float ganglionCellsSensitivity = 0.7f)
        //

        //javadoc: Retina::setupOPLandIPLParvoChannel(colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant, photoreceptorsSpatialConstant, horizontalCellsGain, HcellsTemporalConstant, HcellsSpatialConstant, ganglionCellsSensitivity)
        public void setupOPLandIPLParvoChannel (bool colorMode, bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant, float photoreceptorsSpatialConstant, float horizontalCellsGain, float HcellsTemporalConstant, float HcellsSpatialConstant, float ganglionCellsSensitivity)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupOPLandIPLParvoChannel_10(nativeObj, colorMode, normaliseOutput, photoreceptorsLocalAdaptationSensitivity, photoreceptorsTemporalConstant, photoreceptorsSpatialConstant, horizontalCellsGain, HcellsTemporalConstant, HcellsSpatialConstant, ganglionCellsSensitivity);
        
#else
            return;
#endif
            return;
        }

        //javadoc: Retina::setupOPLandIPLParvoChannel()
        public void setupOPLandIPLParvoChannel ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_setupOPLandIPLParvoChannel_11(nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void write(String fs)
        //

        //javadoc: Retina::write(fs)
        public void write (string fs)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bioinspired_Retina_write_10(nativeObj, fs);
        
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



        // C++:  Mat getMagnoRAW()
        [DllImport (LIBNAME)]
        private static extern IntPtr bioinspired_Retina_getMagnoRAW_10 (IntPtr nativeObj);

        // C++:  Mat getParvoRAW()
        [DllImport (LIBNAME)]
        private static extern IntPtr bioinspired_Retina_getParvoRAW_10 (IntPtr nativeObj);

        // C++: static Ptr_Retina create(Size inputSize, bool colorMode, int colorSamplingMethod = RETINA_COLOR_BAYER, bool useRetinaLogSampling = false, float reductionFactor = 1.0f, float samplingStrenght = 10.0f)
        [DllImport (LIBNAME)]
        private static extern IntPtr bioinspired_Retina_create_10 (double inputSize_width, double inputSize_height, bool colorMode, int colorSamplingMethod, bool useRetinaLogSampling, float reductionFactor, float samplingStrenght);
        [DllImport (LIBNAME)]
        private static extern IntPtr bioinspired_Retina_create_11 (double inputSize_width, double inputSize_height, bool colorMode);

        // C++: static Ptr_Retina create(Size inputSize)
        [DllImport (LIBNAME)]
        private static extern IntPtr bioinspired_Retina_create_12 (double inputSize_width, double inputSize_height);

        // C++:  Size getInputSize()
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_getInputSize_10 (IntPtr nativeObj, double[] retVal);

        // C++:  Size getOutputSize()
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_getOutputSize_10 (IntPtr nativeObj, double[] retVal);

        // C++:  String printSetup()
        [DllImport (LIBNAME)]
        private static extern IntPtr bioinspired_Retina_printSetup_10 (IntPtr nativeObj);

        // C++:  void activateContoursProcessing(bool activate)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_activateContoursProcessing_10 (IntPtr nativeObj, bool activate);

        // C++:  void activateMovingContoursProcessing(bool activate)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_activateMovingContoursProcessing_10 (IntPtr nativeObj, bool activate);

        // C++:  void applyFastToneMapping(Mat inputImage, Mat& outputToneMappedImage)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_applyFastToneMapping_10 (IntPtr nativeObj, IntPtr inputImage_nativeObj, IntPtr outputToneMappedImage_nativeObj);

        // C++:  void clearBuffers()
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_clearBuffers_10 (IntPtr nativeObj);

        // C++:  void getMagno(Mat& retinaOutput_magno)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_getMagno_10 (IntPtr nativeObj, IntPtr retinaOutput_magno_nativeObj);

        // C++:  void getMagnoRAW(Mat& retinaOutput_magno)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_getMagnoRAW_11 (IntPtr nativeObj, IntPtr retinaOutput_magno_nativeObj);

        // C++:  void getParvo(Mat& retinaOutput_parvo)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_getParvo_10 (IntPtr nativeObj, IntPtr retinaOutput_parvo_nativeObj);

        // C++:  void getParvoRAW(Mat& retinaOutput_parvo)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_getParvoRAW_11 (IntPtr nativeObj, IntPtr retinaOutput_parvo_nativeObj);

        // C++:  void run(Mat inputImage)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_run_10 (IntPtr nativeObj, IntPtr inputImage_nativeObj);

        // C++:  void setColorSaturation(bool saturateColors = true, float colorSaturationValue = 4.0f)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_setColorSaturation_10 (IntPtr nativeObj, bool saturateColors, float colorSaturationValue);
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_setColorSaturation_11 (IntPtr nativeObj);

        // C++:  void setup(String retinaParameterFile = "", bool applyDefaultSetupOnFailure = true)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_setup_10 (IntPtr nativeObj, string retinaParameterFile, bool applyDefaultSetupOnFailure);
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_setup_11 (IntPtr nativeObj);

        // C++:  void setupIPLMagnoChannel(bool normaliseOutput = true, float parasolCells_beta = 0.f, float parasolCells_tau = 0.f, float parasolCells_k = 7.f, float amacrinCellsTemporalCutFrequency = 1.2f, float V0CompressionParameter = 0.95f, float localAdaptintegration_tau = 0.f, float localAdaptintegration_k = 7.f)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_setupIPLMagnoChannel_10 (IntPtr nativeObj, bool normaliseOutput, float parasolCells_beta, float parasolCells_tau, float parasolCells_k, float amacrinCellsTemporalCutFrequency, float V0CompressionParameter, float localAdaptintegration_tau, float localAdaptintegration_k);
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_setupIPLMagnoChannel_11 (IntPtr nativeObj);

        // C++:  void setupOPLandIPLParvoChannel(bool colorMode = true, bool normaliseOutput = true, float photoreceptorsLocalAdaptationSensitivity = 0.7f, float photoreceptorsTemporalConstant = 0.5f, float photoreceptorsSpatialConstant = 0.53f, float horizontalCellsGain = 0.f, float HcellsTemporalConstant = 1.f, float HcellsSpatialConstant = 7.f, float ganglionCellsSensitivity = 0.7f)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_setupOPLandIPLParvoChannel_10 (IntPtr nativeObj, bool colorMode, bool normaliseOutput, float photoreceptorsLocalAdaptationSensitivity, float photoreceptorsTemporalConstant, float photoreceptorsSpatialConstant, float horizontalCellsGain, float HcellsTemporalConstant, float HcellsSpatialConstant, float ganglionCellsSensitivity);
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_setupOPLandIPLParvoChannel_11 (IntPtr nativeObj);

        // C++:  void write(String fs)
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_write_10 (IntPtr nativeObj, string fs);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void bioinspired_Retina_delete (IntPtr nativeObj);

    }
}
