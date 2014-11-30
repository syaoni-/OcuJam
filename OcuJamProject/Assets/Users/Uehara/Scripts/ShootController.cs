using UnityEngine;
using System.Collections;

public class ShootController : MonoBehaviour {

	public float shootInterval = 1.0f;
	private float reloadTime = 0.0f;

	public GameObject bullet;
	public GameObject shootEffect;

	public enum SHOOT_STATE{
		NONE,
		SHOOT,
		RELOAD
	}
	private SHOOT_STATE currentState = SHOOT_STATE.SHOOT;
	private SHOOT_STATE nextState = SHOOT_STATE.NONE;

	public AudioClip shootSE;

	// Use this for initialization
	void Start () {
		reloadTime = shootInterval;
	}
	
	// Update is called once per frame
	void Update () {

		switch (currentState) {
		case SHOOT_STATE.SHOOT:
			if (InputManager.isShot)
				nextState = SHOOT_STATE.RELOAD;
			break;
		case SHOOT_STATE.RELOAD:
			reloadTime -= Time.deltaTime;
			if (reloadTime < 0) {
				reloadTime = shootInterval;
				nextState = SHOOT_STATE.SHOOT;
			}
			break;
		}

		if (nextState != SHOOT_STATE.NONE) {
			switch(nextState){
			case SHOOT_STATE.SHOOT:
				break;

			case SHOOT_STATE.RELOAD:
				Instantiate(bullet, this.transform.position, this.transform.rotation);
				audio.PlayOneShot(shootSE);
				break;
			}
			currentState = nextState;
			nextState = SHOOT_STATE.NONE;
		}
	
	}

	void LateUpdate(){

		switch(currentState){
		case SHOOT_STATE.SHOOT:
			break;
		case SHOOT_STATE.RELOAD:
			break;
		}
	}
}
