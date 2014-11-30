using UnityEngine;
using System.Collections;

public class SoundManager : SingletonMonoBehaviour<SoundManager> {

	public void Awake()
	{
		if(this != Instance)
		{
			Destroy(this);
			return;
		}
		DontDestroyOnLoad(this.gameObject);
	}    

	public AudioClip BGM;
	public AudioClip[] SEs;

	// Use this for initialization
	void Start () {
		audio.PlayOneShot(BGM);
		GetComponent<AudioSource>().volume = 1.0f;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void playOneSE(int seNumber){
		audio.PlayOneShot(SEs[seNumber]);
	}

}