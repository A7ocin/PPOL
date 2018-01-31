

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class BOWTrainer
    //javadoc: BOWTrainer

    public class BOWTrainer : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        features2d_BOWTrainer_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal BOWTrainer (IntPtr addr)
            : base (addr)
        {
        }


        public IntPtr getNativeObjAddr ()
        {
            return nativeObj;
        }

        //
        // C++:  Mat cluster(Mat descriptors)
        //

        //javadoc: BOWTrainer::cluster(descriptors)
        public virtual Mat cluster (Mat descriptors)
        {
            ThrowIfDisposed ();
            if (descriptors != null)
                descriptors.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Mat retVal = new Mat (features2d_BOWTrainer_cluster_10 (nativeObj, descriptors.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Mat cluster()
        //

        //javadoc: BOWTrainer::cluster()
        public virtual Mat cluster ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Mat retVal = new Mat (features2d_BOWTrainer_cluster_11 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  int descriptorsCount()
        //

        //javadoc: BOWTrainer::descriptorsCount()
        public int descriptorsCount ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_BOWTrainer_descriptorsCount_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  vector_Mat getDescriptors()
        //

        //javadoc: BOWTrainer::getDescriptors()
        public List<Mat> getDescriptors ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            List<Mat> retVal = new List<Mat> ();
            Mat retValMat = new Mat (features2d_BOWTrainer_getDescriptors_10 (nativeObj));
            Converters.Mat_to_vector_Mat (retValMat, retVal);
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void add(Mat descriptors)
        //

        //javadoc: BOWTrainer::add(descriptors)
        public void add (Mat descriptors)
        {
            ThrowIfDisposed ();
            if (descriptors != null)
                descriptors.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_BOWTrainer_add_10 (nativeObj, descriptors.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void clear()
        //

        //javadoc: BOWTrainer::clear()
        public void clear ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_BOWTrainer_clear_10 (nativeObj);
        
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



        // C++:  Mat cluster(Mat descriptors)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BOWTrainer_cluster_10 (IntPtr nativeObj, IntPtr descriptors_nativeObj);

        // C++:  Mat cluster()
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BOWTrainer_cluster_11 (IntPtr nativeObj);

        // C++:  int descriptorsCount()
        [DllImport (LIBNAME)]
        private static extern int features2d_BOWTrainer_descriptorsCount_10 (IntPtr nativeObj);

        // C++:  vector_Mat getDescriptors()
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BOWTrainer_getDescriptors_10 (IntPtr nativeObj);

        // C++:  void add(Mat descriptors)
        [DllImport (LIBNAME)]
        private static extern void features2d_BOWTrainer_add_10 (IntPtr nativeObj, IntPtr descriptors_nativeObj);

        // C++:  void clear()
        [DllImport (LIBNAME)]
        private static extern void features2d_BOWTrainer_clear_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_BOWTrainer_delete (IntPtr nativeObj);

    }
}
