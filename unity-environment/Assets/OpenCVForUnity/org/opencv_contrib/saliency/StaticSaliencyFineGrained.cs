

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class StaticSaliencyFineGrained
    //javadoc: StaticSaliencyFineGrained

    public class StaticSaliencyFineGrained : StaticSaliency
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        saliency_StaticSaliencyFineGrained_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal StaticSaliencyFineGrained (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++: static Ptr_StaticSaliencyFineGrained create()
        //

        //javadoc: StaticSaliencyFineGrained::create()
        public static StaticSaliencyFineGrained create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            StaticSaliencyFineGrained retVal = new StaticSaliencyFineGrained (saliency_StaticSaliencyFineGrained_create_10 ());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool computeSaliency(Mat image, Mat& saliencyMap)
        //

        //javadoc: StaticSaliencyFineGrained::computeSaliency(image, saliencyMap)
        public override bool computeSaliency (Mat image, Mat saliencyMap)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (saliencyMap != null)
                saliencyMap.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = saliency_StaticSaliencyFineGrained_computeSaliency_10 (nativeObj, image.nativeObj, saliencyMap.nativeObj);
        
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



        // C++: static Ptr_StaticSaliencyFineGrained create()
        [DllImport (LIBNAME)]
        private static extern IntPtr saliency_StaticSaliencyFineGrained_create_10 ();

        // C++:  bool computeSaliency(Mat image, Mat& saliencyMap)
        [DllImport (LIBNAME)]
        private static extern bool saliency_StaticSaliencyFineGrained_computeSaliency_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr saliencyMap_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void saliency_StaticSaliencyFineGrained_delete (IntPtr nativeObj);

    }
}
