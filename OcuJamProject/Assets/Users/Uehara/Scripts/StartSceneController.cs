using UnityEngine;
using System.Collections;

public class StartSceneController : MonoBehaviour {

	private void OnTriggerEnter(Collider bullet){
		FadeManager.Instance.LoadLevel("Test",1.0f);
	}
}
