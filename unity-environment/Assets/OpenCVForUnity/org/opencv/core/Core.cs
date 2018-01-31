

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Core
    //javadoc: Core

    public class Core
    {

        // these constants are wrapped inside functions to prevent inlining
        private static string getVersion () { return "3.3.1-dev"; }
        private static string getNativeLibraryName () { return "opencvforunity"; }
        private static int getVersionMajor () { return 3; }
        private static int getVersionMinor () { return 3; }
        private static int getVersionRevision () { return 1; }
        private static string getVersionStatus () { return "-dev"; }

        public static readonly string VERSION = getVersion ();
        public static readonly string NATIVE_LIBRARY_NAME = getNativeLibraryName ();
        public static readonly int VERSION_MAJOR = getVersionMajor ();
        public static readonly int VERSION_MINOR = getVersionMinor ();
        public static readonly int VERSION_REVISION = getVersionRevision ();
        public static readonly string VERSION_STATUS = getVersionStatus ();

        private const int CV_8U = 0;
        private const int CV_8S = 1;
        private const int CV_16U = 2;
        private const int CV_16S = 3;
        private const int CV_32S = 4;
        private const int CV_32F = 5;
        private const int CV_64F = 6;
        private const int CV_USRTYPE1 = 7;
        public const int SVD_MODIFY_A = 1;
        public const int SVD_NO_UV = 2;
        public const int SVD_FULL_UV = 4;
        public const int FILLED = -1;
        public const int REDUCE_SUM = 0;
        public const int REDUCE_AVG = 1;
        public const int REDUCE_MAX = 2;
        public const int REDUCE_MIN = 3;
        public const int StsOk = 0;
        public const int StsBackTrace = -1;
        public const int StsError = -2;
        public const int StsInternal = -3;
        public const int StsNoMem = -4;
        public const int StsBadArg = -5;
        public const int StsBadFunc = -6;
        public const int StsNoConv = -7;
        public const int StsAutoTrace = -8;
        public const int HeaderIsNull = -9;
        public const int BadImageSize = -10;
        public const int BadOffset = -11;
        public const int BadDataPtr = -12;
        public const int BadStep = -13;
        public const int BadModelOrChSeq = -14;
        public const int BadNumChannels = -15;
        public const int BadNumChannel1U = -16;
        public const int BadDepth = -17;
        public const int BadAlphaChannel = -18;
        public const int BadOrder = -19;
        public const int BadOrigin = -20;
        public const int BadAlign = -21;
        public const int BadCallBack = -22;
        public const int BadTileSize = -23;
        public const int BadCOI = -24;
        public const int BadROISize = -25;
        public const int MaskIsTiled = -26;
        public const int StsNullPtr = -27;
        public const int StsVecLengthErr = -28;
        public const int StsFilterStructContentErr = -29;
        public const int StsKernelStructContentErr = -30;
        public const int StsFilterOffsetErr = -31;
        public const int StsBadSize = -201;
        public const int StsDivByZero = -202;
        public const int StsInplaceNotSupported = -203;
        public const int StsObjectNotFound = -204;
        public const int StsUnmatchedFormats = -205;
        public const int StsBadFlag = -206;
        public const int StsBadPoint = -207;
        public const int StsBadMask = -208;
        public const int StsUnmatchedSizes = -209;
        public const int StsUnsupportedFormat = -210;
        public const int StsOutOfRange = -211;
        public const int StsParseError = -212;
        public const int StsNotImplemented = -213;
        public const int StsBadMemBlock = -214;
        public const int StsAssert = -215;
        public const int GpuNotSupported = -216;
        public const int GpuApiCallError = -217;
        public const int OpenGlNotSupported = -218;
        public const int OpenGlApiCallError = -219;
        public const int OpenCLApiCallError = -220;
        public const int OpenCLDoubleNotSupported = -221;
        public const int OpenCLInitError = -222;
        public const int OpenCLNoAMDBlasFft = -223;
        public const int DECOMP_LU = 0;
        public const int DECOMP_SVD = 1;
        public const int DECOMP_EIG = 2;
        public const int DECOMP_CHOLESKY = 3;
        public const int DECOMP_QR = 4;
        public const int DECOMP_NORMAL = 16;
        public const int NORM_INF = 1;
        public const int NORM_L1 = 2;
        public const int NORM_L2 = 4;
        public const int NORM_L2SQR = 5;
        public const int NORM_HAMMING = 6;
        public const int NORM_HAMMING2 = 7;
        public const int NORM_TYPE_MASK = 7;
        public const int NORM_RELATIVE = 8;
        public const int NORM_MINMAX = 32;
        public const int CMP_EQ = 0;
        public const int CMP_GT = 1;
        public const int CMP_GE = 2;
        public const int CMP_LT = 3;
        public const int CMP_LE = 4;
        public const int CMP_NE = 5;
        public const int GEMM_1_T = 1;
        public const int GEMM_2_T = 2;
        public const int GEMM_3_T = 4;
        public const int DFT_INVERSE = 1;
        public const int DFT_SCALE = 2;
        public const int DFT_ROWS = 4;
        public const int DFT_COMPLEX_OUTPUT = 16;
        public const int DFT_REAL_OUTPUT = 32;
        public const int DFT_COMPLEX_INPUT = 64;
        public const int DCT_INVERSE = DFT_INVERSE;
        public const int DCT_ROWS = DFT_ROWS;
        public const int BORDER_CONSTANT = 0;
        public const int BORDER_REPLICATE = 1;
        public const int BORDER_REFLECT = 2;
        public const int BORDER_WRAP = 3;
        public const int BORDER_REFLECT_101 = 4;
        public const int BORDER_TRANSPARENT = 5;
        public const int BORDER_REFLECT101 = BORDER_REFLECT_101;
        public const int BORDER_DEFAULT = BORDER_REFLECT_101;
        public const int BORDER_ISOLATED = 16;
        public const int SORT_EVERY_ROW = 0;
        public const int SORT_EVERY_COLUMN = 1;
        public const int SORT_ASCENDING = 0;
        public const int SORT_DESCENDING = 16;
        public const int COVAR_SCRAMBLED = 0;
        public const int COVAR_NORMAL = 1;
        public const int COVAR_USE_AVG = 2;
        public const int COVAR_SCALE = 4;
        public const int COVAR_ROWS = 8;
        public const int COVAR_COLS = 16;
        public const int KMEANS_RANDOM_CENTERS = 0;
        public const int KMEANS_PP_CENTERS = 2;
        public const int KMEANS_USE_INITIAL_LABELS = 1;
        public const int LINE_4 = 4;
        public const int LINE_8 = 8;
        public const int LINE_AA = 16;
        public const int FONT_HERSHEY_SIMPLEX = 0;
        public const int FONT_HERSHEY_PLAIN = 1;
        public const int FONT_HERSHEY_DUPLEX = 2;
        public const int FONT_HERSHEY_COMPLEX = 3;
        public const int FONT_HERSHEY_TRIPLEX = 4;
        public const int FONT_HERSHEY_COMPLEX_SMALL = 5;
        public const int FONT_HERSHEY_SCRIPT_SIMPLEX = 6;
        public const int FONT_HERSHEY_SCRIPT_COMPLEX = 7;
        public const int FONT_ITALIC = 16;
        public const int ROTATE_90_CLOCKWISE = 0;
        public const int ROTATE_180 = 1;
        public const int ROTATE_90_COUNTERCLOCKWISE = 2;
        public const int TYPE_GENERAL = 0;
        public const int TYPE_MARKER = 0 + 1;
        public const int TYPE_WRAPPER = 0 + 2;
        public const int TYPE_FUN = 0 + 3;
        public const int IMPL_PLAIN = 0;
        public const int IMPL_IPP = 0 + 1;
        public const int IMPL_OPENCL = 0 + 2;
        public const int FLAGS_NONE = 0;
        public const int FLAGS_MAPPING = 0x01;
        public const int FLAGS_EXPAND_SAME_NAMES = 0x02;
        //
        // C++:  Scalar mean(Mat src, Mat mask = Mat())
        //

        //javadoc: mean(src, mask)
        public static Scalar mean (Mat src, Mat mask)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[4];
core_Core_mean_10(src.nativeObj, mask.nativeObj, tmpArray);
Scalar retVal = new Scalar (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: mean(src)
        public static Scalar mean (Mat src)
        {
            if (src != null) src.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[4];
core_Core_mean_11(src.nativeObj, tmpArray);
Scalar retVal = new Scalar (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Scalar sum(Mat src)
        //

        //javadoc: sum(src)
        public static Scalar sumElems (Mat src)
        {
            if (src != null) src.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[4];
core_Core_sumElems_10(src.nativeObj, tmpArray);
Scalar retVal = new Scalar (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Scalar trace(Mat mtx)
        //

        //javadoc: trace(mtx)
        public static Scalar trace (Mat mtx)
        {
            if (mtx != null) mtx.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double[] tmpArray = new double[4];
core_Core_trace_10(mtx.nativeObj, tmpArray);
Scalar retVal = new Scalar (tmpArray);
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  String getBuildInformation()
        //

        //javadoc: getBuildInformation()
        public static string getBuildInformation ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (core_Core_getBuildInformation_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  String getIppVersion()
        //

        //javadoc: getIppVersion()
        public static string getIppVersion ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        string retVal = Marshal.PtrToStringAnsi (core_Core_getIppVersion_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool checkRange(Mat a, bool quiet = true,  _hidden_ * pos = 0, double minVal = -DBL_MAX, double maxVal = DBL_MAX)
        //

        //javadoc: checkRange(a, quiet, minVal, maxVal)
        public static bool checkRange (Mat a, bool quiet, double minVal, double maxVal)
        {
            if (a != null) a.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = core_Core_checkRange_10(a.nativeObj, quiet, minVal, maxVal);
        
#else
            return false;
#endif
            return retVal;
        }

        //javadoc: checkRange(a)
        public static bool checkRange (Mat a)
        {
            if (a != null) a.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = core_Core_checkRange_11(a.nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool eigen(Mat src, Mat& eigenvalues, Mat& eigenvectors = Mat())
        //

        //javadoc: eigen(src, eigenvalues, eigenvectors)
        public static bool eigen (Mat src, Mat eigenvalues, Mat eigenvectors)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (eigenvalues != null) eigenvalues.ThrowIfDisposed ();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = core_Core_eigen_10(src.nativeObj, eigenvalues.nativeObj, eigenvectors.nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }

        //javadoc: eigen(src, eigenvalues)
        public static bool eigen (Mat src, Mat eigenvalues)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (eigenvalues != null) eigenvalues.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = core_Core_eigen_11(src.nativeObj, eigenvalues.nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool solve(Mat src1, Mat src2, Mat& dst, int flags = DECOMP_LU)
        //

        //javadoc: solve(src1, src2, dst, flags)
        public static bool solve (Mat src1, Mat src2, Mat dst, int flags)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = core_Core_solve_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, flags);
        
#else
            return false;
#endif
            return retVal;
        }

        //javadoc: solve(src1, src2, dst)
        public static bool solve (Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = core_Core_solve_11(src1.nativeObj, src2.nativeObj, dst.nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool useIPP()
        //

        //javadoc: useIPP()
        public static bool useIPP ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = core_Core_useIPP_10();
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  bool useIPP_NE()
        //

        //javadoc: useIPP_NE()
        public static bool useIPP_NE ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        bool retVal = core_Core_useIPP_1NE_10();
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  double Mahalanobis(Mat v1, Mat v2, Mat icovar)
        //

        //javadoc: Mahalanobis(v1, v2, icovar)
        public static double Mahalanobis (Mat v1, Mat v2, Mat icovar)
        {
            if (v1 != null) v1.ThrowIfDisposed ();
            if (v2 != null) v2.ThrowIfDisposed ();
            if (icovar != null) icovar.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_Mahalanobis_10(v1.nativeObj, v2.nativeObj, icovar.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double PSNR(Mat src1, Mat src2)
        //

        //javadoc: PSNR(src1, src2)
        public static double PSNR (Mat src1, Mat src2)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_PSNR_10(src1.nativeObj, src2.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double determinant(Mat mtx)
        //

        //javadoc: determinant(mtx)
        public static double determinant (Mat mtx)
        {
            if (mtx != null) mtx.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_determinant_10(mtx.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getTickFrequency()
        //

        //javadoc: getTickFrequency()
        public static double getTickFrequency ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_getTickFrequency_10();
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double invert(Mat src, Mat& dst, int flags = DECOMP_LU)
        //

        //javadoc: invert(src, dst, flags)
        public static double invert (Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_invert_10(src.nativeObj, dst.nativeObj, flags);
        
#else
            return -1;
#endif
            return retVal;
        }

        //javadoc: invert(src, dst)
        public static double invert (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_invert_11(src.nativeObj, dst.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double kmeans(Mat data, int K, Mat& bestLabels, TermCriteria criteria, int attempts, int flags, Mat& centers = Mat())
        //

        //javadoc: kmeans(data, K, bestLabels, criteria, attempts, flags, centers)
        public static double kmeans (Mat data, int K, Mat bestLabels, TermCriteria criteria, int attempts, int flags, Mat centers)
        {
            if (data != null) data.ThrowIfDisposed ();
            if (bestLabels != null) bestLabels.ThrowIfDisposed ();
            if (centers != null) centers.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_kmeans_10(data.nativeObj, K, bestLabels.nativeObj, criteria.type, criteria.maxCount, criteria.epsilon, attempts, flags, centers.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }

        //javadoc: kmeans(data, K, bestLabels, criteria, attempts, flags)
        public static double kmeans (Mat data, int K, Mat bestLabels, TermCriteria criteria, int attempts, int flags)
        {
            if (data != null) data.ThrowIfDisposed ();
            if (bestLabels != null) bestLabels.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_kmeans_11(data.nativeObj, K, bestLabels.nativeObj, criteria.type, criteria.maxCount, criteria.epsilon, attempts, flags);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double norm(Mat src1, Mat src2, int normType = NORM_L2, Mat mask = Mat())
        //

        //javadoc: norm(src1, src2, normType, mask)
        public static double norm (Mat src1, Mat src2, int normType, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_norm_10(src1.nativeObj, src2.nativeObj, normType, mask.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }

        //javadoc: norm(src1, src2, normType)
        public static double norm (Mat src1, Mat src2, int normType)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_norm_11(src1.nativeObj, src2.nativeObj, normType);
        
#else
            return -1;
#endif
            return retVal;
        }

        //javadoc: norm(src1, src2)
        public static double norm (Mat src1, Mat src2)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_norm_12(src1.nativeObj, src2.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double norm(Mat src1, int normType = NORM_L2, Mat mask = Mat())
        //

        //javadoc: norm(src1, normType, mask)
        public static double norm (Mat src1, int normType, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_norm_13(src1.nativeObj, normType, mask.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }

        //javadoc: norm(src1, normType)
        public static double norm (Mat src1, int normType)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_norm_14(src1.nativeObj, normType);
        
#else
            return -1;
#endif
            return retVal;
        }

        //javadoc: norm(src1)
        public static double norm (Mat src1)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_norm_15(src1.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double solvePoly(Mat coeffs, Mat& roots, int maxIters = 300)
        //

        //javadoc: solvePoly(coeffs, roots, maxIters)
        public static double solvePoly (Mat coeffs, Mat roots, int maxIters)
        {
            if (coeffs != null) coeffs.ThrowIfDisposed ();
            if (roots != null) roots.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_solvePoly_10(coeffs.nativeObj, roots.nativeObj, maxIters);
        
#else
            return -1;
#endif
            return retVal;
        }

        //javadoc: solvePoly(coeffs, roots)
        public static double solvePoly (Mat coeffs, Mat roots)
        {
            if (coeffs != null) coeffs.ThrowIfDisposed ();
            if (roots != null) roots.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_Core_solvePoly_11(coeffs.nativeObj, roots.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float cubeRoot(float val)
        //

        //javadoc: cubeRoot(val)
        public static float cubeRoot (float val)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = core_Core_cubeRoot_10(val);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  float fastAtan2(float y, float x)
        //

        //javadoc: fastAtan2(y, x)
        public static float fastAtan2 (float y, float x)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        float retVal = core_Core_fastAtan2_10(y, x);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int borderInterpolate(int p, int len, int borderType)
        //

        //javadoc: borderInterpolate(p, len, borderType)
        public static int borderInterpolate (int p, int len, int borderType)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = core_Core_borderInterpolate_10(p, len, borderType);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int countNonZero(Mat src)
        //

        //javadoc: countNonZero(src)
        public static int countNonZero (Mat src)
        {
            if (src != null) src.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = core_Core_countNonZero_10(src.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNumThreads()
        //

        //javadoc: getNumThreads()
        public static int getNumThreads ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = core_Core_getNumThreads_10();
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getNumberOfCPUs()
        //

        //javadoc: getNumberOfCPUs()
        public static int getNumberOfCPUs ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = core_Core_getNumberOfCPUs_10();
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getOptimalDFTSize(int vecsize)
        //

        //javadoc: getOptimalDFTSize(vecsize)
        public static int getOptimalDFTSize (int vecsize)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = core_Core_getOptimalDFTSize_10(vecsize);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getThreadNum()
        //

        //javadoc: getThreadNum()
        public static int getThreadNum ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = core_Core_getThreadNum_10();
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int solveCubic(Mat coeffs, Mat& roots)
        //

        //javadoc: solveCubic(coeffs, roots)
        public static int solveCubic (Mat coeffs, Mat roots)
        {
            if (coeffs != null) coeffs.ThrowIfDisposed ();
            if (roots != null) roots.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = core_Core_solveCubic_10(coeffs.nativeObj, roots.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int64 getCPUTickCount()
        //

        //javadoc: getCPUTickCount()
        public static long getCPUTickCount ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        long retVal = core_Core_getCPUTickCount_10();
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int64 getTickCount()
        //

        //javadoc: getTickCount()
        public static long getTickCount ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        long retVal = core_Core_getTickCount_10();
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void LUT(Mat src, Mat lut, Mat& dst)
        //

        //javadoc: LUT(src, lut, dst)
        public static void LUT (Mat src, Mat lut, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (lut != null) lut.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_LUT_10(src.nativeObj, lut.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void PCABackProject(Mat data, Mat mean, Mat eigenvectors, Mat& result)
        //

        //javadoc: PCABackProject(data, mean, eigenvectors, result)
        public static void PCABackProject (Mat data, Mat mean, Mat eigenvectors, Mat result)
        {
            if (data != null) data.ThrowIfDisposed ();
            if (mean != null) mean.ThrowIfDisposed ();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed ();
            if (result != null) result.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_PCABackProject_10(data.nativeObj, mean.nativeObj, eigenvectors.nativeObj, result.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void PCACompute(Mat data, Mat& mean, Mat& eigenvectors, double retainedVariance)
        //

        //javadoc: PCACompute(data, mean, eigenvectors, retainedVariance)
        public static void PCACompute (Mat data, Mat mean, Mat eigenvectors, double retainedVariance)
        {
            if (data != null) data.ThrowIfDisposed ();
            if (mean != null) mean.ThrowIfDisposed ();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_PCACompute_10(data.nativeObj, mean.nativeObj, eigenvectors.nativeObj, retainedVariance);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void PCACompute(Mat data, Mat& mean, Mat& eigenvectors, int maxComponents = 0)
        //

        //javadoc: PCACompute(data, mean, eigenvectors, maxComponents)
        public static void PCACompute (Mat data, Mat mean, Mat eigenvectors, int maxComponents)
        {
            if (data != null) data.ThrowIfDisposed ();
            if (mean != null) mean.ThrowIfDisposed ();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_PCACompute_11(data.nativeObj, mean.nativeObj, eigenvectors.nativeObj, maxComponents);
        
#else
            return;
#endif
            return;
        }

        //javadoc: PCACompute(data, mean, eigenvectors)
        public static void PCACompute (Mat data, Mat mean, Mat eigenvectors)
        {
            if (data != null) data.ThrowIfDisposed ();
            if (mean != null) mean.ThrowIfDisposed ();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_PCACompute_12(data.nativeObj, mean.nativeObj, eigenvectors.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void PCAProject(Mat data, Mat mean, Mat eigenvectors, Mat& result)
        //

        //javadoc: PCAProject(data, mean, eigenvectors, result)
        public static void PCAProject (Mat data, Mat mean, Mat eigenvectors, Mat result)
        {
            if (data != null) data.ThrowIfDisposed ();
            if (mean != null) mean.ThrowIfDisposed ();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed ();
            if (result != null) result.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_PCAProject_10(data.nativeObj, mean.nativeObj, eigenvectors.nativeObj, result.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void SVBackSubst(Mat w, Mat u, Mat vt, Mat rhs, Mat& dst)
        //

        //javadoc: SVBackSubst(w, u, vt, rhs, dst)
        public static void SVBackSubst (Mat w, Mat u, Mat vt, Mat rhs, Mat dst)
        {
            if (w != null) w.ThrowIfDisposed ();
            if (u != null) u.ThrowIfDisposed ();
            if (vt != null) vt.ThrowIfDisposed ();
            if (rhs != null) rhs.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_SVBackSubst_10(w.nativeObj, u.nativeObj, vt.nativeObj, rhs.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void SVDecomp(Mat src, Mat& w, Mat& u, Mat& vt, int flags = 0)
        //

        //javadoc: SVDecomp(src, w, u, vt, flags)
        public static void SVDecomp (Mat src, Mat w, Mat u, Mat vt, int flags)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (w != null) w.ThrowIfDisposed ();
            if (u != null) u.ThrowIfDisposed ();
            if (vt != null) vt.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_SVDecomp_10(src.nativeObj, w.nativeObj, u.nativeObj, vt.nativeObj, flags);
        
#else
            return;
#endif
            return;
        }

        //javadoc: SVDecomp(src, w, u, vt)
        public static void SVDecomp (Mat src, Mat w, Mat u, Mat vt)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (w != null) w.ThrowIfDisposed ();
            if (u != null) u.ThrowIfDisposed ();
            if (vt != null) vt.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_SVDecomp_11(src.nativeObj, w.nativeObj, u.nativeObj, vt.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void absdiff(Mat src1, Mat src2, Mat& dst)
        //

        //javadoc: absdiff(src1, src2, dst)
        public static void absdiff (Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_absdiff_10(src1.nativeObj, src2.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void absdiff(Mat src1, Scalar src2, Mat& dst)
        //

        //javadoc: absdiff(src1, src2, dst)
        public static void absdiff (Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_absdiff_11(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void add(Mat src1, Mat src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        //

        //javadoc: add(src1, src2, dst, mask, dtype)
        public static void add (Mat src1, Mat src2, Mat dst, Mat mask, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_add_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj, dtype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: add(src1, src2, dst, mask)
        public static void add (Mat src1, Mat src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_add_11(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: add(src1, src2, dst)
        public static void add (Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_add_12(src1.nativeObj, src2.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void add(Mat src1, Scalar src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        //

        //javadoc: add(src1, src2, dst, mask, dtype)
        public static void add (Mat src1, Scalar src2, Mat dst, Mat mask, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_add_13(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, mask.nativeObj, dtype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: add(src1, src2, dst, mask)
        public static void add (Mat src1, Scalar src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_add_14(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, mask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: add(src1, src2, dst)
        public static void add (Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_add_15(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void addWeighted(Mat src1, double alpha, Mat src2, double beta, double gamma, Mat& dst, int dtype = -1)
        //

        //javadoc: addWeighted(src1, alpha, src2, beta, gamma, dst, dtype)
        public static void addWeighted (Mat src1, double alpha, Mat src2, double beta, double gamma, Mat dst, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_addWeighted_10(src1.nativeObj, alpha, src2.nativeObj, beta, gamma, dst.nativeObj, dtype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: addWeighted(src1, alpha, src2, beta, gamma, dst)
        public static void addWeighted (Mat src1, double alpha, Mat src2, double beta, double gamma, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_addWeighted_11(src1.nativeObj, alpha, src2.nativeObj, beta, gamma, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void batchDistance(Mat src1, Mat src2, Mat& dist, int dtype, Mat& nidx, int normType = NORM_L2, int K = 0, Mat mask = Mat(), int update = 0, bool crosscheck = false)
        //

        //javadoc: batchDistance(src1, src2, dist, dtype, nidx, normType, K, mask, update, crosscheck)
        public static void batchDistance (Mat src1, Mat src2, Mat dist, int dtype, Mat nidx, int normType, int K, Mat mask, int update, bool crosscheck)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dist != null) dist.ThrowIfDisposed ();
            if (nidx != null) nidx.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_batchDistance_10(src1.nativeObj, src2.nativeObj, dist.nativeObj, dtype, nidx.nativeObj, normType, K, mask.nativeObj, update, crosscheck);
        
#else
            return;
#endif
            return;
        }

        //javadoc: batchDistance(src1, src2, dist, dtype, nidx, normType, K)
        public static void batchDistance (Mat src1, Mat src2, Mat dist, int dtype, Mat nidx, int normType, int K)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dist != null) dist.ThrowIfDisposed ();
            if (nidx != null) nidx.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_batchDistance_11(src1.nativeObj, src2.nativeObj, dist.nativeObj, dtype, nidx.nativeObj, normType, K);
        
#else
            return;
#endif
            return;
        }

        //javadoc: batchDistance(src1, src2, dist, dtype, nidx)
        public static void batchDistance (Mat src1, Mat src2, Mat dist, int dtype, Mat nidx)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dist != null) dist.ThrowIfDisposed ();
            if (nidx != null) nidx.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_batchDistance_12(src1.nativeObj, src2.nativeObj, dist.nativeObj, dtype, nidx.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void bitwise_and(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
        //

        //javadoc: bitwise_and(src1, src2, dst, mask)
        public static void bitwise_and (Mat src1, Mat src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_bitwise_1and_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: bitwise_and(src1, src2, dst)
        public static void bitwise_and (Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_bitwise_1and_11(src1.nativeObj, src2.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void bitwise_not(Mat src, Mat& dst, Mat mask = Mat())
        //

        //javadoc: bitwise_not(src, dst, mask)
        public static void bitwise_not (Mat src, Mat dst, Mat mask)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_bitwise_1not_10(src.nativeObj, dst.nativeObj, mask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: bitwise_not(src, dst)
        public static void bitwise_not (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_bitwise_1not_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void bitwise_or(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
        //

        //javadoc: bitwise_or(src1, src2, dst, mask)
        public static void bitwise_or (Mat src1, Mat src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_bitwise_1or_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: bitwise_or(src1, src2, dst)
        public static void bitwise_or (Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_bitwise_1or_11(src1.nativeObj, src2.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void bitwise_xor(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
        //

        //javadoc: bitwise_xor(src1, src2, dst, mask)
        public static void bitwise_xor (Mat src1, Mat src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_bitwise_1xor_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: bitwise_xor(src1, src2, dst)
        public static void bitwise_xor (Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_bitwise_1xor_11(src1.nativeObj, src2.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void calcCovarMatrix(Mat samples, Mat& covar, Mat& mean, int flags, int ctype = CV_64F)
        //

        //javadoc: calcCovarMatrix(samples, covar, mean, flags, ctype)
        public static void calcCovarMatrix (Mat samples, Mat covar, Mat mean, int flags, int ctype)
        {
            if (samples != null) samples.ThrowIfDisposed ();
            if (covar != null) covar.ThrowIfDisposed ();
            if (mean != null) mean.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_calcCovarMatrix_10(samples.nativeObj, covar.nativeObj, mean.nativeObj, flags, ctype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: calcCovarMatrix(samples, covar, mean, flags)
        public static void calcCovarMatrix (Mat samples, Mat covar, Mat mean, int flags)
        {
            if (samples != null) samples.ThrowIfDisposed ();
            if (covar != null) covar.ThrowIfDisposed ();
            if (mean != null) mean.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_calcCovarMatrix_11(samples.nativeObj, covar.nativeObj, mean.nativeObj, flags);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void cartToPolar(Mat x, Mat y, Mat& magnitude, Mat& angle, bool angleInDegrees = false)
        //

        //javadoc: cartToPolar(x, y, magnitude, angle, angleInDegrees)
        public static void cartToPolar (Mat x, Mat y, Mat magnitude, Mat angle, bool angleInDegrees)
        {
            if (x != null) x.ThrowIfDisposed ();
            if (y != null) y.ThrowIfDisposed ();
            if (magnitude != null) magnitude.ThrowIfDisposed ();
            if (angle != null) angle.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_cartToPolar_10(x.nativeObj, y.nativeObj, magnitude.nativeObj, angle.nativeObj, angleInDegrees);
        
#else
            return;
#endif
            return;
        }

        //javadoc: cartToPolar(x, y, magnitude, angle)
        public static void cartToPolar (Mat x, Mat y, Mat magnitude, Mat angle)
        {
            if (x != null) x.ThrowIfDisposed ();
            if (y != null) y.ThrowIfDisposed ();
            if (magnitude != null) magnitude.ThrowIfDisposed ();
            if (angle != null) angle.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_cartToPolar_11(x.nativeObj, y.nativeObj, magnitude.nativeObj, angle.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void compare(Mat src1, Mat src2, Mat& dst, int cmpop)
        //

        //javadoc: compare(src1, src2, dst, cmpop)
        public static void compare (Mat src1, Mat src2, Mat dst, int cmpop)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_compare_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, cmpop);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void compare(Mat src1, Scalar src2, Mat& dst, int cmpop)
        //

        //javadoc: compare(src1, src2, dst, cmpop)
        public static void compare (Mat src1, Scalar src2, Mat dst, int cmpop)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_compare_11(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, cmpop);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void completeSymm(Mat& mtx, bool lowerToUpper = false)
        //

        //javadoc: completeSymm(mtx, lowerToUpper)
        public static void completeSymm (Mat mtx, bool lowerToUpper)
        {
            if (mtx != null) mtx.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_completeSymm_10(mtx.nativeObj, lowerToUpper);
        
#else
            return;
#endif
            return;
        }

        //javadoc: completeSymm(mtx)
        public static void completeSymm (Mat mtx)
        {
            if (mtx != null) mtx.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_completeSymm_11(mtx.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void convertFp16(Mat src, Mat& dst)
        //

        //javadoc: convertFp16(src, dst)
        public static void convertFp16 (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_convertFp16_10(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void convertScaleAbs(Mat src, Mat& dst, double alpha = 1, double beta = 0)
        //

        //javadoc: convertScaleAbs(src, dst, alpha, beta)
        public static void convertScaleAbs (Mat src, Mat dst, double alpha, double beta)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_convertScaleAbs_10(src.nativeObj, dst.nativeObj, alpha, beta);
        
#else
            return;
#endif
            return;
        }

        //javadoc: convertScaleAbs(src, dst)
        public static void convertScaleAbs (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_convertScaleAbs_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void copyMakeBorder(Mat src, Mat& dst, int top, int bottom, int left, int right, int borderType, Scalar value = Scalar())
        //

        //javadoc: copyMakeBorder(src, dst, top, bottom, left, right, borderType, value)
        public static void copyMakeBorder (Mat src, Mat dst, int top, int bottom, int left, int right, int borderType, Scalar value)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_copyMakeBorder_10(src.nativeObj, dst.nativeObj, top, bottom, left, right, borderType, value.val[0], value.val[1], value.val[2], value.val[3]);
        
#else
            return;
#endif
            return;
        }

        //javadoc: copyMakeBorder(src, dst, top, bottom, left, right, borderType)
        public static void copyMakeBorder (Mat src, Mat dst, int top, int bottom, int left, int right, int borderType)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_copyMakeBorder_11(src.nativeObj, dst.nativeObj, top, bottom, left, right, borderType);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void dct(Mat src, Mat& dst, int flags = 0)
        //

        //javadoc: dct(src, dst, flags)
        public static void dct (Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_dct_10(src.nativeObj, dst.nativeObj, flags);
        
#else
            return;
#endif
            return;
        }

        //javadoc: dct(src, dst)
        public static void dct (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_dct_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void dft(Mat src, Mat& dst, int flags = 0, int nonzeroRows = 0)
        //

        //javadoc: dft(src, dst, flags, nonzeroRows)
        public static void dft (Mat src, Mat dst, int flags, int nonzeroRows)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_dft_10(src.nativeObj, dst.nativeObj, flags, nonzeroRows);
        
#else
            return;
#endif
            return;
        }

        //javadoc: dft(src, dst)
        public static void dft (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_dft_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void divide(Mat src1, Mat src2, Mat& dst, double scale = 1, int dtype = -1)
        //

        //javadoc: divide(src1, src2, dst, scale, dtype)
        public static void divide (Mat src1, Mat src2, Mat dst, double scale, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_divide_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, scale, dtype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: divide(src1, src2, dst, scale)
        public static void divide (Mat src1, Mat src2, Mat dst, double scale)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_divide_11(src1.nativeObj, src2.nativeObj, dst.nativeObj, scale);
        
#else
            return;
#endif
            return;
        }

        //javadoc: divide(src1, src2, dst)
        public static void divide (Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_divide_12(src1.nativeObj, src2.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void divide(Mat src1, Scalar src2, Mat& dst, double scale = 1, int dtype = -1)
        //

        //javadoc: divide(src1, src2, dst, scale, dtype)
        public static void divide (Mat src1, Scalar src2, Mat dst, double scale, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_divide_13(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, scale, dtype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: divide(src1, src2, dst, scale)
        public static void divide (Mat src1, Scalar src2, Mat dst, double scale)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_divide_14(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, scale);
        
#else
            return;
#endif
            return;
        }

        //javadoc: divide(src1, src2, dst)
        public static void divide (Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_divide_15(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void divide(double scale, Mat src2, Mat& dst, int dtype = -1)
        //

        //javadoc: divide(scale, src2, dst, dtype)
        public static void divide (double scale, Mat src2, Mat dst, int dtype)
        {
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_divide_16(scale, src2.nativeObj, dst.nativeObj, dtype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: divide(scale, src2, dst)
        public static void divide (double scale, Mat src2, Mat dst)
        {
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_divide_17(scale, src2.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void eigenNonSymmetric(Mat src, Mat& eigenvalues, Mat& eigenvectors)
        //

        //javadoc: eigenNonSymmetric(src, eigenvalues, eigenvectors)
        public static void eigenNonSymmetric (Mat src, Mat eigenvalues, Mat eigenvectors)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (eigenvalues != null) eigenvalues.ThrowIfDisposed ();
            if (eigenvectors != null) eigenvectors.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_eigenNonSymmetric_10(src.nativeObj, eigenvalues.nativeObj, eigenvectors.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void exp(Mat src, Mat& dst)
        //

        //javadoc: exp(src, dst)
        public static void exp (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_exp_10(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void extractChannel(Mat src, Mat& dst, int coi)
        //

        //javadoc: extractChannel(src, dst, coi)
        public static void extractChannel (Mat src, Mat dst, int coi)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_extractChannel_10(src.nativeObj, dst.nativeObj, coi);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void findNonZero(Mat src, Mat& idx)
        //

        //javadoc: findNonZero(src, idx)
        public static void findNonZero (Mat src, Mat idx)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (idx != null) idx.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_findNonZero_10(src.nativeObj, idx.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void flip(Mat src, Mat& dst, int flipCode)
        //

        //javadoc: flip(src, dst, flipCode)
        public static void flip (Mat src, Mat dst, int flipCode)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_flip_10(src.nativeObj, dst.nativeObj, flipCode);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void gemm(Mat src1, Mat src2, double alpha, Mat src3, double beta, Mat& dst, int flags = 0)
        //

        //javadoc: gemm(src1, src2, alpha, src3, beta, dst, flags)
        public static void gemm (Mat src1, Mat src2, double alpha, Mat src3, double beta, Mat dst, int flags)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (src3 != null) src3.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_gemm_10(src1.nativeObj, src2.nativeObj, alpha, src3.nativeObj, beta, dst.nativeObj, flags);
        
#else
            return;
#endif
            return;
        }

        //javadoc: gemm(src1, src2, alpha, src3, beta, dst)
        public static void gemm (Mat src1, Mat src2, double alpha, Mat src3, double beta, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (src3 != null) src3.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_gemm_11(src1.nativeObj, src2.nativeObj, alpha, src3.nativeObj, beta, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void hconcat(vector_Mat src, Mat& dst)
        //

        //javadoc: hconcat(src, dst)
        public static void hconcat (List<Mat> src, Mat dst)
        {
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat src_mat = Converters.vector_Mat_to_Mat(src);
        core_Core_hconcat_10(src_mat.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void idct(Mat src, Mat& dst, int flags = 0)
        //

        //javadoc: idct(src, dst, flags)
        public static void idct (Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_idct_10(src.nativeObj, dst.nativeObj, flags);
        
#else
            return;
#endif
            return;
        }

        //javadoc: idct(src, dst)
        public static void idct (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_idct_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void idft(Mat src, Mat& dst, int flags = 0, int nonzeroRows = 0)
        //

        //javadoc: idft(src, dst, flags, nonzeroRows)
        public static void idft (Mat src, Mat dst, int flags, int nonzeroRows)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_idft_10(src.nativeObj, dst.nativeObj, flags, nonzeroRows);
        
#else
            return;
#endif
            return;
        }

        //javadoc: idft(src, dst)
        public static void idft (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_idft_11(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void inRange(Mat src, Scalar lowerb, Scalar upperb, Mat& dst)
        //

        //javadoc: inRange(src, lowerb, upperb, dst)
        public static void inRange (Mat src, Scalar lowerb, Scalar upperb, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_inRange_10(src.nativeObj, lowerb.val[0], lowerb.val[1], lowerb.val[2], lowerb.val[3], upperb.val[0], upperb.val[1], upperb.val[2], upperb.val[3], dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void insertChannel(Mat src, Mat& dst, int coi)
        //

        //javadoc: insertChannel(src, dst, coi)
        public static void insertChannel (Mat src, Mat dst, int coi)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_insertChannel_10(src.nativeObj, dst.nativeObj, coi);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void log(Mat src, Mat& dst)
        //

        //javadoc: log(src, dst)
        public static void log (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_log_10(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void magnitude(Mat x, Mat y, Mat& magnitude)
        //

        //javadoc: magnitude(x, y, magnitude)
        public static void magnitude (Mat x, Mat y, Mat magnitude)
        {
            if (x != null) x.ThrowIfDisposed ();
            if (y != null) y.ThrowIfDisposed ();
            if (magnitude != null) magnitude.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_magnitude_10(x.nativeObj, y.nativeObj, magnitude.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void max(Mat src1, Mat src2, Mat& dst)
        //

        //javadoc: max(src1, src2, dst)
        public static void max (Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_max_10(src1.nativeObj, src2.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void max(Mat src1, Scalar src2, Mat& dst)
        //

        //javadoc: max(src1, src2, dst)
        public static void max (Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_max_11(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void meanStdDev(Mat src, vector_double& mean, vector_double& stddev, Mat mask = Mat())
        //

        //javadoc: meanStdDev(src, mean, stddev, mask)
        public static void meanStdDev (Mat src, MatOfDouble mean, MatOfDouble stddev, Mat mask)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (mean != null) mean.ThrowIfDisposed ();
            if (stddev != null) stddev.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat mean_mat = mean;
        Mat stddev_mat = stddev;
        core_Core_meanStdDev_10(src.nativeObj, mean_mat.nativeObj, stddev_mat.nativeObj, mask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: meanStdDev(src, mean, stddev)
        public static void meanStdDev (Mat src, MatOfDouble mean, MatOfDouble stddev)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (mean != null) mean.ThrowIfDisposed ();
            if (stddev != null) stddev.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat mean_mat = mean;
        Mat stddev_mat = stddev;
        core_Core_meanStdDev_11(src.nativeObj, mean_mat.nativeObj, stddev_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void merge(vector_Mat mv, Mat& dst)
        //

        //javadoc: merge(mv, dst)
        public static void merge (List<Mat> mv, Mat dst)
        {
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat mv_mat = Converters.vector_Mat_to_Mat(mv);
        core_Core_merge_10(mv_mat.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void min(Mat src1, Mat src2, Mat& dst)
        //

        //javadoc: min(src1, src2, dst)
        public static void min (Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_min_10(src1.nativeObj, src2.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void min(Mat src1, Scalar src2, Mat& dst)
        //

        //javadoc: min(src1, src2, dst)
        public static void min (Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_min_11(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void mixChannels(vector_Mat src, vector_Mat dst, vector_int fromTo)
        //

        //javadoc: mixChannels(src, dst, fromTo)
        public static void mixChannels (List<Mat> src, List<Mat> dst, MatOfInt fromTo)
        {
            if (fromTo != null) fromTo.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat src_mat = Converters.vector_Mat_to_Mat(src);
        Mat dst_mat = Converters.vector_Mat_to_Mat(dst);
        Mat fromTo_mat = fromTo;
        core_Core_mixChannels_10(src_mat.nativeObj, dst_mat.nativeObj, fromTo_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void mulSpectrums(Mat a, Mat b, Mat& c, int flags, bool conjB = false)
        //

        //javadoc: mulSpectrums(a, b, c, flags, conjB)
        public static void mulSpectrums (Mat a, Mat b, Mat c, int flags, bool conjB)
        {
            if (a != null) a.ThrowIfDisposed ();
            if (b != null) b.ThrowIfDisposed ();
            if (c != null) c.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_mulSpectrums_10(a.nativeObj, b.nativeObj, c.nativeObj, flags, conjB);
        
#else
            return;
#endif
            return;
        }

        //javadoc: mulSpectrums(a, b, c, flags)
        public static void mulSpectrums (Mat a, Mat b, Mat c, int flags)
        {
            if (a != null) a.ThrowIfDisposed ();
            if (b != null) b.ThrowIfDisposed ();
            if (c != null) c.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_mulSpectrums_11(a.nativeObj, b.nativeObj, c.nativeObj, flags);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void mulTransposed(Mat src, Mat& dst, bool aTa, Mat delta = Mat(), double scale = 1, int dtype = -1)
        //

        //javadoc: mulTransposed(src, dst, aTa, delta, scale, dtype)
        public static void mulTransposed (Mat src, Mat dst, bool aTa, Mat delta, double scale, int dtype)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (delta != null) delta.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_mulTransposed_10(src.nativeObj, dst.nativeObj, aTa, delta.nativeObj, scale, dtype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: mulTransposed(src, dst, aTa, delta, scale)
        public static void mulTransposed (Mat src, Mat dst, bool aTa, Mat delta, double scale)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (delta != null) delta.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_mulTransposed_11(src.nativeObj, dst.nativeObj, aTa, delta.nativeObj, scale);
        
#else
            return;
#endif
            return;
        }

        //javadoc: mulTransposed(src, dst, aTa)
        public static void mulTransposed (Mat src, Mat dst, bool aTa)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_mulTransposed_12(src.nativeObj, dst.nativeObj, aTa);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void multiply(Mat src1, Mat src2, Mat& dst, double scale = 1, int dtype = -1)
        //

        //javadoc: multiply(src1, src2, dst, scale, dtype)
        public static void multiply (Mat src1, Mat src2, Mat dst, double scale, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_multiply_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, scale, dtype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: multiply(src1, src2, dst, scale)
        public static void multiply (Mat src1, Mat src2, Mat dst, double scale)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_multiply_11(src1.nativeObj, src2.nativeObj, dst.nativeObj, scale);
        
#else
            return;
#endif
            return;
        }

        //javadoc: multiply(src1, src2, dst)
        public static void multiply (Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_multiply_12(src1.nativeObj, src2.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void multiply(Mat src1, Scalar src2, Mat& dst, double scale = 1, int dtype = -1)
        //

        //javadoc: multiply(src1, src2, dst, scale, dtype)
        public static void multiply (Mat src1, Scalar src2, Mat dst, double scale, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_multiply_13(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, scale, dtype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: multiply(src1, src2, dst, scale)
        public static void multiply (Mat src1, Scalar src2, Mat dst, double scale)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_multiply_14(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, scale);
        
#else
            return;
#endif
            return;
        }

        //javadoc: multiply(src1, src2, dst)
        public static void multiply (Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_multiply_15(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void normalize(Mat src, Mat& dst, double alpha = 1, double beta = 0, int norm_type = NORM_L2, int dtype = -1, Mat mask = Mat())
        //

        //javadoc: normalize(src, dst, alpha, beta, norm_type, dtype, mask)
        public static void normalize (Mat src, Mat dst, double alpha, double beta, int norm_type, int dtype, Mat mask)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_normalize_10(src.nativeObj, dst.nativeObj, alpha, beta, norm_type, dtype, mask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: normalize(src, dst, alpha, beta, norm_type, dtype)
        public static void normalize (Mat src, Mat dst, double alpha, double beta, int norm_type, int dtype)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_normalize_11(src.nativeObj, dst.nativeObj, alpha, beta, norm_type, dtype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: normalize(src, dst, alpha, beta, norm_type)
        public static void normalize (Mat src, Mat dst, double alpha, double beta, int norm_type)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_normalize_12(src.nativeObj, dst.nativeObj, alpha, beta, norm_type);
        
#else
            return;
#endif
            return;
        }

        //javadoc: normalize(src, dst)
        public static void normalize (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_normalize_13(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void patchNaNs(Mat& a, double val = 0)
        //

        //javadoc: patchNaNs(a, val)
        public static void patchNaNs (Mat a, double val)
        {
            if (a != null) a.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_patchNaNs_10(a.nativeObj, val);
        
#else
            return;
#endif
            return;
        }

        //javadoc: patchNaNs(a)
        public static void patchNaNs (Mat a)
        {
            if (a != null) a.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_patchNaNs_11(a.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void perspectiveTransform(Mat src, Mat& dst, Mat m)
        //

        //javadoc: perspectiveTransform(src, dst, m)
        public static void perspectiveTransform (Mat src, Mat dst, Mat m)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (m != null) m.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_perspectiveTransform_10(src.nativeObj, dst.nativeObj, m.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void phase(Mat x, Mat y, Mat& angle, bool angleInDegrees = false)
        //

        //javadoc: phase(x, y, angle, angleInDegrees)
        public static void phase (Mat x, Mat y, Mat angle, bool angleInDegrees)
        {
            if (x != null) x.ThrowIfDisposed ();
            if (y != null) y.ThrowIfDisposed ();
            if (angle != null) angle.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_phase_10(x.nativeObj, y.nativeObj, angle.nativeObj, angleInDegrees);
        
#else
            return;
#endif
            return;
        }

        //javadoc: phase(x, y, angle)
        public static void phase (Mat x, Mat y, Mat angle)
        {
            if (x != null) x.ThrowIfDisposed ();
            if (y != null) y.ThrowIfDisposed ();
            if (angle != null) angle.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_phase_11(x.nativeObj, y.nativeObj, angle.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void polarToCart(Mat magnitude, Mat angle, Mat& x, Mat& y, bool angleInDegrees = false)
        //

        //javadoc: polarToCart(magnitude, angle, x, y, angleInDegrees)
        public static void polarToCart (Mat magnitude, Mat angle, Mat x, Mat y, bool angleInDegrees)
        {
            if (magnitude != null) magnitude.ThrowIfDisposed ();
            if (angle != null) angle.ThrowIfDisposed ();
            if (x != null) x.ThrowIfDisposed ();
            if (y != null) y.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_polarToCart_10(magnitude.nativeObj, angle.nativeObj, x.nativeObj, y.nativeObj, angleInDegrees);
        
#else
            return;
#endif
            return;
        }

        //javadoc: polarToCart(magnitude, angle, x, y)
        public static void polarToCart (Mat magnitude, Mat angle, Mat x, Mat y)
        {
            if (magnitude != null) magnitude.ThrowIfDisposed ();
            if (angle != null) angle.ThrowIfDisposed ();
            if (x != null) x.ThrowIfDisposed ();
            if (y != null) y.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_polarToCart_11(magnitude.nativeObj, angle.nativeObj, x.nativeObj, y.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void pow(Mat src, double power, Mat& dst)
        //

        //javadoc: pow(src, power, dst)
        public static void pow (Mat src, double power, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_pow_10(src.nativeObj, power, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void randShuffle(Mat& dst, double iterFactor = 1., RNG* rng = 0)
        //

        //javadoc: randShuffle(dst, iterFactor)
        public static void randShuffle (Mat dst, double iterFactor)
        {
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_randShuffle_10(dst.nativeObj, iterFactor);
        
#else
            return;
#endif
            return;
        }

        //javadoc: randShuffle(dst)
        public static void randShuffle (Mat dst)
        {
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_randShuffle_11(dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void randn(Mat& dst, double mean, double stddev)
        //

        //javadoc: randn(dst, mean, stddev)
        public static void randn (Mat dst, double mean, double stddev)
        {
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_randn_10(dst.nativeObj, mean, stddev);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void randu(Mat& dst, double low, double high)
        //

        //javadoc: randu(dst, low, high)
        public static void randu (Mat dst, double low, double high)
        {
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_randu_10(dst.nativeObj, low, high);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void reduce(Mat src, Mat& dst, int dim, int rtype, int dtype = -1)
        //

        //javadoc: reduce(src, dst, dim, rtype, dtype)
        public static void reduce (Mat src, Mat dst, int dim, int rtype, int dtype)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_reduce_10(src.nativeObj, dst.nativeObj, dim, rtype, dtype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: reduce(src, dst, dim, rtype)
        public static void reduce (Mat src, Mat dst, int dim, int rtype)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_reduce_11(src.nativeObj, dst.nativeObj, dim, rtype);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void repeat(Mat src, int ny, int nx, Mat& dst)
        //

        //javadoc: repeat(src, ny, nx, dst)
        public static void repeat (Mat src, int ny, int nx, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_repeat_10(src.nativeObj, ny, nx, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void rotate(Mat src, Mat& dst, int rotateCode)
        //

        //javadoc: rotate(src, dst, rotateCode)
        public static void rotate (Mat src, Mat dst, int rotateCode)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_rotate_10(src.nativeObj, dst.nativeObj, rotateCode);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void scaleAdd(Mat src1, double alpha, Mat src2, Mat& dst)
        //

        //javadoc: scaleAdd(src1, alpha, src2, dst)
        public static void scaleAdd (Mat src1, double alpha, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_scaleAdd_10(src1.nativeObj, alpha, src2.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setErrorVerbosity(bool verbose)
        //

        //javadoc: setErrorVerbosity(verbose)
        public static void setErrorVerbosity (bool verbose)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_setErrorVerbosity_10(verbose);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setIdentity(Mat& mtx, Scalar s = Scalar(1))
        //

        //javadoc: setIdentity(mtx, s)
        public static void setIdentity (Mat mtx, Scalar s)
        {
            if (mtx != null) mtx.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_setIdentity_10(mtx.nativeObj, s.val[0], s.val[1], s.val[2], s.val[3]);
        
#else
            return;
#endif
            return;
        }

        //javadoc: setIdentity(mtx)
        public static void setIdentity (Mat mtx)
        {
            if (mtx != null) mtx.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_setIdentity_11(mtx.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setNumThreads(int nthreads)
        //

        //javadoc: setNumThreads(nthreads)
        public static void setNumThreads (int nthreads)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_setNumThreads_10(nthreads);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setRNGSeed(int seed)
        //

        //javadoc: setRNGSeed(seed)
        public static void setRNGSeed (int seed)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_setRNGSeed_10(seed);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void sort(Mat src, Mat& dst, int flags)
        //

        //javadoc: sort(src, dst, flags)
        public static void sort (Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_sort_10(src.nativeObj, dst.nativeObj, flags);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void sortIdx(Mat src, Mat& dst, int flags)
        //

        //javadoc: sortIdx(src, dst, flags)
        public static void sortIdx (Mat src, Mat dst, int flags)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_sortIdx_10(src.nativeObj, dst.nativeObj, flags);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void split(Mat m, vector_Mat& mv)
        //

        //javadoc: split(m, mv)
        public static void split (Mat m, List<Mat> mv)
        {
            if (m != null) m.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat mv_mat = new Mat();
        core_Core_split_10(m.nativeObj, mv_mat.nativeObj);
        Converters.Mat_to_vector_Mat(mv_mat, mv);
        mv_mat.release();
#else
            return;
#endif
            return;
        }


        //
        // C++:  void sqrt(Mat src, Mat& dst)
        //

        //javadoc: sqrt(src, dst)
        public static void sqrt (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_sqrt_10(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void subtract(Mat src1, Mat src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        //

        //javadoc: subtract(src1, src2, dst, mask, dtype)
        public static void subtract (Mat src1, Mat src2, Mat dst, Mat mask, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_subtract_10(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj, dtype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: subtract(src1, src2, dst, mask)
        public static void subtract (Mat src1, Mat src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_subtract_11(src1.nativeObj, src2.nativeObj, dst.nativeObj, mask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: subtract(src1, src2, dst)
        public static void subtract (Mat src1, Mat src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (src2 != null) src2.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_subtract_12(src1.nativeObj, src2.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void subtract(Mat src1, Scalar src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        //

        //javadoc: subtract(src1, src2, dst, mask, dtype)
        public static void subtract (Mat src1, Scalar src2, Mat dst, Mat mask, int dtype)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_subtract_13(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, mask.nativeObj, dtype);
        
#else
            return;
#endif
            return;
        }

        //javadoc: subtract(src1, src2, dst, mask)
        public static void subtract (Mat src1, Scalar src2, Mat dst, Mat mask)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (mask != null) mask.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_subtract_14(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj, mask.nativeObj);
        
#else
            return;
#endif
            return;
        }

        //javadoc: subtract(src1, src2, dst)
        public static void subtract (Mat src1, Scalar src2, Mat dst)
        {
            if (src1 != null) src1.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_subtract_15(src1.nativeObj, src2.val[0], src2.val[1], src2.val[2], src2.val[3], dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void transform(Mat src, Mat& dst, Mat m)
        //

        //javadoc: transform(src, dst, m)
        public static void transform (Mat src, Mat dst, Mat m)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
            if (m != null) m.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_transform_10(src.nativeObj, dst.nativeObj, m.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void transpose(Mat src, Mat& dst)
        //

        //javadoc: transpose(src, dst)
        public static void transpose (Mat src, Mat dst)
        {
            if (src != null) src.ThrowIfDisposed ();
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_transpose_10(src.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void vconcat(vector_Mat src, Mat& dst)
        //

        //javadoc: vconcat(src, dst)
        public static void vconcat (List<Mat> src, Mat dst)
        {
            if (dst != null) dst.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        Mat src_mat = Converters.vector_Mat_to_Mat(src);
        core_Core_vconcat_10(src_mat.nativeObj, dst.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setUseIPP(bool flag)
        //

        //javadoc: setUseIPP(flag)
        public static void setUseIPP (bool flag)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_setUseIPP_10(flag);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setUseIPP_NE(bool flag)
        //

        //javadoc: setUseIPP_NE(flag)
        public static void setUseIPP_NE (bool flag)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_Core_setUseIPP_1NE_10(flag);
        
#else
            return;
#endif
            return;
        }

        // manual port
        public class MinMaxLocResult
        {
            public double minVal;
            public double maxVal;
            public Point minLoc;
            public Point maxLoc;


            public MinMaxLocResult ()
            {
                minVal = 0; maxVal = 0;
                minLoc = new Point ();
                maxLoc = new Point ();
            }
        }


        // C++: minMaxLoc(Mat src, double* minVal, double* maxVal=0, Point* minLoc=0, Point* maxLoc=0, InputArray mask=noArray())


        //javadoc: minMaxLoc(src, mask)
        public static MinMaxLocResult minMaxLoc (Mat src, Mat mask)
        {
            if (src != null)
                src.ThrowIfDisposed ();
            if (mask != null)
                mask.ThrowIfDisposed ();


#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER


    MinMaxLocResult res = new MinMaxLocResult();
    IntPtr maskNativeObj = IntPtr.Zero;
    if (mask != null) {
        maskNativeObj=mask.nativeObj;
    }
    double[] resarr = new double[6];
    core_Core_n_1minMaxLocManual (src.nativeObj, maskNativeObj, resarr);
    res.minVal=resarr[0];
    res.maxVal=resarr[1];
    res.minLoc.x=resarr[2];
    res.minLoc.y=resarr[3];
    res.maxLoc.x=resarr[4];
    res.maxLoc.y=resarr[5];
    return res;
#else
            return null;
#endif
        }


        //javadoc: minMaxLoc(src)
        public static MinMaxLocResult minMaxLoc (Mat src)
        {
            if (src != null)
                src.ThrowIfDisposed ();


#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        return minMaxLoc (src, null);
#else
            return null;
#endif
        }
#if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        const string LIBNAME = "__Internal";
#else
        const string LIBNAME = "opencvforunity";
#endif



        // C++:  Scalar mean(Mat src, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern void core_Core_mean_10 (IntPtr src_nativeObj, IntPtr mask_nativeObj, double[] retVal);
        [DllImport (LIBNAME)]
        private static extern void core_Core_mean_11 (IntPtr src_nativeObj, double[] retVal);

        // C++:  Scalar sum(Mat src)
        [DllImport (LIBNAME)]
        private static extern void core_Core_sumElems_10 (IntPtr src_nativeObj, double[] retVal);

        // C++:  Scalar trace(Mat mtx)
        [DllImport (LIBNAME)]
        private static extern void core_Core_trace_10 (IntPtr mtx_nativeObj, double[] retVal);

        // C++:  String getBuildInformation()
        [DllImport (LIBNAME)]
        private static extern IntPtr core_Core_getBuildInformation_10 ();

        // C++:  String getIppVersion()
        [DllImport (LIBNAME)]
        private static extern IntPtr core_Core_getIppVersion_10 ();

        // C++:  bool checkRange(Mat a, bool quiet = true,  _hidden_ * pos = 0, double minVal = -DBL_MAX, double maxVal = DBL_MAX)
        [DllImport (LIBNAME)]
        private static extern bool core_Core_checkRange_10 (IntPtr a_nativeObj, bool quiet, double minVal, double maxVal);
        [DllImport (LIBNAME)]
        private static extern bool core_Core_checkRange_11 (IntPtr a_nativeObj);

        // C++:  bool eigen(Mat src, Mat& eigenvalues, Mat& eigenvectors = Mat())
        [DllImport (LIBNAME)]
        private static extern bool core_Core_eigen_10 (IntPtr src_nativeObj, IntPtr eigenvalues_nativeObj, IntPtr eigenvectors_nativeObj);
        [DllImport (LIBNAME)]
        private static extern bool core_Core_eigen_11 (IntPtr src_nativeObj, IntPtr eigenvalues_nativeObj);

        // C++:  bool solve(Mat src1, Mat src2, Mat& dst, int flags = DECOMP_LU)
        [DllImport (LIBNAME)]
        private static extern bool core_Core_solve_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, int flags);
        [DllImport (LIBNAME)]
        private static extern bool core_Core_solve_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  bool useIPP()
        [DllImport (LIBNAME)]
        private static extern bool core_Core_useIPP_10 ();

        // C++:  bool useIPP_NE()
        [DllImport (LIBNAME)]
        private static extern bool core_Core_useIPP_1NE_10 ();

        // C++:  double Mahalanobis(Mat v1, Mat v2, Mat icovar)
        [DllImport (LIBNAME)]
        private static extern double core_Core_Mahalanobis_10 (IntPtr v1_nativeObj, IntPtr v2_nativeObj, IntPtr icovar_nativeObj);

        // C++:  double PSNR(Mat src1, Mat src2)
        [DllImport (LIBNAME)]
        private static extern double core_Core_PSNR_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj);

        // C++:  double determinant(Mat mtx)
        [DllImport (LIBNAME)]
        private static extern double core_Core_determinant_10 (IntPtr mtx_nativeObj);

        // C++:  double getTickFrequency()
        [DllImport (LIBNAME)]
        private static extern double core_Core_getTickFrequency_10 ();

        // C++:  double invert(Mat src, Mat& dst, int flags = DECOMP_LU)
        [DllImport (LIBNAME)]
        private static extern double core_Core_invert_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);
        [DllImport (LIBNAME)]
        private static extern double core_Core_invert_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  double kmeans(Mat data, int K, Mat& bestLabels, TermCriteria criteria, int attempts, int flags, Mat& centers = Mat())
        [DllImport (LIBNAME)]
        private static extern double core_Core_kmeans_10 (IntPtr data_nativeObj, int K, IntPtr bestLabels_nativeObj, int criteria_type, int criteria_maxCount, double criteria_epsilon, int attempts, int flags, IntPtr centers_nativeObj);
        [DllImport (LIBNAME)]
        private static extern double core_Core_kmeans_11 (IntPtr data_nativeObj, int K, IntPtr bestLabels_nativeObj, int criteria_type, int criteria_maxCount, double criteria_epsilon, int attempts, int flags);

        // C++:  double norm(Mat src1, Mat src2, int normType = NORM_L2, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern double core_Core_norm_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, int normType, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern double core_Core_norm_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, int normType);
        [DllImport (LIBNAME)]
        private static extern double core_Core_norm_12 (IntPtr src1_nativeObj, IntPtr src2_nativeObj);

        // C++:  double norm(Mat src1, int normType = NORM_L2, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern double core_Core_norm_13 (IntPtr src1_nativeObj, int normType, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern double core_Core_norm_14 (IntPtr src1_nativeObj, int normType);
        [DllImport (LIBNAME)]
        private static extern double core_Core_norm_15 (IntPtr src1_nativeObj);

        // C++:  double solvePoly(Mat coeffs, Mat& roots, int maxIters = 300)
        [DllImport (LIBNAME)]
        private static extern double core_Core_solvePoly_10 (IntPtr coeffs_nativeObj, IntPtr roots_nativeObj, int maxIters);
        [DllImport (LIBNAME)]
        private static extern double core_Core_solvePoly_11 (IntPtr coeffs_nativeObj, IntPtr roots_nativeObj);

        // C++:  float cubeRoot(float val)
        [DllImport (LIBNAME)]
        private static extern float core_Core_cubeRoot_10 (float val);

        // C++:  float fastAtan2(float y, float x)
        [DllImport (LIBNAME)]
        private static extern float core_Core_fastAtan2_10 (float y, float x);

        // C++:  int borderInterpolate(int p, int len, int borderType)
        [DllImport (LIBNAME)]
        private static extern int core_Core_borderInterpolate_10 (int p, int len, int borderType);

        // C++:  int countNonZero(Mat src)
        [DllImport (LIBNAME)]
        private static extern int core_Core_countNonZero_10 (IntPtr src_nativeObj);

        // C++:  int getNumThreads()
        [DllImport (LIBNAME)]
        private static extern int core_Core_getNumThreads_10 ();

        // C++:  int getNumberOfCPUs()
        [DllImport (LIBNAME)]
        private static extern int core_Core_getNumberOfCPUs_10 ();

        // C++:  int getOptimalDFTSize(int vecsize)
        [DllImport (LIBNAME)]
        private static extern int core_Core_getOptimalDFTSize_10 (int vecsize);

        // C++:  int getThreadNum()
        [DllImport (LIBNAME)]
        private static extern int core_Core_getThreadNum_10 ();

        // C++:  int solveCubic(Mat coeffs, Mat& roots)
        [DllImport (LIBNAME)]
        private static extern int core_Core_solveCubic_10 (IntPtr coeffs_nativeObj, IntPtr roots_nativeObj);

        // C++:  int64 getCPUTickCount()
        [DllImport (LIBNAME)]
        private static extern long core_Core_getCPUTickCount_10 ();

        // C++:  int64 getTickCount()
        [DllImport (LIBNAME)]
        private static extern long core_Core_getTickCount_10 ();

        // C++:  void LUT(Mat src, Mat lut, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_LUT_10 (IntPtr src_nativeObj, IntPtr lut_nativeObj, IntPtr dst_nativeObj);

        // C++:  void PCABackProject(Mat data, Mat mean, Mat eigenvectors, Mat& result)
        [DllImport (LIBNAME)]
        private static extern void core_Core_PCABackProject_10 (IntPtr data_nativeObj, IntPtr mean_nativeObj, IntPtr eigenvectors_nativeObj, IntPtr result_nativeObj);

        // C++:  void PCACompute(Mat data, Mat& mean, Mat& eigenvectors, double retainedVariance)
        [DllImport (LIBNAME)]
        private static extern void core_Core_PCACompute_10 (IntPtr data_nativeObj, IntPtr mean_nativeObj, IntPtr eigenvectors_nativeObj, double retainedVariance);

        // C++:  void PCACompute(Mat data, Mat& mean, Mat& eigenvectors, int maxComponents = 0)
        [DllImport (LIBNAME)]
        private static extern void core_Core_PCACompute_11 (IntPtr data_nativeObj, IntPtr mean_nativeObj, IntPtr eigenvectors_nativeObj, int maxComponents);
        [DllImport (LIBNAME)]
        private static extern void core_Core_PCACompute_12 (IntPtr data_nativeObj, IntPtr mean_nativeObj, IntPtr eigenvectors_nativeObj);

        // C++:  void PCAProject(Mat data, Mat mean, Mat eigenvectors, Mat& result)
        [DllImport (LIBNAME)]
        private static extern void core_Core_PCAProject_10 (IntPtr data_nativeObj, IntPtr mean_nativeObj, IntPtr eigenvectors_nativeObj, IntPtr result_nativeObj);

        // C++:  void SVBackSubst(Mat w, Mat u, Mat vt, Mat rhs, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_SVBackSubst_10 (IntPtr w_nativeObj, IntPtr u_nativeObj, IntPtr vt_nativeObj, IntPtr rhs_nativeObj, IntPtr dst_nativeObj);

        // C++:  void SVDecomp(Mat src, Mat& w, Mat& u, Mat& vt, int flags = 0)
        [DllImport (LIBNAME)]
        private static extern void core_Core_SVDecomp_10 (IntPtr src_nativeObj, IntPtr w_nativeObj, IntPtr u_nativeObj, IntPtr vt_nativeObj, int flags);
        [DllImport (LIBNAME)]
        private static extern void core_Core_SVDecomp_11 (IntPtr src_nativeObj, IntPtr w_nativeObj, IntPtr u_nativeObj, IntPtr vt_nativeObj);

        // C++:  void absdiff(Mat src1, Mat src2, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_absdiff_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void absdiff(Mat src1, Scalar src2, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_absdiff_11 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);

        // C++:  void add(Mat src1, Mat src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        [DllImport (LIBNAME)]
        private static extern void core_Core_add_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj, int dtype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_add_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void core_Core_add_12 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void add(Mat src1, Scalar src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        [DllImport (LIBNAME)]
        private static extern void core_Core_add_13 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, IntPtr mask_nativeObj, int dtype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_add_14 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void core_Core_add_15 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);

        // C++:  void addWeighted(Mat src1, double alpha, Mat src2, double beta, double gamma, Mat& dst, int dtype = -1)
        [DllImport (LIBNAME)]
        private static extern void core_Core_addWeighted_10 (IntPtr src1_nativeObj, double alpha, IntPtr src2_nativeObj, double beta, double gamma, IntPtr dst_nativeObj, int dtype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_addWeighted_11 (IntPtr src1_nativeObj, double alpha, IntPtr src2_nativeObj, double beta, double gamma, IntPtr dst_nativeObj);

        // C++:  void batchDistance(Mat src1, Mat src2, Mat& dist, int dtype, Mat& nidx, int normType = NORM_L2, int K = 0, Mat mask = Mat(), int update = 0, bool crosscheck = false)
        [DllImport (LIBNAME)]
        private static extern void core_Core_batchDistance_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dist_nativeObj, int dtype, IntPtr nidx_nativeObj, int normType, int K, IntPtr mask_nativeObj, int update, bool crosscheck);
        [DllImport (LIBNAME)]
        private static extern void core_Core_batchDistance_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dist_nativeObj, int dtype, IntPtr nidx_nativeObj, int normType, int K);
        [DllImport (LIBNAME)]
        private static extern void core_Core_batchDistance_12 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dist_nativeObj, int dtype, IntPtr nidx_nativeObj);

        // C++:  void bitwise_and(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern void core_Core_bitwise_1and_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void core_Core_bitwise_1and_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void bitwise_not(Mat src, Mat& dst, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern void core_Core_bitwise_1not_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void core_Core_bitwise_1not_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void bitwise_or(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern void core_Core_bitwise_1or_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void core_Core_bitwise_1or_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void bitwise_xor(Mat src1, Mat src2, Mat& dst, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern void core_Core_bitwise_1xor_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void core_Core_bitwise_1xor_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void calcCovarMatrix(Mat samples, Mat& covar, Mat& mean, int flags, int ctype = CV_64F)
        [DllImport (LIBNAME)]
        private static extern void core_Core_calcCovarMatrix_10 (IntPtr samples_nativeObj, IntPtr covar_nativeObj, IntPtr mean_nativeObj, int flags, int ctype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_calcCovarMatrix_11 (IntPtr samples_nativeObj, IntPtr covar_nativeObj, IntPtr mean_nativeObj, int flags);

        // C++:  void cartToPolar(Mat x, Mat y, Mat& magnitude, Mat& angle, bool angleInDegrees = false)
        [DllImport (LIBNAME)]
        private static extern void core_Core_cartToPolar_10 (IntPtr x_nativeObj, IntPtr y_nativeObj, IntPtr magnitude_nativeObj, IntPtr angle_nativeObj, bool angleInDegrees);
        [DllImport (LIBNAME)]
        private static extern void core_Core_cartToPolar_11 (IntPtr x_nativeObj, IntPtr y_nativeObj, IntPtr magnitude_nativeObj, IntPtr angle_nativeObj);

        // C++:  void compare(Mat src1, Mat src2, Mat& dst, int cmpop)
        [DllImport (LIBNAME)]
        private static extern void core_Core_compare_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, int cmpop);

        // C++:  void compare(Mat src1, Scalar src2, Mat& dst, int cmpop)
        [DllImport (LIBNAME)]
        private static extern void core_Core_compare_11 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, int cmpop);

        // C++:  void completeSymm(Mat& mtx, bool lowerToUpper = false)
        [DllImport (LIBNAME)]
        private static extern void core_Core_completeSymm_10 (IntPtr mtx_nativeObj, bool lowerToUpper);
        [DllImport (LIBNAME)]
        private static extern void core_Core_completeSymm_11 (IntPtr mtx_nativeObj);

        // C++:  void convertFp16(Mat src, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_convertFp16_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void convertScaleAbs(Mat src, Mat& dst, double alpha = 1, double beta = 0)
        [DllImport (LIBNAME)]
        private static extern void core_Core_convertScaleAbs_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha, double beta);
        [DllImport (LIBNAME)]
        private static extern void core_Core_convertScaleAbs_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void copyMakeBorder(Mat src, Mat& dst, int top, int bottom, int left, int right, int borderType, Scalar value = Scalar())
        [DllImport (LIBNAME)]
        private static extern void core_Core_copyMakeBorder_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int top, int bottom, int left, int right, int borderType, double value_val0, double value_val1, double value_val2, double value_val3);
        [DllImport (LIBNAME)]
        private static extern void core_Core_copyMakeBorder_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int top, int bottom, int left, int right, int borderType);

        // C++:  void dct(Mat src, Mat& dst, int flags = 0)
        [DllImport (LIBNAME)]
        private static extern void core_Core_dct_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);
        [DllImport (LIBNAME)]
        private static extern void core_Core_dct_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void dft(Mat src, Mat& dst, int flags = 0, int nonzeroRows = 0)
        [DllImport (LIBNAME)]
        private static extern void core_Core_dft_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags, int nonzeroRows);
        [DllImport (LIBNAME)]
        private static extern void core_Core_dft_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void divide(Mat src1, Mat src2, Mat& dst, double scale = 1, int dtype = -1)
        [DllImport (LIBNAME)]
        private static extern void core_Core_divide_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, double scale, int dtype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_divide_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, double scale);
        [DllImport (LIBNAME)]
        private static extern void core_Core_divide_12 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void divide(Mat src1, Scalar src2, Mat& dst, double scale = 1, int dtype = -1)
        [DllImport (LIBNAME)]
        private static extern void core_Core_divide_13 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, double scale, int dtype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_divide_14 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, double scale);
        [DllImport (LIBNAME)]
        private static extern void core_Core_divide_15 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);

        // C++:  void divide(double scale, Mat src2, Mat& dst, int dtype = -1)
        [DllImport (LIBNAME)]
        private static extern void core_Core_divide_16 (double scale, IntPtr src2_nativeObj, IntPtr dst_nativeObj, int dtype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_divide_17 (double scale, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void eigenNonSymmetric(Mat src, Mat& eigenvalues, Mat& eigenvectors)
        [DllImport (LIBNAME)]
        private static extern void core_Core_eigenNonSymmetric_10 (IntPtr src_nativeObj, IntPtr eigenvalues_nativeObj, IntPtr eigenvectors_nativeObj);

        // C++:  void exp(Mat src, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_exp_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void extractChannel(Mat src, Mat& dst, int coi)
        [DllImport (LIBNAME)]
        private static extern void core_Core_extractChannel_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int coi);

        // C++:  void findNonZero(Mat src, Mat& idx)
        [DllImport (LIBNAME)]
        private static extern void core_Core_findNonZero_10 (IntPtr src_nativeObj, IntPtr idx_nativeObj);

        // C++:  void flip(Mat src, Mat& dst, int flipCode)
        [DllImport (LIBNAME)]
        private static extern void core_Core_flip_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int flipCode);

        // C++:  void gemm(Mat src1, Mat src2, double alpha, Mat src3, double beta, Mat& dst, int flags = 0)
        [DllImport (LIBNAME)]
        private static extern void core_Core_gemm_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, double alpha, IntPtr src3_nativeObj, double beta, IntPtr dst_nativeObj, int flags);
        [DllImport (LIBNAME)]
        private static extern void core_Core_gemm_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, double alpha, IntPtr src3_nativeObj, double beta, IntPtr dst_nativeObj);

        // C++:  void hconcat(vector_Mat src, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_hconcat_10 (IntPtr src_mat_nativeObj, IntPtr dst_nativeObj);

        // C++:  void idct(Mat src, Mat& dst, int flags = 0)
        [DllImport (LIBNAME)]
        private static extern void core_Core_idct_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);
        [DllImport (LIBNAME)]
        private static extern void core_Core_idct_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void idft(Mat src, Mat& dst, int flags = 0, int nonzeroRows = 0)
        [DllImport (LIBNAME)]
        private static extern void core_Core_idft_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags, int nonzeroRows);
        [DllImport (LIBNAME)]
        private static extern void core_Core_idft_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void inRange(Mat src, Scalar lowerb, Scalar upperb, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_inRange_10 (IntPtr src_nativeObj, double lowerb_val0, double lowerb_val1, double lowerb_val2, double lowerb_val3, double upperb_val0, double upperb_val1, double upperb_val2, double upperb_val3, IntPtr dst_nativeObj);

        // C++:  void insertChannel(Mat src, Mat& dst, int coi)
        [DllImport (LIBNAME)]
        private static extern void core_Core_insertChannel_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int coi);

        // C++:  void log(Mat src, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_log_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void magnitude(Mat x, Mat y, Mat& magnitude)
        [DllImport (LIBNAME)]
        private static extern void core_Core_magnitude_10 (IntPtr x_nativeObj, IntPtr y_nativeObj, IntPtr magnitude_nativeObj);

        // C++:  void max(Mat src1, Mat src2, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_max_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void max(Mat src1, Scalar src2, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_max_11 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);

        // C++:  void meanStdDev(Mat src, vector_double& mean, vector_double& stddev, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern void core_Core_meanStdDev_10 (IntPtr src_nativeObj, IntPtr mean_mat_nativeObj, IntPtr stddev_mat_nativeObj, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void core_Core_meanStdDev_11 (IntPtr src_nativeObj, IntPtr mean_mat_nativeObj, IntPtr stddev_mat_nativeObj);

        // C++:  void merge(vector_Mat mv, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_merge_10 (IntPtr mv_mat_nativeObj, IntPtr dst_nativeObj);

        // C++:  void min(Mat src1, Mat src2, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_min_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void min(Mat src1, Scalar src2, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_min_11 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);

        // C++:  void mixChannels(vector_Mat src, vector_Mat dst, vector_int fromTo)
        [DllImport (LIBNAME)]
        private static extern void core_Core_mixChannels_10 (IntPtr src_mat_nativeObj, IntPtr dst_mat_nativeObj, IntPtr fromTo_mat_nativeObj);

        // C++:  void mulSpectrums(Mat a, Mat b, Mat& c, int flags, bool conjB = false)
        [DllImport (LIBNAME)]
        private static extern void core_Core_mulSpectrums_10 (IntPtr a_nativeObj, IntPtr b_nativeObj, IntPtr c_nativeObj, int flags, bool conjB);
        [DllImport (LIBNAME)]
        private static extern void core_Core_mulSpectrums_11 (IntPtr a_nativeObj, IntPtr b_nativeObj, IntPtr c_nativeObj, int flags);

        // C++:  void mulTransposed(Mat src, Mat& dst, bool aTa, Mat delta = Mat(), double scale = 1, int dtype = -1)
        [DllImport (LIBNAME)]
        private static extern void core_Core_mulTransposed_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, bool aTa, IntPtr delta_nativeObj, double scale, int dtype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_mulTransposed_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, bool aTa, IntPtr delta_nativeObj, double scale);
        [DllImport (LIBNAME)]
        private static extern void core_Core_mulTransposed_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, bool aTa);

        // C++:  void multiply(Mat src1, Mat src2, Mat& dst, double scale = 1, int dtype = -1)
        [DllImport (LIBNAME)]
        private static extern void core_Core_multiply_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, double scale, int dtype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_multiply_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, double scale);
        [DllImport (LIBNAME)]
        private static extern void core_Core_multiply_12 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void multiply(Mat src1, Scalar src2, Mat& dst, double scale = 1, int dtype = -1)
        [DllImport (LIBNAME)]
        private static extern void core_Core_multiply_13 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, double scale, int dtype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_multiply_14 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, double scale);
        [DllImport (LIBNAME)]
        private static extern void core_Core_multiply_15 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);

        // C++:  void normalize(Mat src, Mat& dst, double alpha = 1, double beta = 0, int norm_type = NORM_L2, int dtype = -1, Mat mask = Mat())
        [DllImport (LIBNAME)]
        private static extern void core_Core_normalize_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha, double beta, int norm_type, int dtype, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void core_Core_normalize_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha, double beta, int norm_type, int dtype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_normalize_12 (IntPtr src_nativeObj, IntPtr dst_nativeObj, double alpha, double beta, int norm_type);
        [DllImport (LIBNAME)]
        private static extern void core_Core_normalize_13 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void patchNaNs(Mat& a, double val = 0)
        [DllImport (LIBNAME)]
        private static extern void core_Core_patchNaNs_10 (IntPtr a_nativeObj, double val);
        [DllImport (LIBNAME)]
        private static extern void core_Core_patchNaNs_11 (IntPtr a_nativeObj);

        // C++:  void perspectiveTransform(Mat src, Mat& dst, Mat m)
        [DllImport (LIBNAME)]
        private static extern void core_Core_perspectiveTransform_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr m_nativeObj);

        // C++:  void phase(Mat x, Mat y, Mat& angle, bool angleInDegrees = false)
        [DllImport (LIBNAME)]
        private static extern void core_Core_phase_10 (IntPtr x_nativeObj, IntPtr y_nativeObj, IntPtr angle_nativeObj, bool angleInDegrees);
        [DllImport (LIBNAME)]
        private static extern void core_Core_phase_11 (IntPtr x_nativeObj, IntPtr y_nativeObj, IntPtr angle_nativeObj);

        // C++:  void polarToCart(Mat magnitude, Mat angle, Mat& x, Mat& y, bool angleInDegrees = false)
        [DllImport (LIBNAME)]
        private static extern void core_Core_polarToCart_10 (IntPtr magnitude_nativeObj, IntPtr angle_nativeObj, IntPtr x_nativeObj, IntPtr y_nativeObj, bool angleInDegrees);
        [DllImport (LIBNAME)]
        private static extern void core_Core_polarToCart_11 (IntPtr magnitude_nativeObj, IntPtr angle_nativeObj, IntPtr x_nativeObj, IntPtr y_nativeObj);

        // C++:  void pow(Mat src, double power, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_pow_10 (IntPtr src_nativeObj, double power, IntPtr dst_nativeObj);

        // C++:  void randShuffle(Mat& dst, double iterFactor = 1., RNG* rng = 0)
        [DllImport (LIBNAME)]
        private static extern void core_Core_randShuffle_10 (IntPtr dst_nativeObj, double iterFactor);
        [DllImport (LIBNAME)]
        private static extern void core_Core_randShuffle_11 (IntPtr dst_nativeObj);

        // C++:  void randn(Mat& dst, double mean, double stddev)
        [DllImport (LIBNAME)]
        private static extern void core_Core_randn_10 (IntPtr dst_nativeObj, double mean, double stddev);

        // C++:  void randu(Mat& dst, double low, double high)
        [DllImport (LIBNAME)]
        private static extern void core_Core_randu_10 (IntPtr dst_nativeObj, double low, double high);

        // C++:  void reduce(Mat src, Mat& dst, int dim, int rtype, int dtype = -1)
        [DllImport (LIBNAME)]
        private static extern void core_Core_reduce_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int dim, int rtype, int dtype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_reduce_11 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int dim, int rtype);

        // C++:  void repeat(Mat src, int ny, int nx, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_repeat_10 (IntPtr src_nativeObj, int ny, int nx, IntPtr dst_nativeObj);

        // C++:  void rotate(Mat src, Mat& dst, int rotateCode)
        [DllImport (LIBNAME)]
        private static extern void core_Core_rotate_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int rotateCode);

        // C++:  void scaleAdd(Mat src1, double alpha, Mat src2, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_scaleAdd_10 (IntPtr src1_nativeObj, double alpha, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void setErrorVerbosity(bool verbose)
        [DllImport (LIBNAME)]
        private static extern void core_Core_setErrorVerbosity_10 (bool verbose);

        // C++:  void setIdentity(Mat& mtx, Scalar s = Scalar(1))
        [DllImport (LIBNAME)]
        private static extern void core_Core_setIdentity_10 (IntPtr mtx_nativeObj, double s_val0, double s_val1, double s_val2, double s_val3);
        [DllImport (LIBNAME)]
        private static extern void core_Core_setIdentity_11 (IntPtr mtx_nativeObj);

        // C++:  void setNumThreads(int nthreads)
        [DllImport (LIBNAME)]
        private static extern void core_Core_setNumThreads_10 (int nthreads);

        // C++:  void setRNGSeed(int seed)
        [DllImport (LIBNAME)]
        private static extern void core_Core_setRNGSeed_10 (int seed);

        // C++:  void sort(Mat src, Mat& dst, int flags)
        [DllImport (LIBNAME)]
        private static extern void core_Core_sort_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);

        // C++:  void sortIdx(Mat src, Mat& dst, int flags)
        [DllImport (LIBNAME)]
        private static extern void core_Core_sortIdx_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, int flags);

        // C++:  void split(Mat m, vector_Mat& mv)
        [DllImport (LIBNAME)]
        private static extern void core_Core_split_10 (IntPtr m_nativeObj, IntPtr mv_mat_nativeObj);

        // C++:  void sqrt(Mat src, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_sqrt_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void subtract(Mat src1, Mat src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        [DllImport (LIBNAME)]
        private static extern void core_Core_subtract_10 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj, int dtype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_subtract_11 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void core_Core_subtract_12 (IntPtr src1_nativeObj, IntPtr src2_nativeObj, IntPtr dst_nativeObj);

        // C++:  void subtract(Mat src1, Scalar src2, Mat& dst, Mat mask = Mat(), int dtype = -1)
        [DllImport (LIBNAME)]
        private static extern void core_Core_subtract_13 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, IntPtr mask_nativeObj, int dtype);
        [DllImport (LIBNAME)]
        private static extern void core_Core_subtract_14 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj, IntPtr mask_nativeObj);
        [DllImport (LIBNAME)]
        private static extern void core_Core_subtract_15 (IntPtr src1_nativeObj, double src2_val0, double src2_val1, double src2_val2, double src2_val3, IntPtr dst_nativeObj);

        // C++:  void transform(Mat src, Mat& dst, Mat m)
        [DllImport (LIBNAME)]
        private static extern void core_Core_transform_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj, IntPtr m_nativeObj);

        // C++:  void transpose(Mat src, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_transpose_10 (IntPtr src_nativeObj, IntPtr dst_nativeObj);

        // C++:  void vconcat(vector_Mat src, Mat& dst)
        [DllImport (LIBNAME)]
        private static extern void core_Core_vconcat_10 (IntPtr src_mat_nativeObj, IntPtr dst_nativeObj);

        // C++:  void setUseIPP(bool flag)
        [DllImport (LIBNAME)]
        private static extern void core_Core_setUseIPP_10 (bool flag);

        // C++:  void setUseIPP_NE(bool flag)
        [DllImport (LIBNAME)]
        private static extern void core_Core_setUseIPP_1NE_10 (bool flag);
        [DllImport (LIBNAME)]
        private static extern void core_Core_n_1minMaxLocManual (IntPtr src_nativeObj, IntPtr mask_nativeObj, double[] vals);
    }
}
