

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class StandardCollector
    //javadoc: StandardCollector

    public class StandardCollector : PredictCollector
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
face_StandardCollector_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal StandardCollector (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_StandardCollector create(double threshold = DBL_MAX)
        //

        //javadoc: StandardCollector::create(threshold)
        public static StandardCollector create (double threshold)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        StandardCollector retVal = new StandardCollector(face_StandardCollector_create_10(threshold));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: StandardCollector::create()
        public static StandardCollector create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        StandardCollector retVal = new StandardCollector(face_StandardCollector_create_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  double getMinDist()
        //

        //javadoc: StandardCollector::getMinDist()
        public double getMinDist ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = face_StandardCollector_getMinDist_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMinLabel()
        //

        //javadoc: StandardCollector::getMinLabel()
        public int getMinLabel ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = face_StandardCollector_getMinLabel_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  vector_pair_int_and_double getResults(bool sorted = false)
        //

        // Return type 'vector_pair_int_and_double' is not supported, skipping the function


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++: static Ptr_StandardCollector create(double threshold = DBL_MAX)
        [DllImport (LIBNAME)]
        private static extern IntPtr face_StandardCollector_create_10 (double threshold);
        [DllImport (LIBNAME)]
        private static extern IntPtr face_StandardCollector_create_11 ();

        // C++:  double getMinDist()
        [DllImport (LIBNAME)]
        private static extern double face_StandardCollector_getMinDist_10 (IntPtr nativeObj);

        // C++:  int getMinLabel()
        [DllImport (LIBNAME)]
        private static extern int face_StandardCollector_getMinLabel_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void face_StandardCollector_delete (IntPtr nativeObj);

    }
}
