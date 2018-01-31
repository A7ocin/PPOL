using UnityEngine;

[ExecuteInEditMode]
public class Stereo3DRenderer : MonoBehaviour {
	
	private Stereo3D	_s3d;
	private Material	_stereoMaterial;
	
	void Start () 
    {
		_s3d = GetComponent<Stereo3D>();
	}
	
	void OnRenderImage (RenderTexture source, RenderTexture destination) 
    {
		RenderTexture.active = destination;
		GL.PushMatrix();
		GL.LoadOrtho();
		switch (_s3d.State) {
			case StereoState.Interlace: {
				_s3d.StereoMaterial.SetPass(0);
			} break;
			case StereoState.ReversedInterlace: {
				_s3d.StereoMaterial.SetPass(0);
			} break;
			case StereoState.Anaglyph: {
				_s3d.StereoMaterial.SetPass(1);
			} break;
		}
		DrawQuad();
		GL.PopMatrix();
		
		
		RenderTexture.active = null;
	}
	
	void DrawQuad() {
		GL.Begin (GL.QUADS);      
      	GL.TexCoord2( 0.0f, 0.0f ); GL.Vertex3( 0.0f, 0.0f, 0.1f );
      	GL.TexCoord2( 1.0f, 0.0f ); GL.Vertex3( 1, 0.0f, 0.1f );
      	GL.TexCoord2( 1.0f, 1.0f ); GL.Vertex3( 1, 1.0f, 0.1f );
      	GL.TexCoord2( 0.0f, 1.0f ); GL.Vertex3( 0.0f, 1.0f, 0.1f );
   		GL.End();
	}
	
	Matrix4x4 PerspectiveOffCenter (float left, float right, float bottom, float top,
		float near, float far) {
		
		Matrix4x4 m = new Matrix4x4();
		float x = (2 * near) / (right - left);
		float y = (2 * near) / (top - bottom);
		float a = (right + left) / (right - left);
		float b = (top + bottom) / (top - bottom);
		float c = -(far + near) / (far - near);
		float d = -(2 * far * near) / (far - near);
		float e = 1;
		
		m[0,0] = x;	m[0,1] = 0;	m[0,2] = a;	m[0,3] = 0;
		m[1,0] = 0;	m[1,1] = y;	m[1,2] = b;	m[1,3] = 0;
		m[2,0] = 0;	m[2,1] = 0;	m[2,2] = c;	m[2,3] = d;
		m[3,0] = 0;	m[3,1] = 0;	m[3,2] = e;	m[3,3] = 0;
		
		return m;
	}
	
	Matrix4x4 ProjectionMatrix (bool isLeftCam) {
		float left, right, a, b,  FOVrad;
		float aspect = _s3d.CB.NodalCamera.aspect;
		float tmpAspect;
		
		Camera camera = _s3d.CB.NodalCamera;
		
		FOVrad = camera.fieldOfView / 180 * Mathf.PI;
		tmpAspect = aspect;
		
		a = camera.nearClipPlane * Mathf.Tan(FOVrad * .5f);
		b = camera.nearClipPlane / (_s3d.Convergence + camera.nearClipPlane);
		
		if (isLeftCam) {
			left  = - tmpAspect * a + (_s3d.Interaxial/2) * b;
			right =   tmpAspect * a + (_s3d.Interaxial/2) * b;
		}
		else {
			left  = - tmpAspect * a - (_s3d.Interaxial/2) * b;
			right =   tmpAspect * a - (_s3d.Interaxial/2) * b;
		}
		
		return PerspectiveOffCenter(left, right, -a, a, camera.nearClipPlane, camera.farClipPlane);
	}
}
