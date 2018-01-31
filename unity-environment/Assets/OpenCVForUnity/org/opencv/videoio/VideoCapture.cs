

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class VideoCapture
    //javadoc: VideoCapture

    public class VideoCapture : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
videoio_VideoCapture_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal VideoCapture (IntPtr addr) : base (addr) { }


        public IntPtr getNativeObjAddr () { return nativeObj; }

        //
        // C++:   VideoCapture(String filename, int apiPreference)
        //

        //javadoc: VideoCapture::VideoCapture(filename, apiPreference)
        public VideoCapture (string filename, int apiPreference)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoCapture_VideoCapture_10(filename, apiPreference);
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:   VideoCapture(String filename)
        //

        //javadoc: VideoCapture::VideoCapture(filename)
        public VideoCapture (string filename)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoCapture_VideoCapture_11(filename);
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:   VideoCapture(int index)
        //

        //javadoc: VideoCapture::VideoCapture(index)
        public VideoCapture (int index)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoCapture_VideoCapture_12(index);
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:   VideoCapture()
        //

        //javadoc: VideoCapture::VideoCapture()
        public VideoCapture ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = videoio_VideoCapture_VideoCapture_13();
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:  bool grab()
        //

        //javadoc: VideoCapture::grab()
        public bool grab ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_grab_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool isOpened()
        //

        //javadoc: VideoCapture::isOpened()
        public bool isOpened ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_isOpened_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool open(String filename, int apiPreference)
        //

        //javadoc: VideoCapture::open(filename, apiPreference)
        public bool open (string filename, int apiPreference)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_open_10(nativeObj, filename, apiPreference);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool open(String filename)
        //

        //javadoc: VideoCapture::open(filename)
        public bool open (string filename)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_open_11(nativeObj, filename);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool open(int cameraNum, int apiPreference)
        //

        //javadoc: VideoCapture::open(cameraNum, apiPreference)
        public bool open (int cameraNum, int apiPreference)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_open_12(nativeObj, cameraNum, apiPreference);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool open(int index)
        //

        //javadoc: VideoCapture::open(index)
        public bool open (int index)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_open_13(nativeObj, index);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool read(Mat& image)
        //

        //javadoc: VideoCapture::read(image)
        public bool read (Mat image)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_read_10(nativeObj, image.nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool retrieve(Mat& image, int flag = 0)
        //

        //javadoc: VideoCapture::retrieve(image, flag)
        public bool retrieve (Mat image, int flag)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_retrieve_10(nativeObj, image.nativeObj, flag);
        
#else
            return false;
#endif
            return retVal;
        }

        //javadoc: VideoCapture::retrieve(image)
        public bool retrieve (Mat image)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_retrieve_11(nativeObj, image.nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool set(int propId, double value)
        //

        //javadoc: VideoCapture::set(propId, value)
        public bool set (int propId, double value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = videoio_VideoCapture_set_10(nativeObj, propId, value);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  double get(int propId)
        //

        //javadoc: VideoCapture::get(propId)
        public double get (int propId)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = videoio_VideoCapture_get_10(nativeObj, propId);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void release()
        //

        //javadoc: VideoCapture::release()
        public void release ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        videoio_VideoCapture_release_10(nativeObj);
        
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



        // C++:   VideoCapture(String filename, int apiPreference)
        [DllImport (LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_10 (string filename, int apiPreference);

        // C++:   VideoCapture(String filename)
        [DllImport (LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_11 (string filename);

        // C++:   VideoCapture(int index)
        [DllImport (LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_12 (int index);

        // C++:   VideoCapture()
        [DllImport (LIBNAME)]
        private static extern IntPtr videoio_VideoCapture_VideoCapture_13 ();

        // C++:  bool grab()
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoCapture_grab_10 (IntPtr nativeObj);

        // C++:  bool isOpened()
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoCapture_isOpened_10 (IntPtr nativeObj);

        // C++:  bool open(String filename, int apiPreference)
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoCapture_open_10 (IntPtr nativeObj, string filename, int apiPreference);

        // C++:  bool open(String filename)
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoCapture_open_11 (IntPtr nativeObj, string filename);

        // C++:  bool open(int cameraNum, int apiPreference)
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoCapture_open_12 (IntPtr nativeObj, int cameraNum, int apiPreference);

        // C++:  bool open(int index)
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoCapture_open_13 (IntPtr nativeObj, int index);

        // C++:  bool read(Mat& image)
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoCapture_read_10 (IntPtr nativeObj, IntPtr image_nativeObj);

        // C++:  bool retrieve(Mat& image, int flag = 0)
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoCapture_retrieve_10 (IntPtr nativeObj, IntPtr image_nativeObj, int flag);
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoCapture_retrieve_11 (IntPtr nativeObj, IntPtr image_nativeObj);

        // C++:  bool set(int propId, double value)
        [DllImport (LIBNAME)]
        private static extern bool videoio_VideoCapture_set_10 (IntPtr nativeObj, int propId, double value);

        // C++:  double get(int propId)
        [DllImport (LIBNAME)]
        private static extern double videoio_VideoCapture_get_10 (IntPtr nativeObj, int propId);

        // C++:  void release()
        [DllImport (LIBNAME)]
        private static extern void videoio_VideoCapture_release_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void videoio_VideoCapture_delete (IntPtr nativeObj);

    }
}
