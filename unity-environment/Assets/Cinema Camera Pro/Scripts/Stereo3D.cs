using CinemaProCams;
using UnityEngine;

[RequireComponent (typeof(CameraBody))]
[ExecuteInEditMode]
public class Stereo3D : MonoBehaviour {
	
	private CameraBody		_cameraBody;
	public CameraBody		CB {
		get {
			return _cameraBody;	
		}
	}
	
	private RenderTexture 	_leftCamRT;
	private RenderTexture 	_rightCamRT;
	private GameObject		_leftCam;
	private GameObject		_rightCam;
	
	[SerializeField]
	private int				_selectedRig;
	public int SelectedRig {get {return _selectedRig;} set{_selectedRig = value;}}
	
	[SerializeField]
	private	Material		_stereoMaterial;
	public Material			StereoMaterial {
		get {
			return _stereoMaterial;
		}
	}
	
	[SerializeField]
	private float			_minInteraxial;
	public 	float			MinInteraxial {	get{return _minInteraxial;}}
	
	[SerializeField]
	private float			_maxInteraxial;
	public 	float			MaxInteraxial {	get{return _maxInteraxial;}}
	[SerializeField]
	private	float			_interaxial = 0;
	public	float			Interaxial {get{return _interaxial;} set{_interaxial = value;}}
	
	[SerializeField]
	private float			_minConvergence;
	public float			MinConvergence {get{return _minConvergence;}}
	
	[SerializeField]
	private float			_maxConvergence;
	public float			MaxConvergence {get{return _maxConvergence;}}
	
	[SerializeField]
	private	float			_convergence = 0;
	public	float			Convergence {get{return _convergence;}set{_convergence = value;}}
	
	[SerializeField]
	private StereoState			_sstate;
	public 	StereoState			State {get {return _sstate;} set{_sstate = value;}}
	
	
	[SerializeField]
	private int				_targetFrameRate;
	public 	int				TargetFrameRate {get; set;}
	
	private GameObject		_trackObject;
	
	public	bool			ShowBody = false;
	
	void Awake () {
		bool lc = false, rc = false, to = false;
		
		_cameraBody = GetComponent<CameraBody>();
		
		foreach (Transform t in _cameraBody.NodalCamera.transform) {
			if (!lc) {
				if (lc = t.name == "left_cam")
					_leftCam = t.gameObject;
			}
			
			if (!rc) {
				if (rc = t.name == "right_cam")
					_rightCam = t.gameObject;
			}
			
			if (!to) {
				if (to = t.name == "track")
					_trackObject = t.gameObject;
			}
		}
		if (!lc) _leftCam = new GameObject ("left_cam", typeof(Camera), typeof(CSDOFScatter));
		if (!rc) _rightCam = new GameObject ("right_cam", typeof(Camera), typeof(CSDOFScatter));
		
		if (!to) _trackObject = new GameObject ("track");
		
		_leftCam.transform.parent = 	_cameraBody.NodalCamera.transform;
		_rightCam.transform.parent = 	_cameraBody.NodalCamera.transform;
		_trackObject.transform.parent = _cameraBody.NodalCamera.transform;
		
		_leftCam.transform.position = 	Vector3.zero;
		_rightCam.transform.position =  Vector3.zero;
		
		if (_leftCamRT != null) 	_leftCamRT.Release();
		if (_rightCamRT != null) 	_rightCamRT.Release();
		
		_leftCamRT = 	new RenderTexture(Screen.width, Screen.height, 24);
		_rightCamRT = 	new RenderTexture(Screen.width, Screen.height, 24);
		
	}
	
	void Start () {
		SetMode(_sstate);
		
	}
	
	void OnApplicationQuit () {
		_leftCamRT.Release();
		_rightCamRT.Release();
	}
	
	public void SetDefault () {
		//_leftCam.camera.CopyFrom(_cameraBody.NodalCamera);
		//_rightCam.camera.CopyFrom(_cameraBody.NodalCamera);
		Camera camera = _cameraBody.NodalCamera;
		
		//_leftCam.camera.cullingMask = (LayerMask)(7);
		//_rightCam.camera.cullingMask = (LayerMask)(7);
		
		//_leftCam.camera.clearFlags = CameraClearFlags.Skybox;
		//_rightCam.camera.clearFlags = CameraClearFlags.Skybox;
		
		_leftCam.GetComponent<Camera>().renderingPath = camera.renderingPath;
		_rightCam.GetComponent<Camera>().renderingPath = camera.renderingPath;
	}
	
	public void SetTargetTextures (RenderTexture l, RenderTexture r) {
		#if UNITY_EDITOR
		if (_leftCamRT == null)
			_leftCamRT = new RenderTexture(Screen.width, Screen.height, 24);
		
		if (_rightCamRT == null)
			_rightCamRT = new RenderTexture(Screen.width, Screen.height, 24);
		#endif
		
		if (_leftCamRT.width != Screen.width || _leftCamRT.height != Screen.height) {
			_leftCamRT.Release();
			_leftCamRT = new RenderTexture(Screen.width, Screen.height, 24);
		}
		
		if (_rightCamRT.width != Screen.width || _rightCamRT.height != Screen.height) {
			_rightCamRT.Release();
			_rightCamRT = new RenderTexture(Screen.width, Screen.height, 24);
		}
		
		_leftCam.GetComponent<Camera>().targetTexture = _leftCamRT;
		_rightCam.GetComponent<Camera>().targetTexture = _rightCamRT;

        _stereoMaterial.SetTexture("_LeftTex", _rightCamRT);
		_stereoMaterial.SetTexture ("_RightTex", _leftCamRT);
	}
	
	public void SetParentCamera () {
		_leftCam.transform.parent = _cameraBody.NodalCamera.transform;
		_rightCam.transform.parent = _cameraBody.NodalCamera.transform;
		_trackObject.transform.parent = _cameraBody.NodalCamera.transform;
		_leftCam.transform.position = Vector3.zero;
		_rightCam.transform.position = Vector3.zero;
		
		Camera camera = _cameraBody.NodalCamera;
		
		//camera.cullingMask = 0;
		camera.backgroundColor = new Color(0,0,0,0);
		camera.clearFlags = CameraClearFlags.Nothing;
		//camera.cullingMask = 1 << LayerMask.NameToLayer("Test");
	}
	
	void SetInterlace () {
		SetDefault ();
		SetTargetTextures (_leftCamRT, _rightCamRT);
		
		Camera camera = _cameraBody.NodalCamera;
		
		_leftCam.GetComponent<Camera>().depth = camera.depth - 2;
		_rightCam.GetComponent<Camera>().depth = camera.depth - 1;
		_leftCam.GetComponent<Camera>().enabled = true;
		_rightCam.GetComponent<Camera>().enabled = true;
		_leftCam.GetComponent<Camera>().rect = new Rect(0,0,1,1);
		_rightCam.GetComponent<Camera>().rect = new Rect(0,0,1,1);
		
		UpdateView ();
		SetParentCamera ();
	}
	
	void SetReversedInterlace () {
		SetDefault ();
		SetTargetTextures (_rightCamRT,_leftCamRT);

        _leftCam.GetComponent<Camera>().targetTexture = _leftCamRT;
        _rightCam.GetComponent<Camera>().targetTexture = _rightCamRT;

        _stereoMaterial.SetTexture("_LeftTex", _leftCamRT);
        _stereoMaterial.SetTexture("_RightTex", _rightCamRT);

		Camera camera = _cameraBody.NodalCamera;
		
		_leftCam.GetComponent<Camera>().depth = camera.depth - 2;
		_rightCam.GetComponent<Camera>().depth = camera.depth - 1;
		_leftCam.GetComponent<Camera>().enabled = true;
		_rightCam.GetComponent<Camera>().enabled = true;
		_leftCam.GetComponent<Camera>().rect = new Rect(0,0,1,1);
		_rightCam.GetComponent<Camera>().rect = new Rect(0,0,1,1);
		
		UpdateView ();
		SetParentCamera ();
	}
	
	void SetAnaglyph () {
		SetDefault();
		SetTargetTextures(_leftCamRT, _rightCamRT);
		_stereoMaterial.SetVector("_Balance_Left_R", new Vector4(1, 0, 0, 0));
		_stereoMaterial.SetVector("_Balance_Right_G", new Vector4(0, 1, 0, 0));
		_stereoMaterial.SetVector("_Balance_Right_B", new Vector4(0, 0, 1, 0));
		
		Camera camera = _cameraBody.NodalCamera;
		
		_leftCam.GetComponent<Camera>().depth = camera.depth - 2;
		_rightCam.GetComponent<Camera>().depth = camera.depth - 1;
		
		_leftCam.GetComponent<Camera>().enabled = true;
		_rightCam.GetComponent<Camera>().enabled = true;
		
		_leftCam.GetComponent<Camera>().rect = new Rect(0,0,1,1);
		_rightCam.GetComponent<Camera>().rect = new Rect(0,0,1,1);
		
		UpdateView ();
		SetParentCamera ();
	}
	
	void SetShutter () {
		SetDefault();
		
		Camera camera = _cameraBody.NodalCamera;
		
		_leftCam.GetComponent<Camera>().targetTexture = null;
		_rightCam.GetComponent<Camera>().targetTexture = null;
		_leftCam.GetComponent<Camera>().depth = camera.depth + 1;
		_rightCam.GetComponent<Camera>().depth = camera.depth + 1;
		_leftCam.GetComponent<Camera>().enabled = true;
		_rightCam.GetComponent<Camera>().enabled = false;
		_leftCam.GetComponent<Camera>().rect = new Rect(0,0,1,1);
		_rightCam.GetComponent<Camera>().rect = new Rect(0,0,1,1);
		
		UpdateView ();
		SetParentCamera ();
		
		QualitySettings.vSyncCount = 1;
	}
	
	void SetSideBySide (bool isReversed) {
		SetDefault();
		
		Camera camera = _cameraBody.NodalCamera;
		
		_leftCam.GetComponent<Camera>().targetTexture = null;
		_rightCam.GetComponent<Camera>().targetTexture = null;
		_leftCam.GetComponent<Camera>().depth = camera.depth + 1;
		_rightCam.GetComponent<Camera>().depth = camera.depth + 1;
		_leftCam.GetComponent<Camera>().enabled = true;
		_rightCam.GetComponent<Camera>().enabled = false;

        if (!isReversed)
        {
            _leftCam.GetComponent<Camera>().rect = new Rect(0, 0, 0.5f, 1);
            _rightCam.GetComponent<Camera>().rect = new Rect(0.5f, 0, 0.5f, 1);
        }
        else
        {
            _leftCam.GetComponent<Camera>().rect = new Rect(0.5f, 0, 0.5f, 1);
            _rightCam.GetComponent<Camera>().rect = new Rect(0f, 0, 0.5f, 1);
        }

		UpdateView ();
		SetParentCamera ();
	}

    void SetTopBottom(bool isReversed)
    {
        SetDefault();

        Camera camera = _cameraBody.NodalCamera;

        _leftCam.GetComponent<Camera>().targetTexture = null;
        _rightCam.GetComponent<Camera>().targetTexture = null;
        _leftCam.GetComponent<Camera>().depth = camera.depth + 1;
        _rightCam.GetComponent<Camera>().depth = camera.depth + 1;
        _leftCam.GetComponent<Camera>().enabled = true;
        _rightCam.GetComponent<Camera>().enabled = false;

        if (isReversed)
        {
            _leftCam.GetComponent<Camera>().rect = new Rect(0, 0, 1f, 0.5f);
            _rightCam.GetComponent<Camera>().rect = new Rect(0f, 0.5f, 1f, 0.5f);
        }
        else
        {
            _leftCam.GetComponent<Camera>().rect = new Rect(0f, 0.5f, 1f, 0.5f);
            _rightCam.GetComponent<Camera>().rect = new Rect(0, 0, 1f, 0.5f);
        }

        UpdateView();
        SetParentCamera();
    }
	
	void OnDrawGizmos () {
		
		if (ShowBody) {
			// Draw Near Plane Line
			Gizmos.color = Color.red;
			
			// draw eye one
			Matrix4x4 rotationMatrix = Matrix4x4.TRS(
				_leftCam.transform.position, _leftCam.transform.rotation, _leftCam.transform.lossyScale);
			
			Gizmos.matrix = rotationMatrix;
			Gizmos.DrawLine(Vector3.zero, Vector3.forward * 60);
			Gizmos.DrawWireSphere(Vector3.zero, 0.01f);
			Gizmos.DrawWireCube(Vector3.back * 0.06f, new Vector3(0.03f,0.04f,0.1f));
			
			// draw eye two
			rotationMatrix = Matrix4x4.TRS(
				_rightCam.transform.position, _rightCam.transform.rotation, _rightCam.transform.lossyScale);
			Gizmos.matrix = rotationMatrix;
			Gizmos.DrawLine(Vector3.zero, Vector3.forward * 60);
			Gizmos.DrawWireSphere(Vector3.zero, 0.01f);
			Gizmos.DrawWireCube(Vector3.back * 0.06f, new Vector3(0.03f,0.04f,0.1f));
			
			// draw rig
			Gizmos.matrix = Matrix4x4.TRS (transform.position, transform.rotation, transform.lossyScale);
			Gizmos.DrawWireCube(Vector3.zero, new Vector3(0.2f,0.1f,0.2f));
		}
	}
	
	void Update () {
		
		SetMode(_sstate);
		
		
		CallUpdate();
		
	}
	
	void CallUpdate () {
		SelectRig();
		Controls ();
		
		switch (_sstate) {
			case StereoState.Interlace: {
				
				CameraUpdate ();
				//Converge ();
			} break;
			case StereoState.ReversedInterlace: {
	
				CameraUpdate ();
				//Converge ();
			} break;
				
            //case StereoState.Shutter: {
            //    if (_leftCam.camera.enabled) {
            //        _rightCam.camera.enabled = true;
            //        _leftCam.camera.enabled = false;
            //    } else {
            //        _rightCam.camera.enabled = false;
            //        _leftCam.camera.enabled = true;
            //    }
				
            //} break;
			case StereoState.SideBySide: {
				_rightCam.GetComponent<Camera>().enabled = true;
				_leftCam.GetComponent<Camera>().enabled = true;
			} break;
            case StereoState.ReversedSideBySide:
                {
                    _rightCam.GetComponent<Camera>().enabled = true;
                    _leftCam.GetComponent<Camera>().enabled = true;
                } break;
            case StereoState.TopBottom:
                {
                    _rightCam.GetComponent<Camera>().enabled = true;
                    _leftCam.GetComponent<Camera>().enabled = true;
                } break;
            case StereoState.ReversedTopBottom:
                {
                    _rightCam.GetComponent<Camera>().enabled = true;
                    _leftCam.GetComponent<Camera>().enabled = true;
                } break;
			case StereoState.Anaglyph: {
				
				CameraUpdate ();
				//Converge ();
			} break;
		}
	}
	
	void SelectRig () {
		switch(_selectedRig) {
		case 0: {
			_minInteraxial = 0;
			_maxInteraxial = 0.07f;
			_minConvergence = -5;
			_maxConvergence = 3;
		}
			break;
		case 1: {
			_minInteraxial = 0;
			_maxInteraxial = .1f;
			_minConvergence = -1;
			_maxConvergence = 3;
		}
			break;
		case 2: {
			_minInteraxial = 0;
			_maxInteraxial = .2f;
			_minConvergence = 0;
			_maxConvergence = 3;
		}
			break;
		}
	}
	
	void Controls () {
		if (_interaxial < _maxInteraxial && Input.GetKey(KeyCode.E)) {
			_interaxial += Time.deltaTime * 0.1f;
			if (_interaxial > _maxInteraxial) _interaxial = _maxInteraxial;
		}
		
		if (_interaxial > _minInteraxial && Input.GetKey(KeyCode.Q)) {
			_interaxial -= Time.deltaTime * 0.1f;	
			if (_interaxial < _minInteraxial) _interaxial = _minInteraxial;
		}
		
		if (_convergence < _maxConvergence && Input.GetKey(KeyCode.LeftShift)) {
			_convergence += Time.deltaTime * 2;	
			if (_convergence > _maxConvergence) _convergence = _maxConvergence;
		}
		
		if (_convergence > _minConvergence && Input.GetKey(KeyCode.LeftControl)) {
			_convergence -= Time.deltaTime * 2;	
			if (_convergence < _minConvergence) _convergence = _minConvergence;
		}
		
		if (Input.GetKey (KeyCode.N)) {
			_cameraBody.FocusDistance += 10 * Time.deltaTime;	
		}
		
		if (_cameraBody.FocusDistance > 0 && Input.GetKey (KeyCode.B)) {
			_cameraBody.FocusDistance -= 10 * Time.deltaTime;	
		}
	}
	
	void CameraUpdate () {
		_leftCam.GetComponent<Camera>().fieldOfView = 		_cameraBody.NodalCamera.fieldOfView;
		_leftCam.GetComponent<Camera>().nearClipPlane =		_cameraBody.NodalCamera.nearClipPlane;
		_leftCam.GetComponent<Camera>().farClipPlane =		_cameraBody.NodalCamera.farClipPlane;
		
		_rightCam.GetComponent<Camera>().fieldOfView = 		_cameraBody.NodalCamera.fieldOfView;
		_rightCam.GetComponent<Camera>().nearClipPlane =	_cameraBody.NodalCamera.nearClipPlane;
		_rightCam.GetComponent<Camera>().farClipPlane =		_cameraBody.NodalCamera.farClipPlane;
	}
	
	void Converge () {
		Vector3 velocity = new Vector3(0,0,10f);
		
		_trackObject.transform.position = Vector3.SmoothDamp(
			_trackObject.transform.position, transform.position + (transform.forward * _cameraBody.FocusDistance), 
			ref velocity, 0.15f);	
	}
	
	void LateUpdate () { 
		UpdateView();
	}
	
	void UpdateView () {
		_leftCam.transform.parent = _cameraBody.NodalCamera.transform;
		_rightCam.transform.parent = _cameraBody.NodalCamera.transform; 
		
		_leftCam.transform.position = _cameraBody.NodalCamera.transform.position + 
			Vector3.Cross(_cameraBody.NodalCamera.transform.forward, _cameraBody.NodalCamera.transform.up) * (_interaxial /2f);
		_rightCam.transform.position = _cameraBody.NodalCamera.transform.position + 
			-Vector3.Cross(_cameraBody.NodalCamera.transform.forward, _cameraBody.NodalCamera.transform.up) * (_interaxial /2f);
		
		_leftCam.GetComponent<Camera>().projectionMatrix = _cameraBody.NodalCamera.projectionMatrix;
		_rightCam.GetComponent<Camera>().projectionMatrix = _cameraBody.NodalCamera.projectionMatrix;
		
		if (_convergence > _maxConvergence) _convergence = _maxConvergence;
		if (_convergence < _minConvergence) _convergence = _minConvergence;
		
		_leftCam.transform.localRotation = Quaternion.identity;
		_leftCam.transform.Rotate(_leftCam.transform.up, _convergence);
		_rightCam.transform.localRotation = Quaternion.identity;
		_rightCam.transform.Rotate(_rightCam.transform.up, - _convergence);
	}
	
	
	public void SetMode (StereoState state) {
		if (!_stereoMaterial) _stereoMaterial = (Material)Resources.Load("Stereo3D");
		
		_sstate = state;
		
		switch (state) {
		case StereoState.Interlace: {
			SetInterlace();
			GetComponentInChildren<Stereo3DRenderer>().enabled = true;
		} break;
		case StereoState.ReversedInterlace: {
			SetReversedInterlace();
			GetComponentInChildren<Stereo3DRenderer>().enabled = true;
		} break;	
        //case StereoState.Shutter: {
        //    SetShutter();
        //    GetComponentInChildren<Stereo3DRenderer>().enabled = false;
        //} break;
		case StereoState.SideBySide: {
			SetSideBySide(false);
			GetComponentInChildren<Stereo3DRenderer>().enabled = false;
		} break;
        case StereoState.ReversedSideBySide:
            {
                SetSideBySide(true);
                GetComponentInChildren<Stereo3DRenderer>().enabled = false;
            } break;
        case StereoState.TopBottom:
            {
                SetTopBottom(false);
                GetComponentInChildren<Stereo3DRenderer>().enabled = false;
            } break;
        case StereoState.ReversedTopBottom:
            {
                SetTopBottom(true);
                GetComponentInChildren<Stereo3DRenderer>().enabled = false;
            } break;
		case StereoState.Anaglyph: {
			SetAnaglyph();
			GetComponentInChildren<Stereo3DRenderer>().enabled = true;
		} break;
		}
	}
}

public enum StereoState {
	Interlace,
	ReversedInterlace,
	//Shutter,
	SideBySide,
    ReversedSideBySide,
    TopBottom,
    ReversedTopBottom,
	Anaglyph
}