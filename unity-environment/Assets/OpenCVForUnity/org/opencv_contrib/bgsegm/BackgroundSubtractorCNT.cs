

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class BackgroundSubtractorCNT
    //javadoc: BackgroundSubtractorCNT

    public class BackgroundSubtractorCNT : BackgroundSubtractor
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        bgsegm_BackgroundSubtractorCNT_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal BackgroundSubtractorCNT (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++:  bool getIsParallel()
        //

        //javadoc: BackgroundSubtractorCNT::getIsParallel()
        public bool getIsParallel ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = bgsegm_BackgroundSubtractorCNT_getIsParallel_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool getUseHistory()
        //

        //javadoc: BackgroundSubtractorCNT::getUseHistory()
        public bool getUseHistory ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = bgsegm_BackgroundSubtractorCNT_getUseHistory_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  int getMaxPixelStability()
        //

        //javadoc: BackgroundSubtractorCNT::getMaxPixelStability()
        public int getMaxPixelStability ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = bgsegm_BackgroundSubtractorCNT_getMaxPixelStability_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMinPixelStability()
        //

        //javadoc: BackgroundSubtractorCNT::getMinPixelStability()
        public int getMinPixelStability ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = bgsegm_BackgroundSubtractorCNT_getMinPixelStability_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void apply(Mat image, Mat& fgmask, double learningRate = -1)
        //

        //javadoc: BackgroundSubtractorCNT::apply(image, fgmask, learningRate)
        public override void apply (Mat image, Mat fgmask, double learningRate)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (fgmask != null)
                fgmask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bgsegm_BackgroundSubtractorCNT_apply_10 (nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);
        
#else
            return;
#endif
            return;
        }

        //javadoc: BackgroundSubtractorCNT::apply(image, fgmask)
        public override void apply (Mat image, Mat fgmask)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (fgmask != null)
                fgmask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bgsegm_BackgroundSubtractorCNT_apply_11 (nativeObj, image.nativeObj, fgmask.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getBackgroundImage(Mat& backgroundImage)
        //

        //javadoc: BackgroundSubtractorCNT::getBackgroundImage(backgroundImage)
        public override void getBackgroundImage (Mat backgroundImage)
        {
            ThrowIfDisposed ();
            if (backgroundImage != null)
                backgroundImage.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bgsegm_BackgroundSubtractorCNT_getBackgroundImage_10 (nativeObj, backgroundImage.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setIsParallel(bool value)
        //

        //javadoc: BackgroundSubtractorCNT::setIsParallel(value)
        public void setIsParallel (bool value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bgsegm_BackgroundSubtractorCNT_setIsParallel_10 (nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMaxPixelStability(int value)
        //

        //javadoc: BackgroundSubtractorCNT::setMaxPixelStability(value)
        public void setMaxPixelStability (int value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bgsegm_BackgroundSubtractorCNT_setMaxPixelStability_10 (nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMinPixelStability(int value)
        //

        //javadoc: BackgroundSubtractorCNT::setMinPixelStability(value)
        public void setMinPixelStability (int value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bgsegm_BackgroundSubtractorCNT_setMinPixelStability_10 (nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setUseHistory(bool value)
        //

        //javadoc: BackgroundSubtractorCNT::setUseHistory(value)
        public void setUseHistory (bool value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bgsegm_BackgroundSubtractorCNT_setUseHistory_10 (nativeObj, value);
        
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



        // C++:  bool getIsParallel()
        [DllImport (LIBNAME)]
        private static extern bool bgsegm_BackgroundSubtractorCNT_getIsParallel_10 (IntPtr nativeObj);

        // C++:  bool getUseHistory()
        [DllImport (LIBNAME)]
        private static extern bool bgsegm_BackgroundSubtractorCNT_getUseHistory_10 (IntPtr nativeObj);

        // C++:  int getMaxPixelStability()
        [DllImport (LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorCNT_getMaxPixelStability_10 (IntPtr nativeObj);

        // C++:  int getMinPixelStability()
        [DllImport (LIBNAME)]
        private static extern int bgsegm_BackgroundSubtractorCNT_getMinPixelStability_10 (IntPtr nativeObj);

        // C++:  void apply(Mat image, Mat& fgmask, double learningRate = -1)
        [DllImport (LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_apply_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);

        [DllImport (LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_apply_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);

        // C++:  void getBackgroundImage(Mat& backgroundImage)
        [DllImport (LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_getBackgroundImage_10 (IntPtr nativeObj, IntPtr backgroundImage_nativeObj);

        // C++:  void setIsParallel(bool value)
        [DllImport (LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_setIsParallel_10 (IntPtr nativeObj, bool value);

        // C++:  void setMaxPixelStability(int value)
        [DllImport (LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_setMaxPixelStability_10 (IntPtr nativeObj, int value);

        // C++:  void setMinPixelStability(int value)
        [DllImport (LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_setMinPixelStability_10 (IntPtr nativeObj, int value);

        // C++:  void setUseHistory(bool value)
        [DllImport (LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_setUseHistory_10 (IntPtr nativeObj, bool value);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void bgsegm_BackgroundSubtractorCNT_delete (IntPtr nativeObj);

    }
}
