

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class MSER
    //javadoc: MSER

    public class MSER : Feature2D
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        features2d_MSER_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal MSER (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++: static Ptr_MSER create(int _delta = 5, int _min_area = 60, int _max_area = 14400, double _max_variation = 0.25, double _min_diversity = .2, int _max_evolution = 200, double _area_threshold = 1.01, double _min_margin = 0.003, int _edge_blur_size = 5)
        //

        //javadoc: MSER::create(_delta, _min_area, _max_area, _max_variation, _min_diversity, _max_evolution, _area_threshold, _min_margin, _edge_blur_size)
        public static MSER create (int _delta, int _min_area, int _max_area, double _max_variation, double _min_diversity, int _max_evolution, double _area_threshold, double _min_margin, int _edge_blur_size)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            MSER retVal = new MSER (features2d_MSER_create_10 (_delta, _min_area, _max_area, _max_variation, _min_diversity, _max_evolution, _area_threshold, _min_margin, _edge_blur_size));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: MSER::create()
        public static MSER create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            MSER retVal = new MSER (features2d_MSER_create_11 ());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  String getDefaultName()
        //

        //javadoc: MSER::getDefaultName()
        public override string getDefaultName ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            string retVal = Marshal.PtrToStringAnsi (features2d_MSER_getDefaultName_10 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool getPass2Only()
        //

        //javadoc: MSER::getPass2Only()
        public bool getPass2Only ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = features2d_MSER_getPass2Only_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  int getDelta()
        //

        //javadoc: MSER::getDelta()
        public int getDelta ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_MSER_getDelta_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMaxArea()
        //

        //javadoc: MSER::getMaxArea()
        public int getMaxArea ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_MSER_getMaxArea_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMinArea()
        //

        //javadoc: MSER::getMinArea()
        public int getMinArea ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = features2d_MSER_getMinArea_10 (nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void detectRegions(Mat image, vector_vector_Point& msers, vector_Rect& bboxes)
        //

        //javadoc: MSER::detectRegions(image, msers, bboxes)
        public void detectRegions (Mat image, List<MatOfPoint> msers, MatOfRect bboxes)
        {
            ThrowIfDisposed ();
            if (image != null)
                image.ThrowIfDisposed ();
            if (bboxes != null)
                bboxes.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat msers_mat = new Mat ();
            Mat bboxes_mat = bboxes;
            features2d_MSER_detectRegions_10 (nativeObj, image.nativeObj, msers_mat.nativeObj, bboxes_mat.nativeObj);
            Converters.Mat_to_vector_vector_Point (msers_mat, msers);
            msers_mat.release ();
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setDelta(int delta)
        //

        //javadoc: MSER::setDelta(delta)
        public void setDelta (int delta)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_MSER_setDelta_10 (nativeObj, delta);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMaxArea(int maxArea)
        //

        //javadoc: MSER::setMaxArea(maxArea)
        public void setMaxArea (int maxArea)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_MSER_setMaxArea_10 (nativeObj, maxArea);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMinArea(int minArea)
        //

        //javadoc: MSER::setMinArea(minArea)
        public void setMinArea (int minArea)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_MSER_setMinArea_10 (nativeObj, minArea);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPass2Only(bool f)
        //

        //javadoc: MSER::setPass2Only(f)
        public void setPass2Only (bool f)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            features2d_MSER_setPass2Only_10 (nativeObj, f);
        
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



        // C++: static Ptr_MSER create(int _delta = 5, int _min_area = 60, int _max_area = 14400, double _max_variation = 0.25, double _min_diversity = .2, int _max_evolution = 200, double _area_threshold = 1.01, double _min_margin = 0.003, int _edge_blur_size = 5)
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_MSER_create_10 (int _delta, int _min_area, int _max_area, double _max_variation, double _min_diversity, int _max_evolution, double _area_threshold, double _min_margin, int _edge_blur_size);

        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_MSER_create_11 ();

        // C++:  String getDefaultName()
        [DllImport (LIBNAME)]
        private static extern IntPtr features2d_MSER_getDefaultName_10 (IntPtr nativeObj);

        // C++:  bool getPass2Only()
        [DllImport (LIBNAME)]
        private static extern bool features2d_MSER_getPass2Only_10 (IntPtr nativeObj);

        // C++:  int getDelta()
        [DllImport (LIBNAME)]
        private static extern int features2d_MSER_getDelta_10 (IntPtr nativeObj);

        // C++:  int getMaxArea()
        [DllImport (LIBNAME)]
        private static extern int features2d_MSER_getMaxArea_10 (IntPtr nativeObj);

        // C++:  int getMinArea()
        [DllImport (LIBNAME)]
        private static extern int features2d_MSER_getMinArea_10 (IntPtr nativeObj);

        // C++:  void detectRegions(Mat image, vector_vector_Point& msers, vector_Rect& bboxes)
        [DllImport (LIBNAME)]
        private static extern void features2d_MSER_detectRegions_10 (IntPtr nativeObj, IntPtr image_nativeObj, IntPtr msers_mat_nativeObj, IntPtr bboxes_mat_nativeObj);

        // C++:  void setDelta(int delta)
        [DllImport (LIBNAME)]
        private static extern void features2d_MSER_setDelta_10 (IntPtr nativeObj, int delta);

        // C++:  void setMaxArea(int maxArea)
        [DllImport (LIBNAME)]
        private static extern void features2d_MSER_setMaxArea_10 (IntPtr nativeObj, int maxArea);

        // C++:  void setMinArea(int minArea)
        [DllImport (LIBNAME)]
        private static extern void features2d_MSER_setMinArea_10 (IntPtr nativeObj, int minArea);

        // C++:  void setPass2Only(bool f)
        [DllImport (LIBNAME)]
        private static extern void features2d_MSER_setPass2Only_10 (IntPtr nativeObj, bool f);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void features2d_MSER_delete (IntPtr nativeObj);

    }
}
