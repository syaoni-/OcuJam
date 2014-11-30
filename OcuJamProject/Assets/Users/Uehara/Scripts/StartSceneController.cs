using UnityEngine;
using System.Collections;

public class StartSceneController : MonoBehaviour {

	private void OnTriggerEnter(Collider bullet){
		SoundManager.Instance.playOneSE(0);
		FadeManager.Instance.LoadLevel("Test",3.0f);
	}
}
