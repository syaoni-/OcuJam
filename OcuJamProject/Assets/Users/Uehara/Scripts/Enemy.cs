using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {

	private NavMeshAgent agent;

	public Transform[] roundPos; //BadName
	private Transform nextRoundPos; //BadName
	[SerializeField]private int nextRoundNum = 0; //Bad name
	[SerializeField]private int roundMaxNum;
	private const float ROUND_STOP_DISTANCE = 2.0f;

	public float STOP_TIME;
	private float sceneTime = 0.0f;

	public GameObject burstEffect;

	private enum ENEMY_STATE{
		NONE,
		STOP,
		MOVE,
		DEAD
	}
	[SerializeField]private ENEMY_STATE currentState = ENEMY_STATE.STOP;
	private ENEMY_STATE nextState = ENEMY_STATE.NONE;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
		roundMaxNum = roundPos.Length - 1;
		nextRoundPos = roundPos[0];
	}
	
	// Update is called once per frame
	void Update () {

		switch(currentState){
		case ENEMY_STATE.STOP:
			sceneTime += Time.deltaTime;
			if (sceneTime > STOP_TIME) {
				nextState = ENEMY_STATE.MOVE;
				sceneTime = 0.0f;
			}
			break;
		case ENEMY_STATE.MOVE:
			float distance = Vector3.Distance(this.gameObject.transform.position, nextRoundPos.position);
			if (distance < ROUND_STOP_DISTANCE)
				nextState = ENEMY_STATE.STOP;
			break;
		case ENEMY_STATE.DEAD:
			break;
		}


		if (nextState != ENEMY_STATE.NONE) {
			switch(nextState){
			case ENEMY_STATE.STOP:
				break;

			case ENEMY_STATE.MOVE:
				nextRoundNum++;
				if (nextRoundNum > roundMaxNum)
					nextRoundNum = 0;
				nextRoundPos = roundPos[nextRoundNum];
				break;

			case ENEMY_STATE.DEAD:
				break;
			}
			currentState = nextState;
			nextState = ENEMY_STATE.NONE;
		}
	}


	void LateUpdate(){
		switch(currentState){
		case ENEMY_STATE.STOP:
			break;
		case ENEMY_STATE.MOVE:
			agent.SetDestination(nextRoundPos.position);
			break;
		case ENEMY_STATE.DEAD:
			break;
		}
	}


	private void OnCollisionEnter(Collision other){
		if (other.gameObject.tag == "Bullet") {
			Instantiate(burstEffect, this.transform.position, this.transform.rotation);
			Object.Destroy (this.gameObject);
		}
	}
}
