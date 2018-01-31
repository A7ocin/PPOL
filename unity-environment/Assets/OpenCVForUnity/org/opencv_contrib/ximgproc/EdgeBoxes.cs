

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class EdgeBoxes
    //javadoc: EdgeBoxes

    public class EdgeBoxes : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
ximgproc_EdgeBoxes_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal EdgeBoxes (IntPtr addr) : base (addr) { }


        //
        // C++:  float getAlpha()
        //

        //javadoc: EdgeBoxes::getAlpha()
        public float getAlpha ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getAlpha_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getBeta()
        //

        //javadoc: EdgeBoxes::getBeta()
        public float getBeta ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getBeta_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getClusterMinMag()
        //

        //javadoc: EdgeBoxes::getClusterMinMag()
        public float getClusterMinMag ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getClusterMinMag_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getEdgeMergeThr()
        //

        //javadoc: EdgeBoxes::getEdgeMergeThr()
        public float getEdgeMergeThr ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getEdgeMergeThr_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getEdgeMinMag()
        //

        //javadoc: EdgeBoxes::getEdgeMinMag()
        public float getEdgeMinMag ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getEdgeMinMag_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getEta()
        //

        //javadoc: EdgeBoxes::getEta()
        public float getEta ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getEta_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getGamma()
        //

        //javadoc: EdgeBoxes::getGamma()
        public float getGamma ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getGamma_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getKappa()
        //

        //javadoc: EdgeBoxes::getKappa()
        public float getKappa ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getKappa_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getMaxAspectRatio()
        //

        //javadoc: EdgeBoxes::getMaxAspectRatio()
        public float getMaxAspectRatio ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getMaxAspectRatio_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getMinBoxArea()
        //

        //javadoc: EdgeBoxes::getMinBoxArea()
        public float getMinBoxArea ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getMinBoxArea_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float getMinScore()
        //

        //javadoc: EdgeBoxes::getMinScore()
        public float getMinScore ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = ximgproc_EdgeBoxes_getMinScore_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getMaxBoxes()
        //

        //javadoc: EdgeBoxes::getMaxBoxes()
        public int getMaxBoxes ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = ximgproc_EdgeBoxes_getMaxBoxes_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void getBoundingBoxes(Mat edge_map, Mat orientation_map, vector_Rect& boxes)
        //

        //javadoc: EdgeBoxes::getBoundingBoxes(edge_map, orientation_map, boxes)
        public void getBoundingBoxes (Mat edge_map, Mat orientation_map, MatOfRect boxes)
        {
            ThrowIfDisposed ();
            if (edge_map != null) edge_map.ThrowIfDisposed ();
            if (orientation_map != null) orientation_map.ThrowIfDisposed ();
            if (boxes != null) boxes.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat boxes_mat = boxes;
        ximgproc_EdgeBoxes_getBoundingBoxes_10(nativeObj, edge_map.nativeObj, orientation_map.nativeObj, boxes_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setAlpha(float value)
        //

        //javadoc: EdgeBoxes::setAlpha(value)
        public void setAlpha (float value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setAlpha_10(nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setBeta(float value)
        //

        //javadoc: EdgeBoxes::setBeta(value)
        public void setBeta (float value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setBeta_10(nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setClusterMinMag(float value)
        //

        //javadoc: EdgeBoxes::setClusterMinMag(value)
        public void setClusterMinMag (float value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setClusterMinMag_10(nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setEdgeMergeThr(float value)
        //

        //javadoc: EdgeBoxes::setEdgeMergeThr(value)
        public void setEdgeMergeThr (float value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setEdgeMergeThr_10(nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setEdgeMinMag(float value)
        //

        //javadoc: EdgeBoxes::setEdgeMinMag(value)
        public void setEdgeMinMag (float value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setEdgeMinMag_10(nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setEta(float value)
        //

        //javadoc: EdgeBoxes::setEta(value)
        public void setEta (float value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setEta_10(nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setGamma(float value)
        //

        //javadoc: EdgeBoxes::setGamma(value)
        public void setGamma (float value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setGamma_10(nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setKappa(float value)
        //

        //javadoc: EdgeBoxes::setKappa(value)
        public void setKappa (float value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setKappa_10(nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMaxAspectRatio(float value)
        //

        //javadoc: EdgeBoxes::setMaxAspectRatio(value)
        public void setMaxAspectRatio (float value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setMaxAspectRatio_10(nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMaxBoxes(int value)
        //

        //javadoc: EdgeBoxes::setMaxBoxes(value)
        public void setMaxBoxes (int value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setMaxBoxes_10(nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMinBoxArea(float value)
        //

        //javadoc: EdgeBoxes::setMinBoxArea(value)
        public void setMinBoxArea (float value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setMinBoxArea_10(nativeObj, value);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMinScore(float value)
        //

        //javadoc: EdgeBoxes::setMinScore(value)
        public void setMinScore (float value)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        ximgproc_EdgeBoxes_setMinScore_10(nativeObj, value);
        
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



        // C++:  float getAlpha()
        [DllImport (LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getAlpha_10 (IntPtr nativeObj);

        // C++:  float getBeta()
        [DllImport (LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getBeta_10 (IntPtr nativeObj);

        // C++:  float getClusterMinMag()
        [DllImport (LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getClusterMinMag_10 (IntPtr nativeObj);

        // C++:  float getEdgeMergeThr()
        [DllImport (LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getEdgeMergeThr_10 (IntPtr nativeObj);

        // C++:  float getEdgeMinMag()
        [DllImport (LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getEdgeMinMag_10 (IntPtr nativeObj);

        // C++:  float getEta()
        [DllImport (LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getEta_10 (IntPtr nativeObj);

        // C++:  float getGamma()
        [DllImport (LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getGamma_10 (IntPtr nativeObj);

        // C++:  float getKappa()
        [DllImport (LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getKappa_10 (IntPtr nativeObj);

        // C++:  float getMaxAspectRatio()
        [DllImport (LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getMaxAspectRatio_10 (IntPtr nativeObj);

        // C++:  float getMinBoxArea()
        [DllImport (LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getMinBoxArea_10 (IntPtr nativeObj);

        // C++:  float getMinScore()
        [DllImport (LIBNAME)]
        private static extern float ximgproc_EdgeBoxes_getMinScore_10 (IntPtr nativeObj);

        // C++:  int getMaxBoxes()
        [DllImport (LIBNAME)]
        private static extern int ximgproc_EdgeBoxes_getMaxBoxes_10 (IntPtr nativeObj);

        // C++:  void getBoundingBoxes(Mat edge_map, Mat orientation_map, vector_Rect& boxes)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_getBoundingBoxes_10 (IntPtr nativeObj, IntPtr edge_map_nativeObj, IntPtr orientation_map_nativeObj, IntPtr boxes_mat_nativeObj);

        // C++:  void setAlpha(float value)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setAlpha_10 (IntPtr nativeObj, float value);

        // C++:  void setBeta(float value)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setBeta_10 (IntPtr nativeObj, float value);

        // C++:  void setClusterMinMag(float value)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setClusterMinMag_10 (IntPtr nativeObj, float value);

        // C++:  void setEdgeMergeThr(float value)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setEdgeMergeThr_10 (IntPtr nativeObj, float value);

        // C++:  void setEdgeMinMag(float value)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setEdgeMinMag_10 (IntPtr nativeObj, float value);

        // C++:  void setEta(float value)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setEta_10 (IntPtr nativeObj, float value);

        // C++:  void setGamma(float value)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setGamma_10 (IntPtr nativeObj, float value);

        // C++:  void setKappa(float value)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setKappa_10 (IntPtr nativeObj, float value);

        // C++:  void setMaxAspectRatio(float value)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setMaxAspectRatio_10 (IntPtr nativeObj, float value);

        // C++:  void setMaxBoxes(int value)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setMaxBoxes_10 (IntPtr nativeObj, int value);

        // C++:  void setMinBoxArea(float value)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setMinBoxArea_10 (IntPtr nativeObj, float value);

        // C++:  void setMinScore(float value)
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_setMinScore_10 (IntPtr nativeObj, float value);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void ximgproc_EdgeBoxes_delete (IntPtr nativeObj);

    }
}
