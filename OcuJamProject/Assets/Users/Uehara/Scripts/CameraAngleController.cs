using UnityEngine;
using System.Collections;

public class CameraAngleController : MonoBehaviour {

	public float angleSpeed = 2.0f;

	void LateUpdate(){
		this.transform.eulerAngles += new Vector3(0, InputManager.HORIZONTAL_R, 0) * angleSpeed;
	}
}
