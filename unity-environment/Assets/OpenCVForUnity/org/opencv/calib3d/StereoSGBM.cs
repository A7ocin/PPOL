

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class StereoSGBM
    //javadoc: StereoSGBM

    public class StereoSGBM : StereoMatcher
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
calib3d_StereoSGBM_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal StereoSGBM (IntPtr addr) : base (addr) { }


        public const int MODE_SGBM = 0;
        public const int MODE_HH = 1;
        public const int MODE_SGBM_3WAY = 2;
        public const int MODE_HH4 = 3;
        //
        // C++: static Ptr_StereoSGBM create(int minDisparity = 0, int numDisparities = 16, int blockSize = 3, int P1 = 0, int P2 = 0, int disp12MaxDiff = 0, int preFilterCap = 0, int uniquenessRatio = 0, int speckleWindowSize = 0, int speckleRange = 0, int mode = StereoSGBM::MODE_SGBM)
        //

        //javadoc: StereoSGBM::create(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio, speckleWindowSize, speckleRange, mode)
        public static StereoSGBM create (int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange, int mode)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = new StereoSGBM(calib3d_StereoSGBM_create_10(minDisparity, numDisparities, blockSize, P1, P2, disp12MaxDiff, preFilterCap, uniquenessRatio, speckleWindowSize, speckleRange, mode));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: StereoSGBM::create()
        public static StereoSGBM create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        StereoSGBM retVal = new StereoSGBM(calib3d_StereoSGBM_create_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  int getMode()
        //

        //javadoc: StereoSGBM::getMode()
        public int getMode ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoSGBM_getMode_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getP1()
        //

        //javadoc: StereoSGBM::getP1()
        public int getP1 ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoSGBM_getP1_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getP2()
        //

        //javadoc: StereoSGBM::getP2()
        public int getP2 ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoSGBM_getP2_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getPreFilterCap()
        //

        //javadoc: StereoSGBM::getPreFilterCap()
        public int getPreFilterCap ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoSGBM_getPreFilterCap_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getUniquenessRatio()
        //

        //javadoc: StereoSGBM::getUniquenessRatio()
        public int getUniquenessRatio ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoSGBM_getUniquenessRatio_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setMode(int mode)
        //

        //javadoc: StereoSGBM::setMode(mode)
        public void setMode (int mode)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        calib3d_StereoSGBM_setMode_10(nativeObj, mode);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setP1(int P1)
        //

        //javadoc: StereoSGBM::setP1(P1)
        public void setP1 (int P1)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        calib3d_StereoSGBM_setP1_10(nativeObj, P1);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setP2(int P2)
        //

        //javadoc: StereoSGBM::setP2(P2)
        public void setP2 (int P2)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        calib3d_StereoSGBM_setP2_10(nativeObj, P2);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPreFilterCap(int preFilterCap)
        //

        //javadoc: StereoSGBM::setPreFilterCap(preFilterCap)
        public void setPreFilterCap (int preFilterCap)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        calib3d_StereoSGBM_setPreFilterCap_10(nativeObj, preFilterCap);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setUniquenessRatio(int uniquenessRatio)
        //

        //javadoc: StereoSGBM::setUniquenessRatio(uniquenessRatio)
        public void setUniquenessRatio (int uniquenessRatio)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        calib3d_StereoSGBM_setUniquenessRatio_10(nativeObj, uniquenessRatio);
        
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



        // C++: static Ptr_StereoSGBM create(int minDisparity = 0, int numDisparities = 16, int blockSize = 3, int P1 = 0, int P2 = 0, int disp12MaxDiff = 0, int preFilterCap = 0, int uniquenessRatio = 0, int speckleWindowSize = 0, int speckleRange = 0, int mode = StereoSGBM::MODE_SGBM)
        [DllImport (LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_10 (int minDisparity, int numDisparities, int blockSize, int P1, int P2, int disp12MaxDiff, int preFilterCap, int uniquenessRatio, int speckleWindowSize, int speckleRange, int mode);
        [DllImport (LIBNAME)]
        private static extern IntPtr calib3d_StereoSGBM_create_11 ();

        // C++:  int getMode()
        [DllImport (LIBNAME)]
        private static extern int calib3d_StereoSGBM_getMode_10 (IntPtr nativeObj);

        // C++:  int getP1()
        [DllImport (LIBNAME)]
        private static extern int calib3d_StereoSGBM_getP1_10 (IntPtr nativeObj);

        // C++:  int getP2()
        [DllImport (LIBNAME)]
        private static extern int calib3d_StereoSGBM_getP2_10 (IntPtr nativeObj);

        // C++:  int getPreFilterCap()
        [DllImport (LIBNAME)]
        private static extern int calib3d_StereoSGBM_getPreFilterCap_10 (IntPtr nativeObj);

        // C++:  int getUniquenessRatio()
        [DllImport (LIBNAME)]
        private static extern int calib3d_StereoSGBM_getUniquenessRatio_10 (IntPtr nativeObj);

        // C++:  void setMode(int mode)
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoSGBM_setMode_10 (IntPtr nativeObj, int mode);

        // C++:  void setP1(int P1)
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoSGBM_setP1_10 (IntPtr nativeObj, int P1);

        // C++:  void setP2(int P2)
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoSGBM_setP2_10 (IntPtr nativeObj, int P2);

        // C++:  void setPreFilterCap(int preFilterCap)
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoSGBM_setPreFilterCap_10 (IntPtr nativeObj, int preFilterCap);

        // C++:  void setUniquenessRatio(int uniquenessRatio)
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoSGBM_setUniquenessRatio_10 (IntPtr nativeObj, int uniquenessRatio);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoSGBM_delete (IntPtr nativeObj);

    }
}
