

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class EigenFaceRecognizer
    //javadoc: EigenFaceRecognizer

    public class EigenFaceRecognizer : BasicFaceRecognizer
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
face_EigenFaceRecognizer_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal EigenFaceRecognizer (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_EigenFaceRecognizer create(int num_components = 0, double threshold = DBL_MAX)
        //

        //javadoc: EigenFaceRecognizer::create(num_components, threshold)
        public static EigenFaceRecognizer create (int num_components, double threshold)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        EigenFaceRecognizer retVal = new EigenFaceRecognizer(face_EigenFaceRecognizer_create_10(num_components, threshold));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: EigenFaceRecognizer::create()
        public static EigenFaceRecognizer create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        EigenFaceRecognizer retVal = new EigenFaceRecognizer(face_EigenFaceRecognizer_create_11());
        
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



        // C++: static Ptr_EigenFaceRecognizer create(int num_components = 0, double threshold = DBL_MAX)
        [DllImport (LIBNAME)]
        private static extern IntPtr face_EigenFaceRecognizer_create_10 (int num_components, double threshold);
        [DllImport (LIBNAME)]
        private static extern IntPtr face_EigenFaceRecognizer_create_11 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void face_EigenFaceRecognizer_delete (IntPtr nativeObj);

    }
}
