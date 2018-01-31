

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class StaticSaliencySpectralResidual
    //javadoc: StaticSaliencySpectralResidual

    public class StaticSaliencySpectralResidual : StaticSaliency
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        saliency_StaticSaliencySpectralResidual_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal StaticSaliencySpectralResidual (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++: static Ptr_StaticSaliencySpectralResidual create()
        //

        //javadoc: StaticSaliencySpectralResidual::create()
        public static StaticSaliencySpectralResidual create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            StaticSaliencySpectralResidual retVal = new StaticSaliencySpectralResidual (saliency_StaticSaliencySpectralResidual_create_10 ());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool computeSaliency(Mat image, Mat& saliencyMap)
        //

        //javadoc: StaticSaliencySpectralResidual::computeSaliency(image, saliencyMap)
        public override bool computeSaliency (Mat image, Mat saliencyMap)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (saliencyMap != null)
                saliencyMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = saliency_StaticSaliencySpectralResidual_computeSaliency_10 (nativeObj, image.nativeObj, saliencyMap.nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  int getImageHeight()
        //

        //javadoc: StaticSaliencySpectralResidual::getImageHeight()
        public int getImageHeight ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = saliency_StaticSaliencySpectralResidual_getImageHeight_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getImageWidth()
        //

        //javadoc: StaticSaliencySpectralResidual::getImageWidth()
        public int getImageWidth ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = saliency_StaticSaliencySpectralResidual_getImageWidth_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void read(FileNode fn)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  void setImageHeight(int val)
        //

        //javadoc: StaticSaliencySpectralResidual::setImageHeight(val)
        public void setImageHeight (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            saliency_StaticSaliencySpectralResidual_setImageHeight_10 (nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setImageWidth(int val)
        //

        //javadoc: StaticSaliencySpectralResidual::setImageWidth(val)
        public void setImageWidth (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            saliency_StaticSaliencySpectralResidual_setImageWidth_10 (nativeObj, val);
        
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



        // C++: static Ptr_StaticSaliencySpectralResidual create()
        [DllImport (LIBNAME)]
        private static extern IntPtr saliency_StaticSaliencySpectralResidual_create_10 ();

        // C++:  bool computeSaliency(Mat image, Mat& saliencyMap)
        [DllImport (LIBNAME)]
        private static extern bool saliency_StaticSaliencySpectralResidual_computeSaliency_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr saliencyMap_nativeObj);

        // C++:  int getImageHeight()
        [DllImport (LIBNAME)]
        private static extern int saliency_StaticSaliencySpectralResidual_getImageHeight_10 (IntPtr nativeObj);

        // C++:  int getImageWidth()
        [DllImport (LIBNAME)]
        private static extern int saliency_StaticSaliencySpectralResidual_getImageWidth_10 (IntPtr nativeObj);

        // C++:  void setImageHeight(int val)
        [DllImport (LIBNAME)]
        private static extern void saliency_StaticSaliencySpectralResidual_setImageHeight_10 (IntPtr nativeObj, int val);

        // C++:  void setImageWidth(int val)
        [DllImport (LIBNAME)]
        private static extern void saliency_StaticSaliencySpectralResidual_setImageWidth_10 (IntPtr nativeObj, int val);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void saliency_StaticSaliencySpectralResidual_delete (IntPtr nativeObj);

    }
}
