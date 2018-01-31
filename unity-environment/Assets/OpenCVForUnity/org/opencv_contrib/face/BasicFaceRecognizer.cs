

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class BasicFaceRecognizer
    //javadoc: BasicFaceRecognizer

    public class BasicFaceRecognizer : FaceRecognizer
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
face_BasicFaceRecognizer_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal BasicFaceRecognizer (IntPtr addr) : base (addr) { }


        //
        // C++:  Mat getEigenValues()
        //

        //javadoc: BasicFaceRecognizer::getEigenValues()
        public Mat getEigenValues ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(face_BasicFaceRecognizer_getEigenValues_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Mat getEigenVectors()
        //

        //javadoc: BasicFaceRecognizer::getEigenVectors()
        public Mat getEigenVectors ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(face_BasicFaceRecognizer_getEigenVectors_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Mat getLabels()
        //

        //javadoc: BasicFaceRecognizer::getLabels()
        public Mat getLabels ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(face_BasicFaceRecognizer_getLabels_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Mat getMean()
        //

        //javadoc: BasicFaceRecognizer::getMean()
        public Mat getMean ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(face_BasicFaceRecognizer_getMean_10(nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  double getThreshold()
        //

        //javadoc: BasicFaceRecognizer::getThreshold()
        public double getThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = face_BasicFaceRecognizer_getThreshold_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNumComponents()
        //

        //javadoc: BasicFaceRecognizer::getNumComponents()
        public int getNumComponents ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = face_BasicFaceRecognizer_getNumComponents_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  vector_Mat getProjections()
        //

        //javadoc: BasicFaceRecognizer::getProjections()
        public List<Mat> getProjections ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        List<Mat> retVal = new List<Mat>();
        Mat retValMat = new Mat(face_BasicFaceRecognizer_getProjections_10(nativeObj));
        Converters.Mat_to_vector_Mat(retValMat, retVal);
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void setNumComponents(int val)
        //

        //javadoc: BasicFaceRecognizer::setNumComponents(val)
        public void setNumComponents (int val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        face_BasicFaceRecognizer_setNumComponents_10(nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setThreshold(double val)
        //

        //javadoc: BasicFaceRecognizer::setThreshold(val)
        public void setThreshold (double val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        face_BasicFaceRecognizer_setThreshold_10(nativeObj, val);
        
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



        // C++:  Mat getEigenValues()
        [DllImport (LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getEigenValues_10 (IntPtr nativeObj);

        // C++:  Mat getEigenVectors()
        [DllImport (LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getEigenVectors_10 (IntPtr nativeObj);

        // C++:  Mat getLabels()
        [DllImport (LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getLabels_10 (IntPtr nativeObj);

        // C++:  Mat getMean()
        [DllImport (LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getMean_10 (IntPtr nativeObj);

        // C++:  double getThreshold()
        [DllImport (LIBNAME)]
        private static extern double face_BasicFaceRecognizer_getThreshold_10 (IntPtr nativeObj);

        // C++:  int getNumComponents()
        [DllImport (LIBNAME)]
        private static extern int face_BasicFaceRecognizer_getNumComponents_10 (IntPtr nativeObj);

        // C++:  vector_Mat getProjections()
        [DllImport (LIBNAME)]
        private static extern IntPtr face_BasicFaceRecognizer_getProjections_10 (IntPtr nativeObj);

        // C++:  void setNumComponents(int val)
        [DllImport (LIBNAME)]
        private static extern void face_BasicFaceRecognizer_setNumComponents_10 (IntPtr nativeObj, int val);

        // C++:  void setThreshold(double val)
        [DllImport (LIBNAME)]
        private static extern void face_BasicFaceRecognizer_setThreshold_10 (IntPtr nativeObj, double val);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void face_BasicFaceRecognizer_delete (IntPtr nativeObj);

    }
}
