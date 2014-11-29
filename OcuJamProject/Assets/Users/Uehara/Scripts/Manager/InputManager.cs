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

	public static float h;
	public static float v;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Select"))
				Debug.Log("hoge");
	}
}
