

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class LBPHFaceRecognizer
    //javadoc: LBPHFaceRecognizer

    public class LBPHFaceRecognizer : FaceRecognizer
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
face_LBPHFaceRecognizer_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal LBPHFaceRecognizer (IntPtr addr) : base (addr) { }


        //
        // C++:  Mat getLabels()
        //

        //javadoc: LBPHFaceRecognizer::getLabels()
        public Mat getLabels ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(face_LBPHFaceRecognizer_getLabels_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_LBPHFaceRecognizer create(int radius = 1, int neighbors = 8, int grid_x = 8, int grid_y = 8, double threshold = DBL_MAX)
        //

        //javadoc: LBPHFaceRecognizer::create(radius, neighbors, grid_x, grid_y, threshold)
        public static LBPHFaceRecognizer create (int radius, int neighbors, int grid_x, int grid_y, double threshold)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        LBPHFaceRecognizer retVal = new LBPHFaceRecognizer(face_LBPHFaceRecognizer_create_10(radius, neighbors, grid_x, grid_y, threshold));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: LBPHFaceRecognizer::create()
        public static LBPHFaceRecognizer create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        LBPHFaceRecognizer retVal = new LBPHFaceRecognizer(face_LBPHFaceRecognizer_create_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  double getThreshold()
        //

        //javadoc: LBPHFaceRecognizer::getThreshold()
        public double getThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = face_LBPHFaceRecognizer_getThreshold_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getGridX()
        //

        //javadoc: LBPHFaceRecognizer::getGridX()
        public int getGridX ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = face_LBPHFaceRecognizer_getGridX_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getGridY()
        //

        //javadoc: LBPHFaceRecognizer::getGridY()
        public int getGridY ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = face_LBPHFaceRecognizer_getGridY_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNeighbors()
        //

        //javadoc: LBPHFaceRecognizer::getNeighbors()
        public int getNeighbors ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = face_LBPHFaceRecognizer_getNeighbors_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getRadius()
        //

        //javadoc: LBPHFaceRecognizer::getRadius()
        public int getRadius ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = face_LBPHFaceRecognizer_getRadius_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  vector_Mat getHistograms()
        //

        //javadoc: LBPHFaceRecognizer::getHistograms()
        public List<Mat> getHistograms ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        List<Mat> retVal = new List<Mat>();
        Mat retValMat = new Mat(face_LBPHFaceRecognizer_getHistograms_10(nativeObj));
        Converters.Mat_to_vector_Mat(retValMat, retVal);
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void setGridX(int val)
        //

        //javadoc: LBPHFaceRecognizer::setGridX(val)
        public void setGridX (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        face_LBPHFaceRecognizer_setGridX_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setGridY(int val)
        //

        //javadoc: LBPHFaceRecognizer::setGridY(val)
        public void setGridY (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        face_LBPHFaceRecognizer_setGridY_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setNeighbors(int val)
        //

        //javadoc: LBPHFaceRecognizer::setNeighbors(val)
        public void setNeighbors (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        face_LBPHFaceRecognizer_setNeighbors_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setRadius(int val)
        //

        //javadoc: LBPHFaceRecognizer::setRadius(val)
        public void setRadius (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        face_LBPHFaceRecognizer_setRadius_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setThreshold(double val)
        //

        //javadoc: LBPHFaceRecognizer::setThreshold(val)
        public void setThreshold (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        face_LBPHFaceRecognizer_setThreshold_10(nativeObj, val);
        
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



        // C++:  Mat getLabels()
        [DllImport (LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_getLabels_10 (IntPtr nativeObj);

        // C++: static Ptr_LBPHFaceRecognizer create(int radius = 1, int neighbors = 8, int grid_x = 8, int grid_y = 8, double threshold = DBL_MAX)
        [DllImport (LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_10 (int radius, int neighbors, int grid_x, int grid_y, double threshold);
        [DllImport (LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_create_11 ();

        // C++:  double getThreshold()
        [DllImport (LIBNAME)]
        private static extern double face_LBPHFaceRecognizer_getThreshold_10 (IntPtr nativeObj);

        // C++:  int getGridX()
        [DllImport (LIBNAME)]
        private static extern int face_LBPHFaceRecognizer_getGridX_10 (IntPtr nativeObj);

        // C++:  int getGridY()
        [DllImport (LIBNAME)]
        private static extern int face_LBPHFaceRecognizer_getGridY_10 (IntPtr nativeObj);

        // C++:  int getNeighbors()
        [DllImport (LIBNAME)]
        private static extern int face_LBPHFaceRecognizer_getNeighbors_10 (IntPtr nativeObj);

        // C++:  int getRadius()
        [DllImport (LIBNAME)]
        private static extern int face_LBPHFaceRecognizer_getRadius_10 (IntPtr nativeObj);

        // C++:  vector_Mat getHistograms()
        [DllImport (LIBNAME)]
        private static extern IntPtr face_LBPHFaceRecognizer_getHistograms_10 (IntPtr nativeObj);

        // C++:  void setGridX(int val)
        [DllImport (LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setGridX_10 (IntPtr nativeObj, int val);

        // C++:  void setGridY(int val)
        [DllImport (LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setGridY_10 (IntPtr nativeObj, int val);

        // C++:  void setNeighbors(int val)
        [DllImport (LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setNeighbors_10 (IntPtr nativeObj, int val);

        // C++:  void setRadius(int val)
        [DllImport (LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setRadius_10 (IntPtr nativeObj, int val);

        // C++:  void setThreshold(double val)
        [DllImport (LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_setThreshold_10 (IntPtr nativeObj, double val);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void face_LBPHFaceRecognizer_delete (IntPtr nativeObj);

    }
}
