

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class KalmanFilter
    //javadoc: KalmanFilter

    public class KalmanFilter : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
video_KalmanFilter_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal KalmanFilter (IntPtr addr) : base (addr) { }


        public IntPtr getNativeObjAddr () { return nativeObj; }

        //
        // C++:   KalmanFilter(int dynamParams, int measureParams, int controlParams = 0, int type = CV_32F)
        //

        //javadoc: KalmanFilter::KalmanFilter(dynamParams, measureParams, controlParams, type)
        public KalmanFilter (int dynamParams, int measureParams, int controlParams, int type)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = video_KalmanFilter_KalmanFilter_10(dynamParams, measureParams, controlParams, type);
        
#else
            return null;
#endif
            return;
        }

        //javadoc: KalmanFilter::KalmanFilter(dynamParams, measureParams)
        public KalmanFilter (int dynamParams, int measureParams)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = video_KalmanFilter_KalmanFilter_11(dynamParams, measureParams);
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:   KalmanFilter()
        //

        //javadoc: KalmanFilter::KalmanFilter()
        public KalmanFilter ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = video_KalmanFilter_KalmanFilter_12();
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:  Mat correct(Mat measurement)
        //

        //javadoc: KalmanFilter::correct(measurement)
        public Mat correct (Mat measurement)
        {
            ThrowIfDisposed ();
            if (measurement != null) measurement.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_KalmanFilter_correct_10(nativeObj, measurement.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Mat predict(Mat control = Mat())
        //

        //javadoc: KalmanFilter::predict(control)
        public Mat predict (Mat control)
        {
            ThrowIfDisposed ();
            if (control != null) control.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_KalmanFilter_predict_10(nativeObj, control.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: KalmanFilter::predict()
        public Mat predict ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_KalmanFilter_predict_11(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: Mat KalmanFilter::statePre
        //

        //javadoc: KalmanFilter::get_statePre()
        public Mat get_statePre ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_KalmanFilter_get_1statePre_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: void KalmanFilter::statePre
        //

        //javadoc: KalmanFilter::set_statePre(statePre)
        public void set_statePre (Mat statePre)
        {
            ThrowIfDisposed ();
            if (statePre != null) statePre.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_KalmanFilter_set_1statePre_10(nativeObj, statePre.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: Mat KalmanFilter::statePost
        //

        //javadoc: KalmanFilter::get_statePost()
        public Mat get_statePost ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_KalmanFilter_get_1statePost_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: void KalmanFilter::statePost
        //

        //javadoc: KalmanFilter::set_statePost(statePost)
        public void set_statePost (Mat statePost)
        {
            ThrowIfDisposed ();
            if (statePost != null) statePost.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_KalmanFilter_set_1statePost_10(nativeObj, statePost.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: Mat KalmanFilter::transitionMatrix
        //

        //javadoc: KalmanFilter::get_transitionMatrix()
        public Mat get_transitionMatrix ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_KalmanFilter_get_1transitionMatrix_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: void KalmanFilter::transitionMatrix
        //

        //javadoc: KalmanFilter::set_transitionMatrix(transitionMatrix)
        public void set_transitionMatrix (Mat transitionMatrix)
        {
            ThrowIfDisposed ();
            if (transitionMatrix != null) transitionMatrix.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_KalmanFilter_set_1transitionMatrix_10(nativeObj, transitionMatrix.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: Mat KalmanFilter::controlMatrix
        //

        //javadoc: KalmanFilter::get_controlMatrix()
        public Mat get_controlMatrix ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_KalmanFilter_get_1controlMatrix_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: void KalmanFilter::controlMatrix
        //

        //javadoc: KalmanFilter::set_controlMatrix(controlMatrix)
        public void set_controlMatrix (Mat controlMatrix)
        {
            ThrowIfDisposed ();
            if (controlMatrix != null) controlMatrix.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_KalmanFilter_set_1controlMatrix_10(nativeObj, controlMatrix.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: Mat KalmanFilter::measurementMatrix
        //

        //javadoc: KalmanFilter::get_measurementMatrix()
        public Mat get_measurementMatrix ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_KalmanFilter_get_1measurementMatrix_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: void KalmanFilter::measurementMatrix
        //

        //javadoc: KalmanFilter::set_measurementMatrix(measurementMatrix)
        public void set_measurementMatrix (Mat measurementMatrix)
        {
            ThrowIfDisposed ();
            if (measurementMatrix != null) measurementMatrix.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_KalmanFilter_set_1measurementMatrix_10(nativeObj, measurementMatrix.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: Mat KalmanFilter::processNoiseCov
        //

        //javadoc: KalmanFilter::get_processNoiseCov()
        public Mat get_processNoiseCov ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_KalmanFilter_get_1processNoiseCov_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: void KalmanFilter::processNoiseCov
        //

        //javadoc: KalmanFilter::set_processNoiseCov(processNoiseCov)
        public void set_processNoiseCov (Mat processNoiseCov)
        {
            ThrowIfDisposed ();
            if (processNoiseCov != null) processNoiseCov.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_KalmanFilter_set_1processNoiseCov_10(nativeObj, processNoiseCov.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: Mat KalmanFilter::measurementNoiseCov
        //

        //javadoc: KalmanFilter::get_measurementNoiseCov()
        public Mat get_measurementNoiseCov ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_KalmanFilter_get_1measurementNoiseCov_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: void KalmanFilter::measurementNoiseCov
        //

        //javadoc: KalmanFilter::set_measurementNoiseCov(measurementNoiseCov)
        public void set_measurementNoiseCov (Mat measurementNoiseCov)
        {
            ThrowIfDisposed ();
            if (measurementNoiseCov != null) measurementNoiseCov.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_KalmanFilter_set_1measurementNoiseCov_10(nativeObj, measurementNoiseCov.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: Mat KalmanFilter::errorCovPre
        //

        //javadoc: KalmanFilter::get_errorCovPre()
        public Mat get_errorCovPre ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_KalmanFilter_get_1errorCovPre_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: void KalmanFilter::errorCovPre
        //

        //javadoc: KalmanFilter::set_errorCovPre(errorCovPre)
        public void set_errorCovPre (Mat errorCovPre)
        {
            ThrowIfDisposed ();
            if (errorCovPre != null) errorCovPre.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_KalmanFilter_set_1errorCovPre_10(nativeObj, errorCovPre.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: Mat KalmanFilter::gain
        //

        //javadoc: KalmanFilter::get_gain()
        public Mat get_gain ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_KalmanFilter_get_1gain_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: void KalmanFilter::gain
        //

        //javadoc: KalmanFilter::set_gain(gain)
        public void set_gain (Mat gain)
        {
            ThrowIfDisposed ();
            if (gain != null) gain.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_KalmanFilter_set_1gain_10(nativeObj, gain.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: Mat KalmanFilter::errorCovPost
        //

        //javadoc: KalmanFilter::get_errorCovPost()
        public Mat get_errorCovPost ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(video_KalmanFilter_get_1errorCovPost_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: void KalmanFilter::errorCovPost
        //

        //javadoc: KalmanFilter::set_errorCovPost(errorCovPost)
        public void set_errorCovPost (Mat errorCovPost)
        {
            ThrowIfDisposed ();
            if (errorCovPost != null) errorCovPost.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_KalmanFilter_set_1errorCovPost_10(nativeObj, errorCovPost.nativeObj);
        
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



        // C++:   KalmanFilter(int dynamParams, int measureParams, int controlParams = 0, int type = CV_32F)
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_KalmanFilter_10 (int dynamParams, int measureParams, int controlParams, int type);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_KalmanFilter_11 (int dynamParams, int measureParams);

        // C++:   KalmanFilter()
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_KalmanFilter_12 ();

        // C++:  Mat correct(Mat measurement)
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_correct_10 (IntPtr nativeObj, IntPtr measurement_nativeObj);

        // C++:  Mat predict(Mat control = Mat())
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_predict_10 (IntPtr nativeObj, IntPtr control_nativeObj);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_predict_11 (IntPtr nativeObj);

        // C++: Mat KalmanFilter::statePre
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1statePre_10 (IntPtr nativeObj);

        // C++: void KalmanFilter::statePre
        [DllImport (LIBNAME)]
        private static extern void video_KalmanFilter_set_1statePre_10 (IntPtr nativeObj, IntPtr statePre_nativeObj);

        // C++: Mat KalmanFilter::statePost
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1statePost_10 (IntPtr nativeObj);

        // C++: void KalmanFilter::statePost
        [DllImport (LIBNAME)]
        private static extern void video_KalmanFilter_set_1statePost_10 (IntPtr nativeObj, IntPtr statePost_nativeObj);

        // C++: Mat KalmanFilter::transitionMatrix
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1transitionMatrix_10 (IntPtr nativeObj);

        // C++: void KalmanFilter::transitionMatrix
        [DllImport (LIBNAME)]
        private static extern void video_KalmanFilter_set_1transitionMatrix_10 (IntPtr nativeObj, IntPtr transitionMatrix_nativeObj);

        // C++: Mat KalmanFilter::controlMatrix
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1controlMatrix_10 (IntPtr nativeObj);

        // C++: void KalmanFilter::controlMatrix
        [DllImport (LIBNAME)]
        private static extern void video_KalmanFilter_set_1controlMatrix_10 (IntPtr nativeObj, IntPtr controlMatrix_nativeObj);

        // C++: Mat KalmanFilter::measurementMatrix
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1measurementMatrix_10 (IntPtr nativeObj);

        // C++: void KalmanFilter::measurementMatrix
        [DllImport (LIBNAME)]
        private static extern void video_KalmanFilter_set_1measurementMatrix_10 (IntPtr nativeObj, IntPtr measurementMatrix_nativeObj);

        // C++: Mat KalmanFilter::processNoiseCov
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1processNoiseCov_10 (IntPtr nativeObj);

        // C++: void KalmanFilter::processNoiseCov
        [DllImport (LIBNAME)]
        private static extern void video_KalmanFilter_set_1processNoiseCov_10 (IntPtr nativeObj, IntPtr processNoiseCov_nativeObj);

        // C++: Mat KalmanFilter::measurementNoiseCov
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1measurementNoiseCov_10 (IntPtr nativeObj);

        // C++: void KalmanFilter::measurementNoiseCov
        [DllImport (LIBNAME)]
        private static extern void video_KalmanFilter_set_1measurementNoiseCov_10 (IntPtr nativeObj, IntPtr measurementNoiseCov_nativeObj);

        // C++: Mat KalmanFilter::errorCovPre
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1errorCovPre_10 (IntPtr nativeObj);

        // C++: void KalmanFilter::errorCovPre
        [DllImport (LIBNAME)]
        private static extern void video_KalmanFilter_set_1errorCovPre_10 (IntPtr nativeObj, IntPtr errorCovPre_nativeObj);

        // C++: Mat KalmanFilter::gain
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1gain_10 (IntPtr nativeObj);

        // C++: void KalmanFilter::gain
        [DllImport (LIBNAME)]
        private static extern void video_KalmanFilter_set_1gain_10 (IntPtr nativeObj, IntPtr gain_nativeObj);

        // C++: Mat KalmanFilter::errorCovPost
        [DllImport (LIBNAME)]
        private static extern IntPtr video_KalmanFilter_get_1errorCovPost_10 (IntPtr nativeObj);

        // C++: void KalmanFilter::errorCovPost
        [DllImport (LIBNAME)]
        private static extern void video_KalmanFilter_set_1errorCovPost_10 (IntPtr nativeObj, IntPtr errorCovPost_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void video_KalmanFilter_delete (IntPtr nativeObj);

    }
}
