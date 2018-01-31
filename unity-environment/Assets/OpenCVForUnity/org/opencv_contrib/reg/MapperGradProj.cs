

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class MapperGradProj
    //javadoc: MapperGradProj

    public class MapperGradProj : Mapper
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        reg_MapperGradProj_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal MapperGradProj (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++:   MapperGradProj()
        //

        //javadoc: MapperGradProj::MapperGradProj()
        public MapperGradProj () :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        base (reg_MapperGradProj_MapperGradProj_10 ())
        
#else
            base (IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++:  Ptr_Map calculate(Mat img1, Mat img2, Ptr_Map init = cv::Ptr<Map>())
        //

        //javadoc: MapperGradProj::calculate(img1, img2, init)
        public override Map calculate (Mat img1, Mat img2, Map init)
        {
            ThrowIfDisposed ();
            if (img1 != null)
                img1.ThrowIfDisposed ();
            if (img2 != null)
                img2.ThrowIfDisposed ();
            if (init != null)
                init.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Map retVal = new Map (reg_MapperGradProj_calculate_10 (nativeObj, img1.nativeObj, img2.nativeObj, init.getNativeObjAddr ()));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: MapperGradProj::calculate(img1, img2)
        public override Map calculate (Mat img1, Mat img2)
        {
            ThrowIfDisposed ();
            if (img1 != null)
                img1.ThrowIfDisposed ();
            if (img2 != null)
                img2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Map retVal = new Map (reg_MapperGradProj_calculate_11 (nativeObj, img1.nativeObj, img2.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_Map getMap()
        //

        //javadoc: MapperGradProj::getMap()
        public override Map getMap ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Map retVal = new Map (reg_MapperGradProj_getMap_10 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
        


#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:   MapperGradProj()
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperGradProj_MapperGradProj_10 ();

        // C++:  Ptr_Map calculate(Mat img1, Mat img2, Ptr_Map init = cv::Ptr<Map>())
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperGradProj_calculate_10 (IntPtr nativeObj, IntPtr img1_nativeObj, IntPtr img2_nativeObj, IntPtr init_nativeObj);

        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperGradProj_calculate_11 (IntPtr nativeObj, IntPtr img1_nativeObj, IntPtr img2_nativeObj);

        // C++:  Ptr_Map getMap()
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperGradProj_getMap_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void reg_MapperGradProj_delete (IntPtr nativeObj);

    }
}
