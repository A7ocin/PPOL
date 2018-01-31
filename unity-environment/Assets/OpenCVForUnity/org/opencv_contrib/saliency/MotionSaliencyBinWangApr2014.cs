

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class MotionSaliencyBinWangApr2014
    //javadoc: MotionSaliencyBinWangApr2014

    public class MotionSaliencyBinWangApr2014 : MotionSaliency
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        saliency_MotionSaliencyBinWangApr2014_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal MotionSaliencyBinWangApr2014 (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++: static Ptr_MotionSaliencyBinWangApr2014 create()
        //

        //javadoc: MotionSaliencyBinWangApr2014::create()
        public static MotionSaliencyBinWangApr2014 create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            MotionSaliencyBinWangApr2014 retVal = new MotionSaliencyBinWangApr2014 (saliency_MotionSaliencyBinWangApr2014_create_10 ());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool computeSaliency(Mat image, Mat& saliencyMap)
        //

        //javadoc: MotionSaliencyBinWangApr2014::computeSaliency(image, saliencyMap)
        public override bool computeSaliency (Mat image, Mat saliencyMap)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (saliencyMap != null)
                saliencyMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = saliency_MotionSaliencyBinWangApr2014_computeSaliency_10 (nativeObj, image.nativeObj, saliencyMap.nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool init()
        //

        //javadoc: MotionSaliencyBinWangApr2014::init()
        public bool init ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = saliency_MotionSaliencyBinWangApr2014_init_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  int getImageHeight()
        //

        //javadoc: MotionSaliencyBinWangApr2014::getImageHeight()
        public int getImageHeight ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = saliency_MotionSaliencyBinWangApr2014_getImageHeight_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getImageWidth()
        //

        //javadoc: MotionSaliencyBinWangApr2014::getImageWidth()
        public int getImageWidth ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = saliency_MotionSaliencyBinWangApr2014_getImageWidth_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setImageHeight(int val)
        //

        //javadoc: MotionSaliencyBinWangApr2014::setImageHeight(val)
        public void setImageHeight (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            saliency_MotionSaliencyBinWangApr2014_setImageHeight_10 (nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setImageWidth(int val)
        //

        //javadoc: MotionSaliencyBinWangApr2014::setImageWidth(val)
        public void setImageWidth (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            saliency_MotionSaliencyBinWangApr2014_setImageWidth_10 (nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setImagesize(int W, int H)
        //

        //javadoc: MotionSaliencyBinWangApr2014::setImagesize(W, H)
        public void setImagesize (int W, int H)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            saliency_MotionSaliencyBinWangApr2014_setImagesize_10 (nativeObj, W, H);
        
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



        // C++: static Ptr_MotionSaliencyBinWangApr2014 create()
        [DllImport (LIBNAME)]
        private static extern IntPtr saliency_MotionSaliencyBinWangApr2014_create_10 ();

        // C++:  bool computeSaliency(Mat image, Mat& saliencyMap)
        [DllImport (LIBNAME)]
        private static extern bool saliency_MotionSaliencyBinWangApr2014_computeSaliency_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr saliencyMap_nativeObj);

        // C++:  bool init()
        [DllImport (LIBNAME)]
        private static extern bool saliency_MotionSaliencyBinWangApr2014_init_10 (IntPtr nativeObj);

        // C++:  int getImageHeight()
        [DllImport (LIBNAME)]
        private static extern int saliency_MotionSaliencyBinWangApr2014_getImageHeight_10 (IntPtr nativeObj);

        // C++:  int getImageWidth()
        [DllImport (LIBNAME)]
        private static extern int saliency_MotionSaliencyBinWangApr2014_getImageWidth_10 (IntPtr nativeObj);

        // C++:  void setImageHeight(int val)
        [DllImport (LIBNAME)]
        private static extern void saliency_MotionSaliencyBinWangApr2014_setImageHeight_10 (IntPtr nativeObj, int val);

        // C++:  void setImageWidth(int val)
        [DllImport (LIBNAME)]
        private static extern void saliency_MotionSaliencyBinWangApr2014_setImageWidth_10 (IntPtr nativeObj, int val);

        // C++:  void setImagesize(int W, int H)
        [DllImport (LIBNAME)]
        private static extern void saliency_MotionSaliencyBinWangApr2014_setImagesize_10 (IntPtr nativeObj, int W, int H);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void saliency_MotionSaliencyBinWangApr2014_delete (IntPtr nativeObj);

    }
}
