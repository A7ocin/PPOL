

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class HOGDescriptor
    //javadoc: HOGDescriptor

    public class HOGDescriptor : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
objdetect_HOGDescriptor_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal HOGDescriptor (IntPtr addr) : base (addr) { }


        public IntPtr getNativeObjAddr () { return nativeObj; }

        public const int L2Hys = 0;
        public const int DEFAULT_NLEVELS = 64;
        //
        // C++:   HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture = 1, double _winSigma = -1, int _histogramNormType = HOGDescriptor::L2Hys, double _L2HysThreshold = 0.2, bool _gammaCorrection = false, int _nlevels = HOGDescriptor::DEFAULT_NLEVELS, bool _signedGradient = false)
        //

        //javadoc: HOGDescriptor::HOGDescriptor(_winSize, _blockSize, _blockStride, _cellSize, _nbins, _derivAperture, _winSigma, _histogramNormType, _L2HysThreshold, _gammaCorrection, _nlevels, _signedGradient)
        public HOGDescriptor (Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, bool _gammaCorrection, int _nlevels, bool _signedGradient)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = objdetect_HOGDescriptor_HOGDescriptor_10(_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins, _derivAperture, _winSigma, _histogramNormType, _L2HysThreshold, _gammaCorrection, _nlevels, _signedGradient);
        
#else
            return null;
#endif
            return;
        }

        //javadoc: HOGDescriptor::HOGDescriptor(_winSize, _blockSize, _blockStride, _cellSize, _nbins)
        public HOGDescriptor (Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = objdetect_HOGDescriptor_HOGDescriptor_11(_winSize.width, _winSize.height, _blockSize.width, _blockSize.height, _blockStride.width, _blockStride.height, _cellSize.width, _cellSize.height, _nbins);
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:   HOGDescriptor(String filename)
        //

        //javadoc: HOGDescriptor::HOGDescriptor(filename)
        public HOGDescriptor (string filename)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = objdetect_HOGDescriptor_HOGDescriptor_12(filename);
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:   HOGDescriptor()
        //

        //javadoc: HOGDescriptor::HOGDescriptor()
        public HOGDescriptor ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = objdetect_HOGDescriptor_HOGDescriptor_13();
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:  bool checkDetectorSize()
        //

        //javadoc: HOGDescriptor::checkDetectorSize()
        public bool checkDetectorSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_HOGDescriptor_checkDetectorSize_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool load(String filename, String objname = String())
        //

        //javadoc: HOGDescriptor::load(filename, objname)
        public bool load (string filename, string objname)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_HOGDescriptor_load_10(nativeObj, filename, objname);
        
#else
            return false;
#endif
            return retVal;
        }

        //javadoc: HOGDescriptor::load(filename)
        public bool load (string filename)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_HOGDescriptor_load_11(nativeObj, filename);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  double getWinSigma()
        //

        //javadoc: HOGDescriptor::getWinSigma()
        public double getWinSigma ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = objdetect_HOGDescriptor_getWinSigma_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  size_t getDescriptorSize()
        //

        //javadoc: HOGDescriptor::getDescriptorSize()
        public long getDescriptorSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        long retVal = objdetect_HOGDescriptor_getDescriptorSize_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: static vector_float getDaimlerPeopleDetector()
        //

        //javadoc: HOGDescriptor::getDaimlerPeopleDetector()
        public static MatOfFloat getDaimlerPeopleDetector ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MatOfFloat retVal = MatOfFloat.fromNativeAddr(objdetect_HOGDescriptor_getDaimlerPeopleDetector_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static vector_float getDefaultPeopleDetector()
        //

        //javadoc: HOGDescriptor::getDefaultPeopleDetector()
        public static MatOfFloat getDefaultPeopleDetector ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MatOfFloat retVal = MatOfFloat.fromNativeAddr(objdetect_HOGDescriptor_getDefaultPeopleDetector_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void compute(Mat img, vector_float& descriptors, Size winStride = Size(), Size padding = Size(), vector_Point locations = std::vector<Point>())
        //

        //javadoc: HOGDescriptor::compute(img, descriptors, winStride, padding, locations)
        public void compute (Mat img, MatOfFloat descriptors, Size winStride, Size padding, MatOfPoint locations)
        {
            ThrowIfDisposed ();
            if (img != null) img.ThrowIfDisposed ();
            if (descriptors != null) descriptors.ThrowIfDisposed ();
            if (locations != null) locations.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat descriptors_mat = descriptors;
        Mat locations_mat = locations;
        objdetect_HOGDescriptor_compute_10(nativeObj, img.nativeObj, descriptors_mat.nativeObj, winStride.width, winStride.height, padding.width, padding.height, locations_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: HOGDescriptor::compute(img, descriptors)
        public void compute (Mat img, MatOfFloat descriptors)
        {
            ThrowIfDisposed ();
            if (img != null) img.ThrowIfDisposed ();
            if (descriptors != null) descriptors.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat descriptors_mat = descriptors;
        objdetect_HOGDescriptor_compute_11(nativeObj, img.nativeObj, descriptors_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void computeGradient(Mat img, Mat& grad, Mat& angleOfs, Size paddingTL = Size(), Size paddingBR = Size())
        //

        //javadoc: HOGDescriptor::computeGradient(img, grad, angleOfs, paddingTL, paddingBR)
        public void computeGradient (Mat img, Mat grad, Mat angleOfs, Size paddingTL, Size paddingBR)
        {
            ThrowIfDisposed ();
            if (img != null) img.ThrowIfDisposed ();
            if (grad != null) grad.ThrowIfDisposed ();
            if (angleOfs != null) angleOfs.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        objdetect_HOGDescriptor_computeGradient_10(nativeObj, img.nativeObj, grad.nativeObj, angleOfs.nativeObj, paddingTL.width, paddingTL.height, paddingBR.width, paddingBR.height);
        
#else
            return;
#endif
            return;
        }

        //javadoc: HOGDescriptor::computeGradient(img, grad, angleOfs)
        public void computeGradient (Mat img, Mat grad, Mat angleOfs)
        {
            ThrowIfDisposed ();
            if (img != null) img.ThrowIfDisposed ();
            if (grad != null) grad.ThrowIfDisposed ();
            if (angleOfs != null) angleOfs.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        objdetect_HOGDescriptor_computeGradient_11(nativeObj, img.nativeObj, grad.nativeObj, angleOfs.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void detect(Mat img, vector_Point& foundLocations, vector_double& weights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), vector_Point searchLocations = std::vector<Point>())
        //

        //javadoc: HOGDescriptor::detect(img, foundLocations, weights, hitThreshold, winStride, padding, searchLocations)
        public void detect (Mat img, MatOfPoint foundLocations, MatOfDouble weights, double hitThreshold, Size winStride, Size padding, MatOfPoint searchLocations)
        {
            ThrowIfDisposed ();
            if (img != null) img.ThrowIfDisposed ();
            if (foundLocations != null) foundLocations.ThrowIfDisposed ();
            if (weights != null) weights.ThrowIfDisposed ();
            if (searchLocations != null) searchLocations.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat foundLocations_mat = foundLocations;
        Mat weights_mat = weights;
        Mat searchLocations_mat = searchLocations;
        objdetect_HOGDescriptor_detect_10(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, weights_mat.nativeObj, hitThreshold, winStride.width, winStride.height, padding.width, padding.height, searchLocations_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: HOGDescriptor::detect(img, foundLocations, weights)
        public void detect (Mat img, MatOfPoint foundLocations, MatOfDouble weights)
        {
            ThrowIfDisposed ();
            if (img != null) img.ThrowIfDisposed ();
            if (foundLocations != null) foundLocations.ThrowIfDisposed ();
            if (weights != null) weights.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat foundLocations_mat = foundLocations;
        Mat weights_mat = weights;
        objdetect_HOGDescriptor_detect_11(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, weights_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void detectMultiScale(Mat img, vector_Rect& foundLocations, vector_double& foundWeights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), double scale = 1.05, double finalThreshold = 2.0, bool useMeanshiftGrouping = false)
        //

        //javadoc: HOGDescriptor::detectMultiScale(img, foundLocations, foundWeights, hitThreshold, winStride, padding, scale, finalThreshold, useMeanshiftGrouping)
        public void detectMultiScale (Mat img, MatOfRect foundLocations, MatOfDouble foundWeights, double hitThreshold, Size winStride, Size padding, double scale, double finalThreshold, bool useMeanshiftGrouping)
        {
            ThrowIfDisposed ();
            if (img != null) img.ThrowIfDisposed ();
            if (foundLocations != null) foundLocations.ThrowIfDisposed ();
            if (foundWeights != null) foundWeights.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat foundLocations_mat = foundLocations;
        Mat foundWeights_mat = foundWeights;
        objdetect_HOGDescriptor_detectMultiScale_10(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, foundWeights_mat.nativeObj, hitThreshold, winStride.width, winStride.height, padding.width, padding.height, scale, finalThreshold, useMeanshiftGrouping);
        
#else
            return;
#endif
            return;
        }

        //javadoc: HOGDescriptor::detectMultiScale(img, foundLocations, foundWeights)
        public void detectMultiScale (Mat img, MatOfRect foundLocations, MatOfDouble foundWeights)
        {
            ThrowIfDisposed ();
            if (img != null) img.ThrowIfDisposed ();
            if (foundLocations != null) foundLocations.ThrowIfDisposed ();
            if (foundWeights != null) foundWeights.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat foundLocations_mat = foundLocations;
        Mat foundWeights_mat = foundWeights;
        objdetect_HOGDescriptor_detectMultiScale_11(nativeObj, img.nativeObj, foundLocations_mat.nativeObj, foundWeights_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void save(String filename, String objname = String())
        //

        //javadoc: HOGDescriptor::save(filename, objname)
        public void save (string filename, string objname)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        objdetect_HOGDescriptor_save_10(nativeObj, filename, objname);
        
#else
            return;
#endif
            return;
        }

        //javadoc: HOGDescriptor::save(filename)
        public void save (string filename)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        objdetect_HOGDescriptor_save_11(nativeObj, filename);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setSVMDetector(Mat _svmdetector)
        //

        //javadoc: HOGDescriptor::setSVMDetector(_svmdetector)
        public void setSVMDetector (Mat _svmdetector)
        {
            ThrowIfDisposed ();
            if (_svmdetector != null) _svmdetector.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        objdetect_HOGDescriptor_setSVMDetector_10(nativeObj, _svmdetector.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: Size HOGDescriptor::winSize
        //

        //javadoc: HOGDescriptor::get_winSize()
        public Size get_winSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
objdetect_HOGDescriptor_get_1winSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: Size HOGDescriptor::blockSize
        //

        //javadoc: HOGDescriptor::get_blockSize()
        public Size get_blockSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
objdetect_HOGDescriptor_get_1blockSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: Size HOGDescriptor::blockStride
        //

        //javadoc: HOGDescriptor::get_blockStride()
        public Size get_blockStride ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
objdetect_HOGDescriptor_get_1blockStride_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: Size HOGDescriptor::cellSize
        //

        //javadoc: HOGDescriptor::get_cellSize()
        public Size get_cellSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
objdetect_HOGDescriptor_get_1cellSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: int HOGDescriptor::nbins
        //

        //javadoc: HOGDescriptor::get_nbins()
        public int get_nbins ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = objdetect_HOGDescriptor_get_1nbins_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: int HOGDescriptor::derivAperture
        //

        //javadoc: HOGDescriptor::get_derivAperture()
        public int get_derivAperture ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = objdetect_HOGDescriptor_get_1derivAperture_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: double HOGDescriptor::winSigma
        //

        //javadoc: HOGDescriptor::get_winSigma()
        public double get_winSigma ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = objdetect_HOGDescriptor_get_1winSigma_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: int HOGDescriptor::histogramNormType
        //

        //javadoc: HOGDescriptor::get_histogramNormType()
        public int get_histogramNormType ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = objdetect_HOGDescriptor_get_1histogramNormType_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: double HOGDescriptor::L2HysThreshold
        //

        //javadoc: HOGDescriptor::get_L2HysThreshold()
        public double get_L2HysThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = objdetect_HOGDescriptor_get_1L2HysThreshold_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: bool HOGDescriptor::gammaCorrection
        //

        //javadoc: HOGDescriptor::get_gammaCorrection()
        public bool get_gammaCorrection ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_HOGDescriptor_get_1gammaCorrection_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++: vector_float HOGDescriptor::svmDetector
        //

        //javadoc: HOGDescriptor::get_svmDetector()
        public MatOfFloat get_svmDetector ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MatOfFloat retVal = MatOfFloat.fromNativeAddr(objdetect_HOGDescriptor_get_1svmDetector_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: int HOGDescriptor::nlevels
        //

        //javadoc: HOGDescriptor::get_nlevels()
        public int get_nlevels ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = objdetect_HOGDescriptor_get_1nlevels_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: bool HOGDescriptor::signedGradient
        //

        //javadoc: HOGDescriptor::get_signedGradient()
        public bool get_signedGradient ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_HOGDescriptor_get_1signedGradient_10(nativeObj);
        
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



        // C++:   HOGDescriptor(Size _winSize, Size _blockSize, Size _blockStride, Size _cellSize, int _nbins, int _derivAperture = 1, double _winSigma = -1, int _histogramNormType = HOGDescriptor::L2Hys, double _L2HysThreshold = 0.2, bool _gammaCorrection = false, int _nlevels = HOGDescriptor::DEFAULT_NLEVELS, bool _signedGradient = false)
        [DllImport (LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_10 (double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins, int _derivAperture, double _winSigma, int _histogramNormType, double _L2HysThreshold, bool _gammaCorrection, int _nlevels, bool _signedGradient);
        [DllImport (LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_11 (double _winSize_width, double _winSize_height, double _blockSize_width, double _blockSize_height, double _blockStride_width, double _blockStride_height, double _cellSize_width, double _cellSize_height, int _nbins);

        // C++:   HOGDescriptor(String filename)
        [DllImport (LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_12 (string filename);

        // C++:   HOGDescriptor()
        [DllImport (LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_HOGDescriptor_13 ();

        // C++:  bool checkDetectorSize()
        [DllImport (LIBNAME)]
        private static extern bool objdetect_HOGDescriptor_checkDetectorSize_10 (IntPtr nativeObj);

        // C++:  bool load(String filename, String objname = String())
        [DllImport (LIBNAME)]
        private static extern bool objdetect_HOGDescriptor_load_10 (IntPtr nativeObj, string filename, string objname);
        [DllImport (LIBNAME)]
        private static extern bool objdetect_HOGDescriptor_load_11 (IntPtr nativeObj, string filename);

        // C++:  double getWinSigma()
        [DllImport (LIBNAME)]
        private static extern double objdetect_HOGDescriptor_getWinSigma_10 (IntPtr nativeObj);

        // C++:  size_t getDescriptorSize()
        [DllImport (LIBNAME)]
        private static extern long objdetect_HOGDescriptor_getDescriptorSize_10 (IntPtr nativeObj);

        // C++: static vector_float getDaimlerPeopleDetector()
        [DllImport (LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_getDaimlerPeopleDetector_10 ();

        // C++: static vector_float getDefaultPeopleDetector()
        [DllImport (LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_getDefaultPeopleDetector_10 ();

        // C++:  void compute(Mat img, vector_float& descriptors, Size winStride = Size(), Size padding = Size(), vector_Point locations = std::vector<Point>())
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_compute_10 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr descriptors_mat_nativeObj, double winStride_width, double winStride_height, double padding_width, double padding_height, IntPtr locations_mat_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_compute_11 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr descriptors_mat_nativeObj);

        // C++:  void computeGradient(Mat img, Mat& grad, Mat& angleOfs, Size paddingTL = Size(), Size paddingBR = Size())
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_computeGradient_10 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr grad_nativeObj, IntPtr angleOfs_nativeObj, double paddingTL_width, double paddingTL_height, double paddingBR_width, double paddingBR_height);
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_computeGradient_11 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr grad_nativeObj, IntPtr angleOfs_nativeObj);

        // C++:  void detect(Mat img, vector_Point& foundLocations, vector_double& weights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), vector_Point searchLocations = std::vector<Point>())
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detect_10 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr weights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height, IntPtr searchLocations_mat_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detect_11 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr weights_mat_nativeObj);

        // C++:  void detectMultiScale(Mat img, vector_Rect& foundLocations, vector_double& foundWeights, double hitThreshold = 0, Size winStride = Size(), Size padding = Size(), double scale = 1.05, double finalThreshold = 2.0, bool useMeanshiftGrouping = false)
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detectMultiScale_10 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj, double hitThreshold, double winStride_width, double winStride_height, double padding_width, double padding_height, double scale, double finalThreshold, bool useMeanshiftGrouping);
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_detectMultiScale_11 (IntPtr nativeObj, IntPtr img_nativeObj, IntPtr foundLocations_mat_nativeObj, IntPtr foundWeights_mat_nativeObj);

        // C++:  void save(String filename, String objname = String())
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_save_10 (IntPtr nativeObj, string filename, string objname);
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_save_11 (IntPtr nativeObj, string filename);

        // C++:  void setSVMDetector(Mat _svmdetector)
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_setSVMDetector_10 (IntPtr nativeObj, IntPtr _svmdetector_nativeObj);

        // C++: Size HOGDescriptor::winSize
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_get_1winSize_10 (IntPtr nativeObj, double[] retVal);

        // C++: Size HOGDescriptor::blockSize
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_get_1blockSize_10 (IntPtr nativeObj, double[] retVal);

        // C++: Size HOGDescriptor::blockStride
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_get_1blockStride_10 (IntPtr nativeObj, double[] retVal);

        // C++: Size HOGDescriptor::cellSize
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_get_1cellSize_10 (IntPtr nativeObj, double[] retVal);

        // C++: int HOGDescriptor::nbins
        [DllImport (LIBNAME)]
        private static extern int objdetect_HOGDescriptor_get_1nbins_10 (IntPtr nativeObj);

        // C++: int HOGDescriptor::derivAperture
        [DllImport (LIBNAME)]
        private static extern int objdetect_HOGDescriptor_get_1derivAperture_10 (IntPtr nativeObj);

        // C++: double HOGDescriptor::winSigma
        [DllImport (LIBNAME)]
        private static extern double objdetect_HOGDescriptor_get_1winSigma_10 (IntPtr nativeObj);

        // C++: int HOGDescriptor::histogramNormType
        [DllImport (LIBNAME)]
        private static extern int objdetect_HOGDescriptor_get_1histogramNormType_10 (IntPtr nativeObj);

        // C++: double HOGDescriptor::L2HysThreshold
        [DllImport (LIBNAME)]
        private static extern double objdetect_HOGDescriptor_get_1L2HysThreshold_10 (IntPtr nativeObj);

        // C++: bool HOGDescriptor::gammaCorrection
        [DllImport (LIBNAME)]
        private static extern bool objdetect_HOGDescriptor_get_1gammaCorrection_10 (IntPtr nativeObj);

        // C++: vector_float HOGDescriptor::svmDetector
        [DllImport (LIBNAME)]
        private static extern IntPtr objdetect_HOGDescriptor_get_1svmDetector_10 (IntPtr nativeObj);

        // C++: int HOGDescriptor::nlevels
        [DllImport (LIBNAME)]
        private static extern int objdetect_HOGDescriptor_get_1nlevels_10 (IntPtr nativeObj);

        // C++: bool HOGDescriptor::signedGradient
        [DllImport (LIBNAME)]
        private static extern bool objdetect_HOGDescriptor_get_1signedGradient_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void objdetect_HOGDescriptor_delete (IntPtr nativeObj);

    }
}
