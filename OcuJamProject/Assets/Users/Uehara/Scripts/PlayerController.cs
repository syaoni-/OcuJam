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

	public float walkSpeed = 0.5f;

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
			this.transform.position += this.transform.right * InputManager.HORIZONTAL_L * walkSpeed;
			this.transform.position += this.transform.forward * InputManager.VERTICLE_L * walkSpeed;
			this.transform.eulerAngles += new Vector3(InputManager.VERTICLE_R, InputManager.HORIZONTAL_R, 0);
			break;
		case PLAYER_STATE.DEAD:
			break;
		}
	}
}