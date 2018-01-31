

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class FisherFaceRecognizer
    //javadoc: FisherFaceRecognizer

    public class FisherFaceRecognizer : BasicFaceRecognizer
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
face_FisherFaceRecognizer_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal FisherFaceRecognizer (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_FisherFaceRecognizer create(int num_components = 0, double threshold = DBL_MAX)
        //

        //javadoc: FisherFaceRecognizer::create(num_components, threshold)
        public static FisherFaceRecognizer create (int num_components, double threshold)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        FisherFaceRecognizer retVal = new FisherFaceRecognizer(face_FisherFaceRecognizer_create_10(num_components, threshold));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: FisherFaceRecognizer::create()
        public static FisherFaceRecognizer create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        FisherFaceRecognizer retVal = new FisherFaceRecognizer(face_FisherFaceRecognizer_create_11());
        
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



        // C++: static Ptr_FisherFaceRecognizer create(int num_components = 0, double threshold = DBL_MAX)
        [DllImport (LIBNAME)]
        private static extern IntPtr face_FisherFaceRecognizer_create_10 (int num_components, double threshold);
        [DllImport (LIBNAME)]
        private static extern IntPtr face_FisherFaceRecognizer_create_11 ();

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void face_FisherFaceRecognizer_delete (IntPtr nativeObj);

    }
}
