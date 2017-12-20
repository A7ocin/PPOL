using UnityEngine;
using System.Collections;
//using UnityEditor.Events;

public enum Weapon{
	UNARMED = 0,
	RELAX = 8
}

public class RPGCharacterControllerFREE : MonoBehaviour{
	#region Variables

	//Components
	Rigidbody rb;
	protected Animator animator;
	public GameObject target;
	[HideInInspector]
	public Vector3 targetDashDirection;
	public Camera sceneCamera;
	public bool useNavMesh = false;
	private UnityEngine.AI.NavMeshAgent agent;
	private float navMeshSpeed;
	public Transform goal;

	//jumping variables
	public float gravity = -9.8f;
	[HideInInspector]
	public bool canJump;
	bool isJumping = false;
	[HideInInspector]
	public bool isGrounded;
	public float jumpSpeed = 12;
	public float doublejumpSpeed = 12;
	bool doublejumping = true;
	[HideInInspector]
	public bool canDoubleJump = false;
	[HideInInspector]
	public bool isDoubleJumping = false;
	bool doublejumped = false;
	bool isFalling;
	bool startFall;
	float fallingVelocity = -1f;

	// Used for continuing momentum while in air
	public float inAirSpeed = 8f;
	float maxVelocity = 2f;
	float minVelocity = -2f;

	//rolling variables
	public float rollSpeed = 8;
	bool isRolling = false;
	public float rollduration;

	//movement variables
	[HideInInspector]
	public bool canMove = true;
	public float walkSpeed = 1.35f;
	float moveSpeed;
	public float runSpeed = 6f;
	float rotationSpeed = 40f;
	Vector3 inputVec;
	Vector3 newVelocity;

	//Weapon and Shield
	[HideInInspector]
	public Weapon weapon;
	int rightWeapon = 0;
	int leftWeapon = 0;
	[HideInInspector]
	public bool isRelax = false;

	//isStrafing/action variables
	[HideInInspector]
	public bool canAction = true;
	[HideInInspector]
	public bool isStrafing = false;
	[HideInInspector]
	public bool isDead = false;
	public float knockbackMultiplier = 1f;
	bool isKnockback;

	//inputs variables
	float inputHorizontal = 0f;
	float inputVertical = 0f;
	float inputDashVertical = 0f;
	float inputDashHorizontal = 0f;
	float inputBlock = 0f;
	bool inputLightHit;
	bool inputDeath;
	bool inputAttackR;
	bool inputAttackL;
	bool inputCastL;
	bool inputCastR;
	bool inputJump;

	#endregion

	#region Initialization and Inputs

	void Start(){
		//set the animator component
		animator = GetComponentInChildren<Animator>();
		rb = GetComponent<Rigidbody>();
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
		agent.enabled = false;
	}

	void Inputs(){
		inputDashHorizontal = Input.GetAxisRaw("DashHorizontal");
		inputDashVertical = Input.GetAxisRaw("DashVertical");
		inputHorizontal = Input.GetAxisRaw("Horizontal");
		inputVertical = Input.GetAxisRaw("Vertical");
		inputLightHit = Input.GetButtonDown("LightHit");
		inputDeath = Input.GetButtonDown("Death");
		inputAttackL = Input.GetButtonDown("AttackL");
		inputAttackR = Input.GetButtonDown("AttackR");
		inputCastL = Input.GetButtonDown("CastL");
		inputCastR = Input.GetButtonDown("CastR");
		inputBlock = Input.GetAxisRaw("TargetBlock");
		inputJump = Input.GetButtonDown("Jump");
	}

	#endregion

	#region Updates

	void Update(){
		//make sure there is animator on character
		if(animator){
			Inputs();
			if(canMove && !isDead && !useNavMesh){
				CameraRelativeMovement();
			} 
			Rolling();
			Jumping();
			if(inputLightHit && canAction && isGrounded){
				GetHit();
			}
			if(inputDeath && canAction && isGrounded){
				if(!isDead){
					StartCoroutine(_Death());
				}
				else{
					StartCoroutine(_Revive());
				}
			}
			if(inputAttackL && canAction && isGrounded){
				Attack(1);
			}
			if(inputAttackR && canAction && isGrounded){
				Attack(2);
			}
			if(inputCastL && canAction && isGrounded && !isStrafing){
				AttackKick(1);
			}
			if(inputCastR && canAction && isGrounded && !isStrafing){
				AttackKick(2);
			}
			//if strafing
			if((Input.GetKey(KeyCode.LeftShift) || inputBlock > 0.1f) && canAction){  
				isStrafing = true;
				animator.SetBool("Strafing", true);
				if(inputCastL && canAction && isGrounded){
					CastAttack(1);
				}
				if(inputCastR && canAction && isGrounded){
					CastAttack(2);
				}
			}
			else{
				isStrafing = false;
				animator.SetBool("Strafing", false);
			}
			//Navmesh
			if(Input.GetMouseButtonDown(0))
			{
				if(useNavMesh)
				{
					RaycastHit hit;
					if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100)) {
						agent.destination = hit.point;
					}
				}
			}
		}
		else{
			Debug.Log("ERROR: There is no animator for character.");
		}
		if(useNavMesh){
			agent.enabled = true;
			navMeshSpeed = agent.velocity.magnitude;
		}
		else{
			agent.enabled = false;
		}
		//Slow time
		if(Input.GetKeyDown(KeyCode.T)){
			if(Time.timeScale != 1){
				Time.timeScale = 1;
			}
			else{
				Time.timeScale = 0.15f;
			}
		}
		//Pause
		if(Input.GetKeyDown(KeyCode.P)){
			if(Time.timeScale != 1){
				Time.timeScale = 1;
			}
			else{
				Time.timeScale = 0f;
			}
		}
	}

	void FixedUpdate(){
		CheckForGrounded();
		//apply gravity force
		rb.AddForce(0, gravity, 0, ForceMode.Acceleration);
		AirControl();
		//check if character can move
		if(canMove && !isDead){
			moveSpeed = UpdateMovement();  
		}
		//check if falling
		if(rb.velocity.y < fallingVelocity && useNavMesh != true){
			isFalling = true;
			animator.SetInteger("Jumping", 2);
			canJump = false;
		}
		else{
			isFalling = false;
		}
	}

	//get velocity of rigid body and pass the value to the animator to control the animations
	void LateUpdate(){
		if(!useNavMesh){
			//Get local velocity of charcter
			float velocityXel = transform.InverseTransformDirection(rb.velocity).x;
			float velocityZel = transform.InverseTransformDirection(rb.velocity).z;
			//Update animator with movement values
			animator.SetFloat("Velocity X", velocityXel / runSpeed);
			animator.SetFloat("Velocity Z", velocityZel / runSpeed);
			//if character is alive and can move, set our animator
			if(!isDead && canMove){
				if(moveSpeed > 0){
					animator.SetBool("Moving", true);
				}
				else{
					animator.SetBool("Moving", false);
				}
			}
		}
		else{
			animator.SetFloat("Velocity X", agent.velocity.sqrMagnitude);
			animator.SetFloat("Velocity Z", agent.velocity.sqrMagnitude);
			if(navMeshSpeed > 0){
				animator.SetBool("Moving", true);
			}
			else{
				animator.SetBool("Moving", false);
			}
		}
	}

	#endregion

	#region UpdateMovement

	void CameraRelativeMovement(){
		//converts control input vectors into camera facing vectors
		Transform cameraTransform = sceneCamera.transform;
		//Forward vector relative to the camera along the x-z plane   
		Vector3 forward = cameraTransform.TransformDirection(Vector3.forward);
		forward.y = 0;
		forward = forward.normalized;
		//Right vector relative to the camera always orthogonal to the forward vector
		Vector3 right = new Vector3(forward.z, 0, -forward.x);
		if(!isRolling){
			targetDashDirection = inputDashHorizontal * right + inputDashVertical * -forward;
		}
		inputVec = inputHorizontal * right + inputVertical * forward;
	}

	//rotate character towards direction moved
	void RotateTowardsMovementDir(){
		if(inputVec != Vector3.zero && !isStrafing && !isRolling){
			transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(inputVec), Time.deltaTime * rotationSpeed);
		}
	}

	float UpdateMovement(){
		if(!useNavMesh){
			CameraRelativeMovement();
		}
		Vector3 motion = inputVec;
		if(isGrounded){
			//reduce input for diagonal movement
			if(motion.magnitude > 1){
				motion.Normalize();
			}
			if(canMove){
				//set speed by walking / running
				if(isStrafing){
					newVelocity = motion * walkSpeed;
				}
				else{
					newVelocity = motion * runSpeed;
				}
				//if rolling use rolling speed and direction
				if(isRolling){
					//force the dash movement to 1
					targetDashDirection.Normalize();
					newVelocity = rollSpeed * targetDashDirection;
				}
			}
		}
		else{
			//if we are falling use momentum
			newVelocity = rb.velocity;
		}
		if(!isStrafing || !canMove){
			RotateTowardsMovementDir();
		}
		if(isStrafing && !isRelax){
			//make character point at target
			Quaternion targetRotation;
			Vector3 targetPos = target.transform.position;
			targetRotation = Quaternion.LookRotation(targetPos - new Vector3(transform.position.x, 0, transform.position.z));
			transform.eulerAngles = Vector3.up * Mathf.MoveTowardsAngle(transform.eulerAngles.y, targetRotation.eulerAngles.y, (rotationSpeed * Time.deltaTime) * rotationSpeed);
		}
		newVelocity.y = rb.velocity.y;
		rb.velocity = newVelocity;
		//return a movement value for the animator
		return inputVec.magnitude;
	}

	#endregion

	#region Jumping

	//checks if character is within a certain distance from the ground, and markes it IsGrounded
	void CheckForGrounded(){
		if(!useNavMesh){
			float distanceToGround;
			float threshold = .45f;
			RaycastHit hit;
			Vector3 offset = new Vector3(0, .4f, 0);
			if(Physics.Raycast((transform.position + offset), -Vector3.up, out hit, 100f)){
				distanceToGround = hit.distance;
				if(distanceToGround < threshold){
					isGrounded = true;
					canJump = true;
					startFall = false;
					doublejumped = false;
					canDoubleJump = false;
					isFalling = false;
					if(!isJumping){
						animator.SetInteger("Jumping", 0);
					}
				}
				else{
					isGrounded = false;
				}
			}
		}
		else{
			isGrounded = true;
		}
	}

	void Jumping(){
		if(isGrounded){
			if(canJump && inputJump){
				StartCoroutine(_Jump());
			}
		}
		else{    
			canDoubleJump = true;
			canJump = false;
			if(isFalling){
				//set the animation back to falling
				animator.SetInteger("Jumping", 2);
				//prevent from going into land animation while in air
				if(!startFall){
					animator.SetTrigger("JumpTrigger");
					startFall = true;
				}
			}
			if(canDoubleJump && doublejumping && inputJump && !doublejumped && isFalling){
				// Apply the current movement to launch velocity
				rb.velocity += doublejumpSpeed * Vector3.up;
				animator.SetInteger("Jumping", 3);
				doublejumped = true;
			}
		}
	}

	public IEnumerator _Jump(){
		isJumping = true;
		animator.SetInteger("Jumping", 1);
		animator.SetTrigger("JumpTrigger");
		// Apply the current movement to launch velocity
		rb.velocity += jumpSpeed * Vector3.up;
		canJump = false;
		yield return new WaitForSeconds(.5f);
		isJumping = false;
	}

	void AirControl(){
		if(!isGrounded){
			CameraRelativeMovement();
			Vector3 motion = inputVec;
			motion *= (Mathf.Abs(inputVec.x) == 1 && Mathf.Abs(inputVec.z) == 1) ? 0.7f : 1;
			rb.AddForce(motion * inAirSpeed, ForceMode.Acceleration);
			//limit the amount of velocity we can achieve
			float velocityX = 0;
			float velocityZ = 0;
			if(rb.velocity.x > maxVelocity){
				velocityX = GetComponent<Rigidbody>().velocity.x - maxVelocity;
				if(velocityX < 0){
					velocityX = 0;
				}
				rb.AddForce(new Vector3(-velocityX, 0, 0), ForceMode.Acceleration);
			}
			if(rb.velocity.x < minVelocity){
				velocityX = rb.velocity.x - minVelocity;
				if(velocityX > 0){
					velocityX = 0;
				}
				rb.AddForce(new Vector3(-velocityX, 0, 0), ForceMode.Acceleration);
			}
			if(rb.velocity.z > maxVelocity){
				velocityZ = rb.velocity.z - maxVelocity;
				if(velocityZ < 0){
					velocityZ = 0;
				}
				rb.AddForce(new Vector3(0, 0, -velocityZ), ForceMode.Acceleration);
			}
			if(rb.velocity.z < minVelocity){
				velocityZ = rb.velocity.z - minVelocity;
				if(velocityZ > 0){
					velocityZ = 0;
				}
				rb.AddForce(new Vector3(0, 0, -velocityZ), ForceMode.Acceleration);
			}
		}
	}

	#endregion

	#region MiscMethods

	//0 = No side
	//1 = Left
	//2 = Right
	//3 = Dual
	public void Attack(int attackSide){
		if(canAction){
			if(weapon == Weapon.UNARMED){
				int maxAttacks = 3;
				int attackNumber = 0;
				if(attackSide == 1 || attackSide == 3){
					attackNumber = Random.Range(3, maxAttacks);
				}
				else if(attackSide == 2){
					attackNumber = Random.Range(6, maxAttacks + 3);
				}
				if(isGrounded){
					if(attackSide != 3){
						animator.SetTrigger("Attack" + (attackNumber).ToString() + "Trigger");
						if(leftWeapon == 12 || leftWeapon == 14 || rightWeapon == 13 || rightWeapon == 15){
							StartCoroutine(_LockMovementAndAttack(0, .75f));
						}
						else{
							StartCoroutine(_LockMovementAndAttack(0, .6f));
						}
					}
					else{
						animator.SetTrigger("AttackDual" + (attackNumber).ToString() + "Trigger");
						StartCoroutine(_LockMovementAndAttack(0, .75f));
					}
				}
			}
			//2 handed weapons
			else{
				if(isGrounded){
					animator.SetTrigger("Attack" + (6).ToString() + "Trigger");
					StartCoroutine(_LockMovementAndAttack(0, .85f));
				}
			}
		}
	}

	public void AttackKick(int kickSide){
		if(isGrounded){
			if(kickSide == 1){
				animator.SetTrigger("AttackKick1Trigger");
			}
			else{
				animator.SetTrigger("AttackKick2Trigger");
			}
			StartCoroutine(_LockMovementAndAttack(0, .8f));
		}
	}

	//0 = No side
	//1 = Left
	//2 = Right
	//3 = Dual
	public void CastAttack(int attackSide){
		if(weapon == Weapon.UNARMED){
			int maxAttacks = 3;
			if(attackSide == 1){
				int attackNumber = Random.Range(0, maxAttacks);
				if(isGrounded){
					animator.SetTrigger("CastAttack" + (attackNumber + 1).ToString() + "Trigger");
					StartCoroutine(_LockMovementAndAttack(0, .8f));
				}
			}
			if(attackSide == 2){
				int attackNumber = Random.Range(3, maxAttacks + 3);
				if(isGrounded){
					animator.SetTrigger("CastAttack" + (attackNumber + 1).ToString() + "Trigger");
					StartCoroutine(_LockMovementAndAttack(0, .8f));
				}
			}
			if(attackSide == 3){
				int attackNumber = Random.Range(0, maxAttacks);
				if(isGrounded){
					animator.SetTrigger("CastDualAttack" + (attackNumber + 1).ToString() + "Trigger");
					StartCoroutine(_LockMovementAndAttack(0, 1f));
				}
			}
		} 
	}

	public void GetHit(){
		int hits = 5;
		int hitNumber = Random.Range(0, hits);
		animator.SetTrigger("GetHit" + (hitNumber + 1).ToString() + "Trigger");
		StartCoroutine(_LockMovementAndAttack(.1f, .4f));
		//apply directional knockback force
		if(hitNumber <= 1){
			StartCoroutine(_Knockback(-transform.forward, 8, 4));
		}
		else if(hitNumber == 2){
			StartCoroutine(_Knockback(transform.forward, 8, 4));
		}
		else if(hitNumber == 3){
			StartCoroutine(_Knockback(transform.right, 8, 4));
		}
		else if(hitNumber == 4){
			StartCoroutine(_Knockback(-transform.right, 8, 4));
		}
	}

	IEnumerator _Knockback(Vector3 knockDirection, int knockBackAmount, int variableAmount){
		isKnockback = true;
		StartCoroutine(_KnockbackForce(knockDirection, knockBackAmount, variableAmount));
		yield return new WaitForSeconds(.1f);
		isKnockback = false;
	}

	IEnumerator _KnockbackForce(Vector3 knockDirection, int knockBackAmount, int variableAmount){
		while(isKnockback){
			rb.AddForce(knockDirection * ((knockBackAmount + Random.Range(-variableAmount, variableAmount)) * (knockbackMultiplier * 10)), ForceMode.Impulse);
			yield return null;
		}
	}

	public IEnumerator _Death(){
		animator.SetTrigger("Death1Trigger");
		StartCoroutine(_LockMovementAndAttack(.1f, 1.5f));
		isDead = true;
		animator.SetBool("Moving", false);
		inputVec = new Vector3(0, 0, 0);
		yield return null;
	}

	public IEnumerator _Revive(){
		animator.SetTrigger("Revive1Trigger");
		isDead = false;
		yield return null;
	}

	//Animation Events
	void Hit(){

	}

	void FootL(){

	}

	void FootR(){

	}

	void Jump(){

	}

	void Land(){

	}

	#endregion

	#region Rolling

	void Rolling(){
		if(!isRolling && isGrounded){
			if(Input.GetAxis("DashVertical") > .5 || Input.GetAxis("DashVertical") < -.5 || Input.GetAxis("DashHorizontal") > .5 || Input.GetAxis("DashHorizontal") < -.5){
				StartCoroutine(_DirectionalRoll(Input.GetAxis("DashVertical"), Input.GetAxis("DashHorizontal")));
			}
		}
	}

	public IEnumerator _DirectionalRoll(float x, float v){
		//check which way the dash is pressed relative to the character facing
		float angle = Vector3.Angle(targetDashDirection, -transform.forward);
		float sign = Mathf.Sign(Vector3.Dot(transform.up, Vector3.Cross(targetDashDirection, transform.forward)));
		// angle in [-179,180]
		float signed_angle = angle * sign;
		//angle in 0-360
		float angle360 = (signed_angle + 180) % 360;
		//deternime the animation to play based on the angle
		if(angle360 > 315 || angle360 < 45){
			StartCoroutine(_Roll(1));
		}
		if(angle360 > 45 && angle360 < 135){
			StartCoroutine(_Roll(2));
		}
		if(angle360 > 135 && angle360 < 225){
			StartCoroutine(_Roll(3));
		}
		if(angle360 > 225 && angle360 < 315){
			StartCoroutine(_Roll(4));
		}
		yield return null;
	}

	public IEnumerator _Roll(int rollNumber){
		if(rollNumber == 1){
			animator.SetTrigger("RollForwardTrigger");
		}
		if(rollNumber == 2){
			animator.SetTrigger("RollRightTrigger");
		}
		if(rollNumber == 3){
			animator.SetTrigger("RollBackwardTrigger");
		}
		if(rollNumber == 4){
			animator.SetTrigger("RollLeftTrigger");
		}
		isRolling = true;
		yield return new WaitForSeconds(rollduration);
		isRolling = false;
	}

	#endregion

	#region _Coroutines

	//method to keep character from moveing while attacking, etc
	public IEnumerator _LockMovementAndAttack(float delayTime, float lockTime){
		yield return new WaitForSeconds(delayTime);
		canAction = false;
		canMove = false;
		animator.SetBool("Moving", false);
		rb.velocity = Vector3.zero;
		rb.angularVelocity = Vector3.zero;
		inputVec = new Vector3(0, 0, 0);
		animator.applyRootMotion = true;
		yield return new WaitForSeconds(lockTime);
		canAction = true;
		canMove = true;
		animator.applyRootMotion = false;
	}

	#endregion
}