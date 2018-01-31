

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class Plot2d
    //javadoc: Plot2d

    public class Plot2d : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
plot_Plot2d_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal Plot2d (IntPtr addr) : base (addr) { }


        //
        // C++: static Ptr_Plot2d create(Mat data)
        //

        //javadoc: Plot2d::create(data)
        public static Plot2d create (Mat data)
        {
            if (data != null) data.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Plot2d retVal = new Plot2d(plot_Plot2d_create_10(data.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++: static Ptr_Plot2d create(Mat dataX, Mat dataY)
        //

        //javadoc: Plot2d::create(dataX, dataY)
        public static Plot2d create (Mat dataX, Mat dataY)
        {
            if (dataX != null) dataX.ThrowIfDisposed ();
            if (dataY != null) dataY.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        Plot2d retVal = new Plot2d(plot_Plot2d_create_11(dataX.nativeObj, dataY.nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void render(Mat& _plotResult)
        //

        //javadoc: Plot2d::render(_plotResult)
        public void render (Mat _plotResult)
        {
            ThrowIfDisposed ();
            if (_plotResult != null) _plotResult.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_render_10(nativeObj, _plotResult.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setGridLinesNumber(int gridLinesNumber)
        //

        //javadoc: Plot2d::setGridLinesNumber(gridLinesNumber)
        public void setGridLinesNumber (int gridLinesNumber)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setGridLinesNumber_10(nativeObj, gridLinesNumber);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setInvertOrientation(bool _invertOrientation)
        //

        //javadoc: Plot2d::setInvertOrientation(_invertOrientation)
        public void setInvertOrientation (bool _invertOrientation)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setInvertOrientation_10(nativeObj, _invertOrientation);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMaxX(double _plotMaxX)
        //

        //javadoc: Plot2d::setMaxX(_plotMaxX)
        public void setMaxX (double _plotMaxX)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setMaxX_10(nativeObj, _plotMaxX);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMaxY(double _plotMaxY)
        //

        //javadoc: Plot2d::setMaxY(_plotMaxY)
        public void setMaxY (double _plotMaxY)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setMaxY_10(nativeObj, _plotMaxY);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMinX(double _plotMinX)
        //

        //javadoc: Plot2d::setMinX(_plotMinX)
        public void setMinX (double _plotMinX)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setMinX_10(nativeObj, _plotMinX);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setMinY(double _plotMinY)
        //

        //javadoc: Plot2d::setMinY(_plotMinY)
        public void setMinY (double _plotMinY)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setMinY_10(nativeObj, _plotMinY);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setNeedPlotLine(bool _needPlotLine)
        //

        //javadoc: Plot2d::setNeedPlotLine(_needPlotLine)
        public void setNeedPlotLine (bool _needPlotLine)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setNeedPlotLine_10(nativeObj, _needPlotLine);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPlotAxisColor(Scalar _plotAxisColor)
        //

        //javadoc: Plot2d::setPlotAxisColor(_plotAxisColor)
        public void setPlotAxisColor (Scalar _plotAxisColor)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setPlotAxisColor_10(nativeObj, _plotAxisColor.val[0], _plotAxisColor.val[1], _plotAxisColor.val[2], _plotAxisColor.val[3]);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPlotBackgroundColor(Scalar _plotBackgroundColor)
        //

        //javadoc: Plot2d::setPlotBackgroundColor(_plotBackgroundColor)
        public void setPlotBackgroundColor (Scalar _plotBackgroundColor)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setPlotBackgroundColor_10(nativeObj, _plotBackgroundColor.val[0], _plotBackgroundColor.val[1], _plotBackgroundColor.val[2], _plotBackgroundColor.val[3]);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPlotGridColor(Scalar _plotGridColor)
        //

        //javadoc: Plot2d::setPlotGridColor(_plotGridColor)
        public void setPlotGridColor (Scalar _plotGridColor)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setPlotGridColor_10(nativeObj, _plotGridColor.val[0], _plotGridColor.val[1], _plotGridColor.val[2], _plotGridColor.val[3]);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPlotLineColor(Scalar _plotLineColor)
        //

        //javadoc: Plot2d::setPlotLineColor(_plotLineColor)
        public void setPlotLineColor (Scalar _plotLineColor)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setPlotLineColor_10(nativeObj, _plotLineColor.val[0], _plotLineColor.val[1], _plotLineColor.val[2], _plotLineColor.val[3]);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPlotLineWidth(int _plotLineWidth)
        //

        //javadoc: Plot2d::setPlotLineWidth(_plotLineWidth)
        public void setPlotLineWidth (int _plotLineWidth)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setPlotLineWidth_10(nativeObj, _plotLineWidth);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPlotSize(int _plotSizeWidth, int _plotSizeHeight)
        //

        //javadoc: Plot2d::setPlotSize(_plotSizeWidth, _plotSizeHeight)
        public void setPlotSize (int _plotSizeWidth, int _plotSizeHeight)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setPlotSize_10(nativeObj, _plotSizeWidth, _plotSizeHeight);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPlotTextColor(Scalar _plotTextColor)
        //

        //javadoc: Plot2d::setPlotTextColor(_plotTextColor)
        public void setPlotTextColor (Scalar _plotTextColor)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setPlotTextColor_10(nativeObj, _plotTextColor.val[0], _plotTextColor.val[1], _plotTextColor.val[2], _plotTextColor.val[3]);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPointIdxToPrint(int pointIdx)
        //

        //javadoc: Plot2d::setPointIdxToPrint(pointIdx)
        public void setPointIdxToPrint (int pointIdx)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setPointIdxToPrint_10(nativeObj, pointIdx);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setShowGrid(bool needShowGrid)
        //

        //javadoc: Plot2d::setShowGrid(needShowGrid)
        public void setShowGrid (bool needShowGrid)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setShowGrid_10(nativeObj, needShowGrid);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setShowText(bool needShowText)
        //

        //javadoc: Plot2d::setShowText(needShowText)
        public void setShowText (bool needShowText)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        plot_Plot2d_setShowText_10(nativeObj, needShowText);
        
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



        // C++: static Ptr_Plot2d create(Mat data)
        [DllImport (LIBNAME)]
        private static extern IntPtr plot_Plot2d_create_10 (IntPtr data_nativeObj);

        // C++: static Ptr_Plot2d create(Mat dataX, Mat dataY)
        [DllImport (LIBNAME)]
        private static extern IntPtr plot_Plot2d_create_11 (IntPtr dataX_nativeObj, IntPtr dataY_nativeObj);

        // C++:  void render(Mat& _plotResult)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_render_10 (IntPtr nativeObj, IntPtr _plotResult_nativeObj);

        // C++:  void setGridLinesNumber(int gridLinesNumber)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setGridLinesNumber_10 (IntPtr nativeObj, int gridLinesNumber);

        // C++:  void setInvertOrientation(bool _invertOrientation)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setInvertOrientation_10 (IntPtr nativeObj, bool _invertOrientation);

        // C++:  void setMaxX(double _plotMaxX)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setMaxX_10 (IntPtr nativeObj, double _plotMaxX);

        // C++:  void setMaxY(double _plotMaxY)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setMaxY_10 (IntPtr nativeObj, double _plotMaxY);

        // C++:  void setMinX(double _plotMinX)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setMinX_10 (IntPtr nativeObj, double _plotMinX);

        // C++:  void setMinY(double _plotMinY)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setMinY_10 (IntPtr nativeObj, double _plotMinY);

        // C++:  void setNeedPlotLine(bool _needPlotLine)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setNeedPlotLine_10 (IntPtr nativeObj, bool _needPlotLine);

        // C++:  void setPlotAxisColor(Scalar _plotAxisColor)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setPlotAxisColor_10 (IntPtr nativeObj, double _plotAxisColor_val0, double _plotAxisColor_val1, double _plotAxisColor_val2, double _plotAxisColor_val3);

        // C++:  void setPlotBackgroundColor(Scalar _plotBackgroundColor)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setPlotBackgroundColor_10 (IntPtr nativeObj, double _plotBackgroundColor_val0, double _plotBackgroundColor_val1, double _plotBackgroundColor_val2, double _plotBackgroundColor_val3);

        // C++:  void setPlotGridColor(Scalar _plotGridColor)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setPlotGridColor_10 (IntPtr nativeObj, double _plotGridColor_val0, double _plotGridColor_val1, double _plotGridColor_val2, double _plotGridColor_val3);

        // C++:  void setPlotLineColor(Scalar _plotLineColor)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setPlotLineColor_10 (IntPtr nativeObj, double _plotLineColor_val0, double _plotLineColor_val1, double _plotLineColor_val2, double _plotLineColor_val3);

        // C++:  void setPlotLineWidth(int _plotLineWidth)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setPlotLineWidth_10 (IntPtr nativeObj, int _plotLineWidth);

        // C++:  void setPlotSize(int _plotSizeWidth, int _plotSizeHeight)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setPlotSize_10 (IntPtr nativeObj, int _plotSizeWidth, int _plotSizeHeight);

        // C++:  void setPlotTextColor(Scalar _plotTextColor)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setPlotTextColor_10 (IntPtr nativeObj, double _plotTextColor_val0, double _plotTextColor_val1, double _plotTextColor_val2, double _plotTextColor_val3);

        // C++:  void setPointIdxToPrint(int pointIdx)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setPointIdxToPrint_10 (IntPtr nativeObj, int pointIdx);

        // C++:  void setShowGrid(bool needShowGrid)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setShowGrid_10 (IntPtr nativeObj, bool needShowGrid);

        // C++:  void setShowText(bool needShowText)
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_setShowText_10 (IntPtr nativeObj, bool needShowText);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void plot_Plot2d_delete (IntPtr nativeObj);

    }
}
