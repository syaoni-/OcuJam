using UnityEngine;
using System.Collections;

public class GoalTriggerController : MonoBehaviour {

	private void OnTriggerEnter(Collider other){
		if (other.tag == "Player") {
			FadeManager.Instance.LoadLevel("GOAL",1.0f);
		}
	}
}
