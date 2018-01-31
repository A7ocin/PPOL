

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Dictionary
    //javadoc: Dictionary

    public class Dictionary : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
aruco_Dictionary_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal Dictionary (IntPtr addr) : base (addr) { }


        public IntPtr getNativeObjAddr () { return nativeObj; }

        //
        // C++: static Ptr_Dictionary create(int nMarkers, int markerSize, Ptr_Dictionary baseDictionary)
        //

        //javadoc: Dictionary::create(nMarkers, markerSize, baseDictionary)
        public static Dictionary create_from (int nMarkers, int markerSize, Dictionary baseDictionary)
        {
            if (baseDictionary != null) baseDictionary.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Dictionary retVal = new Dictionary(aruco_Dictionary_create_1from_10(nMarkers, markerSize, baseDictionary.getNativeObjAddr()));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_Dictionary create(int nMarkers, int markerSize)
        //

        //javadoc: Dictionary::create(nMarkers, markerSize)
        public static Dictionary create (int nMarkers, int markerSize)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Dictionary retVal = new Dictionary(aruco_Dictionary_create_10(nMarkers, markerSize));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_Dictionary get(int dict)
        //

        //javadoc: Dictionary::get(dict)
        public static Dictionary get (int dict)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Dictionary retVal = new Dictionary(aruco_Dictionary_get_10(dict));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void drawMarker(int id, int sidePixels, Mat& _img, int borderBits = 1)
        //

        //javadoc: Dictionary::drawMarker(id, sidePixels, _img, borderBits)
        public void drawMarker (int id, int sidePixels, Mat _img, int borderBits)
        {
            ThrowIfDisposed ();
            if (_img != null) _img.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_Dictionary_drawMarker_10(nativeObj, id, sidePixels, _img.nativeObj, borderBits);
        
#else
            return;
#endif
            return;
        }

        //javadoc: Dictionary::drawMarker(id, sidePixels, _img)
        public void drawMarker (int id, int sidePixels, Mat _img)
        {
            ThrowIfDisposed ();
            if (_img != null) _img.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_Dictionary_drawMarker_11(nativeObj, id, sidePixels, _img.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: Mat Dictionary::bytesList
        //

        //javadoc: Dictionary::get_bytesList()
        public Mat get_bytesList ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(aruco_Dictionary_get_1bytesList_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: int Dictionary::markerSize
        //

        //javadoc: Dictionary::get_markerSize()
        public int get_markerSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = aruco_Dictionary_get_1markerSize_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: int Dictionary::maxCorrectionBits
        //

        //javadoc: Dictionary::get_maxCorrectionBits()
        public int get_maxCorrectionBits ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = aruco_Dictionary_get_1maxCorrectionBits_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_Dictionary create(int nMarkers, int markerSize, Ptr_Dictionary baseDictionary)
        [DllImport (LIBNAME)]
        private static extern IntPtr aruco_Dictionary_create_1from_10 (int nMarkers, int markerSize, IntPtr baseDictionary_nativeObj);

        // C++: static Ptr_Dictionary create(int nMarkers, int markerSize)
        [DllImport (LIBNAME)]
        private static extern IntPtr aruco_Dictionary_create_10 (int nMarkers, int markerSize);

        // C++: static Ptr_Dictionary get(int dict)
        [DllImport (LIBNAME)]
        private static extern IntPtr aruco_Dictionary_get_10 (int dict);

        // C++:  void drawMarker(int id, int sidePixels, Mat& _img, int borderBits = 1)
        [DllImport (LIBNAME)]
        private static extern void aruco_Dictionary_drawMarker_10 (IntPtr nativeObj, int id, int sidePixels, IntPtr _img_nativeObj, int borderBits);
        [DllImport (LIBNAME)]
        private static extern void aruco_Dictionary_drawMarker_11 (IntPtr nativeObj, int id, int sidePixels, IntPtr _img_nativeObj);

        // C++: Mat Dictionary::bytesList
        [DllImport (LIBNAME)]
        private static extern IntPtr aruco_Dictionary_get_1bytesList_10 (IntPtr nativeObj);

        // C++: int Dictionary::markerSize
        [DllImport (LIBNAME)]
        private static extern int aruco_Dictionary_get_1markerSize_10 (IntPtr nativeObj);

        // C++: int Dictionary::maxCorrectionBits
        [DllImport (LIBNAME)]
        private static extern int aruco_Dictionary_get_1maxCorrectionBits_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void aruco_Dictionary_delete (IntPtr nativeObj);

    }
}
