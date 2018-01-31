

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Board
    //javadoc: Board

    public class Board : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
aruco_Board_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal Board (IntPtr addr) : base (addr) { }


        public IntPtr getNativeObjAddr () { return nativeObj; }

        //
        // C++: static Ptr_Board create(vector_Mat objPoints, Ptr_Dictionary dictionary, Mat ids)
        //

        //javadoc: Board::create(objPoints, dictionary, ids)
        public static Board create (List<Mat> objPoints, Dictionary dictionary, Mat ids)
        {
            if (dictionary != null) dictionary.ThrowIfDisposed ();
            if (ids != null) ids.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat objPoints_mat = Converters.vector_Mat_to_Mat(objPoints);
        Board retVal = new Board(aruco_Board_create_10(objPoints_mat.nativeObj, dictionary.getNativeObjAddr(), ids.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: vector_vector_Point3f Board::objPoints
        //

        //javadoc: Board::get_objPoints()
        public List<MatOfPoint3f> get_objPoints ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        List<MatOfPoint3f> retVal = new List<MatOfPoint3f>();
        Mat retValMat = new Mat(aruco_Board_get_1objPoints_10(nativeObj));
        Converters.Mat_to_vector_vector_Point3f(retValMat, retVal);
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: Ptr_Dictionary Board::dictionary
        //

        //javadoc: Board::get_dictionary()
        public Dictionary get_dictionary ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Dictionary retVal = new Dictionary(aruco_Board_get_1dictionary_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: vector_int Board::ids
        //

        //javadoc: Board::get_ids()
        public MatOfInt get_ids ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        MatOfInt retVal = MatOfInt.fromNativeAddr(aruco_Board_get_1ids_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_Board create(vector_Mat objPoints, Ptr_Dictionary dictionary, Mat ids)
        [DllImport (LIBNAME)]
        private static extern IntPtr aruco_Board_create_10 (IntPtr objPoints_mat_nativeObj, IntPtr dictionary_nativeObj, IntPtr ids_nativeObj);

        // C++: vector_vector_Point3f Board::objPoints
        [DllImport (LIBNAME)]
        private static extern IntPtr aruco_Board_get_1objPoints_10 (IntPtr nativeObj);

        // C++: Ptr_Dictionary Board::dictionary
        [DllImport (LIBNAME)]
        private static extern IntPtr aruco_Board_get_1dictionary_10 (IntPtr nativeObj);

        // C++: vector_int Board::ids
        [DllImport (LIBNAME)]
        private static extern IntPtr aruco_Board_get_1ids_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void aruco_Board_delete (IntPtr nativeObj);

    }
}
