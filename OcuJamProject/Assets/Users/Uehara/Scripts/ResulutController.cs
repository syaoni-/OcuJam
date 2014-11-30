using UnityEngine;
using System.Collections;

public class ResulutController : MonoBehaviour {

	private void OnTriggerEnter(Collider bullet){
		SoundManager.Instance.playOneSE(0);
		FadeManager.Instance.LoadLevel("Title",1.0f);
	}
}
