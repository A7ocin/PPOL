

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class AKAZE
    //javadoc: AKAZE

    public class AKAZE : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        features2d_AKAZE_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal AKAZE (IntPtr addr)
            : base (addr)
        {
        }


        public const int DESCRIPTOR_KAZE_UPRIGHT = 2;
        public const int DESCRIPTOR_KAZE = 3;
        public const int DESCRIPTOR_MLDB_UPRIGHT = 4;
        public const int DESCRIPTOR_MLDB = 5;
        //
        // C++: static Ptr_AKAZE create(int descriptor_type = AKAZE::DESCRIPTOR_MLDB, int descriptor_size = 0, int descriptor_channels = 3, float threshold = 0.001f, int nOctaves = 4, int nOctaveLayers = 4, int diffusivity = KAZE::DIFF_PM_G2)
        //

        //javadoc: AKAZE::create(descriptor_type, descriptor_size, descriptor_channels, threshold, nOctaves, nOctaveLayers, diffusivity)
        public static AKAZE create (int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves, int nOctaveLayers, int diffusivity)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            AKAZE retVal = new AKAZE (features2d_AKAZE_create_10 (descriptor_type, descriptor_size, descriptor_channels, threshold, nOctaves, nOctaveLayers, diffusivity));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: AKAZE::create()
        public static AKAZE create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            AKAZE retVal = new AKAZE (features2d_AKAZE_create_11 ());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  String getDefaultName()
        //

        //javadoc: AKAZE::getDefaultName()
        public override string getDefaultName ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            string retVal = Marshal.PtrToStringAnsi (features2d_AKAZE_getDefaultName_10 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  double getThreshold()
        //

        //javadoc: AKAZE::getThreshold()
        public double getThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = features2d_AKAZE_getThreshold_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getDescriptorChannels()
        //

        //javadoc: AKAZE::getDescriptorChannels()
        public int getDescriptorChannels ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_AKAZE_getDescriptorChannels_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getDescriptorSize()
        //

        //javadoc: AKAZE::getDescriptorSize()
        public int getDescriptorSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_AKAZE_getDescriptorSize_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getDescriptorType()
        //

        //javadoc: AKAZE::getDescriptorType()
        public int getDescriptorType ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_AKAZE_getDescriptorType_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getDiffusivity()
        //

        //javadoc: AKAZE::getDiffusivity()
        public int getDiffusivity ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_AKAZE_getDiffusivity_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNOctaveLayers()
        //

        //javadoc: AKAZE::getNOctaveLayers()
        public int getNOctaveLayers ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_AKAZE_getNOctaveLayers_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNOctaves()
        //

        //javadoc: AKAZE::getNOctaves()
        public int getNOctaves ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_AKAZE_getNOctaves_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setDescriptorChannels(int dch)
        //

        //javadoc: AKAZE::setDescriptorChannels(dch)
        public void setDescriptorChannels (int dch)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_AKAZE_setDescriptorChannels_10 (nativeObj, dch);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setDescriptorSize(int dsize)
        //

        //javadoc: AKAZE::setDescriptorSize(dsize)
        public void setDescriptorSize (int dsize)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_AKAZE_setDescriptorSize_10 (nativeObj, dsize);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setDescriptorType(int dtype)
        //

        //javadoc: AKAZE::setDescriptorType(dtype)
        public void setDescriptorType (int dtype)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_AKAZE_setDescriptorType_10 (nativeObj, dtype);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setDiffusivity(int diff)
        //

        //javadoc: AKAZE::setDiffusivity(diff)
        public void setDiffusivity (int diff)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_AKAZE_setDiffusivity_10 (nativeObj, diff);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setNOctaveLayers(int octaveLayers)
        //

        //javadoc: AKAZE::setNOctaveLayers(octaveLayers)
        public void setNOctaveLayers (int octaveLayers)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_AKAZE_setNOctaveLayers_10 (nativeObj, octaveLayers);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setNOctaves(int octaves)
        //

        //javadoc: AKAZE::setNOctaves(octaves)
        public void setNOctaves (int octaves)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_AKAZE_setNOctaves_10 (nativeObj, octaves);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setThreshold(double threshold)
        //

        //javadoc: AKAZE::setThreshold(threshold)
        public void setThreshold (double threshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_AKAZE_setThreshold_10 (nativeObj, threshold);
        
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



        // C++: static Ptr_AKAZE create(int descriptor_type = AKAZE::DESCRIPTOR_MLDB, int descriptor_size = 0, int descriptor_channels = 3, float threshold = 0.001f, int nOctaves = 4, int nOctaveLayers = 4, int diffusivity = KAZE::DIFF_PM_G2)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_10 (int descriptor_type, int descriptor_size, int descriptor_channels, float threshold, int nOctaves, int nOctaveLayers, int diffusivity);

        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_AKAZE_create_11 ();

        // C++:  String getDefaultName()
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_AKAZE_getDefaultName_10 (IntPtr nativeObj);

        // C++:  double getThreshold()
        [DllImport (LIBNAME)]
        private static extern double features2d_AKAZE_getThreshold_10 (IntPtr nativeObj);

        // C++:  int getDescriptorChannels()
        [DllImport (LIBNAME)]
        private static extern int features2d_AKAZE_getDescriptorChannels_10 (IntPtr nativeObj);

        // C++:  int getDescriptorSize()
        [DllImport (LIBNAME)]
        private static extern int features2d_AKAZE_getDescriptorSize_10 (IntPtr nativeObj);

        // C++:  int getDescriptorType()
        [DllImport (LIBNAME)]
        private static extern int features2d_AKAZE_getDescriptorType_10 (IntPtr nativeObj);

        // C++:  int getDiffusivity()
        [DllImport (LIBNAME)]
        private static extern int features2d_AKAZE_getDiffusivity_10 (IntPtr nativeObj);

        // C++:  int getNOctaveLayers()
        [DllImport (LIBNAME)]
        private static extern int features2d_AKAZE_getNOctaveLayers_10 (IntPtr nativeObj);

        // C++:  int getNOctaves()
        [DllImport (LIBNAME)]
        private static extern int features2d_AKAZE_getNOctaves_10 (IntPtr nativeObj);

        // C++:  void setDescriptorChannels(int dch)
        [DllImport (LIBNAME)]
        private static extern void features2d_AKAZE_setDescriptorChannels_10 (IntPtr nativeObj, int dch);

        // C++:  void setDescriptorSize(int dsize)
        [DllImport (LIBNAME)]
        private static extern void features2d_AKAZE_setDescriptorSize_10 (IntPtr nativeObj, int dsize);

        // C++:  void setDescriptorType(int dtype)
        [DllImport (LIBNAME)]
        private static extern void features2d_AKAZE_setDescriptorType_10 (IntPtr nativeObj, int dtype);

        // C++:  void setDiffusivity(int diff)
        [DllImport (LIBNAME)]
        private static extern void features2d_AKAZE_setDiffusivity_10 (IntPtr nativeObj, int diff);

        // C++:  void setNOctaveLayers(int octaveLayers)
        [DllImport (LIBNAME)]
        private static extern void features2d_AKAZE_setNOctaveLayers_10 (IntPtr nativeObj, int octaveLayers);

        // C++:  void setNOctaves(int octaves)
        [DllImport (LIBNAME)]
        private static extern void features2d_AKAZE_setNOctaves_10 (IntPtr nativeObj, int octaves);

        // C++:  void setThreshold(double threshold)
        [DllImport (LIBNAME)]
        private static extern void features2d_AKAZE_setThreshold_10 (IntPtr nativeObj, double threshold);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_AKAZE_delete (IntPtr nativeObj);

    }
}
