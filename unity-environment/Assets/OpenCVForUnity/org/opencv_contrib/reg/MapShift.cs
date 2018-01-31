

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class MapShift
    //javadoc: MapShift

    public class MapShift : Map
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        reg_MapShift_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal MapShift (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++:   MapShift(Mat shift)
        //

        //javadoc: MapShift::MapShift(shift)
        public MapShift (Mat shift) :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        base (reg_MapShift_MapShift_10 (shift.nativeObj))
        
#else
            base (IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++:   MapShift()
        //

        //javadoc: MapShift::MapShift()
        public MapShift () :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        base (reg_MapShift_MapShift_11 ())
        
#else
            base (IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++:  Ptr_Map inverseMap()
        //

        //javadoc: MapShift::inverseMap()
        public override Map inverseMap ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Map retVal = new Map (reg_MapShift_inverseMap_10 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void compose(Ptr_Map map)
        //

        //javadoc: MapShift::compose(map)
        public override void compose (Map map)
        {
            ThrowIfDisposed ();
            if (map != null)
                map.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            reg_MapShift_compose_10 (nativeObj, map.getNativeObjAddr ());
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getShift(Mat& shift)
        //

        //javadoc: MapShift::getShift(shift)
        public void getShift (Mat shift)
        {
            ThrowIfDisposed ();
            if (shift != null)
                shift.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            reg_MapShift_getShift_10 (nativeObj, shift.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void inverseWarp(Mat img1, Mat& img2)
        //

        //javadoc: MapShift::inverseWarp(img1, img2)
        public override void inverseWarp (Mat img1, Mat img2)
        {
            ThrowIfDisposed ();
            if (img1 != null)
                img1.ThrowIfDisposed ();
            if (img2 != null)
                img2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            reg_MapShift_inverseWarp_10 (nativeObj, img1.nativeObj, img2.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void scale(double factor)
        //

        //javadoc: MapShift::scale(factor)
        public override void scale (double factor)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            reg_MapShift_scale_10 (nativeObj, factor);
        
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



        // C++:   MapShift(Mat shift)
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapShift_MapShift_10 (IntPtr shift_nativeObj);

        // C++:   MapShift()
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapShift_MapShift_11 ();

        // C++:  Ptr_Map inverseMap()
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapShift_inverseMap_10 (IntPtr nativeObj);

        // C++:  void compose(Ptr_Map map)
        [DllImport (LIBNAME)]
        private static extern void reg_MapShift_compose_10 (IntPtr nativeObj, IntPtr map_nativeObj);

        // C++:  void getShift(Mat& shift)
        [DllImport (LIBNAME)]
        private static extern void reg_MapShift_getShift_10 (IntPtr nativeObj, IntPtr shift_nativeObj);

        // C++:  void inverseWarp(Mat img1, Mat& img2)
        [DllImport (LIBNAME)]
        private static extern void reg_MapShift_inverseWarp_10 (IntPtr nativeObj, IntPtr img1_nativeObj, IntPtr img2_nativeObj);

        // C++:  void scale(double factor)
        [DllImport (LIBNAME)]
        private static extern void reg_MapShift_scale_10 (IntPtr nativeObj, double factor);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void reg_MapShift_delete (IntPtr nativeObj);

    }
}
