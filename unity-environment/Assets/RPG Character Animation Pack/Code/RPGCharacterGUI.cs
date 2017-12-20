using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class RPGCharacterGUI : MonoBehaviour{
	RPGCharacterControllerFREE rpgCharacter;
	bool useNav;
	bool navToggle;

	void Start(){
		rpgCharacter = GetComponent<RPGCharacterControllerFREE>();
	}

	void OnGUI(){
		if(!rpgCharacter.isDead){
			if(rpgCharacter.canAction && !rpgCharacter.isRelax && !rpgCharacter.useNavMesh){
				if(rpgCharacter.isGrounded){
					if(GUI.Button(new Rect(25, 15, 100, 30), "Roll Forward")){
						rpgCharacter.targetDashDirection = transform.forward;
						StartCoroutine(rpgCharacter._Roll(1));
					}
					if(GUI.Button(new Rect(130, 15, 100, 30), "Roll Backward")){
						rpgCharacter.targetDashDirection = -transform.forward;
						StartCoroutine(rpgCharacter._Roll(3));
					}
					if(GUI.Button(new Rect(25, 45, 100, 30), "Roll Left")){
						rpgCharacter.targetDashDirection = -transform.right;
						StartCoroutine(rpgCharacter._Roll(4));
					}
					if(GUI.Button(new Rect(130, 45, 100, 30), "Roll Right")){
						rpgCharacter.targetDashDirection = transform.right;
						StartCoroutine(rpgCharacter._Roll(2));
					}
					//ATTACK LEFT
					if(GUI.Button(new Rect(25, 85, 100, 30), "Attack L")){
						rpgCharacter.Attack(1);
					}
					//ATTACK RIGHT
					if(GUI.Button(new Rect(130, 85, 100, 30), "Attack R")){
						rpgCharacter.Attack(2);
					}
					if(rpgCharacter.weapon == Weapon.UNARMED){
						if(GUI.Button(new Rect(25, 115, 100, 30), "Left Kick")){
							rpgCharacter.AttackKick(1);
						}
						if(GUI.Button(new Rect(130, 115, 100, 30), "Right Kick")){
							rpgCharacter.AttackKick(2);
						}
					}
					if(GUI.Button(new Rect(30, 240, 100, 30), "Get Hit")){
						rpgCharacter.GetHit();
					}
				}
				if(rpgCharacter.canJump || rpgCharacter.canDoubleJump){
					if(rpgCharacter.isGrounded){
						if(GUI.Button(new Rect(25, 165, 100, 30), "Jump")){
							if(rpgCharacter.canJump && rpgCharacter.isGrounded){
								StartCoroutine(rpgCharacter._Jump());
							}
						}
					}
					else{
						if(GUI.Button(new Rect(25, 165, 100, 30), "Double Jump")){
							if(rpgCharacter.canDoubleJump && !rpgCharacter.isDoubleJumping){
								StartCoroutine(rpgCharacter._Jump());
							}
						}
					}
				}
				if(rpgCharacter.isGrounded){
					if(GUI.Button(new Rect(30, 270, 100, 30), "Death")){
						StartCoroutine(rpgCharacter._Death());
					}
				}
			}
			//Character NavMesh navigation
			useNav = GUI.Toggle(new Rect(25, 200, 100, 30), useNav, "Use NavMesh");
			if(useNav)
			{
				if(navToggle == false)
				{
					rpgCharacter.useNavMesh = true;
					navToggle = true;
				}
			}
			else
			{
				rpgCharacter.useNavMesh = false;
				navToggle = false;
			}
		}
		if(rpgCharacter.isDead){
			if(GUI.Button(new Rect(30, 270, 100, 30), "Revive")){
				StartCoroutine(rpgCharacter._Revive());
			}
		}
	}
}