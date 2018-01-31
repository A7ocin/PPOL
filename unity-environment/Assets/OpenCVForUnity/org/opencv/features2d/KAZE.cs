

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class KAZE
    //javadoc: KAZE

    public class KAZE : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        features2d_KAZE_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal KAZE (IntPtr addr)
            : base (addr)
        {
        }


        public const int DIFF_PM_G1 = 0;
        public const int DIFF_PM_G2 = 1;
        public const int DIFF_WEICKERT = 2;
        public const int DIFF_CHARBONNIER = 3;
        //
        // C++: static Ptr_KAZE create(bool extended = false, bool upright = false, float threshold = 0.001f, int nOctaves = 4, int nOctaveLayers = 4, int diffusivity = KAZE::DIFF_PM_G2)
        //

        //javadoc: KAZE::create(extended, upright, threshold, nOctaves, nOctaveLayers, diffusivity)
        public static KAZE create (bool extended, bool upright, float threshold, int nOctaves, int nOctaveLayers, int diffusivity)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            KAZE retVal = new KAZE (features2d_KAZE_create_10 (extended, upright, threshold, nOctaves, nOctaveLayers, diffusivity));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: KAZE::create()
        public static KAZE create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            KAZE retVal = new KAZE (features2d_KAZE_create_11 ());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  String getDefaultName()
        //

        //javadoc: KAZE::getDefaultName()
        public override string getDefaultName ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            string retVal = Marshal.PtrToStringAnsi (features2d_KAZE_getDefaultName_10 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool getExtended()
        //

        //javadoc: KAZE::getExtended()
        public bool getExtended ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = features2d_KAZE_getExtended_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool getUpright()
        //

        //javadoc: KAZE::getUpright()
        public bool getUpright ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = features2d_KAZE_getUpright_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  double getThreshold()
        //

        //javadoc: KAZE::getThreshold()
        public double getThreshold ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            double retVal = features2d_KAZE_getThreshold_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getDiffusivity()
        //

        //javadoc: KAZE::getDiffusivity()
        public int getDiffusivity ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_KAZE_getDiffusivity_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNOctaveLayers()
        //

        //javadoc: KAZE::getNOctaveLayers()
        public int getNOctaveLayers ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_KAZE_getNOctaveLayers_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNOctaves()
        //

        //javadoc: KAZE::getNOctaves()
        public int getNOctaves ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_KAZE_getNOctaves_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void setDiffusivity(int diff)
        //

        //javadoc: KAZE::setDiffusivity(diff)
        public void setDiffusivity (int diff)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_KAZE_setDiffusivity_10 (nativeObj, diff);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setExtended(bool extended)
        //

        //javadoc: KAZE::setExtended(extended)
        public void setExtended (bool extended)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_KAZE_setExtended_10 (nativeObj, extended);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setNOctaveLayers(int octaveLayers)
        //

        //javadoc: KAZE::setNOctaveLayers(octaveLayers)
        public void setNOctaveLayers (int octaveLayers)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_KAZE_setNOctaveLayers_10 (nativeObj, octaveLayers);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setNOctaves(int octaves)
        //

        //javadoc: KAZE::setNOctaves(octaves)
        public void setNOctaves (int octaves)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_KAZE_setNOctaves_10 (nativeObj, octaves);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setThreshold(double threshold)
        //

        //javadoc: KAZE::setThreshold(threshold)
        public void setThreshold (double threshold)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_KAZE_setThreshold_10 (nativeObj, threshold);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setUpright(bool upright)
        //

        //javadoc: KAZE::setUpright(upright)
        public void setUpright (bool upright)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_KAZE_setUpright_10 (nativeObj, upright);
        
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



        // C++: static Ptr_KAZE create(bool extended = false, bool upright = false, float threshold = 0.001f, int nOctaves = 4, int nOctaveLayers = 4, int diffusivity = KAZE::DIFF_PM_G2)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_10 (bool extended, bool upright, float threshold, int nOctaves, int nOctaveLayers, int diffusivity);

        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_KAZE_create_11 ();

        // C++:  String getDefaultName()
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_KAZE_getDefaultName_10 (IntPtr nativeObj);

        // C++:  bool getExtended()
        [DllImport (LIBNAME)]
        private static extern bool features2d_KAZE_getExtended_10 (IntPtr nativeObj);

        // C++:  bool getUpright()
        [DllImport (LIBNAME)]
        private static extern bool features2d_KAZE_getUpright_10 (IntPtr nativeObj);

        // C++:  double getThreshold()
        [DllImport (LIBNAME)]
        private static extern double features2d_KAZE_getThreshold_10 (IntPtr nativeObj);

        // C++:  int getDiffusivity()
        [DllImport (LIBNAME)]
        private static extern int features2d_KAZE_getDiffusivity_10 (IntPtr nativeObj);

        // C++:  int getNOctaveLayers()
        [DllImport (LIBNAME)]
        private static extern int features2d_KAZE_getNOctaveLayers_10 (IntPtr nativeObj);

        // C++:  int getNOctaves()
        [DllImport (LIBNAME)]
        private static extern int features2d_KAZE_getNOctaves_10 (IntPtr nativeObj);

        // C++:  void setDiffusivity(int diff)
        [DllImport (LIBNAME)]
        private static extern void features2d_KAZE_setDiffusivity_10 (IntPtr nativeObj, int diff);

        // C++:  void setExtended(bool extended)
        [DllImport (LIBNAME)]
        private static extern void features2d_KAZE_setExtended_10 (IntPtr nativeObj, bool extended);

        // C++:  void setNOctaveLayers(int octaveLayers)
        [DllImport (LIBNAME)]
        private static extern void features2d_KAZE_setNOctaveLayers_10 (IntPtr nativeObj, int octaveLayers);

        // C++:  void setNOctaves(int octaves)
        [DllImport (LIBNAME)]
        private static extern void features2d_KAZE_setNOctaves_10 (IntPtr nativeObj, int octaves);

        // C++:  void setThreshold(double threshold)
        [DllImport (LIBNAME)]
        private static extern void features2d_KAZE_setThreshold_10 (IntPtr nativeObj, double threshold);

        // C++:  void setUpright(bool upright)
        [DllImport (LIBNAME)]
        private static extern void features2d_KAZE_setUpright_10 (IntPtr nativeObj, bool upright);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_KAZE_delete (IntPtr nativeObj);

    }
}
