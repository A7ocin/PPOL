

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class MergeDebevec
    //javadoc: MergeDebevec

    public class MergeDebevec : MergeExposures
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        photo_MergeDebevec_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal MergeDebevec (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++:  void process(vector_Mat src, Mat& dst, Mat times, Mat response)
        //

        //javadoc: MergeDebevec::process(src, dst, times, response)
        public override void process (List<Mat> src, Mat dst, Mat times, Mat response)
        {
            ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            if (times != null)
                times.ThrowIfDisposed ();
            if (response != null)
                response.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat src_mat = Converters.vector_Mat_to_Mat (src);
            photo_MergeDebevec_process_10 (nativeObj, src_mat.nativeObj, dst.nativeObj, times.nativeObj, response.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void process(vector_Mat src, Mat& dst, Mat times)
        //

        //javadoc: MergeDebevec::process(src, dst, times)
        public void process (List<Mat> src, Mat dst, Mat times)
        {
            ThrowIfDisposed ();
            if (dst != null)
                dst.ThrowIfDisposed ();
            if (times != null)
                times.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat src_mat = Converters.vector_Mat_to_Mat (src);
            photo_MergeDebevec_process_11 (nativeObj, src_mat.nativeObj, dst.nativeObj, times.nativeObj);
        
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



        // C++:  void process(vector_Mat src, Mat& dst, Mat times, Mat response)
        [DllImport (LIBNAME)]
        private static extern void photo_MergeDebevec_process_10 (IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_nativeObj, IntPtr times_nativeObj, IntPtr response_nativeObj);

        // C++:  void process(vector_Mat src, Mat& dst, Mat times)
        [DllImport (LIBNAME)]
        private static extern void photo_MergeDebevec_process_11 (IntPtr nativeObj, IntPtr src_mat_nativeObj, IntPtr dst_nativeObj, IntPtr times_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void photo_MergeDebevec_delete (IntPtr nativeObj);

    }
}
