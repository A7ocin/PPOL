#if !UNITY_WEBGL && !UNITY_WSA_10_0

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class TextDetector
    //javadoc: TextDetector

    public class TextDetector : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        text_TextDetector_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal TextDetector (IntPtr addr)
            : base (addr)
        {
        }


        public IntPtr getNativeObjAddr ()
        {
            return nativeObj;
        }

        //
        // C++:  void detect(Mat inputImage, vector_Rect& Bbox, vector_float& confidence)
        //

        //javadoc: TextDetector::detect(inputImage, Bbox, confidence)
        public virtual void detect (Mat inputImage, MatOfRect Bbox, MatOfFloat confidence)
        {
            ThrowIfDisposed ();
            if (inputImage != null)
                inputImage.ThrowIfDisposed ();
            if (Bbox != null)
                Bbox.ThrowIfDisposed ();
            if (confidence != null)
                confidence.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat Bbox_mat = Bbox;
            Mat confidence_mat = confidence;
            text_TextDetector_detect_10 (nativeObj, inputImage.nativeObj, Bbox_mat.nativeObj, confidence_mat.nativeObj);
        
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



        // C++:  void detect(Mat inputImage, vector_Rect& Bbox, vector_float& confidence)
        [DllImport (LIBNAME)]
        private static extern void text_TextDetector_detect_10 (IntPtr nativeObj, IntPtr inputImage_nativeObj, IntPtr Bbox_mat_nativeObj, IntPtr confidence_mat_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void text_TextDetector_delete (IntPtr nativeObj);

    }
}
#endif