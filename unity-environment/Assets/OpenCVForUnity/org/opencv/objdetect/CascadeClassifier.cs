

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class CascadeClassifier
    //javadoc: CascadeClassifier

    public class CascadeClassifier : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
objdetect_CascadeClassifier_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal CascadeClassifier (IntPtr addr) : base (addr) { }


        public IntPtr getNativeObjAddr () { return nativeObj; }

        //
        // C++:   CascadeClassifier(String filename)
        //

        //javadoc: CascadeClassifier::CascadeClassifier(filename)
        public CascadeClassifier (string filename)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = objdetect_CascadeClassifier_CascadeClassifier_10(filename);
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:   CascadeClassifier()
        //

        //javadoc: CascadeClassifier::CascadeClassifier()
        public CascadeClassifier ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = objdetect_CascadeClassifier_CascadeClassifier_11();
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:  Size getOriginalWindowSize()
        //

        //javadoc: CascadeClassifier::getOriginalWindowSize()
        public Size getOriginalWindowSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
objdetect_CascadeClassifier_getOriginalWindowSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static bool convert(String oldcascade, String newcascade)
        //

        //javadoc: CascadeClassifier::convert(oldcascade, newcascade)
        public static bool convert (string oldcascade, string newcascade)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_CascadeClassifier_convert_10(oldcascade, newcascade);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool empty()
        //

        //javadoc: CascadeClassifier::empty()
        public bool empty ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_CascadeClassifier_empty_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool isOldFormatCascade()
        //

        //javadoc: CascadeClassifier::isOldFormatCascade()
        public bool isOldFormatCascade ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_CascadeClassifier_isOldFormatCascade_10(nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool load(String filename)
        //

        //javadoc: CascadeClassifier::load(filename)
        public bool load (string filename)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = objdetect_CascadeClassifier_load_10(nativeObj, filename);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool read(FileNode node)
        //

        // Unknown type 'FileNode' (I), skipping the function


        //
        // C++:  int getFeatureType()
        //

        //javadoc: CascadeClassifier::getFeatureType()
        public int getFeatureType ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = objdetect_CascadeClassifier_getFeatureType_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        //

        //javadoc: CascadeClassifier::detectMultiScale(image, objects, scaleFactor, minNeighbors, flags, minSize, maxSize)
        public void detectMultiScale (Mat image, MatOfRect objects, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (objects != null) objects.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        objdetect_CascadeClassifier_detectMultiScale_10(nativeObj, image.nativeObj, objects_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height);
        
#else
            return;
#endif
            return;
        }

        //javadoc: CascadeClassifier::detectMultiScale(image, objects)
        public void detectMultiScale (Mat image, MatOfRect objects)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (objects != null) objects.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        objdetect_CascadeClassifier_detectMultiScale_11(nativeObj, image.nativeObj, objects_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void detectMultiScale(Mat image, vector_Rect& objects, vector_int& numDetections, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        //

        //javadoc: CascadeClassifier::detectMultiScale(image, objects, numDetections, scaleFactor, minNeighbors, flags, minSize, maxSize)
        public void detectMultiScale2 (Mat image, MatOfRect objects, MatOfInt numDetections, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (objects != null) objects.ThrowIfDisposed ();
            if (numDetections != null) numDetections.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat numDetections_mat = numDetections;
        objdetect_CascadeClassifier_detectMultiScale2_10(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height);
        
#else
            return;
#endif
            return;
        }

        //javadoc: CascadeClassifier::detectMultiScale(image, objects, numDetections)
        public void detectMultiScale2 (Mat image, MatOfRect objects, MatOfInt numDetections)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (objects != null) objects.ThrowIfDisposed ();
            if (numDetections != null) numDetections.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat numDetections_mat = numDetections;
        objdetect_CascadeClassifier_detectMultiScale2_11(nativeObj, image.nativeObj, objects_mat.nativeObj, numDetections_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void detectMultiScale(Mat image, vector_Rect& objects, vector_int& rejectLevels, vector_double& levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
        //

        //javadoc: CascadeClassifier::detectMultiScale(image, objects, rejectLevels, levelWeights, scaleFactor, minNeighbors, flags, minSize, maxSize, outputRejectLevels)
        public void detectMultiScale3 (Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights, double scaleFactor, int minNeighbors, int flags, Size minSize, Size maxSize, bool outputRejectLevels)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (objects != null) objects.ThrowIfDisposed ();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed ();
            if (levelWeights != null) levelWeights.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat rejectLevels_mat = rejectLevels;
        Mat levelWeights_mat = levelWeights;
        objdetect_CascadeClassifier_detectMultiScale3_10(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj, scaleFactor, minNeighbors, flags, minSize.width, minSize.height, maxSize.width, maxSize.height, outputRejectLevels);
        
#else
            return;
#endif
            return;
        }

        //javadoc: CascadeClassifier::detectMultiScale(image, objects, rejectLevels, levelWeights)
        public void detectMultiScale3 (Mat image, MatOfRect objects, MatOfInt rejectLevels, MatOfDouble levelWeights)
        {
            ThrowIfDisposed ();
            if (image != null) image.ThrowIfDisposed ();
            if (objects != null) objects.ThrowIfDisposed ();
            if (rejectLevels != null) rejectLevels.ThrowIfDisposed ();
            if (levelWeights != null) levelWeights.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat objects_mat = objects;
        Mat rejectLevels_mat = rejectLevels;
        Mat levelWeights_mat = levelWeights;
        objdetect_CascadeClassifier_detectMultiScale3_11(nativeObj, image.nativeObj, objects_mat.nativeObj, rejectLevels_mat.nativeObj, levelWeights_mat.nativeObj);
        
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



        // C++:   CascadeClassifier(String filename)
        [DllImport (LIBNAME)]
        private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_10 (string filename);

        // C++:   CascadeClassifier()
        [DllImport (LIBNAME)]
        private static extern IntPtr objdetect_CascadeClassifier_CascadeClassifier_11 ();

        // C++:  Size getOriginalWindowSize()
        [DllImport (LIBNAME)]
        private static extern void objdetect_CascadeClassifier_getOriginalWindowSize_10 (IntPtr nativeObj, double[] retVal);

        // C++: static bool convert(String oldcascade, String newcascade)
        [DllImport (LIBNAME)]
        private static extern bool objdetect_CascadeClassifier_convert_10 (string oldcascade, string newcascade);

        // C++:  bool empty()
        [DllImport (LIBNAME)]
        private static extern bool objdetect_CascadeClassifier_empty_10 (IntPtr nativeObj);

        // C++:  bool isOldFormatCascade()
        [DllImport (LIBNAME)]
        private static extern bool objdetect_CascadeClassifier_isOldFormatCascade_10 (IntPtr nativeObj);

        // C++:  bool load(String filename)
        [DllImport (LIBNAME)]
        private static extern bool objdetect_CascadeClassifier_load_10 (IntPtr nativeObj, string filename);

        // C++:  int getFeatureType()
        [DllImport (LIBNAME)]
        private static extern int objdetect_CascadeClassifier_getFeatureType_10 (IntPtr nativeObj);

        // C++:  void detectMultiScale(Mat image, vector_Rect& objects, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        [DllImport (LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);
        [DllImport (LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj);

        // C++:  void detectMultiScale(Mat image, vector_Rect& objects, vector_int& numDetections, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size())
        [DllImport (LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height);
        [DllImport (LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale2_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr numDetections_mat_nativeObj);

        // C++:  void detectMultiScale(Mat image, vector_Rect& objects, vector_int& rejectLevels, vector_double& levelWeights, double scaleFactor = 1.1, int minNeighbors = 3, int flags = 0, Size minSize = Size(), Size maxSize = Size(), bool outputRejectLevels = false)
        [DllImport (LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj, double scaleFactor, int minNeighbors, int flags, double minSize_width, double minSize_height, double maxSize_width, double maxSize_height, bool outputRejectLevels);
        [DllImport (LIBNAME)]
        private static extern void objdetect_CascadeClassifier_detectMultiScale3_11 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr objects_mat_nativeObj, IntPtr rejectLevels_mat_nativeObj, IntPtr levelWeights_mat_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void objdetect_CascadeClassifier_delete (IntPtr nativeObj);

    }
}
