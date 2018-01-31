

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class BackgroundSubtractorKNN
    //javadoc: BackgroundSubtractorKNN

    public class BackgroundSubtractorKNN : BackgroundSubtractor
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
video_BackgroundSubtractorKNN_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal BackgroundSubtractorKNN (IntPtr addr) : base (addr) { }


        //
        // C++:  bool getDetectShadows()
        //

        //javadoc: BackgroundSubtractorKNN::getDetectShadows()
        public bool getDetectShadows ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = video_BackgroundSubtractorKNN_getDetectShadows_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  double getDist2Threshold()
        //

        //javadoc: BackgroundSubtractorKNN::getDist2Threshold()
        public double getDist2Threshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_BackgroundSubtractorKNN_getDist2Threshold_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getShadowThreshold()
        //

        //javadoc: BackgroundSubtractorKNN::getShadowThreshold()
        public double getShadowThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_BackgroundSubtractorKNN_getShadowThreshold_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getHistory()
        //

        //javadoc: BackgroundSubtractorKNN::getHistory()
        public int getHistory ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_BackgroundSubtractorKNN_getHistory_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNSamples()
        //

        //javadoc: BackgroundSubtractorKNN::getNSamples()
        public int getNSamples ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_BackgroundSubtractorKNN_getNSamples_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getShadowValue()
        //

        //javadoc: BackgroundSubtractorKNN::getShadowValue()
        public int getShadowValue ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_BackgroundSubtractorKNN_getShadowValue_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getkNNSamples()
        //

        //javadoc: BackgroundSubtractorKNN::getkNNSamples()
        public int getkNNSamples ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_BackgroundSubtractorKNN_getkNNSamples_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setDetectShadows(bool detectShadows)
        //

        //javadoc: BackgroundSubtractorKNN::setDetectShadows(detectShadows)
        public void setDetectShadows (bool detectShadows)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorKNN_setDetectShadows_10(nativeObj, detectShadows);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setDist2Threshold(double _dist2Threshold)
        //

        //javadoc: BackgroundSubtractorKNN::setDist2Threshold(_dist2Threshold)
        public void setDist2Threshold (double _dist2Threshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorKNN_setDist2Threshold_10(nativeObj, _dist2Threshold);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setHistory(int history)
        //

        //javadoc: BackgroundSubtractorKNN::setHistory(history)
        public void setHistory (int history)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorKNN_setHistory_10(nativeObj, history);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setNSamples(int _nN)
        //

        //javadoc: BackgroundSubtractorKNN::setNSamples(_nN)
        public void setNSamples (int _nN)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorKNN_setNSamples_10(nativeObj, _nN);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setShadowThreshold(double threshold)
        //

        //javadoc: BackgroundSubtractorKNN::setShadowThreshold(threshold)
        public void setShadowThreshold (double threshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorKNN_setShadowThreshold_10(nativeObj, threshold);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setShadowValue(int value)
        //

        //javadoc: BackgroundSubtractorKNN::setShadowValue(value)
        public void setShadowValue (int value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorKNN_setShadowValue_10(nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setkNNSamples(int _nkNN)
        //

        //javadoc: BackgroundSubtractorKNN::setkNNSamples(_nkNN)
        public void setkNNSamples (int _nkNN)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_BackgroundSubtractorKNN_setkNNSamples_10(nativeObj, _nkNN);
        
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



        // C++:  bool getDetectShadows()
        [DllImport (LIBNAME)]
        private static extern bool video_BackgroundSubtractorKNN_getDetectShadows_10 (IntPtr nativeObj);

        // C++:  double getDist2Threshold()
        [DllImport (LIBNAME)]
        private static extern double video_BackgroundSubtractorKNN_getDist2Threshold_10 (IntPtr nativeObj);

        // C++:  double getShadowThreshold()
        [DllImport (LIBNAME)]
        private static extern double video_BackgroundSubtractorKNN_getShadowThreshold_10 (IntPtr nativeObj);

        // C++:  int getHistory()
        [DllImport (LIBNAME)]
        private static extern int video_BackgroundSubtractorKNN_getHistory_10 (IntPtr nativeObj);

        // C++:  int getNSamples()
        [DllImport (LIBNAME)]
        private static extern int video_BackgroundSubtractorKNN_getNSamples_10 (IntPtr nativeObj);

        // C++:  int getShadowValue()
        [DllImport (LIBNAME)]
        private static extern int video_BackgroundSubtractorKNN_getShadowValue_10 (IntPtr nativeObj);

        // C++:  int getkNNSamples()
        [DllImport (LIBNAME)]
        private static extern int video_BackgroundSubtractorKNN_getkNNSamples_10 (IntPtr nativeObj);

        // C++:  void setDetectShadows(bool detectShadows)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setDetectShadows_10 (IntPtr nativeObj, bool detectShadows);

        // C++:  void setDist2Threshold(double _dist2Threshold)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setDist2Threshold_10 (IntPtr nativeObj, double _dist2Threshold);

        // C++:  void setHistory(int history)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setHistory_10 (IntPtr nativeObj, int history);

        // C++:  void setNSamples(int _nN)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setNSamples_10 (IntPtr nativeObj, int _nN);

        // C++:  void setShadowThreshold(double threshold)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setShadowThreshold_10 (IntPtr nativeObj, double threshold);

        // C++:  void setShadowValue(int value)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setShadowValue_10 (IntPtr nativeObj, int value);

        // C++:  void setkNNSamples(int _nkNN)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_setkNNSamples_10 (IntPtr nativeObj, int _nkNN);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorKNN_delete (IntPtr nativeObj);

    }
}
