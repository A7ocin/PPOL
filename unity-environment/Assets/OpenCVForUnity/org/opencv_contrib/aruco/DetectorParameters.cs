

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class DetectorParameters
    //javadoc: DetectorParameters

    public class DetectorParameters : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
aruco_DetectorParameters_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal DetectorParameters (IntPtr addr) : base (addr) { }


        public IntPtr getNativeObjAddr () { return nativeObj; }

        //
        // C++: static Ptr_DetectorParameters create()
        //

        //javadoc: DetectorParameters::create()
        public static DetectorParameters create ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        DetectorParameters retVal = new DetectorParameters(aruco_DetectorParameters_create_10());
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: int DetectorParameters::adaptiveThreshWinSizeMin
        //

        //javadoc: DetectorParameters::get_adaptiveThreshWinSizeMin()
        public int get_adaptiveThreshWinSizeMin ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = aruco_DetectorParameters_get_1adaptiveThreshWinSizeMin_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::adaptiveThreshWinSizeMin
        //

        //javadoc: DetectorParameters::set_adaptiveThreshWinSizeMin(adaptiveThreshWinSizeMin)
        public void set_adaptiveThreshWinSizeMin (int adaptiveThreshWinSizeMin)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1adaptiveThreshWinSizeMin_10(nativeObj, adaptiveThreshWinSizeMin);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: int DetectorParameters::adaptiveThreshWinSizeMax
        //

        //javadoc: DetectorParameters::get_adaptiveThreshWinSizeMax()
        public int get_adaptiveThreshWinSizeMax ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = aruco_DetectorParameters_get_1adaptiveThreshWinSizeMax_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::adaptiveThreshWinSizeMax
        //

        //javadoc: DetectorParameters::set_adaptiveThreshWinSizeMax(adaptiveThreshWinSizeMax)
        public void set_adaptiveThreshWinSizeMax (int adaptiveThreshWinSizeMax)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1adaptiveThreshWinSizeMax_10(nativeObj, adaptiveThreshWinSizeMax);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: int DetectorParameters::adaptiveThreshWinSizeStep
        //

        //javadoc: DetectorParameters::get_adaptiveThreshWinSizeStep()
        public int get_adaptiveThreshWinSizeStep ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = aruco_DetectorParameters_get_1adaptiveThreshWinSizeStep_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::adaptiveThreshWinSizeStep
        //

        //javadoc: DetectorParameters::set_adaptiveThreshWinSizeStep(adaptiveThreshWinSizeStep)
        public void set_adaptiveThreshWinSizeStep (int adaptiveThreshWinSizeStep)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1adaptiveThreshWinSizeStep_10(nativeObj, adaptiveThreshWinSizeStep);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: double DetectorParameters::adaptiveThreshConstant
        //

        //javadoc: DetectorParameters::get_adaptiveThreshConstant()
        public double get_adaptiveThreshConstant ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = aruco_DetectorParameters_get_1adaptiveThreshConstant_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::adaptiveThreshConstant
        //

        //javadoc: DetectorParameters::set_adaptiveThreshConstant(adaptiveThreshConstant)
        public void set_adaptiveThreshConstant (double adaptiveThreshConstant)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1adaptiveThreshConstant_10(nativeObj, adaptiveThreshConstant);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: double DetectorParameters::minMarkerPerimeterRate
        //

        //javadoc: DetectorParameters::get_minMarkerPerimeterRate()
        public double get_minMarkerPerimeterRate ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = aruco_DetectorParameters_get_1minMarkerPerimeterRate_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::minMarkerPerimeterRate
        //

        //javadoc: DetectorParameters::set_minMarkerPerimeterRate(minMarkerPerimeterRate)
        public void set_minMarkerPerimeterRate (double minMarkerPerimeterRate)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1minMarkerPerimeterRate_10(nativeObj, minMarkerPerimeterRate);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: double DetectorParameters::maxMarkerPerimeterRate
        //

        //javadoc: DetectorParameters::get_maxMarkerPerimeterRate()
        public double get_maxMarkerPerimeterRate ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = aruco_DetectorParameters_get_1maxMarkerPerimeterRate_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::maxMarkerPerimeterRate
        //

        //javadoc: DetectorParameters::set_maxMarkerPerimeterRate(maxMarkerPerimeterRate)
        public void set_maxMarkerPerimeterRate (double maxMarkerPerimeterRate)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1maxMarkerPerimeterRate_10(nativeObj, maxMarkerPerimeterRate);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: double DetectorParameters::polygonalApproxAccuracyRate
        //

        //javadoc: DetectorParameters::get_polygonalApproxAccuracyRate()
        public double get_polygonalApproxAccuracyRate ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = aruco_DetectorParameters_get_1polygonalApproxAccuracyRate_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::polygonalApproxAccuracyRate
        //

        //javadoc: DetectorParameters::set_polygonalApproxAccuracyRate(polygonalApproxAccuracyRate)
        public void set_polygonalApproxAccuracyRate (double polygonalApproxAccuracyRate)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1polygonalApproxAccuracyRate_10(nativeObj, polygonalApproxAccuracyRate);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: double DetectorParameters::minCornerDistanceRate
        //

        //javadoc: DetectorParameters::get_minCornerDistanceRate()
        public double get_minCornerDistanceRate ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = aruco_DetectorParameters_get_1minCornerDistanceRate_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::minCornerDistanceRate
        //

        //javadoc: DetectorParameters::set_minCornerDistanceRate(minCornerDistanceRate)
        public void set_minCornerDistanceRate (double minCornerDistanceRate)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1minCornerDistanceRate_10(nativeObj, minCornerDistanceRate);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: int DetectorParameters::minDistanceToBorder
        //

        //javadoc: DetectorParameters::get_minDistanceToBorder()
        public int get_minDistanceToBorder ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = aruco_DetectorParameters_get_1minDistanceToBorder_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::minDistanceToBorder
        //

        //javadoc: DetectorParameters::set_minDistanceToBorder(minDistanceToBorder)
        public void set_minDistanceToBorder (int minDistanceToBorder)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1minDistanceToBorder_10(nativeObj, minDistanceToBorder);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: double DetectorParameters::minMarkerDistanceRate
        //

        //javadoc: DetectorParameters::get_minMarkerDistanceRate()
        public double get_minMarkerDistanceRate ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = aruco_DetectorParameters_get_1minMarkerDistanceRate_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::minMarkerDistanceRate
        //

        //javadoc: DetectorParameters::set_minMarkerDistanceRate(minMarkerDistanceRate)
        public void set_minMarkerDistanceRate (double minMarkerDistanceRate)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1minMarkerDistanceRate_10(nativeObj, minMarkerDistanceRate);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: int DetectorParameters::cornerRefinementMethod
        //

        //javadoc: DetectorParameters::get_cornerRefinementMethod()
        public int get_cornerRefinementMethod ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = aruco_DetectorParameters_get_1cornerRefinementMethod_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::cornerRefinementMethod
        //

        //javadoc: DetectorParameters::set_cornerRefinementMethod(cornerRefinementMethod)
        public void set_cornerRefinementMethod (int cornerRefinementMethod)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1cornerRefinementMethod_10(nativeObj, cornerRefinementMethod);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: int DetectorParameters::cornerRefinementWinSize
        //

        //javadoc: DetectorParameters::get_cornerRefinementWinSize()
        public int get_cornerRefinementWinSize ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = aruco_DetectorParameters_get_1cornerRefinementWinSize_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::cornerRefinementWinSize
        //

        //javadoc: DetectorParameters::set_cornerRefinementWinSize(cornerRefinementWinSize)
        public void set_cornerRefinementWinSize (int cornerRefinementWinSize)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1cornerRefinementWinSize_10(nativeObj, cornerRefinementWinSize);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: int DetectorParameters::cornerRefinementMaxIterations
        //

        //javadoc: DetectorParameters::get_cornerRefinementMaxIterations()
        public int get_cornerRefinementMaxIterations ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = aruco_DetectorParameters_get_1cornerRefinementMaxIterations_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::cornerRefinementMaxIterations
        //

        //javadoc: DetectorParameters::set_cornerRefinementMaxIterations(cornerRefinementMaxIterations)
        public void set_cornerRefinementMaxIterations (int cornerRefinementMaxIterations)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1cornerRefinementMaxIterations_10(nativeObj, cornerRefinementMaxIterations);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: double DetectorParameters::cornerRefinementMinAccuracy
        //

        //javadoc: DetectorParameters::get_cornerRefinementMinAccuracy()
        public double get_cornerRefinementMinAccuracy ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = aruco_DetectorParameters_get_1cornerRefinementMinAccuracy_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::cornerRefinementMinAccuracy
        //

        //javadoc: DetectorParameters::set_cornerRefinementMinAccuracy(cornerRefinementMinAccuracy)
        public void set_cornerRefinementMinAccuracy (double cornerRefinementMinAccuracy)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1cornerRefinementMinAccuracy_10(nativeObj, cornerRefinementMinAccuracy);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: int DetectorParameters::markerBorderBits
        //

        //javadoc: DetectorParameters::get_markerBorderBits()
        public int get_markerBorderBits ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = aruco_DetectorParameters_get_1markerBorderBits_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::markerBorderBits
        //

        //javadoc: DetectorParameters::set_markerBorderBits(markerBorderBits)
        public void set_markerBorderBits (int markerBorderBits)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1markerBorderBits_10(nativeObj, markerBorderBits);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: int DetectorParameters::perspectiveRemovePixelPerCell
        //

        //javadoc: DetectorParameters::get_perspectiveRemovePixelPerCell()
        public int get_perspectiveRemovePixelPerCell ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        int retVal = aruco_DetectorParameters_get_1perspectiveRemovePixelPerCell_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::perspectiveRemovePixelPerCell
        //

        //javadoc: DetectorParameters::set_perspectiveRemovePixelPerCell(perspectiveRemovePixelPerCell)
        public void set_perspectiveRemovePixelPerCell (int perspectiveRemovePixelPerCell)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1perspectiveRemovePixelPerCell_10(nativeObj, perspectiveRemovePixelPerCell);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: double DetectorParameters::perspectiveRemoveIgnoredMarginPerCell
        //

        //javadoc: DetectorParameters::get_perspectiveRemoveIgnoredMarginPerCell()
        public double get_perspectiveRemoveIgnoredMarginPerCell ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = aruco_DetectorParameters_get_1perspectiveRemoveIgnoredMarginPerCell_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::perspectiveRemoveIgnoredMarginPerCell
        //

        //javadoc: DetectorParameters::set_perspectiveRemoveIgnoredMarginPerCell(perspectiveRemoveIgnoredMarginPerCell)
        public void set_perspectiveRemoveIgnoredMarginPerCell (double perspectiveRemoveIgnoredMarginPerCell)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1perspectiveRemoveIgnoredMarginPerCell_10(nativeObj, perspectiveRemoveIgnoredMarginPerCell);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: double DetectorParameters::maxErroneousBitsInBorderRate
        //

        //javadoc: DetectorParameters::get_maxErroneousBitsInBorderRate()
        public double get_maxErroneousBitsInBorderRate ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = aruco_DetectorParameters_get_1maxErroneousBitsInBorderRate_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::maxErroneousBitsInBorderRate
        //

        //javadoc: DetectorParameters::set_maxErroneousBitsInBorderRate(maxErroneousBitsInBorderRate)
        public void set_maxErroneousBitsInBorderRate (double maxErroneousBitsInBorderRate)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1maxErroneousBitsInBorderRate_10(nativeObj, maxErroneousBitsInBorderRate);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: double DetectorParameters::minOtsuStdDev
        //

        //javadoc: DetectorParameters::get_minOtsuStdDev()
        public double get_minOtsuStdDev ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = aruco_DetectorParameters_get_1minOtsuStdDev_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::minOtsuStdDev
        //

        //javadoc: DetectorParameters::set_minOtsuStdDev(minOtsuStdDev)
        public void set_minOtsuStdDev (double minOtsuStdDev)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1minOtsuStdDev_10(nativeObj, minOtsuStdDev);
        
#else
            return;
#endif
            return;
        }


        //
        // C++: double DetectorParameters::errorCorrectionRate
        //

        //javadoc: DetectorParameters::get_errorCorrectionRate()
        public double get_errorCorrectionRate ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = aruco_DetectorParameters_get_1errorCorrectionRate_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++: void DetectorParameters::errorCorrectionRate
        //

        //javadoc: DetectorParameters::set_errorCorrectionRate(errorCorrectionRate)
        public void set_errorCorrectionRate (double errorCorrectionRate)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        aruco_DetectorParameters_set_1errorCorrectionRate_10(nativeObj, errorCorrectionRate);
        
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



        // C++: static Ptr_DetectorParameters create()
        [DllImport (LIBNAME)]
        private static extern IntPtr aruco_DetectorParameters_create_10 ();

        // C++: int DetectorParameters::adaptiveThreshWinSizeMin
        [DllImport (LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1adaptiveThreshWinSizeMin_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::adaptiveThreshWinSizeMin
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1adaptiveThreshWinSizeMin_10 (IntPtr nativeObj, int adaptiveThreshWinSizeMin);

        // C++: int DetectorParameters::adaptiveThreshWinSizeMax
        [DllImport (LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1adaptiveThreshWinSizeMax_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::adaptiveThreshWinSizeMax
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1adaptiveThreshWinSizeMax_10 (IntPtr nativeObj, int adaptiveThreshWinSizeMax);

        // C++: int DetectorParameters::adaptiveThreshWinSizeStep
        [DllImport (LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1adaptiveThreshWinSizeStep_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::adaptiveThreshWinSizeStep
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1adaptiveThreshWinSizeStep_10 (IntPtr nativeObj, int adaptiveThreshWinSizeStep);

        // C++: double DetectorParameters::adaptiveThreshConstant
        [DllImport (LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1adaptiveThreshConstant_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::adaptiveThreshConstant
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1adaptiveThreshConstant_10 (IntPtr nativeObj, double adaptiveThreshConstant);

        // C++: double DetectorParameters::minMarkerPerimeterRate
        [DllImport (LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1minMarkerPerimeterRate_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::minMarkerPerimeterRate
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1minMarkerPerimeterRate_10 (IntPtr nativeObj, double minMarkerPerimeterRate);

        // C++: double DetectorParameters::maxMarkerPerimeterRate
        [DllImport (LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1maxMarkerPerimeterRate_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::maxMarkerPerimeterRate
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1maxMarkerPerimeterRate_10 (IntPtr nativeObj, double maxMarkerPerimeterRate);

        // C++: double DetectorParameters::polygonalApproxAccuracyRate
        [DllImport (LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1polygonalApproxAccuracyRate_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::polygonalApproxAccuracyRate
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1polygonalApproxAccuracyRate_10 (IntPtr nativeObj, double polygonalApproxAccuracyRate);

        // C++: double DetectorParameters::minCornerDistanceRate
        [DllImport (LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1minCornerDistanceRate_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::minCornerDistanceRate
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1minCornerDistanceRate_10 (IntPtr nativeObj, double minCornerDistanceRate);

        // C++: int DetectorParameters::minDistanceToBorder
        [DllImport (LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1minDistanceToBorder_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::minDistanceToBorder
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1minDistanceToBorder_10 (IntPtr nativeObj, int minDistanceToBorder);

        // C++: double DetectorParameters::minMarkerDistanceRate
        [DllImport (LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1minMarkerDistanceRate_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::minMarkerDistanceRate
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1minMarkerDistanceRate_10 (IntPtr nativeObj, double minMarkerDistanceRate);

        // C++: int DetectorParameters::cornerRefinementMethod
        [DllImport (LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1cornerRefinementMethod_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::cornerRefinementMethod
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1cornerRefinementMethod_10 (IntPtr nativeObj, int cornerRefinementMethod);

        // C++: int DetectorParameters::cornerRefinementWinSize
        [DllImport (LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1cornerRefinementWinSize_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::cornerRefinementWinSize
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1cornerRefinementWinSize_10 (IntPtr nativeObj, int cornerRefinementWinSize);

        // C++: int DetectorParameters::cornerRefinementMaxIterations
        [DllImport (LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1cornerRefinementMaxIterations_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::cornerRefinementMaxIterations
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1cornerRefinementMaxIterations_10 (IntPtr nativeObj, int cornerRefinementMaxIterations);

        // C++: double DetectorParameters::cornerRefinementMinAccuracy
        [DllImport (LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1cornerRefinementMinAccuracy_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::cornerRefinementMinAccuracy
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1cornerRefinementMinAccuracy_10 (IntPtr nativeObj, double cornerRefinementMinAccuracy);

        // C++: int DetectorParameters::markerBorderBits
        [DllImport (LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1markerBorderBits_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::markerBorderBits
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1markerBorderBits_10 (IntPtr nativeObj, int markerBorderBits);

        // C++: int DetectorParameters::perspectiveRemovePixelPerCell
        [DllImport (LIBNAME)]
        private static extern int aruco_DetectorParameters_get_1perspectiveRemovePixelPerCell_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::perspectiveRemovePixelPerCell
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1perspectiveRemovePixelPerCell_10 (IntPtr nativeObj, int perspectiveRemovePixelPerCell);

        // C++: double DetectorParameters::perspectiveRemoveIgnoredMarginPerCell
        [DllImport (LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1perspectiveRemoveIgnoredMarginPerCell_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::perspectiveRemoveIgnoredMarginPerCell
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1perspectiveRemoveIgnoredMarginPerCell_10 (IntPtr nativeObj, double perspectiveRemoveIgnoredMarginPerCell);

        // C++: double DetectorParameters::maxErroneousBitsInBorderRate
        [DllImport (LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1maxErroneousBitsInBorderRate_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::maxErroneousBitsInBorderRate
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1maxErroneousBitsInBorderRate_10 (IntPtr nativeObj, double maxErroneousBitsInBorderRate);

        // C++: double DetectorParameters::minOtsuStdDev
        [DllImport (LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1minOtsuStdDev_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::minOtsuStdDev
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1minOtsuStdDev_10 (IntPtr nativeObj, double minOtsuStdDev);

        // C++: double DetectorParameters::errorCorrectionRate
        [DllImport (LIBNAME)]
        private static extern double aruco_DetectorParameters_get_1errorCorrectionRate_10 (IntPtr nativeObj);

        // C++: void DetectorParameters::errorCorrectionRate
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_set_1errorCorrectionRate_10 (IntPtr nativeObj, double errorCorrectionRate);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void aruco_DetectorParameters_delete (IntPtr nativeObj);

    }
}
