

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class MapProjec
    //javadoc: MapProjec

    public class MapProjec : Map
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        reg_MapProjec_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal MapProjec (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++:   MapProjec(Mat projTr)
        //

        //javadoc: MapProjec::MapProjec(projTr)
        public MapProjec (Mat projTr) :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        base (reg_MapProjec_MapProjec_10 (projTr.nativeObj))
        
#else
            base (IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++:   MapProjec()
        //

        //javadoc: MapProjec::MapProjec()
        public MapProjec () :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        base (reg_MapProjec_MapProjec_11 ())
        
#else
            base (IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++:  Ptr_Map inverseMap()
        //

        //javadoc: MapProjec::inverseMap()
        public override Map inverseMap ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Map retVal = new Map (reg_MapProjec_inverseMap_10 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void compose(Ptr_Map map)
        //

        //javadoc: MapProjec::compose(map)
        public override void compose (Map map)
        {
            ThrowIfDisposed ();
            if (map != null)
                map.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            reg_MapProjec_compose_10 (nativeObj, map.getNativeObjAddr ());
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getProjTr(Mat& projTr)
        //

        //javadoc: MapProjec::getProjTr(projTr)
        public void getProjTr (Mat projTr)
        {
            ThrowIfDisposed ();
            if (projTr != null)
                projTr.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            reg_MapProjec_getProjTr_10 (nativeObj, projTr.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void inverseWarp(Mat img1, Mat& img2)
        //

        //javadoc: MapProjec::inverseWarp(img1, img2)
        public override void inverseWarp (Mat img1, Mat img2)
        {
            ThrowIfDisposed ();
            if (img1 != null)
                img1.ThrowIfDisposed ();
            if (img2 != null)
                img2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            reg_MapProjec_inverseWarp_10 (nativeObj, img1.nativeObj, img2.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void normalize()
        //

        //javadoc: MapProjec::normalize()
        public void normalize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            reg_MapProjec_normalize_10 (nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void scale(double factor)
        //

        //javadoc: MapProjec::scale(factor)
        public override void scale (double factor)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            reg_MapProjec_scale_10 (nativeObj, factor);
        
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



        // C++:   MapProjec(Mat projTr)
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapProjec_MapProjec_10 (IntPtr projTr_nativeObj);

        // C++:   MapProjec()
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapProjec_MapProjec_11 ();

        // C++:  Ptr_Map inverseMap()
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapProjec_inverseMap_10 (IntPtr nativeObj);

        // C++:  void compose(Ptr_Map map)
        [DllImport (LIBNAME)]
        private static extern void reg_MapProjec_compose_10 (IntPtr nativeObj, IntPtr map_nativeObj);

        // C++:  void getProjTr(Mat& projTr)
        [DllImport (LIBNAME)]
        private static extern void reg_MapProjec_getProjTr_10 (IntPtr nativeObj, IntPtr projTr_nativeObj);

        // C++:  void inverseWarp(Mat img1, Mat& img2)
        [DllImport (LIBNAME)]
        private static extern void reg_MapProjec_inverseWarp_10 (IntPtr nativeObj, IntPtr img1_nativeObj, IntPtr img2_nativeObj);

        // C++:  void normalize()
        [DllImport (LIBNAME)]
        private static extern void reg_MapProjec_normalize_10 (IntPtr nativeObj);

        // C++:  void scale(double factor)
        [DllImport (LIBNAME)]
        private static extern void reg_MapProjec_scale_10 (IntPtr nativeObj, double factor);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void reg_MapProjec_delete (IntPtr nativeObj);

    }
}
