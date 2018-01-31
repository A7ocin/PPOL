#if !UNITY_WEBGL && !UNITY_WSA_10_0

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{

    // C++: class Importer
    //javadoc: Importer
    [Obsolete ("This method is deprecated.")]
    public class Importer : Algorithm
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        dnn_Importer_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal Importer (IntPtr addr)
            : base (addr)
        {
        }


        //
        // C++:  void populateNet(Net net)
        //

        //javadoc: Importer::populateNet(net)
        public void populateNet (Net net)
        {
            ThrowIfDisposed ();
            if (net != null)
                net.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            dnn_Importer_populateNet_10 (nativeObj, net.nativeObj);
        
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



        // C++:  void populateNet(Net net)
        [DllImport (LIBNAME)]
        private static extern void dnn_Importer_populateNet_10 (IntPtr nativeObj, IntPtr net_nativeObj);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void dnn_Importer_delete (IntPtr nativeObj);

    }
}
#endif
