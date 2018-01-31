

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class SparsePyrLKOpticalFlow
    //javadoc: SparsePyrLKOpticalFlow

    public class SparsePyrLKOpticalFlow : SparseOpticalFlow
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
video_SparsePyrLKOpticalFlow_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal SparsePyrLKOpticalFlow (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_SparsePyrLKOpticalFlow create(Size winSize = Size(21, 21), int maxLevel = 3, TermCriteria crit = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 0.01), int flags = 0, double minEigThreshold = 1e-4)
        //

        //javadoc: SparsePyrLKOpticalFlow::create(winSize, maxLevel, crit, flags, minEigThreshold)
        public static SparsePyrLKOpticalFlow create (Size winSize, int maxLevel, TermCriteria crit, int flags, double minEigThreshold)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SparsePyrLKOpticalFlow retVal = new SparsePyrLKOpticalFlow(video_SparsePyrLKOpticalFlow_create_10(winSize.width, winSize.height, maxLevel, crit.type, crit.maxCount, crit.epsilon, flags, minEigThreshold));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: SparsePyrLKOpticalFlow::create()
        public static SparsePyrLKOpticalFlow create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        SparsePyrLKOpticalFlow retVal = new SparsePyrLKOpticalFlow(video_SparsePyrLKOpticalFlow_create_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Size getWinSize()
        //

        //javadoc: SparsePyrLKOpticalFlow::getWinSize()
        public Size getWinSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[2];
video_SparsePyrLKOpticalFlow_getWinSize_10(nativeObj, tmpArray);
Size retVal = new Size (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  TermCriteria getTermCriteria()
        //

        //javadoc: SparsePyrLKOpticalFlow::getTermCriteria()
        public TermCriteria getTermCriteria ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[3];
video_SparsePyrLKOpticalFlow_getTermCriteria_10(nativeObj, tmpArray);
TermCriteria retVal = new TermCriteria (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  double getMinEigThreshold()
        //

        //javadoc: SparsePyrLKOpticalFlow::getMinEigThreshold()
        public double getMinEigThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = video_SparsePyrLKOpticalFlow_getMinEigThreshold_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getFlags()
        //

        //javadoc: SparsePyrLKOpticalFlow::getFlags()
        public int getFlags ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_SparsePyrLKOpticalFlow_getFlags_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMaxLevel()
        //

        //javadoc: SparsePyrLKOpticalFlow::getMaxLevel()
        public int getMaxLevel ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = video_SparsePyrLKOpticalFlow_getMaxLevel_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setFlags(int flags)
        //

        //javadoc: SparsePyrLKOpticalFlow::setFlags(flags)
        public void setFlags (int flags)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_SparsePyrLKOpticalFlow_setFlags_10(nativeObj, flags);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMaxLevel(int maxLevel)
        //

        //javadoc: SparsePyrLKOpticalFlow::setMaxLevel(maxLevel)
        public void setMaxLevel (int maxLevel)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_SparsePyrLKOpticalFlow_setMaxLevel_10(nativeObj, maxLevel);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMinEigThreshold(double minEigThreshold)
        //

        //javadoc: SparsePyrLKOpticalFlow::setMinEigThreshold(minEigThreshold)
        public void setMinEigThreshold (double minEigThreshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_SparsePyrLKOpticalFlow_setMinEigThreshold_10(nativeObj, minEigThreshold);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setTermCriteria(TermCriteria crit)
        //

        //javadoc: SparsePyrLKOpticalFlow::setTermCriteria(crit)
        public void setTermCriteria (TermCriteria crit)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_SparsePyrLKOpticalFlow_setTermCriteria_10(nativeObj, crit.type, crit.maxCount, crit.epsilon);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWinSize(Size winSize)
        //

        //javadoc: SparsePyrLKOpticalFlow::setWinSize(winSize)
        public void setWinSize (Size winSize)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        video_SparsePyrLKOpticalFlow_setWinSize_10(nativeObj, winSize.width, winSize.height);
        
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



        // C++: static Ptr_SparsePyrLKOpticalFlow create(Size winSize = Size(21, 21), int maxLevel = 3, TermCriteria crit = TermCriteria(TermCriteria::COUNT+TermCriteria::EPS, 30, 0.01), int flags = 0, double minEigThreshold = 1e-4)
        [DllImport (LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_10 (double winSize_width, double winSize_height, int maxLevel, int crit_type, int crit_maxCount, double crit_epsilon, int flags, double minEigThreshold);
        [DllImport (LIBNAME)]
        private static extern IntPtr video_SparsePyrLKOpticalFlow_create_11 ();

        // C++:  Size getWinSize()
        [DllImport (LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_getWinSize_10 (IntPtr nativeObj, double[] retVal);

        // C++:  TermCriteria getTermCriteria()
        [DllImport (LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_getTermCriteria_10 (IntPtr nativeObj, double[] retVal);

        // C++:  double getMinEigThreshold()
        [DllImport (LIBNAME)]
        private static extern double video_SparsePyrLKOpticalFlow_getMinEigThreshold_10 (IntPtr nativeObj);

        // C++:  int getFlags()
        [DllImport (LIBNAME)]
        private static extern int video_SparsePyrLKOpticalFlow_getFlags_10 (IntPtr nativeObj);

        // C++:  int getMaxLevel()
        [DllImport (LIBNAME)]
        private static extern int video_SparsePyrLKOpticalFlow_getMaxLevel_10 (IntPtr nativeObj);

        // C++:  void setFlags(int flags)
        [DllImport (LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setFlags_10 (IntPtr nativeObj, int flags);

        // C++:  void setMaxLevel(int maxLevel)
        [DllImport (LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setMaxLevel_10 (IntPtr nativeObj, int maxLevel);

        // C++:  void setMinEigThreshold(double minEigThreshold)
        [DllImport (LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setMinEigThreshold_10 (IntPtr nativeObj, double minEigThreshold);

        // C++:  void setTermCriteria(TermCriteria crit)
        [DllImport (LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setTermCriteria_10 (IntPtr nativeObj, int crit_type, int crit_maxCount, double crit_epsilon);

        // C++:  void setWinSize(Size winSize)
        [DllImport (LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_setWinSize_10 (IntPtr nativeObj, double winSize_width, double winSize_height);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void video_SparsePyrLKOpticalFlow_delete (IntPtr nativeObj);

    }
}
