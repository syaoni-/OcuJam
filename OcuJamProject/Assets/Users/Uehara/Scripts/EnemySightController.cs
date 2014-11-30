using UnityEngine;
using System.Collections;

public class EnemySightController : MonoBehaviour {

	private void OnTriggerEnter(Collider other){
		Debug.Log ("hoge");
		if (other.gameObject.tag == "Player") {
			this.transform.parent.gameObject.GetComponent<Enemy>().FindPlayer(other.gameObject);
		}
	}
}
