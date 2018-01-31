

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class BOWKMeansTrainer
    //javadoc: BOWKMeansTrainer

    public class BOWKMeansTrainer : BOWTrainer
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        features2d_BOWKMeansTrainer_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal BOWKMeansTrainer (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++:   BOWKMeansTrainer(int clusterCount, TermCriteria termcrit = TermCriteria(), int attempts = 3, int flags = KMEANS_PP_CENTERS)
        //

        //javadoc: BOWKMeansTrainer::BOWKMeansTrainer(clusterCount, termcrit, attempts, flags)
        public BOWKMeansTrainer (int clusterCount, TermCriteria termcrit, int attempts, int flags) :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        base (features2d_BOWKMeansTrainer_BOWKMeansTrainer_10 (clusterCount, termcrit.type, termcrit.maxCount, termcrit.epsilon, attempts, flags))
        
#else
            base (IntPtr.Zero)
#endif
        {

            return;

        }

        //javadoc: BOWKMeansTrainer::BOWKMeansTrainer(clusterCount)
        public BOWKMeansTrainer (int clusterCount) :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        base (features2d_BOWKMeansTrainer_BOWKMeansTrainer_11 (clusterCount))
        
#else
            base (IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++:  Mat cluster(Mat descriptors)
        //

        //javadoc: BOWKMeansTrainer::cluster(descriptors)
        public override Mat cluster (Mat descriptors)
        {
            ThrowIfDisposed ();
            if (descriptors != null)
                descriptors.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Mat retVal = new Mat (features2d_BOWKMeansTrainer_cluster_10 (nativeObj, descriptors.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Mat cluster()
        //

        //javadoc: BOWKMeansTrainer::cluster()
        public override Mat cluster ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Mat retVal = new Mat (features2d_BOWKMeansTrainer_cluster_11 (nativeObj));
        
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



        // C++:   BOWKMeansTrainer(int clusterCount, TermCriteria termcrit = TermCriteria(), int attempts = 3, int flags = KMEANS_PP_CENTERS)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BOWKMeansTrainer_BOWKMeansTrainer_10 (int clusterCount, int termcrit_type, int termcrit_maxCount, double termcrit_epsilon, int attempts, int flags);

        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BOWKMeansTrainer_BOWKMeansTrainer_11 (int clusterCount);

        // C++:  Mat cluster(Mat descriptors)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BOWKMeansTrainer_cluster_10 (IntPtr nativeObj, IntPtr descriptors_nativeObj);

        // C++:  Mat cluster()
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_BOWKMeansTrainer_cluster_11 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_BOWKMeansTrainer_delete (IntPtr nativeObj);

    }
}
