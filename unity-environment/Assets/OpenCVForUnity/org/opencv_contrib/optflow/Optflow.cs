

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Optflow
    //javadoc: Optflow

    public class Optflow
    {

        public const int GPC_DESCRIPTOR_DCT = 0;
        public const int GPC_DESCRIPTOR_WHT = 0 + 1;
        //
        // C++:  Mat readOpticalFlow(String path)
        //

        //javadoc: readOpticalFlow(path)
        public static Mat readOpticalFlow (string path)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Mat retVal = new Mat(optflow_Optflow_readOpticalFlow_10(path));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_DISOpticalFlow createOptFlow_DIS(int preset = DISOpticalFlow::PRESET_FAST)
        //

        //javadoc: createOptFlow_DIS(preset)
        public static DISOpticalFlow createOptFlow_DIS (int preset)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DISOpticalFlow retVal = new DISOpticalFlow(optflow_Optflow_createOptFlow_1DIS_10(preset));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: createOptFlow_DIS()
        public static DISOpticalFlow createOptFlow_DIS ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DISOpticalFlow retVal = new DISOpticalFlow(optflow_Optflow_createOptFlow_1DIS_11());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_DenseOpticalFlow createOptFlow_DeepFlow()
        //

        // Return type 'Ptr_DenseOpticalFlow' is not supported, skipping the function


        //
        // C++:  Ptr_DenseOpticalFlow createOptFlow_Farneback()
        //

        // Return type 'Ptr_DenseOpticalFlow' is not supported, skipping the function


        //
        // C++:  Ptr_DenseOpticalFlow createOptFlow_PCAFlow()
        //

        // Return type 'Ptr_DenseOpticalFlow' is not supported, skipping the function


        //
        // C++:  Ptr_DenseOpticalFlow createOptFlow_SimpleFlow()
        //

        // Return type 'Ptr_DenseOpticalFlow' is not supported, skipping the function


        //
        // C++:  Ptr_DenseOpticalFlow createOptFlow_SparseToDense()
        //

        // Return type 'Ptr_DenseOpticalFlow' is not supported, skipping the function


        //
        // C++:  Ptr_VariationalRefinement createVariationalFlowRefinement()
        //

        //javadoc: createVariationalFlowRefinement()
        public static VariationalRefinement createVariationalFlowRefinement ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        VariationalRefinement retVal = new VariationalRefinement(optflow_Optflow_createVariationalFlowRefinement_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool writeOpticalFlow(String path, Mat flow)
        //

        //javadoc: writeOpticalFlow(path, flow)
        public static bool writeOpticalFlow (string path, Mat flow)
        {
            if (flow != null) flow.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = optflow_Optflow_writeOpticalFlow_10(path, flow.nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  double calcGlobalOrientation(Mat orientation, Mat mask, Mat mhi, double timestamp, double duration)
        //

        //javadoc: calcGlobalOrientation(orientation, mask, mhi, timestamp, duration)
        public static double calcGlobalOrientation (Mat orientation, Mat mask, Mat mhi, double timestamp, double duration)
        {
            if (orientation != null) orientation.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
            if (mhi != null) mhi.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = optflow_Optflow_calcGlobalOrientation_10(orientation.nativeObj, mask.nativeObj, mhi.nativeObj, timestamp, duration);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void calcMotionGradient(Mat mhi, Mat& mask, Mat& orientation, double delta1, double delta2, int apertureSize = 3)
        //

        //javadoc: calcMotionGradient(mhi, mask, orientation, delta1, delta2, apertureSize)
        public static void calcMotionGradient (Mat mhi, Mat mask, Mat orientation, double delta1, double delta2, int apertureSize)
        {
            if (mhi != null) mhi.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
            if (orientation != null) orientation.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_Optflow_calcMotionGradient_10(mhi.nativeObj, mask.nativeObj, orientation.nativeObj, delta1, delta2, apertureSize);
        
#else
            return;
#endif
            return;
        }

        //javadoc: calcMotionGradient(mhi, mask, orientation, delta1, delta2)
        public static void calcMotionGradient (Mat mhi, Mat mask, Mat orientation, double delta1, double delta2)
        {
            if (mhi != null) mhi.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
            if (orientation != null) orientation.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_Optflow_calcMotionGradient_11(mhi.nativeObj, mask.nativeObj, orientation.nativeObj, delta1, delta2);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void segmentMotion(Mat mhi, Mat& segmask, vector_Rect& boundingRects, double timestamp, double segThresh)
        //

        //javadoc: segmentMotion(mhi, segmask, boundingRects, timestamp, segThresh)
        public static void segmentMotion (Mat mhi, Mat segmask, MatOfRect boundingRects, double timestamp, double segThresh)
        {
            if (mhi != null) mhi.ThrowIfDisposed ();
            if (segmask != null) segmask.ThrowIfDisposed ();
            if (boundingRects != null) boundingRects.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat boundingRects_mat = boundingRects;
        optflow_Optflow_segmentMotion_10(mhi.nativeObj, segmask.nativeObj, boundingRects_mat.nativeObj, timestamp, segThresh);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void updateMotionHistory(Mat silhouette, Mat& mhi, double timestamp, double duration)
        //

        //javadoc: updateMotionHistory(silhouette, mhi, timestamp, duration)
        public static void updateMotionHistory (Mat silhouette, Mat mhi, double timestamp, double duration)
        {
            if (silhouette != null) silhouette.ThrowIfDisposed ();
            if (mhi != null) mhi.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_Optflow_updateMotionHistory_10(silhouette.nativeObj, mhi.nativeObj, timestamp, duration);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void calcOpticalFlowSF(Mat from, Mat to, Mat& flow, int layers, int averaging_block_size, int max_flow, double sigma_dist, double sigma_color, int postprocess_window, double sigma_dist_fix, double sigma_color_fix, double occ_thr, int upscale_averaging_radius, double upscale_sigma_dist, double upscale_sigma_color, double speed_up_thr)
        //

        //javadoc: calcOpticalFlowSF(from, to, flow, layers, averaging_block_size, max_flow, sigma_dist, sigma_color, postprocess_window, sigma_dist_fix, sigma_color_fix, occ_thr, upscale_averaging_radius, upscale_sigma_dist, upscale_sigma_color, speed_up_thr)
        public static void calcOpticalFlowSF (Mat from, Mat to, Mat flow, int layers, int averaging_block_size, int max_flow, double sigma_dist, double sigma_color, int postprocess_window, double sigma_dist_fix, double sigma_color_fix, double occ_thr, int upscale_averaging_radius, double upscale_sigma_dist, double upscale_sigma_color, double speed_up_thr)
        {
            if (from != null) from.ThrowIfDisposed ();
            if (to != null) to.ThrowIfDisposed ();
            if (flow != null) flow.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_Optflow_calcOpticalFlowSF_10(from.nativeObj, to.nativeObj, flow.nativeObj, layers, averaging_block_size, max_flow, sigma_dist, sigma_color, postprocess_window, sigma_dist_fix, sigma_color_fix, occ_thr, upscale_averaging_radius, upscale_sigma_dist, upscale_sigma_color, speed_up_thr);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void calcOpticalFlowSF(Mat from, Mat to, Mat& flow, int layers, int averaging_block_size, int max_flow)
        //

        //javadoc: calcOpticalFlowSF(from, to, flow, layers, averaging_block_size, max_flow)
        public static void calcOpticalFlowSF (Mat from, Mat to, Mat flow, int layers, int averaging_block_size, int max_flow)
        {
            if (from != null) from.ThrowIfDisposed ();
            if (to != null) to.ThrowIfDisposed ();
            if (flow != null) flow.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_Optflow_calcOpticalFlowSF_11(from.nativeObj, to.nativeObj, flow.nativeObj, layers, averaging_block_size, max_flow);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void calcOpticalFlowSparseToDense(Mat from, Mat to, Mat& flow, int grid_step = 8, int k = 128, float sigma = 0.05f, bool use_post_proc = true, float fgs_lambda = 500.0f, float fgs_sigma = 1.5f)
        //

        //javadoc: calcOpticalFlowSparseToDense(from, to, flow, grid_step, k, sigma, use_post_proc, fgs_lambda, fgs_sigma)
        public static void calcOpticalFlowSparseToDense (Mat from, Mat to, Mat flow, int grid_step, int k, float sigma, bool use_post_proc, float fgs_lambda, float fgs_sigma)
        {
            if (from != null) from.ThrowIfDisposed ();
            if (to != null) to.ThrowIfDisposed ();
            if (flow != null) flow.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_Optflow_calcOpticalFlowSparseToDense_10(from.nativeObj, to.nativeObj, flow.nativeObj, grid_step, k, sigma, use_post_proc, fgs_lambda, fgs_sigma);
        
#else
            return;
#endif
            return;
        }

        //javadoc: calcOpticalFlowSparseToDense(from, to, flow)
        public static void calcOpticalFlowSparseToDense (Mat from, Mat to, Mat flow)
        {
            if (from != null) from.ThrowIfDisposed ();
            if (to != null) to.ThrowIfDisposed ();
            if (flow != null) flow.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        optflow_Optflow_calcOpticalFlowSparseToDense_11(from.nativeObj, to.nativeObj, flow.nativeObj);
        
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



        // C++:  Mat readOpticalFlow(String path)
        [DllImport (LIBNAME)]
        private static extern IntPtr optflow_Optflow_readOpticalFlow_10 (string path);

        // C++:  Ptr_DISOpticalFlow createOptFlow_DIS(int preset = DISOpticalFlow::PRESET_FAST)
        [DllImport (LIBNAME)]
        private static extern IntPtr optflow_Optflow_createOptFlow_1DIS_10 (int preset);
        [DllImport (LIBNAME)]
        private static extern IntPtr optflow_Optflow_createOptFlow_1DIS_11 ();

        // C++:  Ptr_VariationalRefinement createVariationalFlowRefinement()
        [DllImport (LIBNAME)]
        private static extern IntPtr optflow_Optflow_createVariationalFlowRefinement_10 ();

        // C++:  bool writeOpticalFlow(String path, Mat flow)
        [DllImport (LIBNAME)]
        private static extern bool optflow_Optflow_writeOpticalFlow_10 (string path, IntPtr flow_nativeObj);

        // C++:  double calcGlobalOrientation(Mat orientation, Mat mask, Mat mhi, double timestamp, double duration)
        [DllImport (LIBNAME)]
        private static extern double optflow_Optflow_calcGlobalOrientation_10 (IntPtr orientation_nativeObj, IntPtr mask_nativeObj, IntPtr mhi_nativeObj, double timestamp, double duration);

        // C++:  void calcMotionGradient(Mat mhi, Mat& mask, Mat& orientation, double delta1, double delta2, int apertureSize = 3)
        [DllImport (LIBNAME)]
        private static extern void optflow_Optflow_calcMotionGradient_10 (IntPtr mhi_nativeObj, IntPtr mask_nativeObj, IntPtr orientation_nativeObj, double delta1, double delta2, int apertureSize);
        [DllImport (LIBNAME)]
        private static extern void optflow_Optflow_calcMotionGradient_11 (IntPtr mhi_nativeObj, IntPtr mask_nativeObj, IntPtr orientation_nativeObj, double delta1, double delta2);

        // C++:  void segmentMotion(Mat mhi, Mat& segmask, vector_Rect& boundingRects, double timestamp, double segThresh)
        [DllImport (LIBNAME)]
        private static extern void optflow_Optflow_segmentMotion_10 (IntPtr mhi_nativeObj, IntPtr segmask_nativeObj, IntPtr boundingRects_mat_nativeObj, double timestamp, double segThresh);

        // C++:  void updateMotionHistory(Mat silhouette, Mat& mhi, double timestamp, double duration)
        [DllImport (LIBNAME)]
        private static extern void optflow_Optflow_updateMotionHistory_10 (IntPtr silhouette_nativeObj, IntPtr mhi_nativeObj, double timestamp, double duration);

        // C++:  void calcOpticalFlowSF(Mat from, Mat to, Mat& flow, int layers, int averaging_block_size, int max_flow, double sigma_dist, double sigma_color, int postprocess_window, double sigma_dist_fix, double sigma_color_fix, double occ_thr, int upscale_averaging_radius, double upscale_sigma_dist, double upscale_sigma_color, double speed_up_thr)
        [DllImport (LIBNAME)]
        private static extern void optflow_Optflow_calcOpticalFlowSF_10 (IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr flow_nativeObj, int layers, int averaging_block_size, int max_flow, double sigma_dist, double sigma_color, int postprocess_window, double sigma_dist_fix, double sigma_color_fix, double occ_thr, int upscale_averaging_radius, double upscale_sigma_dist, double upscale_sigma_color, double speed_up_thr);

        // C++:  void calcOpticalFlowSF(Mat from, Mat to, Mat& flow, int layers, int averaging_block_size, int max_flow)
        [DllImport (LIBNAME)]
        private static extern void optflow_Optflow_calcOpticalFlowSF_11 (IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr flow_nativeObj, int layers, int averaging_block_size, int max_flow);

        // C++:  void calcOpticalFlowSparseToDense(Mat from, Mat to, Mat& flow, int grid_step = 8, int k = 128, float sigma = 0.05f, bool use_post_proc = true, float fgs_lambda = 500.0f, float fgs_sigma = 1.5f)
        [DllImport (LIBNAME)]
        private static extern void optflow_Optflow_calcOpticalFlowSparseToDense_10 (IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr flow_nativeObj, int grid_step, int k, float sigma, bool use_post_proc, float fgs_lambda, float fgs_sigma);
        [DllImport (LIBNAME)]
        private static extern void optflow_Optflow_calcOpticalFlowSparseToDense_11 (IntPtr from_nativeObj, IntPtr to_nativeObj, IntPtr flow_nativeObj);

    }
}
