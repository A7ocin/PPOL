#if !UNITY_WEBGL && !UNITY_WSA_10_0

using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace OpenCVForUnity
{
    // C++: class Net
    //javadoc: Net

    public class Net : DisposableOpenCVObject
    {

        protected override void Dispose (bool disposing)
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            try {
                if (disposing) {
                }
                if (IsEnabledDispose) {
                    if (nativeObj != IntPtr.Zero)
                        dnn_Net_delete (nativeObj);
                    nativeObj = IntPtr.Zero;
                }
            } finally {
                base.Dispose (disposing);
            }
#else
            return;
#endif
        }

        protected internal Net (IntPtr addr)
            : base (addr)
        {
        }


        public IntPtr getNativeObjAddr ()
        {
            return nativeObj;
        }

        //
        // C++:   Net()
        //

        //javadoc: Net::Net()
        public Net ()
        {
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            nativeObj = dnn_Net_Net_10 ();
        
#else
            return null;
#endif
            return;
        }


        //
        // C++:  Mat forward(String outputName = String())
        //

        //javadoc: Net::forward(outputName)
        public Mat forward (string outputName)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Mat retVal = new Mat (dnn_Net_forward_10 (nativeObj, outputName));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: Net::forward()
        public Mat forward ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Mat retVal = new Mat (dnn_Net_forward_11 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Mat getParam(LayerId layer, int numParam = 0)
        //

        //javadoc: Net::getParam(layer, numParam)
        public Mat getParam (DictValue layer, int numParam)
        {
            ThrowIfDisposed ();
            if (layer != null)
                layer.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Mat retVal = new Mat (dnn_Net_getParam_10 (nativeObj, layer.getNativeObjAddr (), numParam));
        
#else
            return null;
#endif
            return retVal;
        }

        //javadoc: Net::getParam(layer)
        public Mat getParam (DictValue layer)
        {
            ThrowIfDisposed ();
            if (layer != null)
                layer.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Mat retVal = new Mat (dnn_Net_getParam_11 (nativeObj, layer.getNativeObjAddr ()));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  Ptr_Layer getLayer(LayerId layerId)
        //

        //javadoc: Net::getLayer(layerId)
        public Layer getLayer (DictValue layerId)
        {
            ThrowIfDisposed ();
            if (layerId != null)
                layerId.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            Layer retVal = new Layer (dnn_Net_getLayer_10 (nativeObj, layerId.getNativeObjAddr ()));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  bool empty()
        //

        //javadoc: Net::empty()
        public bool empty ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            bool retVal = dnn_Net_empty_10 (nativeObj);
        
#else
            return false;
#endif
            return retVal;
        }


        //
        // C++:  int getLayerId(String layer)
        //

        //javadoc: Net::getLayerId(layer)
        public int getLayerId (string layer)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = dnn_Net_getLayerId_10 (nativeObj, layer);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int getLayersCount(String layerType)
        //

        //javadoc: Net::getLayersCount(layerType)
        public int getLayersCount (string layerType)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            int retVal = dnn_Net_getLayersCount_10 (nativeObj, layerType);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int64 getFLOPS(MatShape netInputShape)
        //

        //javadoc: Net::getFLOPS(netInputShape)
        public long getFLOPS (MatOfInt netInputShape)
        {
            ThrowIfDisposed ();
            if (netInputShape != null)
                netInputShape.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat netInputShape_mat = netInputShape;
            long retVal = dnn_Net_getFLOPS_10 (nativeObj, netInputShape_mat.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int64 getFLOPS(int layerId, MatShape netInputShape)
        //

        //javadoc: Net::getFLOPS(layerId, netInputShape)
        public long getFLOPS (int layerId, MatOfInt netInputShape)
        {
            ThrowIfDisposed ();
            if (netInputShape != null)
                netInputShape.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat netInputShape_mat = netInputShape;
            long retVal = dnn_Net_getFLOPS_11 (nativeObj, layerId, netInputShape_mat.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int64 getFLOPS(int layerId, vector_MatShape netInputShapes)
        //

        //javadoc: Net::getFLOPS(layerId, netInputShapes)
        public long getFLOPS (int layerId, List<MatOfInt> netInputShapes)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat netInputShapes_mat = Converters.vector_MatShape_to_Mat (netInputShapes);
            long retVal = dnn_Net_getFLOPS_12 (nativeObj, layerId, netInputShapes_mat.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int64 getFLOPS(vector_MatShape netInputShapes)
        //

        //javadoc: Net::getFLOPS(netInputShapes)
        public long getFLOPS (List<MatOfInt> netInputShapes)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat netInputShapes_mat = Converters.vector_MatShape_to_Mat (netInputShapes);
            long retVal = dnn_Net_getFLOPS_13 (nativeObj, netInputShapes_mat.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  int64 getPerfProfile(vector_double& timings)
        //

        //javadoc: Net::getPerfProfile(timings)
        public long getPerfProfile (MatOfDouble timings)
        {
            ThrowIfDisposed ();
            if (timings != null)
                timings.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat timings_mat = timings;
            long retVal = dnn_Net_getPerfProfile_10 (nativeObj, timings_mat.nativeObj);
        
#else
            return -1;
#endif
            return retVal;
        }


        //
        // C++:  vector_String getLayerNames()
        //

        //javadoc: Net::getLayerNames()
        public List<string> getLayerNames ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            List<string> retVal = new List<string> ();
            Mat retValMat = new Mat (dnn_Net_getLayerNames_10 (nativeObj));
            Converters.Mat_to_vector_String (retValMat, retVal);
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  vector_int getUnconnectedOutLayers()
        //

        //javadoc: Net::getUnconnectedOutLayers()
        public MatOfInt getUnconnectedOutLayers ()
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            MatOfInt retVal = MatOfInt.fromNativeAddr (dnn_Net_getUnconnectedOutLayers_10 (nativeObj));
        
#else
            return null;
#endif
            return retVal;
        }


        //
        // C++:  void connect(String outPin, String inpPin)
        //

        //javadoc: Net::connect(outPin, inpPin)
        public void connect (string outPin, string inpPin)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            dnn_Net_connect_10 (nativeObj, outPin, inpPin);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void deleteLayer(LayerId layer)
        //

        //javadoc: Net::deleteLayer(layer)
        public void deleteLayer (DictValue layer)
        {
            ThrowIfDisposed ();
            if (layer != null)
                layer.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            dnn_Net_deleteLayer_10 (nativeObj, layer.getNativeObjAddr ());
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void enableFusion(bool fusion)
        //

        //javadoc: Net::enableFusion(fusion)
        public void enableFusion (bool fusion)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            dnn_Net_enableFusion_10 (nativeObj, fusion);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void forward(vector_Mat& outputBlobs, String outputName = String())
        //

        //javadoc: Net::forward(outputBlobs, outputName)
        public void forward (List<Mat> outputBlobs, string outputName)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat outputBlobs_mat = new Mat ();
            dnn_Net_forward_12 (nativeObj, outputBlobs_mat.nativeObj, outputName);
            Converters.Mat_to_vector_Mat (outputBlobs_mat, outputBlobs);
            outputBlobs_mat.release ();
#else
            return;
#endif
            return;
        }

        //javadoc: Net::forward(outputBlobs)
        public void forward (List<Mat> outputBlobs)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat outputBlobs_mat = new Mat ();
            dnn_Net_forward_13 (nativeObj, outputBlobs_mat.nativeObj);
            Converters.Mat_to_vector_Mat (outputBlobs_mat, outputBlobs);
            outputBlobs_mat.release ();
#else
            return;
#endif
            return;
        }


        //
        // C++:  void forward(vector_Mat& outputBlobs, vector_String outBlobNames)
        //

        //javadoc: Net::forward(outputBlobs, outBlobNames)
        public void forward (List<Mat> outputBlobs, List<string> outBlobNames)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat outputBlobs_mat = new Mat ();
            Mat outBlobNames_mat = Converters.vector_String_to_Mat (outBlobNames);
            dnn_Net_forward_14 (nativeObj, outputBlobs_mat.nativeObj, outBlobNames_mat.nativeObj);
            Converters.Mat_to_vector_Mat (outputBlobs_mat, outputBlobs);
            outputBlobs_mat.release ();
#else
            return;
#endif
            return;
        }


        //
        // C++:  void forward(vector_vector_Mat outputBlobs, vector_String outBlobNames)
        //

        // Unknown type 'vector_vector_Mat' (I), skipping the function


        //
        // C++:  void getLayerTypes(vector_String& layersTypes)
        //

        //javadoc: Net::getLayerTypes(layersTypes)
        public void getLayerTypes (List<string> layersTypes)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat layersTypes_mat = new Mat ();
            dnn_Net_getLayerTypes_10 (nativeObj, layersTypes_mat.nativeObj);
            Converters.Mat_to_vector_String (layersTypes_mat, layersTypes);
            layersTypes_mat.release ();
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getLayersShapes(MatShape netInputShape, vector_int& layersIds, vector_vector_MatShape& inLayersShapes, vector_vector_MatShape& outLayersShapes)
        //

        // Unknown type 'vector_vector_MatShape' (O), skipping the function


        //
        // C++:  void getLayersShapes(vector_MatShape netInputShapes, vector_int& layersIds, vector_vector_MatShape& inLayersShapes, vector_vector_MatShape& outLayersShapes)
        //

        // Unknown type 'vector_vector_MatShape' (O), skipping the function


        //
        // C++:  void getMemoryConsumption(MatShape netInputShape, size_t& weights, size_t& blobs)
        //

        //javadoc: Net::getMemoryConsumption(netInputShape, weights, blobs)
        public void getMemoryConsumption (MatOfInt netInputShape, long[] weights, long[] blobs)
        {
            ThrowIfDisposed ();
            if (netInputShape != null)
                netInputShape.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat netInputShape_mat = netInputShape;
            double[] weights_out = new double[1];
            double[] blobs_out = new double[1];
            dnn_Net_getMemoryConsumption_10 (nativeObj, netInputShape_mat.nativeObj, weights_out, blobs_out);
            if (weights != null)
                weights [0] = (long)weights_out [0];
            if (blobs != null)
                blobs [0] = (long)blobs_out [0];
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getMemoryConsumption(int layerId, MatShape netInputShape, size_t& weights, size_t& blobs)
        //

        //javadoc: Net::getMemoryConsumption(layerId, netInputShape, weights, blobs)
        public void getMemoryConsumption (int layerId, MatOfInt netInputShape, long[] weights, long[] blobs)
        {
            ThrowIfDisposed ();
            if (netInputShape != null)
                netInputShape.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat netInputShape_mat = netInputShape;
            double[] weights_out = new double[1];
            double[] blobs_out = new double[1];
            dnn_Net_getMemoryConsumption_11 (nativeObj, layerId, netInputShape_mat.nativeObj, weights_out, blobs_out);
            if (weights != null)
                weights [0] = (long)weights_out [0];
            if (blobs != null)
                blobs [0] = (long)blobs_out [0];
#else
            return;
#endif
            return;
        }


        //
        // C++:  void getMemoryConsumption(int layerId, vector_MatShape netInputShapes, size_t& weights, size_t& blobs)
        //

        //javadoc: Net::getMemoryConsumption(layerId, netInputShapes, weights, blobs)
        public void getMemoryConsumption (int layerId, List<MatOfInt> netInputShapes, long[] weights, long[] blobs)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat netInputShapes_mat = Converters.vector_MatShape_to_Mat (netInputShapes);
            double[] weights_out = new double[1];
            double[] blobs_out = new double[1];
            dnn_Net_getMemoryConsumption_12 (nativeObj, layerId, netInputShapes_mat.nativeObj, weights_out, blobs_out);
            if (weights != null)
                weights [0] = (long)weights_out [0];
            if (blobs != null)
                blobs [0] = (long)blobs_out [0];
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setHalideScheduler(String scheduler)
        //

        //javadoc: Net::setHalideScheduler(scheduler)
        public void setHalideScheduler (string scheduler)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            dnn_Net_setHalideScheduler_10 (nativeObj, scheduler);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setInput(Mat blob, String name = "")
        //

        //javadoc: Net::setInput(blob, name)
        public void setInput (Mat blob, string name)
        {
            ThrowIfDisposed ();
            if (blob != null)
                blob.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            dnn_Net_setInput_10 (nativeObj, blob.nativeObj, name);
        
#else
            return;
#endif
            return;
        }

        //javadoc: Net::setInput(blob)
        public void setInput (Mat blob)
        {
            ThrowIfDisposed ();
            if (blob != null)
                blob.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            dnn_Net_setInput_11 (nativeObj, blob.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setInputsNames(vector_String inputBlobNames)
        //

        //javadoc: Net::setInputsNames(inputBlobNames)
        public void setInputsNames (List<string> inputBlobNames)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            Mat inputBlobNames_mat = Converters.vector_String_to_Mat (inputBlobNames);
            dnn_Net_setInputsNames_10 (nativeObj, inputBlobNames_mat.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setParam(LayerId layer, int numParam, Mat blob)
        //

        //javadoc: Net::setParam(layer, numParam, blob)
        public void setParam (DictValue layer, int numParam, Mat blob)
        {
            ThrowIfDisposed ();
            if (layer != null)
                layer.ThrowIfDisposed ();
            if (blob != null)
                blob.ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            dnn_Net_setParam_10 (nativeObj, layer.getNativeObjAddr (), numParam, blob.nativeObj);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPreferableBackend(int backendId)
        //

        //javadoc: Net::setPreferableBackend(backendId)
        public void setPreferableBackend (int backendId)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            dnn_Net_setPreferableBackend_10 (nativeObj, backendId);
        
#else
            return;
#endif
            return;
        }


        //
        // C++:  void setPreferableTarget(int targetId)
        //

        //javadoc: Net::setPreferableTarget(targetId)
        public void setPreferableTarget (int targetId)
        {
            ThrowIfDisposed ();
#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
        
            dnn_Net_setPreferableTarget_10 (nativeObj, targetId);
        
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



        // C++:   Net()
        [DllImport (LIBNAME)]
        private static extern IntPtr dnn_Net_Net_10 ();

        // C++:  Mat forward(String outputName = String())
        [DllImport (LIBNAME)]
        private static extern IntPtr dnn_Net_forward_10 (IntPtr nativeObj, string outputName);

        [DllImport (LIBNAME)]
        private static extern IntPtr dnn_Net_forward_11 (IntPtr nativeObj);

        // C++:  Mat getParam(LayerId layer, int numParam = 0)
        [DllImport (LIBNAME)]
        private static extern IntPtr dnn_Net_getParam_10 (IntPtr nativeObj, IntPtr layer_nativeObj, int numParam);

        [DllImport (LIBNAME)]
        private static extern IntPtr dnn_Net_getParam_11 (IntPtr nativeObj, IntPtr layer_nativeObj);

        // C++:  Ptr_Layer getLayer(LayerId layerId)
        [DllImport (LIBNAME)]
        private static extern IntPtr dnn_Net_getLayer_10 (IntPtr nativeObj, IntPtr layerId_nativeObj);

        // C++:  bool empty()
        [DllImport (LIBNAME)]
        private static extern bool dnn_Net_empty_10 (IntPtr nativeObj);

        // C++:  int getLayerId(String layer)
        [DllImport (LIBNAME)]
        private static extern int dnn_Net_getLayerId_10 (IntPtr nativeObj, string layer);

        // C++:  int getLayersCount(String layerType)
        [DllImport (LIBNAME)]
        private static extern int dnn_Net_getLayersCount_10 (IntPtr nativeObj, string layerType);

        // C++:  int64 getFLOPS(MatShape netInputShape)
        [DllImport (LIBNAME)]
        private static extern long dnn_Net_getFLOPS_10 (IntPtr nativeObj, IntPtr netInputShape_mat_nativeObj);

        // C++:  int64 getFLOPS(int layerId, MatShape netInputShape)
        [DllImport (LIBNAME)]
        private static extern long dnn_Net_getFLOPS_11 (IntPtr nativeObj, int layerId, IntPtr netInputShape_mat_nativeObj);

        // C++:  int64 getFLOPS(int layerId, vector_MatShape netInputShapes)
        [DllImport (LIBNAME)]
        private static extern long dnn_Net_getFLOPS_12 (IntPtr nativeObj, int layerId, IntPtr netInputShapes_mat_nativeObj);

        // C++:  int64 getFLOPS(vector_MatShape netInputShapes)
        [DllImport (LIBNAME)]
        private static extern long dnn_Net_getFLOPS_13 (IntPtr nativeObj, IntPtr netInputShapes_mat_nativeObj);

        // C++:  int64 getPerfProfile(vector_double& timings)
        [DllImport (LIBNAME)]
        private static extern long dnn_Net_getPerfProfile_10 (IntPtr nativeObj, IntPtr timings_mat_nativeObj);

        // C++:  vector_String getLayerNames()
        [DllImport (LIBNAME)]
        private static extern IntPtr dnn_Net_getLayerNames_10 (IntPtr nativeObj);

        // C++:  vector_int getUnconnectedOutLayers()
        [DllImport (LIBNAME)]
        private static extern IntPtr dnn_Net_getUnconnectedOutLayers_10 (IntPtr nativeObj);

        // C++:  void connect(String outPin, String inpPin)
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_connect_10 (IntPtr nativeObj, string outPin, string inpPin);

        // C++:  void deleteLayer(LayerId layer)
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_deleteLayer_10 (IntPtr nativeObj, IntPtr layer_nativeObj);

        // C++:  void enableFusion(bool fusion)
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_enableFusion_10 (IntPtr nativeObj, bool fusion);

        // C++:  void forward(vector_Mat& outputBlobs, String outputName = String())
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_forward_12 (IntPtr nativeObj, IntPtr outputBlobs_mat_nativeObj, string outputName);

        [DllImport (LIBNAME)]
        private static extern void dnn_Net_forward_13 (IntPtr nativeObj, IntPtr outputBlobs_mat_nativeObj);

        // C++:  void forward(vector_Mat& outputBlobs, vector_String outBlobNames)
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_forward_14 (IntPtr nativeObj, IntPtr outputBlobs_mat_nativeObj, IntPtr outBlobNames_mat_nativeObj);

        // C++:  void getLayerTypes(vector_String& layersTypes)
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_getLayerTypes_10 (IntPtr nativeObj, IntPtr layersTypes_mat_nativeObj);

        // C++:  void getMemoryConsumption(MatShape netInputShape, size_t& weights, size_t& blobs)
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_getMemoryConsumption_10 (IntPtr nativeObj, IntPtr netInputShape_mat_nativeObj, double[] weights_out, double[] blobs_out);

        // C++:  void getMemoryConsumption(int layerId, MatShape netInputShape, size_t& weights, size_t& blobs)
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_getMemoryConsumption_11 (IntPtr nativeObj, int layerId, IntPtr netInputShape_mat_nativeObj, double[] weights_out, double[] blobs_out);

        // C++:  void getMemoryConsumption(int layerId, vector_MatShape netInputShapes, size_t& weights, size_t& blobs)
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_getMemoryConsumption_12 (IntPtr nativeObj, int layerId, IntPtr netInputShapes_mat_nativeObj, double[] weights_out, double[] blobs_out);

        // C++:  void setHalideScheduler(String scheduler)
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_setHalideScheduler_10 (IntPtr nativeObj, string scheduler);

        // C++:  void setInput(Mat blob, String name = "")
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_setInput_10 (IntPtr nativeObj, IntPtr blob_nativeObj, string name);

        [DllImport (LIBNAME)]
        private static extern void dnn_Net_setInput_11 (IntPtr nativeObj, IntPtr blob_nativeObj);

        // C++:  void setInputsNames(vector_String inputBlobNames)
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_setInputsNames_10 (IntPtr nativeObj, IntPtr inputBlobNames_mat_nativeObj);

        // C++:  void setParam(LayerId layer, int numParam, Mat blob)
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_setParam_10 (IntPtr nativeObj, IntPtr layer_nativeObj, int numParam, IntPtr blob_nativeObj);

        // C++:  void setPreferableBackend(int backendId)
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_setPreferableBackend_10 (IntPtr nativeObj, int backendId);

        // C++:  void setPreferableTarget(int targetId)
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_setPreferableTarget_10 (IntPtr nativeObj, int targetId);

        // native support for java finalize()
        [DllImport (LIBNAME)]
        private static extern void dnn_Net_delete (IntPtr nativeObj);

    }
}
#endif