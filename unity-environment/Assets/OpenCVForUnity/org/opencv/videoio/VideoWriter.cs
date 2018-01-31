

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class VideoWriter
    //javadoc: VideoWriter

    public class VideoWriter : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
videoio_VideoWriter_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal VideoWriter (IntPtr addr) : base (addr) { }


        public IntPtr getNativeObjAddr () { return nativeObj; }

        //
        // C++:   VideoWriter(String filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor = true)
        //

        //javadoc: VideoWriter::VideoWriter(filename, apiPreference, fourcc, fps, frameSize, isColor)
        public VideoWriter (string filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoWriter_VideoWriter_10(filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height, isColor);
        
#else
            return null;
#endif
            return;
        }

        //javadoc: VideoWriter::VideoWriter(filename, apiPreference, fourcc, fps, frameSize)
        public VideoWriter (string filename, int apiPreference, int fourcc, double fps, Size frameSize)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoWriter_VideoWriter_11(filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height);
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:   VideoWriter(String filename, int fourcc, double fps, Size frameSize, bool isColor = true)
        //

        //javadoc: VideoWriter::VideoWriter(filename, fourcc, fps, frameSize, isColor)
        public VideoWriter (string filename, int fourcc, double fps, Size frameSize, bool isColor)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoWriter_VideoWriter_12(filename, fourcc, fps, frameSize.width, frameSize.height, isColor);
        
#else
            return null;
#endif
            return;
        }

        //javadoc: VideoWriter::VideoWriter(filename, fourcc, fps, frameSize)
        public VideoWriter (string filename, int fourcc, double fps, Size frameSize)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoWriter_VideoWriter_13(filename, fourcc, fps, frameSize.width, frameSize.height);
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:   VideoWriter()
        //

        //javadoc: VideoWriter::VideoWriter()
        public VideoWriter ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoWriter_VideoWriter_14();
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:  bool isOpened()
        //

        //javadoc: VideoWriter::isOpened()
        public bool isOpened ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoWriter_isOpened_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool open(String filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor = true)
        //

        //javadoc: VideoWriter::open(filename, apiPreference, fourcc, fps, frameSize, isColor)
        public bool open (string filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoWriter_open_10(nativeObj, filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height, isColor);
        
#else
            return false;
#endif
            return retVal;
        }

        //javadoc: VideoWriter::open(filename, apiPreference, fourcc, fps, frameSize)
        public bool open (string filename, int apiPreference, int fourcc, double fps, Size frameSize)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoWriter_open_11(nativeObj, filename, apiPreference, fourcc, fps, frameSize.width, frameSize.height);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool open(String filename, int fourcc, double fps, Size frameSize, bool isColor = true)
        //

        //javadoc: VideoWriter::open(filename, fourcc, fps, frameSize, isColor)
        public bool open (string filename, int fourcc, double fps, Size frameSize, bool isColor)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoWriter_open_12(nativeObj, filename, fourcc, fps, frameSize.width, frameSize.height, isColor);
        
#else
            return false;
#endif
            return retVal;
        }

        //javadoc: VideoWriter::open(filename, fourcc, fps, frameSize)
        public bool open (string filename, int fourcc, double fps, Size frameSize)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoWriter_open_13(nativeObj, filename, fourcc, fps, frameSize.width, frameSize.height);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool set(int propId, double value)
        //

        //javadoc: VideoWriter::set(propId, value)
        public bool set (int propId, double value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoWriter_set_10(nativeObj, propId, value);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  double get(int propId)
        //

        //javadoc: VideoWriter::get(propId)
        public double get (int propId)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = videoio_VideoWriter_get_10(nativeObj, propId);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: static int fourcc(char c1, char c2, char c3, char c4)
        //

        //javadoc: VideoWriter::fourcc(c1, c2, c3, c4)
        public static int fourcc (char c1, char c2, char c3, char c4)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = videoio_VideoWriter_fourcc_10(c1, c2, c3, c4);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void release()
        //

        //javadoc: VideoWriter::release()
        public void release ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        videoio_VideoWriter_release_10(nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void write(Mat image)
        //

        //javadoc: VideoWriter::write(image)
        public void write (Mat image)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        videoio_VideoWriter_write_10(nativeObj, image.nativeObj);
        
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



        // C++:   VideoWriter(String filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor = true)
        [DllImport (LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_10 (string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height, bool isColor);
        [DllImport (LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_11 (string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height);

        // C++:   VideoWriter(String filename, int fourcc, double fps, Size frameSize, bool isColor = true)
        [DllImport (LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_12 (string filename, int fourcc, double fps, double frameSize_width, double frameSize_height, bool isColor);
        [DllImport (LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_13 (string filename, int fourcc, double fps, double frameSize_width, double frameSize_height);

        // C++:   VideoWriter()
        [DllImport (LIBNAME)]
        private static extern IntPtr videoio_VideoWriter_VideoWriter_14 ();

        // C++:  bool isOpened()
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoWriter_isOpened_10 (IntPtr nativeObj);

        // C++:  bool open(String filename, int apiPreference, int fourcc, double fps, Size frameSize, bool isColor = true)
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoWriter_open_10 (IntPtr nativeObj, string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height, bool isColor);
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoWriter_open_11 (IntPtr nativeObj, string filename, int apiPreference, int fourcc, double fps, double frameSize_width, double frameSize_height);

        // C++:  bool open(String filename, int fourcc, double fps, Size frameSize, bool isColor = true)
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoWriter_open_12 (IntPtr nativeObj, string filename, int fourcc, double fps, double frameSize_width, double frameSize_height, bool isColor);
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoWriter_open_13 (IntPtr nativeObj, string filename, int fourcc, double fps, double frameSize_width, double frameSize_height);

        // C++:  bool set(int propId, double value)
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoWriter_set_10 (IntPtr nativeObj, int propId, double value);

        // C++:  double get(int propId)
        [DllImport (LIBNAME)]
        private static extern double videoio_VideoWriter_get_10 (IntPtr nativeObj, int propId);

        // C++: static int fourcc(char c1, char c2, char c3, char c4)
        [DllImport (LIBNAME)]
        private static extern int videoio_VideoWriter_fourcc_10 (char c1, char c2, char c3, char c4);

        // C++:  void release()
        [DllImport (LIBNAME)]
        private static extern void videoio_VideoWriter_release_10 (IntPtr nativeObj);

        // C++:  void write(Mat image)
        [DllImport (LIBNAME)]
        private static extern void videoio_VideoWriter_write_10 (IntPtr nativeObj, IntPtr image_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void videoio_VideoWriter_delete (IntPtr nativeObj);

    }
}
