

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class StereoBM
    //javadoc: StereoBM

    public class StereoBM : StereoMatcher
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
calib3d_StereoBM_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal StereoBM (IntPtr addr) : base (addr) { }


        public const int PREFILTER_NORMALIZED_RESPONSE = 0;
        public const int PREFILTER_XSOBEL = 1;
        //
        // C++: static Ptr_StereoBM create(int numDisparities = 0, int blockSize = 21)
        //

        //javadoc: StereoBM::create(numDisparities, blockSize)
        public static StereoBM create (int numDisparities, int blockSize)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        StereoBM retVal = new StereoBM(calib3d_StereoBM_create_10(numDisparities, blockSize));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: StereoBM::create()
        public static StereoBM create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        StereoBM retVal = new StereoBM(calib3d_StereoBM_create_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Rect getROI1()
        //

        //javadoc: StereoBM::getROI1()
        public Rect getROI1 ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[4];
calib3d_StereoBM_getROI1_10(nativeObj, tmpArray);
Rect retVal = new Rect (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Rect getROI2()
        //

        //javadoc: StereoBM::getROI2()
        public Rect getROI2 ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[4];
calib3d_StereoBM_getROI2_10(nativeObj, tmpArray);
Rect retVal = new Rect (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  int getPreFilterCap()
        //

        //javadoc: StereoBM::getPreFilterCap()
        public int getPreFilterCap ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoBM_getPreFilterCap_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getPreFilterSize()
        //

        //javadoc: StereoBM::getPreFilterSize()
        public int getPreFilterSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoBM_getPreFilterSize_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getPreFilterType()
        //

        //javadoc: StereoBM::getPreFilterType()
        public int getPreFilterType ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoBM_getPreFilterType_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getSmallerBlockSize()
        //

        //javadoc: StereoBM::getSmallerBlockSize()
        public int getSmallerBlockSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoBM_getSmallerBlockSize_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getTextureThreshold()
        //

        //javadoc: StereoBM::getTextureThreshold()
        public int getTextureThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoBM_getTextureThreshold_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getUniquenessRatio()
        //

        //javadoc: StereoBM::getUniquenessRatio()
        public int getUniquenessRatio ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = calib3d_StereoBM_getUniquenessRatio_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setPreFilterCap(int preFilterCap)
        //

        //javadoc: StereoBM::setPreFilterCap(preFilterCap)
        public void setPreFilterCap (int preFilterCap)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        calib3d_StereoBM_setPreFilterCap_10(nativeObj, preFilterCap);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPreFilterSize(int preFilterSize)
        //

        //javadoc: StereoBM::setPreFilterSize(preFilterSize)
        public void setPreFilterSize (int preFilterSize)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        calib3d_StereoBM_setPreFilterSize_10(nativeObj, preFilterSize);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPreFilterType(int preFilterType)
        //

        //javadoc: StereoBM::setPreFilterType(preFilterType)
        public void setPreFilterType (int preFilterType)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        calib3d_StereoBM_setPreFilterType_10(nativeObj, preFilterType);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setROI1(Rect roi1)
        //

        //javadoc: StereoBM::setROI1(roi1)
        public void setROI1 (Rect roi1)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        calib3d_StereoBM_setROI1_10(nativeObj, roi1.x, roi1.y, roi1.width, roi1.height);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setROI2(Rect roi2)
        //

        //javadoc: StereoBM::setROI2(roi2)
        public void setROI2 (Rect roi2)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        calib3d_StereoBM_setROI2_10(nativeObj, roi2.x, roi2.y, roi2.width, roi2.height);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setSmallerBlockSize(int blockSize)
        //

        //javadoc: StereoBM::setSmallerBlockSize(blockSize)
        public void setSmallerBlockSize (int blockSize)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        calib3d_StereoBM_setSmallerBlockSize_10(nativeObj, blockSize);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setTextureThreshold(int textureThreshold)
        //

        //javadoc: StereoBM::setTextureThreshold(textureThreshold)
        public void setTextureThreshold (int textureThreshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        calib3d_StereoBM_setTextureThreshold_10(nativeObj, textureThreshold);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setUniquenessRatio(int uniquenessRatio)
        //

        //javadoc: StereoBM::setUniquenessRatio(uniquenessRatio)
        public void setUniquenessRatio (int uniquenessRatio)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        calib3d_StereoBM_setUniquenessRatio_10(nativeObj, uniquenessRatio);
        
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



        // C++: static Ptr_StereoBM create(int numDisparities = 0, int blockSize = 21)
        [DllImport (LIBNAME)]
        private static extern IntPtr calib3d_StereoBM_create_10 (int numDisparities, int blockSize);
        [DllImport (LIBNAME)]
        private static extern IntPtr calib3d_StereoBM_create_11 ();

        // C++:  Rect getROI1()
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoBM_getROI1_10 (IntPtr nativeObj, double[] retVal);

        // C++:  Rect getROI2()
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoBM_getROI2_10 (IntPtr nativeObj, double[] retVal);

        // C++:  int getPreFilterCap()
        [DllImport (LIBNAME)]
        private static extern int calib3d_StereoBM_getPreFilterCap_10 (IntPtr nativeObj);

        // C++:  int getPreFilterSize()
        [DllImport (LIBNAME)]
        private static extern int calib3d_StereoBM_getPreFilterSize_10 (IntPtr nativeObj);

        // C++:  int getPreFilterType()
        [DllImport (LIBNAME)]
        private static extern int calib3d_StereoBM_getPreFilterType_10 (IntPtr nativeObj);

        // C++:  int getSmallerBlockSize()
        [DllImport (LIBNAME)]
        private static extern int calib3d_StereoBM_getSmallerBlockSize_10 (IntPtr nativeObj);

        // C++:  int getTextureThreshold()
        [DllImport (LIBNAME)]
        private static extern int calib3d_StereoBM_getTextureThreshold_10 (IntPtr nativeObj);

        // C++:  int getUniquenessRatio()
        [DllImport (LIBNAME)]
        private static extern int calib3d_StereoBM_getUniquenessRatio_10 (IntPtr nativeObj);

        // C++:  void setPreFilterCap(int preFilterCap)
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoBM_setPreFilterCap_10 (IntPtr nativeObj, int preFilterCap);

        // C++:  void setPreFilterSize(int preFilterSize)
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoBM_setPreFilterSize_10 (IntPtr nativeObj, int preFilterSize);

        // C++:  void setPreFilterType(int preFilterType)
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoBM_setPreFilterType_10 (IntPtr nativeObj, int preFilterType);

        // C++:  void setROI1(Rect roi1)
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoBM_setROI1_10 (IntPtr nativeObj, int roi1_x, int roi1_y, int roi1_width, int roi1_height);

        // C++:  void setROI2(Rect roi2)
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoBM_setROI2_10 (IntPtr nativeObj, int roi2_x, int roi2_y, int roi2_width, int roi2_height);

        // C++:  void setSmallerBlockSize(int blockSize)
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoBM_setSmallerBlockSize_10 (IntPtr nativeObj, int blockSize);

        // C++:  void setTextureThreshold(int textureThreshold)
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoBM_setTextureThreshold_10 (IntPtr nativeObj, int textureThreshold);

        // C++:  void setUniquenessRatio(int uniquenessRatio)
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoBM_setUniquenessRatio_10 (IntPtr nativeObj, int uniquenessRatio);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void calib3d_StereoBM_delete (IntPtr nativeObj);

    }
}
