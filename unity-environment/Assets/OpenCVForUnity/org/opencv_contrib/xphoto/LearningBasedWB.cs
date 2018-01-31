

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class LearningBasedWB
    //javadoc: LearningBasedWB

    public class LearningBasedWB : WhiteBalancer
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
xphoto_LearningBasedWB_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal LearningBasedWB (IntPtr addr) : base (addr) { }


        //
        // C++:  float getSaturationThreshold()
        //

        //javadoc: LearningBasedWB::getSaturationThreshold()
        public float getSaturationThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = xphoto_LearningBasedWB_getSaturationThreshold_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getHistBinNum()
        //

        //javadoc: LearningBasedWB::getHistBinNum()
        public int getHistBinNum ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = xphoto_LearningBasedWB_getHistBinNum_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getRangeMaxVal()
        //

        //javadoc: LearningBasedWB::getRangeMaxVal()
        public int getRangeMaxVal ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = xphoto_LearningBasedWB_getRangeMaxVal_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void extractSimpleFeatures(Mat src, Mat& dst)
        //

        //javadoc: LearningBasedWB::extractSimpleFeatures(src, dst)
        public void extractSimpleFeatures (Mat src, Mat dst)
        {
            ThrowIfDisposed ();
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_LearningBasedWB_extractSimpleFeatures_10(nativeObj, src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setHistBinNum(int val)
        //

        //javadoc: LearningBasedWB::setHistBinNum(val)
        public void setHistBinNum (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_LearningBasedWB_setHistBinNum_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setRangeMaxVal(int val)
        //

        //javadoc: LearningBasedWB::setRangeMaxVal(val)
        public void setRangeMaxVal (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_LearningBasedWB_setRangeMaxVal_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setSaturationThreshold(float val)
        //

        //javadoc: LearningBasedWB::setSaturationThreshold(val)
        public void setSaturationThreshold (float val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        xphoto_LearningBasedWB_setSaturationThreshold_10(nativeObj, val);
        
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



        // C++:  float getSaturationThreshold()
        [DllImport (LIBNAME)]
        private static extern float xphoto_LearningBasedWB_getSaturationThreshold_10 (IntPtr nativeObj);

        // C++:  int getHistBinNum()
        [DllImport (LIBNAME)]
        private static extern int xphoto_LearningBasedWB_getHistBinNum_10 (IntPtr nativeObj);

        // C++:  int getRangeMaxVal()
        [DllImport (LIBNAME)]
        private static extern int xphoto_LearningBasedWB_getRangeMaxVal_10 (IntPtr nativeObj);

        // C++:  void extractSimpleFeatures(Mat src, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void xphoto_LearningBasedWB_extractSimpleFeatures_10 (IntPtr nativeObj, IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void setHistBinNum(int val)
        [DllImport (LIBNAME)]
        private static extern void xphoto_LearningBasedWB_setHistBinNum_10 (IntPtr nativeObj, int val);

        // C++:  void setRangeMaxVal(int val)
        [DllImport (LIBNAME)]
        private static extern void xphoto_LearningBasedWB_setRangeMaxVal_10 (IntPtr nativeObj, int val);

        // C++:  void setSaturationThreshold(float val)
        [DllImport (LIBNAME)]
        private static extern void xphoto_LearningBasedWB_setSaturationThreshold_10 (IntPtr nativeObj, float val);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void xphoto_LearningBasedWB_delete (IntPtr nativeObj);

    }
}
