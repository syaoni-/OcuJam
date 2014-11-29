using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public enum PLAYER_STATE{
		NONE,
		MOVE,
		DEAD
	}

	PLAYER_STATE currentState = PLAYER_STATE.MOVE;
	PLAYER_STATE nextState = PLAYER_STATE.NONE;

	private Vector3 FRONT_WALK_DIRECTION = new Vector3(0, 1, 1);
	public float walkSpeed = 0.5f;
	public float angleSpeed = 2.0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		switch (currentState) {
		case PLAYER_STATE.MOVE:
			break;
		case PLAYER_STATE.DEAD:
			break;
		}

		if (nextState != PLAYER_STATE.NONE) {
			switch(nextState){

			case PLAYER_STATE.MOVE:
				break;
			case PLAYER_STATE.DEAD:
				break;

			}
		}
	
	}

	void LateUpdate(){

		switch (currentState) {
		case PLAYER_STATE.MOVE:

			/*  Move and Angle*/
			this.transform.position += this.transform.right * InputManager.HORIZONTAL_L * walkSpeed;
			this.transform.position += new Vector3(this.transform.forward.x * InputManager.VERTICLE_L * walkSpeed, 0, this.transform.forward.z * InputManager.VERTICLE_L * walkSpeed);//this.transform.forward * InputManager.VERTICLE_L * walkSpeed;
			Debug.Log("X : "+this.transform.eulerAngles.x);
			Debug.Log("Cos : "+Mathf.Cos(this.transform.eulerAngles.x));
			float nextAngleX = this.transform.eulerAngles.x + InputManager.VERTICLE_R;
			if (!(70 < nextAngleX && nextAngleX < 290))
					this.transform.eulerAngles += new Vector3(InputManager.VERTICLE_R, InputManager.HORIZONTAL_R, 0) * angleSpeed;
			break;
		case PLAYER_STATE.DEAD:
			break;
		}
	}
}