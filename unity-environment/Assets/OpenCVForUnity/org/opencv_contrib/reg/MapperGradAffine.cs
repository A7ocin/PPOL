

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class MapperGradAffine
    //javadoc: MapperGradAffine

    public class MapperGradAffine : Mapper
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        reg_MapperGradAffine_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal MapperGradAffine (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++:   MapperGradAffine()
        //

        //javadoc: MapperGradAffine::MapperGradAffine()
        public MapperGradAffine () :
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        base (reg_MapperGradAffine_MapperGradAffine_10 ())
        
#else
            base (IntPtr.Zero)
#endif
        {

            return;

        }


        //
        // C++:  Ptr_Map calculate(Mat img1, Mat img2, Ptr_Map init = cv::Ptr<Map>())
        //

        //javadoc: MapperGradAffine::calculate(img1, img2, init)
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
        
            Map retVal = new Map (reg_MapperGradAffine_calculate_10 (nativeObj, img1.nativeObj, img2.nativeObj, init.getNativeObjAddr ()));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: MapperGradAffine::calculate(img1, img2)
        public override Map calculate (Mat img1, Mat img2)
        {
            ThrowIfDisposed ();
            if (img1 != null)
                img1.ThrowIfDisposed ();
            if (img2 != null)
                img2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Map retVal = new Map (reg_MapperGradAffine_calculate_11 (nativeObj, img1.nativeObj, img2.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_Map getMap()
        //

        //javadoc: MapperGradAffine::getMap()
        public override Map getMap ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Map retVal = new Map (reg_MapperGradAffine_getMap_10 (nativeObj));
        
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



        // C++:   MapperGradAffine()
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperGradAffine_MapperGradAffine_10 ();

        // C++:  Ptr_Map calculate(Mat img1, Mat img2, Ptr_Map init = cv::Ptr<Map>())
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperGradAffine_calculate_10 (IntPtr nativeObj, IntPtr img1_nativeObj, IntPtr img2_nativeObj, IntPtr init_nativeObj);

        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperGradAffine_calculate_11 (IntPtr nativeObj, IntPtr img1_nativeObj, IntPtr img2_nativeObj);

        // C++:  Ptr_Map getMap()
        [DllImport (LIBNAME)]
        private static extern IntPtr reg_MapperGradAffine_getMap_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void reg_MapperGradAffine_delete (IntPtr nativeObj);

    }
}
