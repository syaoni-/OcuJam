using UnityEngine;
using System.Collections;

public class InputManager : SingletonMonoBehaviour<InputManager> {

	public void Awake()
	{
		if(this != Instance)
		{
			Destroy(this);
			return;
		}
		
		DontDestroyOnLoad(this.gameObject);
	}    

	public static float HORIZONTAL_L = 0.0f; //Left JoyStyck Horizontal
	public static float VERTICLE_L = 0.0f; //Left JoyStick Vertical
	public static float HORIZONTAL_R = 0.0f; //Right JoyStick Horizontal
	public static float VERTICLE_R = 0.0f; //

	public static bool isShot;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		isShot = false;
		HORIZONTAL_L = 0.0f;
		VERTICLE_L = 0.0f;
		HORIZONTAL_R = 0.0f;
		VERTICLE_R = 0.0f;

		if (Input.GetButtonDown ("Select"))
						isShot = true;

		if (Input.GetAxis("LeftJoyStickH") != 0.0f)
			HORIZONTAL_L = Input.GetAxis("LeftJoyStickH");

		if (Input.GetAxis ("LeftJoyStickV") != 0.0f) {
			VERTICLE_L = -Input.GetAxis ("LeftJoyStickV");  
		}

		if (Input.GetAxis("RightJoyStickH") != 0.0f)
				HORIZONTAL_R = Input.GetAxis("RightJoyStickH");

		if (Input.GetAxis ("RightJoyStickV") != 0.0f)
				VERTICLE_R = Input.GetAxis ("RightJoyStickV");
	}
}
