using UnityEngine;
using System.Collections;

public class EnemyTest : MonoBehaviour {

	public Transform targetPos;
	private NavMeshAgent agent;

	// Use this for initialization
	void Start () {
		agent = GetComponent<NavMeshAgent>();
	}
	
	// Update is called once per frame
	void Update () {
		agent.SetDestination(targetPos.position);
	}
}
