

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class ORB
    //javadoc: ORB

    public class ORB : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        features2d_ORB_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal ORB (IntPtr addr)
            : base (addr)
        {
        }


        public const int kBytes = 32;
        public const int HARRIS_SCORE = 0;
        public const int FAST_SCORE = 1;
        //
        // C++: static Ptr_ORB create(int nfeatures = 500, float scaleFactor = 1.2f, int nlevels = 8, int edgeThreshold = 31, int firstLevel = 0, int WTA_K = 2, int scoreType = ORB::HARRIS_SCORE, int patchSize = 31, int fastThreshold = 20)
        //

        //javadoc: ORB::create(nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K, scoreType, patchSize, fastThreshold)
        public static ORB create (int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType, int patchSize, int fastThreshold)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            ORB retVal = new ORB (features2d_ORB_create_10 (nfeatures, scaleFactor, nlevels, edgeThreshold, firstLevel, WTA_K, scoreType, patchSize, fastThreshold));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: ORB::create()
        public static ORB create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            ORB retVal = new ORB (features2d_ORB_create_11 ());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  String getDefaultName()
        //

        //javadoc: ORB::getDefaultName()
        public override string getDefaultName ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            string retVal = Marshal.PtrToStringAnsi (features2d_ORB_getDefaultName_10 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  double getScaleFactor()
        //

        //javadoc: ORB::getScaleFactor()
        public double getScaleFactor ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = features2d_ORB_getScaleFactor_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getEdgeThreshold()
        //

        //javadoc: ORB::getEdgeThreshold()
        public int getEdgeThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_ORB_getEdgeThreshold_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getFastThreshold()
        //

        //javadoc: ORB::getFastThreshold()
        public int getFastThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_ORB_getFastThreshold_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getFirstLevel()
        //

        //javadoc: ORB::getFirstLevel()
        public int getFirstLevel ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_ORB_getFirstLevel_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMaxFeatures()
        //

        //javadoc: ORB::getMaxFeatures()
        public int getMaxFeatures ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_ORB_getMaxFeatures_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNLevels()
        //

        //javadoc: ORB::getNLevels()
        public int getNLevels ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_ORB_getNLevels_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getPatchSize()
        //

        //javadoc: ORB::getPatchSize()
        public int getPatchSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_ORB_getPatchSize_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getScoreType()
        //

        //javadoc: ORB::getScoreType()
        public int getScoreType ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_ORB_getScoreType_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getWTA_K()
        //

        //javadoc: ORB::getWTA_K()
        public int getWTA_K ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_ORB_getWTA_1K_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setEdgeThreshold(int edgeThreshold)
        //

        //javadoc: ORB::setEdgeThreshold(edgeThreshold)
        public void setEdgeThreshold (int edgeThreshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_ORB_setEdgeThreshold_10 (nativeObj, edgeThreshold);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setFastThreshold(int fastThreshold)
        //

        //javadoc: ORB::setFastThreshold(fastThreshold)
        public void setFastThreshold (int fastThreshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_ORB_setFastThreshold_10 (nativeObj, fastThreshold);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setFirstLevel(int firstLevel)
        //

        //javadoc: ORB::setFirstLevel(firstLevel)
        public void setFirstLevel (int firstLevel)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_ORB_setFirstLevel_10 (nativeObj, firstLevel);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMaxFeatures(int maxFeatures)
        //

        //javadoc: ORB::setMaxFeatures(maxFeatures)
        public void setMaxFeatures (int maxFeatures)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_ORB_setMaxFeatures_10 (nativeObj, maxFeatures);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setNLevels(int nlevels)
        //

        //javadoc: ORB::setNLevels(nlevels)
        public void setNLevels (int nlevels)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_ORB_setNLevels_10 (nativeObj, nlevels);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPatchSize(int patchSize)
        //

        //javadoc: ORB::setPatchSize(patchSize)
        public void setPatchSize (int patchSize)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_ORB_setPatchSize_10 (nativeObj, patchSize);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setScaleFactor(double scaleFactor)
        //

        //javadoc: ORB::setScaleFactor(scaleFactor)
        public void setScaleFactor (double scaleFactor)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_ORB_setScaleFactor_10 (nativeObj, scaleFactor);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setScoreType(int scoreType)
        //

        //javadoc: ORB::setScoreType(scoreType)
        public void setScoreType (int scoreType)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_ORB_setScoreType_10 (nativeObj, scoreType);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setWTA_K(int wta_k)
        //

        //javadoc: ORB::setWTA_K(wta_k)
        public void setWTA_K (int wta_k)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_ORB_setWTA_1K_10 (nativeObj, wta_k);
        
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



        // C++: static Ptr_ORB create(int nfeatures = 500, float scaleFactor = 1.2f, int nlevels = 8, int edgeThreshold = 31, int firstLevel = 0, int WTA_K = 2, int scoreType = ORB::HARRIS_SCORE, int patchSize = 31, int fastThreshold = 20)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_ORB_create_10 (int nfeatures, float scaleFactor, int nlevels, int edgeThreshold, int firstLevel, int WTA_K, int scoreType, int patchSize, int fastThreshold);

        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_ORB_create_11 ();

        // C++:  String getDefaultName()
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_ORB_getDefaultName_10 (IntPtr nativeObj);

        // C++:  double getScaleFactor()
        [DllImport (LIBNAME)]
        private static extern double features2d_ORB_getScaleFactor_10 (IntPtr nativeObj);

        // C++:  int getEdgeThreshold()
        [DllImport (LIBNAME)]
        private static extern int features2d_ORB_getEdgeThreshold_10 (IntPtr nativeObj);

        // C++:  int getFastThreshold()
        [DllImport (LIBNAME)]
        private static extern int features2d_ORB_getFastThreshold_10 (IntPtr nativeObj);

        // C++:  int getFirstLevel()
        [DllImport (LIBNAME)]
        private static extern int features2d_ORB_getFirstLevel_10 (IntPtr nativeObj);

        // C++:  int getMaxFeatures()
        [DllImport (LIBNAME)]
        private static extern int features2d_ORB_getMaxFeatures_10 (IntPtr nativeObj);

        // C++:  int getNLevels()
        [DllImport (LIBNAME)]
        private static extern int features2d_ORB_getNLevels_10 (IntPtr nativeObj);

        // C++:  int getPatchSize()
        [DllImport (LIBNAME)]
        private static extern int features2d_ORB_getPatchSize_10 (IntPtr nativeObj);

        // C++:  int getScoreType()
        [DllImport (LIBNAME)]
        private static extern int features2d_ORB_getScoreType_10 (IntPtr nativeObj);

        // C++:  int getWTA_K()
        [DllImport (LIBNAME)]
        private static extern int features2d_ORB_getWTA_1K_10 (IntPtr nativeObj);

        // C++:  void setEdgeThreshold(int edgeThreshold)
        [DllImport (LIBNAME)]
        private static extern void features2d_ORB_setEdgeThreshold_10 (IntPtr nativeObj, int edgeThreshold);

        // C++:  void setFastThreshold(int fastThreshold)
        [DllImport (LIBNAME)]
        private static extern void features2d_ORB_setFastThreshold_10 (IntPtr nativeObj, int fastThreshold);

        // C++:  void setFirstLevel(int firstLevel)
        [DllImport (LIBNAME)]
        private static extern void features2d_ORB_setFirstLevel_10 (IntPtr nativeObj, int firstLevel);

        // C++:  void setMaxFeatures(int maxFeatures)
        [DllImport (LIBNAME)]
        private static extern void features2d_ORB_setMaxFeatures_10 (IntPtr nativeObj, int maxFeatures);

        // C++:  void setNLevels(int nlevels)
        [DllImport (LIBNAME)]
        private static extern void features2d_ORB_setNLevels_10 (IntPtr nativeObj, int nlevels);

        // C++:  void setPatchSize(int patchSize)
        [DllImport (LIBNAME)]
        private static extern void features2d_ORB_setPatchSize_10 (IntPtr nativeObj, int patchSize);

        // C++:  void setScaleFactor(double scaleFactor)
        [DllImport (LIBNAME)]
        private static extern void features2d_ORB_setScaleFactor_10 (IntPtr nativeObj, double scaleFactor);

        // C++:  void setScoreType(int scoreType)
        [DllImport (LIBNAME)]
        private static extern void features2d_ORB_setScoreType_10 (IntPtr nativeObj, int scoreType);

        // C++:  void setWTA_K(int wta_k)
        [DllImport (LIBNAME)]
        private static extern void features2d_ORB_setWTA_1K_10 (IntPtr nativeObj, int wta_k);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_ORB_delete (IntPtr nativeObj);

    }
}
