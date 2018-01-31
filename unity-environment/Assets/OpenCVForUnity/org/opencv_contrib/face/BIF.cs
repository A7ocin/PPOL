

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class BIF
    //javadoc: BIF

    public class BIF : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
face_BIF_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal BIF (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_BIF create(int num_bands = 8, int num_rotations = 12)
        //

        //javadoc: BIF::create(num_bands, num_rotations)
        public static BIF create (int num_bands, int num_rotations)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BIF retVal = new BIF(face_BIF_create_10(num_bands, num_rotations));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: BIF::create()
        public static BIF create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        BIF retVal = new BIF(face_BIF_create_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  int getNumBands()
        //

        //javadoc: BIF::getNumBands()
        public int getNumBands ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = face_BIF_getNumBands_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNumRotations()
        //

        //javadoc: BIF::getNumRotations()
        public int getNumRotations ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = face_BIF_getNumRotations_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void compute(Mat image, Mat& features)
        //

        //javadoc: BIF::compute(image, features)
        public void compute (Mat image, Mat features)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (features != null) features.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        face_BIF_compute_10(nativeObj, image.nativeObj, features.nativeObj);
        
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



        // C++: static Ptr_BIF create(int num_bands = 8, int num_rotations = 12)
        [DllImport (LIBNAME)]
        private static extern IntPtr face_BIF_create_10 (int num_bands, int num_rotations);
        [DllImport (LIBNAME)]
        private static extern IntPtr face_BIF_create_11 ();

        // C++:  int getNumBands()
        [DllImport (LIBNAME)]
        private static extern int face_BIF_getNumBands_10 (IntPtr nativeObj);

        // C++:  int getNumRotations()
        [DllImport (LIBNAME)]
        private static extern int face_BIF_getNumRotations_10 (IntPtr nativeObj);

        // C++:  void compute(Mat image, Mat& features)
        [DllImport (LIBNAME)]
        private static extern void face_BIF_compute_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr features_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void face_BIF_delete (IntPtr nativeObj);

    }
}
