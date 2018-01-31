

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class GFTTDetector
    //javadoc: GFTTDetector

    public class GFTTDetector : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        features2d_GFTTDetector_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal GFTTDetector (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++: static Ptr_GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector = false, double k = 0.04)
        //

        //javadoc: GFTTDetector::create(maxCorners, qualityLevel, minDistance, blockSize, gradiantSize, useHarrisDetector, k)
        public static GFTTDetector create (int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector, double k)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            GFTTDetector retVal = new GFTTDetector (features2d_GFTTDetector_create_10 (maxCorners, qualityLevel, minDistance, blockSize, gradiantSize, useHarrisDetector, k));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: GFTTDetector::create(maxCorners, qualityLevel, minDistance, blockSize, gradiantSize)
        public static GFTTDetector create (int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            GFTTDetector retVal = new GFTTDetector (features2d_GFTTDetector_create_11 (maxCorners, qualityLevel, minDistance, blockSize, gradiantSize));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_GFTTDetector create(int maxCorners = 1000, double qualityLevel = 0.01, double minDistance = 1, int blockSize = 3, bool useHarrisDetector = false, double k = 0.04)
        //

        //javadoc: GFTTDetector::create(maxCorners, qualityLevel, minDistance, blockSize, useHarrisDetector, k)
        public static GFTTDetector create (int maxCorners, double qualityLevel, double minDistance, int blockSize, bool useHarrisDetector, double k)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            GFTTDetector retVal = new GFTTDetector (features2d_GFTTDetector_create_12 (maxCorners, qualityLevel, minDistance, blockSize, useHarrisDetector, k));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: GFTTDetector::create()
        public static GFTTDetector create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            GFTTDetector retVal = new GFTTDetector (features2d_GFTTDetector_create_13 ());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  String getDefaultName()
        //

        //javadoc: GFTTDetector::getDefaultName()
        public override string getDefaultName ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            string retVal = Marshal.PtrToStringAnsi (features2d_GFTTDetector_getDefaultName_10 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool getHarrisDetector()
        //

        //javadoc: GFTTDetector::getHarrisDetector()
        public bool getHarrisDetector ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = features2d_GFTTDetector_getHarrisDetector_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  double getK()
        //

        //javadoc: GFTTDetector::getK()
        public double getK ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = features2d_GFTTDetector_getK_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getMinDistance()
        //

        //javadoc: GFTTDetector::getMinDistance()
        public double getMinDistance ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = features2d_GFTTDetector_getMinDistance_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getQualityLevel()
        //

        //javadoc: GFTTDetector::getQualityLevel()
        public double getQualityLevel ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = features2d_GFTTDetector_getQualityLevel_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getBlockSize()
        //

        //javadoc: GFTTDetector::getBlockSize()
        public int getBlockSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_GFTTDetector_getBlockSize_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMaxFeatures()
        //

        //javadoc: GFTTDetector::getMaxFeatures()
        public int getMaxFeatures ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_GFTTDetector_getMaxFeatures_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setBlockSize(int blockSize)
        //

        //javadoc: GFTTDetector::setBlockSize(blockSize)
        public void setBlockSize (int blockSize)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_GFTTDetector_setBlockSize_10 (nativeObj, blockSize);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setHarrisDetector(bool val)
        //

        //javadoc: GFTTDetector::setHarrisDetector(val)
        public void setHarrisDetector (bool val)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_GFTTDetector_setHarrisDetector_10 (nativeObj, val);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setK(double k)
        //

        //javadoc: GFTTDetector::setK(k)
        public void setK (double k)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_GFTTDetector_setK_10 (nativeObj, k);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMaxFeatures(int maxFeatures)
        //

        //javadoc: GFTTDetector::setMaxFeatures(maxFeatures)
        public void setMaxFeatures (int maxFeatures)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_GFTTDetector_setMaxFeatures_10 (nativeObj, maxFeatures);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMinDistance(double minDistance)
        //

        //javadoc: GFTTDetector::setMinDistance(minDistance)
        public void setMinDistance (double minDistance)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_GFTTDetector_setMinDistance_10 (nativeObj, minDistance);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setQualityLevel(double qlevel)
        //

        //javadoc: GFTTDetector::setQualityLevel(qlevel)
        public void setQualityLevel (double qlevel)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_GFTTDetector_setQualityLevel_10 (nativeObj, qlevel);
        
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



        // C++: static Ptr_GFTTDetector create(int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector = false, double k = 0.04)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_10 (int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize, bool useHarrisDetector, double k);

        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_11 (int maxCorners, double qualityLevel, double minDistance, int blockSize, int gradiantSize);

        // C++: static Ptr_GFTTDetector create(int maxCorners = 1000, double qualityLevel = 0.01, double minDistance = 1, int blockSize = 3, bool useHarrisDetector = false, double k = 0.04)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_12 (int maxCorners, double qualityLevel, double minDistance, int blockSize, bool useHarrisDetector, double k);

        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_create_13 ();

        // C++:  String getDefaultName()
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_GFTTDetector_getDefaultName_10 (IntPtr nativeObj);

        // C++:  bool getHarrisDetector()
        [DllImport (LIBNAME)]
        private static extern bool features2d_GFTTDetector_getHarrisDetector_10 (IntPtr nativeObj);

        // C++:  double getK()
        [DllImport (LIBNAME)]
        private static extern double features2d_GFTTDetector_getK_10 (IntPtr nativeObj);

        // C++:  double getMinDistance()
        [DllImport (LIBNAME)]
        private static extern double features2d_GFTTDetector_getMinDistance_10 (IntPtr nativeObj);

        // C++:  double getQualityLevel()
        [DllImport (LIBNAME)]
        private static extern double features2d_GFTTDetector_getQualityLevel_10 (IntPtr nativeObj);

        // C++:  int getBlockSize()
        [DllImport (LIBNAME)]
        private static extern int features2d_GFTTDetector_getBlockSize_10 (IntPtr nativeObj);

        // C++:  int getMaxFeatures()
        [DllImport (LIBNAME)]
        private static extern int features2d_GFTTDetector_getMaxFeatures_10 (IntPtr nativeObj);

        // C++:  void setBlockSize(int blockSize)
        [DllImport (LIBNAME)]
        private static extern void features2d_GFTTDetector_setBlockSize_10 (IntPtr nativeObj, int blockSize);

        // C++:  void setHarrisDetector(bool val)
        [DllImport (LIBNAME)]
        private static extern void features2d_GFTTDetector_setHarrisDetector_10 (IntPtr nativeObj, bool val);

        // C++:  void setK(double k)
        [DllImport (LIBNAME)]
        private static extern void features2d_GFTTDetector_setK_10 (IntPtr nativeObj, double k);

        // C++:  void setMaxFeatures(int maxFeatures)
        [DllImport (LIBNAME)]
        private static extern void features2d_GFTTDetector_setMaxFeatures_10 (IntPtr nativeObj, int maxFeatures);

        // C++:  void setMinDistance(double minDistance)
        [DllImport (LIBNAME)]
        private static extern void features2d_GFTTDetector_setMinDistance_10 (IntPtr nativeObj, double minDistance);

        // C++:  void setQualityLevel(double qlevel)
        [DllImport (LIBNAME)]
        private static extern void features2d_GFTTDetector_setQualityLevel_10 (IntPtr nativeObj, double qlevel);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_GFTTDetector_delete (IntPtr nativeObj);

    }
}
