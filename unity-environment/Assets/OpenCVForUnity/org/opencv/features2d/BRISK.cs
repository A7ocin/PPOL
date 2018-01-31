

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class BRISK
    //javadoc: BRISK

    public class BRISK : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        features2d_BRISK_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal BRISK (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++: static Ptr_BRISK create(int thresh, int octaves, vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        //

        //javadoc: BRISK::create(thresh, octaves, radiusList, numberList, dMax, dMin, indexChange)
        public static BRISK create (int thresh, int octaves, MatOfFloat radiusList, MatOfInt numberList, float dMax, float dMin, MatOfInt indexChange)
        {
            if (radiusList != null)
                radiusList.ThrowIfDisposed ();
            if (numberList != null)
                numberList.ThrowIfDisposed ();
            if (indexChange != null)
                indexChange.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat radiusList_mat = radiusList;
            Mat numberList_mat = numberList;
            Mat indexChange_mat = indexChange;
            BRISK retVal = new BRISK (features2d_BRISK_create_10 (thresh, octaves, radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax, dMin, indexChange_mat.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: BRISK::create(thresh, octaves, radiusList, numberList)
        public static BRISK create (int thresh, int octaves, MatOfFloat radiusList, MatOfInt numberList)
        {
            if (radiusList != null)
                radiusList.ThrowIfDisposed ();
            if (numberList != null)
                numberList.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat radiusList_mat = radiusList;
            Mat numberList_mat = numberList;
            BRISK retVal = new BRISK (features2d_BRISK_create_11 (thresh, octaves, radiusList_mat.nativeObj, numberList_mat.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_BRISK create(int thresh = 30, int octaves = 3, float patternScale = 1.0f)
        //

        //javadoc: BRISK::create(thresh, octaves, patternScale)
        public static BRISK create (int thresh, int octaves, float patternScale)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            BRISK retVal = new BRISK (features2d_BRISK_create_12 (thresh, octaves, patternScale));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: BRISK::create()
        public static BRISK create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            BRISK retVal = new BRISK (features2d_BRISK_create_13 ());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_BRISK create(vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        //

        //javadoc: BRISK::create(radiusList, numberList, dMax, dMin, indexChange)
        public static BRISK create (MatOfFloat radiusList, MatOfInt numberList, float dMax, float dMin, MatOfInt indexChange)
        {
            if (radiusList != null)
                radiusList.ThrowIfDisposed ();
            if (numberList != null)
                numberList.ThrowIfDisposed ();
            if (indexChange != null)
                indexChange.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat radiusList_mat = radiusList;
            Mat numberList_mat = numberList;
            Mat indexChange_mat = indexChange;
            BRISK retVal = new BRISK (features2d_BRISK_create_14 (radiusList_mat.nativeObj, numberList_mat.nativeObj, dMax, dMin, indexChange_mat.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: BRISK::create(radiusList, numberList)
        public static BRISK create (MatOfFloat radiusList, MatOfInt numberList)
        {
            if (radiusList != null)
                radiusList.ThrowIfDisposed ();
            if (numberList != null)
                numberList.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat radiusList_mat = radiusList;
            Mat numberList_mat = numberList;
            BRISK retVal = new BRISK (features2d_BRISK_create_15 (radiusList_mat.nativeObj, numberList_mat.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  String getDefaultName()
        //

        //javadoc: BRISK::getDefaultName()
        public override string getDefaultName ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            string retVal = Marshal.PtrToStringAnsi (features2d_BRISK_getDefaultName_10 (nativeObj));
        
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



        // C++: static Ptr_BRISK create(int thresh, int octaves, vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_10 (int thresh, int octaves, IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax, float dMin, IntPtr indexChange_mat_nativeObj);

        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_11 (int thresh, int octaves, IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj);

        // C++: static Ptr_BRISK create(int thresh = 30, int octaves = 3, float patternScale = 1.0f)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_12 (int thresh, int octaves, float patternScale);

        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_13 ();

        // C++: static Ptr_BRISK create(vector_float radiusList, vector_int numberList, float dMax = 5.85f, float dMin = 8.2f, vector_int indexChange = std::vector<int>())
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_14 (IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj, float dMax, float dMin, IntPtr indexChange_mat_nativeObj);

        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BRISK_create_15 (IntPtr radiusList_mat_nativeObj, IntPtr numberList_mat_nativeObj);

        // C++:  String getDefaultName()
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BRISK_getDefaultName_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_BRISK_delete (IntPtr nativeObj);

    }
}
