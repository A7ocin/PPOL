

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class BackgroundSubtractorMOG2
    //javadoc: BackgroundSubtractorMOG2

    public class BackgroundSubtractorMOG2 : BackgroundSubtractor
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        video_BackgroundSubtractorMOG2_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal BackgroundSubtractorMOG2 (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++:  bool getDetectShadows()
        //

        //javadoc: BackgroundSubtractorMOG2::getDetectShadows()
        public bool getDetectShadows ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = video_BackgroundSubtractorMOG2_getDetectShadows_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  double getBackgroundRatio()
        //

        //javadoc: BackgroundSubtractorMOG2::getBackgroundRatio()
        public double getBackgroundRatio ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = video_BackgroundSubtractorMOG2_getBackgroundRatio_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getComplexityReductionThreshold()
        //

        //javadoc: BackgroundSubtractorMOG2::getComplexityReductionThreshold()
        public double getComplexityReductionThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = video_BackgroundSubtractorMOG2_getComplexityReductionThreshold_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getShadowThreshold()
        //

        //javadoc: BackgroundSubtractorMOG2::getShadowThreshold()
        public double getShadowThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = video_BackgroundSubtractorMOG2_getShadowThreshold_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getVarInit()
        //

        //javadoc: BackgroundSubtractorMOG2::getVarInit()
        public double getVarInit ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = video_BackgroundSubtractorMOG2_getVarInit_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getVarMax()
        //

        //javadoc: BackgroundSubtractorMOG2::getVarMax()
        public double getVarMax ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = video_BackgroundSubtractorMOG2_getVarMax_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getVarMin()
        //

        //javadoc: BackgroundSubtractorMOG2::getVarMin()
        public double getVarMin ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = video_BackgroundSubtractorMOG2_getVarMin_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getVarThreshold()
        //

        //javadoc: BackgroundSubtractorMOG2::getVarThreshold()
        public double getVarThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = video_BackgroundSubtractorMOG2_getVarThreshold_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getVarThresholdGen()
        //

        //javadoc: BackgroundSubtractorMOG2::getVarThresholdGen()
        public double getVarThresholdGen ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = video_BackgroundSubtractorMOG2_getVarThresholdGen_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getHistory()
        //

        //javadoc: BackgroundSubtractorMOG2::getHistory()
        public int getHistory ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = video_BackgroundSubtractorMOG2_getHistory_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNMixtures()
        //

        //javadoc: BackgroundSubtractorMOG2::getNMixtures()
        public int getNMixtures ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = video_BackgroundSubtractorMOG2_getNMixtures_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getShadowValue()
        //

        //javadoc: BackgroundSubtractorMOG2::getShadowValue()
        public int getShadowValue ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = video_BackgroundSubtractorMOG2_getShadowValue_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void apply(Mat image, Mat& fgmask, double learningRate = -1)
        //

        //javadoc: BackgroundSubtractorMOG2::apply(image, fgmask, learningRate)
        public override void apply (Mat image, Mat fgmask, double learningRate)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (fgmask != null)
                fgmask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_apply_10 (nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);
        
#else
            return;
#endif
            return;
        }

        //javadoc: BackgroundSubtractorMOG2::apply(image, fgmask)
        public override void apply (Mat image, Mat fgmask)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (fgmask != null)
                fgmask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_apply_11 (nativeObj, image.nativeObj, fgmask.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setBackgroundRatio(double ratio)
        //

        //javadoc: BackgroundSubtractorMOG2::setBackgroundRatio(ratio)
        public void setBackgroundRatio (double ratio)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_setBackgroundRatio_10 (nativeObj, ratio);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setComplexityReductionThreshold(double ct)
        //

        //javadoc: BackgroundSubtractorMOG2::setComplexityReductionThreshold(ct)
        public void setComplexityReductionThreshold (double ct)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_setComplexityReductionThreshold_10 (nativeObj, ct);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setDetectShadows(bool detectShadows)
        //

        //javadoc: BackgroundSubtractorMOG2::setDetectShadows(detectShadows)
        public void setDetectShadows (bool detectShadows)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_setDetectShadows_10 (nativeObj, detectShadows);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setHistory(int history)
        //

        //javadoc: BackgroundSubtractorMOG2::setHistory(history)
        public void setHistory (int history)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_setHistory_10 (nativeObj, history);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setNMixtures(int nmixtures)
        //

        //javadoc: BackgroundSubtractorMOG2::setNMixtures(nmixtures)
        public void setNMixtures (int nmixtures)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_setNMixtures_10 (nativeObj, nmixtures);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setShadowThreshold(double threshold)
        //

        //javadoc: BackgroundSubtractorMOG2::setShadowThreshold(threshold)
        public void setShadowThreshold (double threshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_setShadowThreshold_10 (nativeObj, threshold);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setShadowValue(int value)
        //

        //javadoc: BackgroundSubtractorMOG2::setShadowValue(value)
        public void setShadowValue (int value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_setShadowValue_10 (nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setVarInit(double varInit)
        //

        //javadoc: BackgroundSubtractorMOG2::setVarInit(varInit)
        public void setVarInit (double varInit)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_setVarInit_10 (nativeObj, varInit);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setVarMax(double varMax)
        //

        //javadoc: BackgroundSubtractorMOG2::setVarMax(varMax)
        public void setVarMax (double varMax)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_setVarMax_10 (nativeObj, varMax);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setVarMin(double varMin)
        //

        //javadoc: BackgroundSubtractorMOG2::setVarMin(varMin)
        public void setVarMin (double varMin)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_setVarMin_10 (nativeObj, varMin);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setVarThreshold(double varThreshold)
        //

        //javadoc: BackgroundSubtractorMOG2::setVarThreshold(varThreshold)
        public void setVarThreshold (double varThreshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_setVarThreshold_10 (nativeObj, varThreshold);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setVarThresholdGen(double varThresholdGen)
        //

        //javadoc: BackgroundSubtractorMOG2::setVarThresholdGen(varThresholdGen)
        public void setVarThresholdGen (double varThresholdGen)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractorMOG2_setVarThresholdGen_10 (nativeObj, varThresholdGen);
        
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
        private static extern bool video_BackgroundSubtractorMOG2_getDetectShadows_10 (IntPtr nativeObj);

        // C++:  double getBackgroundRatio()
        [DllImport (LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getBackgroundRatio_10 (IntPtr nativeObj);

        // C++:  double getComplexityReductionThreshold()
        [DllImport (LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getComplexityReductionThreshold_10 (IntPtr nativeObj);

        // C++:  double getShadowThreshold()
        [DllImport (LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getShadowThreshold_10 (IntPtr nativeObj);

        // C++:  double getVarInit()
        [DllImport (LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarInit_10 (IntPtr nativeObj);

        // C++:  double getVarMax()
        [DllImport (LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarMax_10 (IntPtr nativeObj);

        // C++:  double getVarMin()
        [DllImport (LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarMin_10 (IntPtr nativeObj);

        // C++:  double getVarThreshold()
        [DllImport (LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarThreshold_10 (IntPtr nativeObj);

        // C++:  double getVarThresholdGen()
        [DllImport (LIBNAME)]
        private static extern double video_BackgroundSubtractorMOG2_getVarThresholdGen_10 (IntPtr nativeObj);

        // C++:  int getHistory()
        [DllImport (LIBNAME)]
        private static extern int video_BackgroundSubtractorMOG2_getHistory_10 (IntPtr nativeObj);

        // C++:  int getNMixtures()
        [DllImport (LIBNAME)]
        private static extern int video_BackgroundSubtractorMOG2_getNMixtures_10 (IntPtr nativeObj);

        // C++:  int getShadowValue()
        [DllImport (LIBNAME)]
        private static extern int video_BackgroundSubtractorMOG2_getShadowValue_10 (IntPtr nativeObj);

        // C++:  void apply(Mat image, Mat& fgmask, double learningRate = -1)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_apply_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);

        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_apply_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);

        // C++:  void setBackgroundRatio(double ratio)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setBackgroundRatio_10 (IntPtr nativeObj, double ratio);

        // C++:  void setComplexityReductionThreshold(double ct)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setComplexityReductionThreshold_10 (IntPtr nativeObj, double ct);

        // C++:  void setDetectShadows(bool detectShadows)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setDetectShadows_10 (IntPtr nativeObj, bool detectShadows);

        // C++:  void setHistory(int history)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setHistory_10 (IntPtr nativeObj, int history);

        // C++:  void setNMixtures(int nmixtures)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setNMixtures_10 (IntPtr nativeObj, int nmixtures);

        // C++:  void setShadowThreshold(double threshold)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setShadowThreshold_10 (IntPtr nativeObj, double threshold);

        // C++:  void setShadowValue(int value)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setShadowValue_10 (IntPtr nativeObj, int value);

        // C++:  void setVarInit(double varInit)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarInit_10 (IntPtr nativeObj, double varInit);

        // C++:  void setVarMax(double varMax)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarMax_10 (IntPtr nativeObj, double varMax);

        // C++:  void setVarMin(double varMin)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarMin_10 (IntPtr nativeObj, double varMin);

        // C++:  void setVarThreshold(double varThreshold)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarThreshold_10 (IntPtr nativeObj, double varThreshold);

        // C++:  void setVarThresholdGen(double varThresholdGen)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_setVarThresholdGen_10 (IntPtr nativeObj, double varThresholdGen);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractorMOG2_delete (IntPtr nativeObj);

    }
}
