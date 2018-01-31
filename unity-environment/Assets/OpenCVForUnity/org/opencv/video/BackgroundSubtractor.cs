

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class BackgroundSubtractor
    //javadoc: BackgroundSubtractor

    public class BackgroundSubtractor : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        video_BackgroundSubtractor_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal BackgroundSubtractor (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++:  void apply(Mat image, Mat& fgmask, double learningRate = -1)
        //

        //javadoc: BackgroundSubtractor::apply(image, fgmask, learningRate)
        public virtual void apply (Mat image, Mat fgmask, double learningRate)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (fgmask != null)
                fgmask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractor_apply_10 (nativeObj, image.nativeObj, fgmask.nativeObj, learningRate);
        
#else
            return;
#endif
            return;
        }

        //javadoc: BackgroundSubtractor::apply(image, fgmask)
        public virtual void apply (Mat image, Mat fgmask)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (fgmask != null)
                fgmask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractor_apply_11 (nativeObj, image.nativeObj, fgmask.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getBackgroundImage(Mat& backgroundImage)
        //

        //javadoc: BackgroundSubtractor::getBackgroundImage(backgroundImage)
        public virtual void getBackgroundImage (Mat backgroundImage)
        {
            ThrowIfDisposed ();
            if (backgroundImage != null)
                backgroundImage.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            video_BackgroundSubtractor_getBackgroundImage_10 (nativeObj, backgroundImage.nativeObj);
        
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



        // C++:  void apply(Mat image, Mat& fgmask, double learningRate = -1)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractor_apply_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj, double learningRate);

        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractor_apply_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr fgmask_nativeObj);

        // C++:  void getBackgroundImage(Mat& backgroundImage)
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractor_getBackgroundImage_10 (IntPtr nativeObj, IntPtr backgroundImage_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void video_BackgroundSubtractor_delete (IntPtr nativeObj);

    }
}
