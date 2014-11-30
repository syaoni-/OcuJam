using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	private enum GAME_STATE{
		NONE,
		START,
		PLAY,
		GAMEOVER
	}
	private GAME_STATE currentState = GAME_STATE.START;
	private GAME_STATE nextState = GAME_STATE.NONE;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate(){

	}
}
