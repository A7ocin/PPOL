using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.IO;

namespace OpenCVForUnity
{
    public static class Utils
    {
        /**
        * Returns this "OpenCV for Unity" version number.
        * 
        * @return this "OpenCV for Unity" version number
        */
        public static string getVersion ()
        {
            return "2.2.5";
        }

        /**
        * Copies an OpenCV Mat data to a pixel data IntPtr.
        * <p>
        * <br>This function copies the OpenCV Mat data to the pixel data IntPtr.
        * <br>The pixel data has to be of the same byte size as the Mat data ([total() * elemSize()] byte).
        * <br>Because this function doesn't check bounds, is faster than Mat.get().
        *
        * @param mat a Mat object
        * @param intPtr the pixel data has to be of the same byte size as the Mat data ([total() * elemSize()] byte)
        */
        public static void copyFromMat (Mat mat, IntPtr intPtr)
        {
            if (mat != null)
                mat.ThrowIfDisposed ();

            if (mat == null)
                throw new ArgumentNullException ("mat == null");
            if (intPtr == IntPtr.Zero)
                throw new ArgumentNullException ("intPtr == IntPtr.Zero");

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            OpenCVForUnity_MatDataToByteArray (mat.nativeObj, intPtr);
#else
            return;
#endif
        }

        /**
        * Copies a pixel data IntPtr to an OpenCV Mat data.
        * <p>
        * <br>This function copy the pixel data IntPtr to the OpenCV Mat data.
        * <br>The Mat object has to be of the same byte size as the pixel data ([total() * elemSize()] byte).
        * <br>Because this function doesn't check bounds, is faster than Mat.put().
        * 
        * @param intPtr a pixel data IntPtr
        * @param mat the Mat object has to be of the same byte size as the pixel data ([total() * elemSize()] byte)
        */
        public static void copyToMat (IntPtr intPtr, Mat mat)
        {
            if (mat != null)
                mat.ThrowIfDisposed ();

            if (intPtr == IntPtr.Zero)
                throw new ArgumentNullException ("intPtr == IntPtr.Zero");
            if (mat == null)
                throw new ArgumentNullException ("mat == null");


#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            OpenCVForUnity_ByteArrayToMatData (intPtr, mat.nativeObj);
#else
            return;
#endif
        }

        /**
        * Copies an OpenCV Mat data to a pixel data Array.
        * <p>
        * <br>This function copies the OpenCV Mat data to the pixel data Array.
        * <br>The pixel data Array has to be of the same byte size as the Mat data ([total() * elemSize()] byte).
        * <br>Because this function doesn't check bounds, is faster than Mat.get().
        *
        * @param mat a Mat object
        * @param array the pixel data Array has to be of the same byte size as the Mat data ([total() * elemSize()] byte)
        */
        public static void copyFromMat<T> (Mat mat, IList<T> array)
        {
            if (mat != null)
                mat.ThrowIfDisposed ();

            if (mat == null)
                throw new ArgumentNullException ("mat == null");
            if (array == null)
                throw new ArgumentNullException ("array == null");

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            GCHandle arrayHandle = GCHandle.Alloc (array, GCHandleType.Pinned);

            OpenCVForUnity_MatDataToByteArray (mat.nativeObj, arrayHandle.AddrOfPinnedObject ());

            arrayHandle.Free ();
#else
            return;
#endif
        }

        /**
        * Copies a pixel data Array to an OpenCV Mat data.
        * <p>
        * <br>This function copies the pixel data Array to the OpenCV Mat data.
        * <br>The Mat object has to be of the same byte size as the pixel data Array ([total() * elemSize()] byte).
        * <br>Because this function doesn't check bounds, is faster than Mat.put().
        * 
        * @param array a pixel data Array
        * @param mat the Mat object has to be of the same byte size as the pixel data Array ([total() * elemSize()] byte)
        */
        public static void copyToMat<T> (IList<T> array, Mat mat)
        {
            if (mat != null)
                mat.ThrowIfDisposed ();

            if (array == null)
                throw new ArgumentNullException ("array == null");
            if (mat == null)
                throw new ArgumentNullException ("mat == null");

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            GCHandle arrayHandle = GCHandle.Alloc (array, GCHandleType.Pinned);
            
            OpenCVForUnity_ByteArrayToMatData (arrayHandle.AddrOfPinnedObject (), mat.nativeObj);

            arrayHandle.Free ();
#else
            return;
#endif
        }

        /**
        * Copies a Texture pixel data to a pixel data IntPtr using low-level native plugin interface.
        * <p>
        * <br>This function copies the Texture pixel data to the pixel data IntPtr.
        * <br>The pixel data has to be of the same byte size as the Texture pixel data ([width * height * bytePerPixel] byte).
        * <br>This function doesn't check bounds.
        * <br>This function not implemented yet on OpenGLCore, Direct3D12.
        *
        * @param texture a Texture object
        * @param intPtr the pixel data has to be of the same byte size as the Texture pixel data ([width * height * bytePerPixel] byte)
        * @param bytesPerPixel the bytes per pixel
        */
        [Obsolete ("Please use Utils.textureToTexture2D() and Texture2D.GetRawTextureData() method instead.")]
        public static void copyFromTexture (Texture texture, IntPtr intPtr, int bytesPerPixel)
        {
            if (texture == null)
                throw new ArgumentNullException ("texture == null");
            if (intPtr == IntPtr.Zero)
                throw new ArgumentNullException ("intPtr == IntPtr.Zero");

#if (UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER) && !(UNITY_WEBGL && !UNITY_EDITOR)
            OpenCVForUnity_TextureDataToByteArray (texture.GetNativeTexturePtr (), texture.width, texture.height, intPtr, bytesPerPixel);
#else
            return;
#endif
        }

        /**
        * Copies a pixel data IntPtr to a Texture pixel data using low-level native plugin interface.
        * <p>
        * <br>This function copies the pixel data IntPtr to the Texture pixel data.
        * <br>The Texture pixel data has to be of the same byte size as the pixel data ([width * height * bytePerPixel] byte).
        * <br>This function doesn't check bounds.
        * <br>This function not implemented yet on OpenGLCore, Direct3D12.
        * 
        * @param intPtr a pixel data IntPtr
        * @param mat the Texture pixel data has to be of the same byte size as the Pixel data ([width * height * bytePerPixel] byte)
        * @param bytesPerPixel the bytes per pixel
        */
        [Obsolete ("Please use Texture2D.LoadRawTextureData() and Graphics.CopyTexture() method instead.")]
        public static void copyToTexture (IntPtr intPtr, Texture texture, int bytesPerPixel)
        {
            if (intPtr == IntPtr.Zero)
                throw new ArgumentNullException ("intPtr == IntPtr.Zero");
            if (texture == null)
                throw new ArgumentNullException ("texture == null");

#if (UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER) && !(UNITY_WEBGL && !UNITY_EDITOR)
            OpenCVForUnity_ByteArrayToTextureData (intPtr, texture.GetNativeTexturePtr (), texture.width, texture.height, bytesPerPixel);
#else
            return;
#endif
        }

        /**
        * Copies a Texture pixel data to a pixel data Array using low-level native plugin interface.
        * <p>
        * <br>This function copies the Texture pixel data to the pixel data Array.
        * <br>The pixel data Array has to be of the same byte size as the Texture pixel data ([width * height * bytePerPixel] byte).
        * <br>This function doesn't check bounds.
        * <br>This function not implemented yet on OpenGLCore, Direct3D12.
        *
        * @param texture a Texture object
        * @param array the pixel data Array has to be of the same byte size as the Texture pixel data ([width * height * bytePerPixel] byte)
        * @param bytesPerPixel the bytes per pixel
        */
        [Obsolete ("Please use Utils.textureToTexture2D() and Texture2D.GetRawTextureData() method instead.")]
        public static void copyFromTexture<T> (Texture texture, IList<T> array, int bytesPerPixel)
        {
            if (texture == null)
                throw new ArgumentNullException ("texture == null");
            if (array == null)
                throw new ArgumentNullException ("array == null");

#if (UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER) && !(UNITY_WEBGL && !UNITY_EDITOR)
            GCHandle arrayHandle = GCHandle.Alloc (array, GCHandleType.Pinned);

            OpenCVForUnity_TextureDataToByteArray (texture.GetNativeTexturePtr (), texture.width, texture.height, arrayHandle.AddrOfPinnedObject (), bytesPerPixel);
            
            arrayHandle.Free ();
#else
            return;
#endif
        }

        /**
        * Copies a pixel data Array to a Texture pixel data using low-level native plugin interface.
        * <p>
        * <br>This function copies the pixel data Array to the Texture pixel data.
        * <br>The Texture pixel data has to be of the same byte size as the pixel data Array ([width * height * bytePerPixel] byte).
        * <br>This function doesn't check bounds.
        * <br>This function not implemented yet on OpenGLCore, Direct3D12.
        * 
        * @param array a pixel data Array
        * @param mat the Texture pixel data has to be of the same byte size as the pixel data Array ([width * height * bytePerPixel] byte)
        * @param bytesPerPixel the bytes per pixel
        */
        [Obsolete ("Please use Texture2D.LoadRawTextureData() and Graphics.CopyTexture() method instead.")]
        public static void copyToTexture<T> (IList<T> array, Texture texture, int bytesPerPixel)
        {
            if (array == null)
                throw new ArgumentNullException ("array == null");
            if (texture == null)
                throw new ArgumentNullException ("texture == null");

#if (UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER) && !(UNITY_WEBGL && !UNITY_EDITOR)
            GCHandle arrayHandle = GCHandle.Alloc (array, GCHandleType.Pinned);

            OpenCVForUnity_ByteArrayToTextureData (arrayHandle.AddrOfPinnedObject (), texture.GetNativeTexturePtr (), texture.width, texture.height, bytesPerPixel);
            
            arrayHandle.Free ();
#else
            return;
#endif
        }

        /**
        * Converts OpenCV Mat to Unity Texture2D.
        * <p>
        * <br>This function converts the OpenCV Mat to the Unity Texture2D image.
        * <br>The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * <br>The Texture2D object has to be of the TextureFormat 'RGBA32' or 'ARGB32'.(SetPixels32() must function.)
        * <br>The Texture2D object has to be of the same size as the Mat'(width * height).
        *
        * @param mat the Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY)
        * @param texture2D the Texture2D object has to be of the TextureFormat 'RGBA32' or 'ARGB32'.(SetPixels32() must function.) The Texture2D object has to be of the same size as the Mat (width * height).
        */
        public static void matToTexture2D (Mat mat, Texture2D texture2D)
        {
            matToTexture2D (mat, texture2D, null);
        }

        /**
        * Converts OpenCV Mat to Unity Texture2D.
        * <p>
        * <br>This function converts the OpenCV Mat to the Unity Texture2D image.
        * <br>The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * <br>The Texture2D object has to be of the TextureFormat 'RGBA32' or 'ARGB32'.(SetPixels32() must function.)
        * <br>The Texture2D object has to be of the same size as the Mat'(width * height).
        *
        * @param mat the Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY)
        * @param texture2D the Texture2D object has to be of the TextureFormat 'RGBA32' or 'ARGB32'.(SetPixels32() must function) The Texture2D object has to be of the same size as the Mat (width * height).
        * @param bufferColors the optional array to receive pixel data. 
        * You can optionally pass in an array of Color32s to use in colors to avoid allocating new memory each frame.
        * The array needs to be initialized to a length matching width * height of the texture.(<a href="http://docs.unity3d.com/ScriptReference/WebCamTexture.GetPixels32.html">http://docs.unity3d.com/ScriptReference/WebCamTexture.GetPixels32.html</a>)
        */
        public static void matToTexture2D (Mat mat, Texture2D texture2D, Color32[] bufferColors)
        {
            if (mat != null)
                mat.ThrowIfDisposed ();

            if (mat == null)
                throw new ArgumentNullException ("mat");
            if (texture2D == null)
                throw new ArgumentNullException ("texture2D");

            if (mat.cols () != texture2D.width || mat.rows () != texture2D.height)
                throw new ArgumentException ("The Texture2D object has to be of the same size");



            //                      Core.flip (mat, mat, 0);
            //
            //                      byte[] data = new byte[mat.cols () * mat.rows () * mat.channels ()];
            //                      mat.get (0, 0, data);
            //
            //                      Core.flip (mat, mat, 0);
            //
            //                      if (texture2D.format == TextureFormat.ARGB32 || texture2D.format == TextureFormat.BGRA32 || texture2D.format == TextureFormat.RGBA32) {
            //
            //                              Color32[] colors = new Color32[mat.cols () * mat.rows ()];
            //                              
            //                                      
            //
            //                              if (mat.type () == CvType.CV_8UC1) {
            //                                      for (int i = 0; i < colors.Length; i++) {
            //                                              colors [i] = new Color32 (data [i], data [i], data [i], 255);
            //                                      }
            //                              } else if (mat.type () == CvType.CV_8UC3) {
            //                                      for (int i = 0; i < colors.Length; i++) {
            //                                              colors [i] = new Color32 (data [(i * 3) + 0], data [(i * 3) + 1], data [(i * 3) + 2], 255);
            //                                      }
            //                              } else if (mat.type () == CvType.CV_8UC4) {
            //                                      for (int i = 0; i < colors.Length; i++) {
            //                                              colors [i] = new Color32 (data [(i * 4) + 0], data [(i * 4) + 1], data [(i * 4) + 2], data [(i * 4) + 3]);
            //                                      }
            //                              }
            //                                      
            //                              
            //                              texture2D.SetPixels32 (colors);
            //                              
            //                      } else {
            //                              Color[] colors = new Color[mat.cols () * mat.rows ()];
            //                              
            //                              if (mat.type () == CvType.CV_8UC1) {
            //                                      for (int i = 0; i < colors.Length; i++) {
            //                                              colors [i] = new Color ((float)data [i] / 255.0f, data [i] / 255.0f, data [i] / 255.0f);
            //                                      }
            //                              } else if (mat.type () == CvType.CV_8UC3) {
            //                                      for (int i = 0; i < colors.Length; i++) {
            //                                              colors [i] = new Color ((float)data [(i * 3) + 0] / 255.0f, (float)data [(i * 3) + 1] / 255.0f, (float)data [(i * 3) + 2] / 255.0f);
            //                                      }
            //                              } else if (mat.type () == CvType.CV_8UC4) {
            //                                      for (int i = 0; i < colors.Length; i++) {
            //                                              colors [i] = new Color ((float)data [(i * 4) + 0] / 255.0f, (float)data [(i * 4) + 1] / 255.0f, (float)data [(i * 4) + 2] / 255.0f);
            //                                      }
            //                              }
            //                  
            //                              
            //                              texture2D.SetPixels (colors);
            //
            //                      }
            //
            //                      texture2D.Apply ();

            //                      #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            //          if(mat.type () == CvType.CV_8UC4){
            //              OpenCVForUnity_LowLevelMatToTexture (mat.nativeObj, texture2D.GetNativeTexturePtr(), texture2D.width, texture2D.height);
            //
            //          return;
            //          }
            //          
            //                      #endif



#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER

            #if UNITY_5_3_OR_NEWER
            int type = mat.type ();

            if (mat.isContinuous () && (texture2D.format == TextureFormat.RGBA32 && type == CvType.CV_8UC4) || (texture2D.format == TextureFormat.RGB24 && type == CvType.CV_8UC3) || (texture2D.format == TextureFormat.Alpha8 && type == CvType.CV_8UC1)) {

                Core.flip (mat, mat, 0);
                texture2D.LoadRawTextureData ((IntPtr)mat.dataAddr (), mat.width () * mat.height () * (int)mat.elemSize ());
                texture2D.Apply ();
                Core.flip (mat, mat, 0);

                return;
            }
            #endif

            GCHandle colorsHandle;

            if (bufferColors == null) {
                Color32[] colors = texture2D.GetPixels32 ();
                
                colorsHandle = GCHandle.Alloc (colors, GCHandleType.Pinned);

                OpenCVForUnity_MatToTexture (mat.nativeObj, colorsHandle.AddrOfPinnedObject ());
                
                texture2D.SetPixels32 (colors);
            } else {
                colorsHandle = GCHandle.Alloc (bufferColors, GCHandleType.Pinned);

                OpenCVForUnity_MatToTexture (mat.nativeObj, colorsHandle.AddrOfPinnedObject ());
                
                texture2D.SetPixels32 (bufferColors);
            }


            texture2D.Apply ();
            
            colorsHandle.Free ();

#else
            return;
#endif
        }

        /**
        * Fast converts OpenCV Mat to Unity Texture2D.(Unity5.3+)
        * <p>
        * <br>This function converts the OpenCV Mat to the Unity Texture2D image.
        * <br>Passed Mat data should be of required size to fill the whole texture according to its width, height, data format and mipmapCount. 
        * <br>This function doesn't check bounds.
        *
        * @param mat
        * @param texture2D The Texture2D object has to be of the same size as the Mat (width * height).
        */
        public static void fastMatToTexture2D (Mat mat, Texture2D texture2D)
        {
            if (mat != null)
                mat.ThrowIfDisposed ();

            if (mat == null)
                throw new ArgumentNullException ("mat");
            if (texture2D == null)
                throw new ArgumentNullException ("texture2D");

            if (mat.cols () != texture2D.width || mat.rows () != texture2D.height)
                throw new ArgumentException ("The Texture2D object has to be of the same size");

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER

#if UNITY_5_3_OR_NEWER
            if (!mat.isContinuous ()) {
                throw new ArgumentException ("mat.isContinuous() must be true.");
            }

            Core.flip (mat, mat, 0);
            texture2D.LoadRawTextureData ((IntPtr)mat.dataAddr (), (int)mat.total () * (int)mat.elemSize ());
            texture2D.Apply ();
            Core.flip (mat, mat, 0);

            return;
#else
            return;
#endif

#else
            return;
#endif
        }

        /**
        * Converts Unity Texture2D to OpenCV Mat.
        * <p>
        * <br>This function converts the Unity Texture2D image to the OpenCV Mat.
        * <br>The Mat object has to be of the same size as the Texture2D'(width * height).
        * <br>The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * 
        * @param texture2D the Texture2D object has to be of the TextureFormat 'RGBA32' or 'ARGB32'.(SetPixels32() must function)
        * @param mat the Mat object has to be of the same size as the Texture2D'(width * height).
        * The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        */
        public static void texture2DToMat (Texture2D texture2D, Mat mat)
        {
            if (mat != null)
                mat.ThrowIfDisposed ();

            if (texture2D == null)
                throw new ArgumentNullException ("texture2D == null");
            if (mat == null)
                throw new ArgumentNullException ("mat == null");

            if (mat.cols () != texture2D.width || mat.rows () != texture2D.height)
                throw new ArgumentException ("The Mat object has to be of the same size");

            //                      byte[] data = new byte[mat.cols () * mat.rows () * mat.channels ()];
            //
            //                      Color32[] colors = texture2D.GetPixels32 ();
            //
            //                      if (mat.type () == CvType.CV_8UC1) {
            //                              for (int i = 0; i < colors.Length; i++) {
            //                                      data [i] = colors [i].b;
            //                              }
            //                              mat.put (0, 0, data);
            //                              Core.flip (mat, mat, 0);
            //                      } else if (mat.type () == CvType.CV_8UC3) {
            //                              for (int i = 0; i < colors.Length; i++) {
            //                                      data [(i * 3) + 0] = colors [i].b;
            //                                      data [(i * 3) + 1] = colors [i].g;
            //                                      data [(i * 3) + 2] = colors [i].r;
            //                              }
            //                              mat.put (0, 0, data);
            //                              Core.flip (mat, mat, 0);
            //                      } else if (mat.type () == CvType.CV_8UC4) {
            //                              for (int i = 0; i < colors.Length; i++) {
            //                                      data [(i * 4) + 0] = colors [i].b;
            //                                      data [(i * 4) + 1] = colors [i].g;
            //                                      data [(i * 4) + 2] = colors [i].r;
            //                                      data [(i * 4) + 3] = colors [i].a;
            //                              }
            //                              mat.put (0, 0, data);
            //                              Core.flip (mat, mat, 0);
            //                      }


            //                      #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            //          if(mat.type () == CvType.CV_8UC4){
            //              OpenCVForUnity_LowLevelTextureToMat (texture2D.GetNativeTexturePtr(), texture2D.width, texture2D.height, mat.nativeObj);
            //              
            //              return;
            //          }
            //          
            //                      #endif

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER

            #if (UNITY_5 && !UNITY_5_0) || UNITY_5_3_OR_NEWER 
            int type = mat.type ();

            if ((texture2D.format == TextureFormat.RGBA32 && type == CvType.CV_8UC4) || (texture2D.format == TextureFormat.RGB24 && type == CvType.CV_8UC3) || (texture2D.format == TextureFormat.Alpha8 && type == CvType.CV_8UC1)) {
                mat.put (0, 0, texture2D.GetRawTextureData ());
                Core.flip (mat, mat, 0);

                return;
            }
            #endif

            
            Color32[] colors = texture2D.GetPixels32 ();
            
            GCHandle colorsHandle = GCHandle.Alloc (colors, GCHandleType.Pinned);
            
            OpenCVForUnity_TextureToMat (colorsHandle.AddrOfPinnedObject (), mat.nativeObj);
            
            colorsHandle.Free ();
            
#else
            return;
#endif
        }

        /**
        * Fast converts Unity Texture2D to OpenCV Mat.(Unity5.1+)
        * <p>
        * <br>This function converts the Unity Texture2D image to the OpenCV Mat.
        * <br>Mat data size must be the same as the texture data size.
        * <br>This function doesn't check bounds.
        * 
        * @param texture2D
        * @param mat the Mat object has to be of the same size as the Texture2D'(width * height).
        */
        public static void fastTexture2DToMat (Texture2D texture2D, Mat mat)
        {
            if (mat != null)
                mat.ThrowIfDisposed ();

            if (texture2D == null)
                throw new ArgumentNullException ("texture2D == null");
            if (mat == null)
                throw new ArgumentNullException ("mat == null");

            if (mat.cols () != texture2D.width || mat.rows () != texture2D.height)
                throw new ArgumentException ("The Mat object has to be of the same size");

#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER

#if (UNITY_5 && !UNITY_5_0) || UNITY_5_3_OR_NEWER

            mat.put (0, 0, texture2D.GetRawTextureData ());
            Core.flip (mat, mat, 0);

            return;

#else
            return;
#endif

#else
            return;
#endif
        }

        /**
        * Converts Unity WebCamTexture to OpenCV Mat.
        * <p>
        * <br>This function converts the Unity WebCamTexture image to the OpenCV Mat.
        * <br>The Mat object has to be of the same size as the WebCamTexture'(width * height).
        * <br>The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * 
        * @param webcamTexture a WebCamTexture object
        * @param mat the Mat object has to be of the same size as the WebCamTexture'(width * height).
        * The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        */
        public static void webCamTextureToMat (WebCamTexture webCamTexture, Mat mat)
        {
            webCamTextureToMat (webCamTexture, mat, null);
        }

        /**
        * Converts Unity WebCamTexture to OpenCV Mat.
        * <p>
        * <br>This function converts the Unity WebCamTexture image to the OpenCV Mat.
        * <br>The Mat object has to be of the same size as the WebCamTexture'(width * height).
        * <br>The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * 
        * @param webcamTexture a WebCamTexture object
        * @param mat the Mat object has to be of the same size as the WebCamTexture'(width * height).
        * The Mat object has to be of the types 'CV_8UC4' (RGBA) , 'CV_8UC3' (RGB) or 'CV_8UC1' (GRAY).
        * @param bufferColors the optional array to receive pixel data.
        * You can optionally pass in an array of Color32s to use in colors to avoid allocating new memory each frame.
        * The array needs to be initialized to a length matching width * height of the texture.(http://docs.unity3d.com/ScriptReference/WebCamTexture.GetPixels32.html)
        */
        public static void webCamTextureToMat (WebCamTexture webCamTexture, Mat mat, Color32[] bufferColors)
        {
            if (mat != null)
                mat.ThrowIfDisposed ();

            if (webCamTexture == null)
                throw new ArgumentNullException ("webCamTexture == null");
            if (mat == null)
                throw new ArgumentNullException ("mat == null");

            if (mat.cols () != webCamTexture.width || mat.rows () != webCamTexture.height)
                throw new ArgumentException ("The Mat object has to be of the same size");

            //                                              byte[] data = new byte[mat.cols () * mat.rows () * mat.channels ()];
            //                      
            //                                              Color32[] colors = webCamTexture.GetPixels32 ();
            //                      
            //                                              if (mat.type () == CvType.CV_8UC1) {
            //                                                      for (int i = 0; i < colors.Length; i++) {
            //                                                              data [i] = colors [i].b;
            //                                                      }
            //                                                      mat.put (0, 0, data);
            //                                                      Core.flip (mat, mat, 0);
            //                                              } else if (mat.type () == CvType.CV_8UC3) {
            //                                                      for (int i = 0; i < colors.Length; i++) {
            //                                                              data [(i * 3) + 0] = colors [i].r;
            //                                                              data [(i * 3) + 1] = colors [i].g;
            //                                                              data [(i * 3) + 2] = colors [i].b;
            //                                                      }
            //                                                      mat.put (0, 0, data);
            //                                                      Core.flip (mat, mat, 0);
            //                                              } else if (mat.type () == CvType.CV_8UC4) {
            //                                                      for (int i = 0; i < colors.Length; i++) {
            //                                                              data [(i * 4) + 0] = colors [i].r;
            //                                                              data [(i * 4) + 1] = colors [i].g;
            //                                                              data [(i * 4) + 2] = colors [i].b;
            //                                                              data [(i * 4) + 3] = colors [i].a;
            //                                                      }
            //                                                      mat.put (0, 0, data);
            //                                                      Core.flip (mat, mat, 0);
            //                                              }

            //                      #if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            //          if(mat.type () == CvType.CV_8UC4){
            //              OpenCVForUnity_LowLevelTextureToMat (webCamTexture.GetNativeTexturePtr(), webCamTexture.width, webCamTexture.height, mat.nativeObj);
            //              
            //              return;
            //          }
            //          
            //                      #endif

#if (UNITY_IOS && !UNITY_EDITOR && (UNITY_4_6_3 || UNITY_5_0_0 || UNITY_5_0_1))
                        if (mat.type () == CvType.CV_8UC4) {
                                OpenCVForUnity_LowLevelTextureToMat (webCamTexture.GetNativeTexturePtr (), webCamTexture.width, webCamTexture.height, mat.nativeObj);
                                if (Utils.getLowLevelGraphicsDeviceType() == 16 && Utils.getLowLevelTextureFormat (webCamTexture) == 80) {
                                        Imgproc.cvtColor (mat, mat, Imgproc.COLOR_BGRA2RGBA);
                                }
                                Core.flip (mat, mat, 0);
                                return;
                        }
#endif


#if UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER
            GCHandle colorsHandle;
            if (bufferColors == null) {

                Color32[] colors = webCamTexture.GetPixels32 ();
            
                colorsHandle = GCHandle.Alloc (colors, GCHandleType.Pinned);
            } else {
                webCamTexture.GetPixels32 (bufferColors);
                
                colorsHandle = GCHandle.Alloc (bufferColors, GCHandleType.Pinned);
            }
            
            OpenCVForUnity_TextureToMat (colorsHandle.AddrOfPinnedObject (), mat.nativeObj);
            
            colorsHandle.Free ();
            
#else
            return;
#endif
        }

        /**
        * Converts Texture to Texture2D.
        * <p>
        * <br>This function converts the Texture image to the Texture2D image.
        * <br>The texture and texture2D need to be the same size.
        * <br>The texture2D's TextureFormat needs to be RGBA32(Unity5.5+), ARGB32, RGB24, RGBAFloat or RGBAHalf.
        * 
        * @param texture a texture object
        * @param texture2D a texture2D object
        */
        public static void textureToTexture2D (Texture texture, Texture2D texture2D)
        {
            if (texture == null)
                throw new ArgumentNullException ("texture");
            if (texture2D == null)
                throw new ArgumentNullException ("texture2D");

            if (texture.width != texture2D.width || texture.height != texture2D.height)
                throw new ArgumentException ("texture and texture2D need to be the same size.");

            RenderTexture prevRT = RenderTexture.active;

            if (texture is RenderTexture) {
                RenderTexture.active = (RenderTexture)texture;
                texture2D.ReadPixels (new UnityEngine.Rect (0f, 0f, texture.width, texture.height), 0, 0, false);
                texture2D.Apply (false, false);

            } else {
                RenderTexture tempRT = RenderTexture.GetTemporary (texture.width, texture.height, 0, RenderTextureFormat.ARGB32);
                Graphics.Blit (texture, tempRT);

                RenderTexture.active = tempRT;
                texture2D.ReadPixels (new UnityEngine.Rect (0f, 0f, texture.width, texture.height), 0, 0, false);
                texture2D.Apply (false, false);
                RenderTexture.ReleaseTemporary (tempRT);
            }

            RenderTexture.active = prevRT;
        }

        /**
        * Converts OpenCV Mat to Unity Texture using low-level native plugin interface.
        * <p>
        * <br>This function converts the OpenCV Mat to the Unity Texture image using low-level native plugin interface.
        * <br>The Mat object has to be of the types 'CV_8UC4' (RGBA).
        * <br>The Texture object has to be of the TextureFormat 'RGBA32' or 'ARGB32'.
        * <br>The Texture object has to be of the same size as the Mat'(width * height).
        * <br>This function not implemented yet on OpenGLCore, Direct3D12.
        *
        * @param mat the Mat object has to be of the types 'CV_8UC4' (RGBA)
        * @param texture the Texture object has to be of the TextureFormat 'RGBA32' or 'ARGB32'. The Texture object has to be of the same size as the Mat (width * height).
        */
        [Obsolete ("Please use Texture2D.LoadRawTextureData() and Graphics.CopyTexture() method instead.")]
        public static void matToTexture (Mat mat, Texture texture)
        {
            if (mat != null)
                mat.ThrowIfDisposed ();

            if (mat == null)
                throw new ArgumentNullException ("mat");
            if (texture == null)
                throw new ArgumentNullException ("texture2D");

            if (mat.cols () != texture.width || mat.rows () != texture.height)
                throw new ArgumentException ("The Texture object has to be of the same size");

#if (UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER) && !(UNITY_WEBGL && !UNITY_EDITOR)
            
            OpenCVForUnity_LowLevelMatToTexture (mat.nativeObj, texture.GetNativeTexturePtr (), texture.width, texture.height);
            
#else
            return;
#endif
        }

        /**
        * Converts Unity Texture to OpenCV Mat using low-level native plugin interface.
        * <p>
        * <br>This function converts the Unity Texture image to the OpenCV Mat using low-level native plugin interface.
        * <br>The Mat object has to be of the same size as the Texture'(width * height).
        * <br>The Mat object has to be of the types 'CV_8UC4' (RGBA).
        * <br>This function not implemented yet on OpenGLCore, Direct3D12.
        * <br>When using Windows 10 and Direct3D11, Utils.textureToMat() seems to have limitations on the size of the texture. 2^n x 2^n (32x32, 32x64, 128x128, ...) is OK. But, other size is NG. 
        * 
        * @param texture a Texture object
        * @param mat the Mat object has to be of the same size as the Texture'(width * height).
        * The Mat object has to be of the types 'CV_8UC4' (RGBA).
        */
        [Obsolete ("Please use Utils.textureToTexture2D() and Texture2D.GetRawTextureData() method instead.")]
        public static void textureToMat (Texture texture, Mat mat)
        {
            if (mat != null)
                mat.ThrowIfDisposed ();

            if (texture == null)
                throw new ArgumentNullException ("texture2D == null");
            if (mat == null)
                throw new ArgumentNullException ("mat == null");

            if (mat.cols () != texture.width || mat.rows () != texture.height)
                throw new ArgumentException ("The Mat object has to be of the same size");


#if (UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER) && !(UNITY_WEBGL && !UNITY_EDITOR)
            
            OpenCVForUnity_LowLevelTextureToMat (texture.GetNativeTexturePtr (), texture.width, texture.height, mat.nativeObj);
            
#else
            return;
#endif
        }

        /**
        * Returns the low level graphics API type used by the graphics device. (using low-level native plugin interface)
        * <p>
        * <br>This function not implemented yet on OpenGLCore, Direct3D12.
        * 
        * <br><a href="http://docs.unity3d.com/Manual/NativePluginInterface.html">http://docs.unity3d.com/Manual/NativePluginInterface.html</a>
        * <br>kUnityGfxRendererOpenGL            =  0, // Desktop OpenGL
        * <br>kUnityGfxRendererD3D9              =  1, // Direct3D 9
        * <br>kUnityGfxRendererD3D11             =  2, // Direct3D 11
        * <br>kUnityGfxRendererGCM               =  3, // PlayStation 3
        * <br>kUnityGfxRendererNull              =  4, // "null" device (used in batch mode)
        * <br>kUnityGfxRendererXenon             =  6, // Xbox 360
        * <br>kUnityGfxRendererOpenGLES20        =  8, // OpenGL ES 2.0
        * <br>kUnityGfxRendererOpenGLES30        = 11, // OpenGL ES 3.0
        * <br>kUnityGfxRendererGXM               = 12, // PlayStation Vita
        * <br>kUnityGfxRendererPS4               = 13, // PlayStation 4
        * <br>kUnityGfxRendererXboxOne           = 14, // Xbox One        
        * <br>kUnityGfxRendererMetal             = 16, // iOS Metal
        * <br>kUnityGfxRendererD3D12             = 18, // Direct3D 12
        *
        * @return the graphics API type
        */
        [Obsolete ("This method is deprecated.")]
        public static int getLowLevelGraphicsDeviceType ()
        {
#if (UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER) && !(UNITY_WEBGL && !UNITY_EDITOR)
            return OpenCVForUnity_GetLowLevelGraphicsDeviceType ();
#else
            return -1;
#endif
        }

        /**
        * Returns the low level texture format of a Texture. (using low-level native plugin interface)
        * <p>
        * <br>This function not implemented yet on OpenGLCore, Direct3D12.
        * <br>Direct3D 9 D3DFORMAT (Win)
        * <br>Direct3D 11 DXGI_FORMAT (Win WindowsPhone)
        * <br>OpenGL internalFormat (Win OSX)
        * <br>OpenGLES always return -1 (Android iOS)
        * <br>Metal MTLPixelFormat (iOS)
        * 
        * @param texture a Texture object
        * @return the low level texture format
        */
        [Obsolete ("This method is deprecated.")]
        public static int getLowLevelTextureFormat (Texture texture)
        {
            if (texture == null)
                throw new ArgumentNullException ("texture == null");

#if (UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER) && !(UNITY_WEBGL && !UNITY_EDITOR)
            return OpenCVForUnity_GetLowLevelTextureFormat (texture.GetNativeTexturePtr ());
#else
            return -1;
#endif
        }

        /**
        * Indicates whether is new low level native plugin interface.
        * <p>
        * <br><a href="http://docs.unity3d.com/Manual/NativePluginInterface.html">http://docs.unity3d.com/Manual/NativePluginInterface.html</a>
        *
        * @return true, if it is new low level native plugin interface false otherwise.
        */
        [Obsolete ("This method is deprecated.")]
        public static bool isNewLowLevelNativePluginInterface ()
        {
#if (UNITY_PRO_LICENSE || ((UNITY_ANDROID || UNITY_IOS) && !UNITY_EDITOR) || UNITY_5 || UNITY_5_3_OR_NEWER) && !(UNITY_WEBGL && !UNITY_EDITOR)
            return OpenCVForUnity_IsNewLowLevelNativePluginInterface ();
#else
            return false;
#endif
        }

        /**
        * Gets the readable path of a file in the "StreamingAssets" folder.
        * <p>
        * <br>Set a relative file path from the starting point of the "StreamingAssets" folder. e.g. "foobar.txt" or "hogehoge/foobar.txt".
        * <br>[Android]The target file that exists in the "StreamingAssets" folder is copied into the folder of the Application.persistentDataPath. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copyied. 
        * <br>[WebGL]If the target file has not yet been copied to WebGL's virtual filesystem, you need to use getFilePathAsync() at first.
        * 
        * @param filepath a relative file path starting from "StreamingAssets" folder
        * @param refresh [Android]If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copyied.
        * @return returns the file path in case of success and returns empty in case of error.
        */
        public static string getFilePath (string filepath, bool refresh = false)
        {
#if UNITY_ANDROID && !UNITY_EDITOR
            filepath = filepath.TrimStart (chTrims);

            string srcPath = Path.Combine(Application.streamingAssetsPath, filepath);
            string destPath = Path.Combine(Application.persistentDataPath, "opencvforunity");
            destPath = Path.Combine(destPath, filepath);

            if (!refresh && File.Exists(destPath))
                return destPath;

            using (WWW request = new WWW (srcPath)) {
                while (!request.isDone) {;}

                if (!string.IsNullOrEmpty(request.error)) {
                    Debug.LogWarning (request.error);
                    return String.Empty;
                }

                //create Directory
                String dirPath = Path.GetDirectoryName (destPath);
                if (!Directory.Exists (dirPath))
                    Directory.CreateDirectory (dirPath);

                File.WriteAllBytes (destPath, request.bytes);
            }

            return destPath;
#elif UNITY_WEBGL && !UNITY_EDITOR
            filepath = filepath.TrimStart (chTrims);

            string destPath = Path.Combine(Path.AltDirectorySeparatorChar.ToString(), "opencvforunity");
            destPath = Path.Combine(destPath, filepath);

            if (File.Exists(destPath)){
                return destPath;
            }else{
                return String.Empty;
            }
#else
            filepath = filepath.TrimStart (chTrims);

            string destPath = Path.Combine (Application.streamingAssetsPath, filepath);

            if (File.Exists (destPath)) {
                return destPath;
            } else {
                return String.Empty;
            }
#endif
        }

        /**
        * Gets the readable path of a file in the "StreamingAssets" folder by using coroutines.
        * <p>
        * <br>Set a relative file path from the starting point of the "StreamingAssets" folder.  e.g. "foobar.txt" or "hogehoge/foobar.txt".
        * <br>[Android]The target file that exists in the "StreamingAssets" folder is copied into the folder of the Application.persistentDataPath. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copyied. 
        * <br>[WebGL]The target file in the "StreamingAssets" folder is copied to the WebGL's virtual filesystem. If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copyied. 
        * 
        * @param filepath a relative file path starting from "StreamingAssets" folder
        * @param completed a callback function that is called when process is completed. Returns the file path in case of success and returns empty in case of error.
        * @param progress a callback function that is called when process is progress. Returns the file path and a value of 0 to 1.
        * @param refresh [Android][WebGL]If refresh flag is false, when the file has already been copied, the file is not copied. If refresh flag is true, the file is always copyied.
        */
        public static IEnumerator getFilePathAsync (string filepath, Action<string> completed, Action<string, float> progress = null, bool refresh = false)
        {
#if (UNITY_ANDROID || UNITY_WEBGL) && !UNITY_EDITOR
            filepath = filepath.TrimStart (chTrims);

            string srcPath = Path.Combine(Application.streamingAssetsPath, filepath);
#if UNITY_ANDROID
            string destPath = Path.Combine(Application.persistentDataPath, "opencvforunity");
#else
            string destPath = Path.Combine(Path.AltDirectorySeparatorChar.ToString(), "opencvforunity");
#endif
            destPath = Path.Combine(destPath, filepath);

            if (!refresh && File.Exists(destPath)){
                if (progress != null)
                    progress(destPath, 0);
                yield return null;
                if (progress != null)
                    progress(destPath, 1);
                if (completed != null)
                    completed (destPath);
            } else {
#if UNITY_WEBGL && UNITY_5_4_OR_NEWER
                using (UnityEngine.Networking.UnityWebRequest request = UnityEngine.Networking.UnityWebRequest.Get (srcPath)) {
                    request.Send ();
                    while (!request.isDone) {
                        if (progress != null)
                        progress(filepath, request.downloadProgress);

                        yield return null;
                    }

#if UNITY_2017 && UNITY_2017_1_OR_NEWER
                    if (request.isHttpError || request.isNetworkError) {
#else
                    if (request.isError) {
#endif
                        Debug.LogWarning (request.error);
                        if (completed != null)
                            completed (String.Empty);
                    }

                    //create Directory
                    String dirPath = Path.GetDirectoryName (destPath);
                    if (!Directory.Exists (dirPath))
                        Directory.CreateDirectory (dirPath);

                    File.WriteAllBytes (destPath, request.downloadHandler.data);
                }
#else
                using (WWW request = new WWW (srcPath)) {

                    while (!request.isDone) {
                        if (progress != null)
                            progress(filepath, request.progress);

                        yield return null;
                    }

                    if (!string.IsNullOrEmpty(request.error)) {
                        Debug.LogWarning (request.error);
                            if (completed != null)
                                completed (String.Empty);
                    }

                    //create Directory
                    String dirPath = Path.GetDirectoryName (destPath);
                    if (!Directory.Exists (dirPath))
                        Directory.CreateDirectory (dirPath);

                    File.WriteAllBytes(destPath, request.bytes);
                }
#endif

                    if (completed != null) completed (destPath);
            }
#else
            filepath = filepath.TrimStart (chTrims);

            string destPath = Path.Combine (Application.streamingAssetsPath, filepath);

            if (File.Exists (destPath)) {
                if (progress != null)
                    progress (destPath, 0);
                yield return null;
                if (progress != null)
                    progress (destPath, 1);
                if (completed != null)
                    completed (destPath);
            } else {
                if (progress != null)
                    progress (String.Empty, 0);
                yield return null;
                if (completed != null)
                    completed (String.Empty);
            }
#endif

            yield break;
        }

        private static char[] chTrims = {
            '.',
            #if UNITY_WINRT_8_1 && !UNITY_EDITOR
            '/',
            '\\'
            #else
            System.IO.Path.DirectorySeparatorChar,
            System.IO.Path.AltDirectorySeparatorChar
            #endif
        };

        /**
        * Sets the debug mode.
        * <p>
        * <br>if true, The error log of the Native side OpenCV will be displayed on the Unity Editor Console.
        * <br>This method is supported in WIN, MAC and LINUX.
        * <br>Please use as follows.
        * <br>Utils.setDebugMode(true);
        * <br>aaa
        * <br>bbb
        * <br>ccc
        * <br>Utils.setDebugMode(false);
        * 
        * @param debugMode if true, The error log of the Native side OpenCV will be displayed on the Unity Editor Console
        */
        public static void setDebugMode (bool debugMode)
        {
#if (UNITY_PRO_LICENSE || UNITY_5 || UNITY_5_3_OR_NEWER) && (UNITY_STANDALONE || UNITY_EDITOR)
            OpenCVForUnity_SetDebugMode (debugMode);

            if (debugMode) {
                OpenCVForUnity_SetDebugLogFunc (debugLogFunc);
//                              OpenCVForUnity_DebugLogTest ();
            } else {
                OpenCVForUnity_SetDebugLogFunc (null);
            }
#endif
        }

        internal static int URShift (int number, int bits)
        {
            if (number >= 0)
                return number >> bits;
            else
                return (number >> bits) + (2 << ~bits);
        }

        internal static long URShift (long number, int bits)//TODO:@check
        {
            if (number >= 0)
                return number >> bits;
            else
                return (number >> bits) + (2 << ~bits);
        }

        internal static int HashContents<T> (this IEnumerable<T> enumerable)//TODO:@check
        {
            int hash = 0x218A9B2C;
            foreach (var item in enumerable) {
                int thisHash = item.GetHashCode ();
                //mix up the bits.
                hash = thisHash ^ ((hash << 5) + hash);
            }
            return hash;
        }

        #if (UNITY_PRO_LICENSE || UNITY_5 || UNITY_5_3_OR_NEWER) && (UNITY_STANDALONE || UNITY_EDITOR)
        
        private delegate void DebugLogDelegate (string str);

        private static DebugLogDelegate debugLogFunc = msg => Debug.LogError (msg);

        [DllImport ("opencvforunity")]
        private static extern void OpenCVForUnity_SetDebugMode (bool flag);

        [DllImport ("opencvforunity")]
        private static extern void OpenCVForUnity_SetDebugLogFunc (DebugLogDelegate func);

        [DllImport ("opencvforunity")]
        private static extern void OpenCVForUnity_DebugLogTest ();
        #endif

        #if (UNITY_IOS || UNITY_WEBGL) && !UNITY_EDITOR
        
        [DllImport("__Internal")]
        private static extern void OpenCVForUnity_MatToTexture (IntPtr mat, IntPtr textureColors);
        
        [DllImport("__Internal")]
        private static extern void OpenCVForUnity_TextureToMat (IntPtr textureColors, IntPtr Mat);

        [DllImport("__Internal")]
        private static extern void OpenCVForUnity_MatDataToByteArray (IntPtr mat, IntPtr byteArray);
        
        [DllImport("__Internal")]
        private static extern void OpenCVForUnity_ByteArrayToMatData (IntPtr byteArray, IntPtr Mat);


        











#if !UNITY_WEBGL
        [DllImport("__Internal")]
        private static extern void OpenCVForUnity_TextureDataToByteArray (IntPtr texPtr, int texWidth, int texHeight, IntPtr byteArray, int bytesPerPixel);
        
        [DllImport("__Internal")]
        private static extern void OpenCVForUnity_ByteArrayToTextureData (IntPtr byteArray, IntPtr texPtr, int texWidth, int texHeight, int bytesPerPixel);
        
        [DllImport("__Internal")]
        private static extern void OpenCVForUnity_LowLevelMatToTexture (IntPtr mat, IntPtr texPtr, int texWidth, int texHeight);
        
        [DllImport("__Internal")]
        private static extern void OpenCVForUnity_LowLevelTextureToMat (IntPtr texPtr, int texWidth, int texHeight, IntPtr mat);

        [DllImport("__Internal")]
        private static extern int OpenCVForUnity_GetLowLevelGraphicsDeviceType ();

        [DllImport("__Internal")]
        private static extern int OpenCVForUnity_GetLowLevelTextureFormat (IntPtr texPtr);

        [DllImport("__Internal")]
        private static extern bool OpenCVForUnity_IsNewLowLevelNativePluginInterface ();
#endif
        

        











#else

        [DllImport ("opencvforunity")]
        private static extern void OpenCVForUnity_MatToTexture (IntPtr mat, IntPtr textureColors);

        [DllImport ("opencvforunity")]
        private static extern void OpenCVForUnity_TextureToMat (IntPtr textureColors, IntPtr Mat);

        [DllImport ("opencvforunity")]
        private static extern void OpenCVForUnity_MatDataToByteArray (IntPtr mat, IntPtr byteArray);

        [DllImport ("opencvforunity")]
        private static extern void OpenCVForUnity_ByteArrayToMatData (IntPtr byteArray, IntPtr Mat);

        [DllImport ("opencvforunity")]
        private static extern void OpenCVForUnity_TextureDataToByteArray (IntPtr texPtr, int texWidth, int texHeight, IntPtr byteArray, int bytesPerPixel);

        [DllImport ("opencvforunity")]
        private static extern void OpenCVForUnity_ByteArrayToTextureData (IntPtr byteArray, IntPtr texPtr, int texWidth, int texHeight, int bytesPerPixel);

        [DllImport ("opencvforunity")]
        private static extern void OpenCVForUnity_LowLevelMatToTexture (IntPtr mat, IntPtr texPtr, int texWidth, int texHeight);

        [DllImport ("opencvforunity")]
        private static extern void OpenCVForUnity_LowLevelTextureToMat (IntPtr texPtr, int texWidth, int texHeight, IntPtr mat);

        [DllImport ("opencvforunity")]
        private static extern int OpenCVForUnity_GetLowLevelGraphicsDeviceType ();

        [DllImport ("opencvforunity")]
        private static extern int OpenCVForUnity_GetLowLevelTextureFormat (IntPtr texPtr);

        [DllImport ("opencvforunity")]
        private static extern bool OpenCVForUnity_IsNewLowLevelNativePluginInterface ();

        #endif
    }
}
