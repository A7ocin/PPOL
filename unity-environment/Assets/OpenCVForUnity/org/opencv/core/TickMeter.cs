

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class TickMeter
    //javadoc: TickMeter

    public class TickMeter : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
try {
if (disposing) {
}
if (IsEnabledDispose) {
if (nativeObj != IntPtr.Zero)
core_TickMeter_delete(nativeObj);
nativeObj = IntPtr.Zero;
}
} finally {
base.Dispose (disposing);
}
#else
            return;
#endif
        }

        protected internal TickMeter (IntPtr addr) : base (addr) { }


        public IntPtr getNativeObjAddr () { return nativeObj; }

        //
        // C++:   TickMeter()
        //

        //javadoc: TickMeter::TickMeter()
        public TickMeter ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        nativeObj = core_TickMeter_TickMeter_10();
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:  double getTimeMicro()
        //

        //javadoc: TickMeter::getTimeMicro()
        public double getTimeMicro ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_TickMeter_getTimeMicro_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getTimeMilli()
        //

        //javadoc: TickMeter::getTimeMilli()
        public double getTimeMilli ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_TickMeter_getTimeMilli_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  double getTimeSec()
        //

        //javadoc: TickMeter::getTimeSec()
        public double getTimeSec ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        double retVal = core_TickMeter_getTimeSec_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int64 getCounter()
        //

        //javadoc: TickMeter::getCounter()
        public long getCounter ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        long retVal = core_TickMeter_getCounter_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int64 getTimeTicks()
        //

        //javadoc: TickMeter::getTimeTicks()
        public long getTimeTicks ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        long retVal = core_TickMeter_getTimeTicks_10(nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  void reset()
        //

        //javadoc: TickMeter::reset()
        public void reset ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_TickMeter_reset_10(nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void start()
        //

        //javadoc: TickMeter::start()
        public void start ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_TickMeter_start_10(nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void stop()
        //

        //javadoc: TickMeter::stop()
        public void stop ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
        core_TickMeter_stop_10(nativeObj);
        
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



        // C++:   TickMeter()
        [DllImport (LIBNAME)]
        private static extern IntPtr core_TickMeter_TickMeter_10 ();

        // C++:  double getTimeMicro()
        [DllImport (LIBNAME)]
        private static extern double core_TickMeter_getTimeMicro_10 (IntPtr nativeObj);

        // C++:  double getTimeMilli()
        [DllImport (LIBNAME)]
        private static extern double core_TickMeter_getTimeMilli_10 (IntPtr nativeObj);

        // C++:  double getTimeSec()
        [DllImport (LIBNAME)]
        private static extern double core_TickMeter_getTimeSec_10 (IntPtr nativeObj);

        // C++:  int64 getCounter()
        [DllImport (LIBNAME)]
        private static extern long core_TickMeter_getCounter_10 (IntPtr nativeObj);

        // C++:  int64 getTimeTicks()
        [DllImport (LIBNAME)]
        private static extern long core_TickMeter_getTimeTicks_10 (IntPtr nativeObj);

        // C++:  void reset()
        [DllImport (LIBNAME)]
        private static extern void core_TickMeter_reset_10 (IntPtr nativeObj);

        // C++:  void start()
        [DllImport (LIBNAME)]
        private static extern void core_TickMeter_start_10 (IntPtr nativeObj);

        // C++:  void stop()
        [DllImport (LIBNAME)]
        private static extern void core_TickMeter_stop_10 (IntPtr nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void core_TickMeter_delete (IntPtr nativeObj);

    }
}
