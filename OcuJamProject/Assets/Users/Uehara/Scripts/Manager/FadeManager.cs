using UnityEngine;
using System.Collections;

public class FadeManager : SingletonMonoBehaviour<FadeManager>
{
	private Texture2D blackTexture;
	private float fadeAlpha = 0;
	private bool isFading = false;
	
	public void Awake ()
	{
		if (this != Instance) {
			Destroy (this);
			return;
		}
		
		DontDestroyOnLoad (this.gameObject);
		
		this.blackTexture = new Texture2D (32, 32, TextureFormat.RGB24, false);
		this.blackTexture.ReadPixels (new Rect (0, 0, 32, 32), 0, 0, false);
		this.blackTexture.SetPixel (0, 0, Color.white);
		this.blackTexture.Apply ();
	}
	
	public void OnGUI ()
	{
		if (!this.isFading)
			return;
		
		GUI.color = new Color (0, 0, 0, this.fadeAlpha);
		GUI.DrawTexture (new Rect (0, 0, Screen.width, Screen.height), this.blackTexture);
	}
	
	public void LoadLevel(string scene, float interval)
	{
		StartCoroutine (TransScene (scene, interval));
	}
	
	
	private IEnumerator TransScene (string scene, float interval)
	{
		this.isFading = true;
		float time = 0;
		while (time <= interval) {
			this.fadeAlpha = Mathf.Lerp (0f, 1f, time / interval);      
			time += Time.deltaTime;
			yield return 0;
		}
		
		Application.LoadLevel (scene);
		
		time = 0;
		while (time <= interval) {
			this.fadeAlpha = Mathf.Lerp (1f, 0f, time / interval);
			time += Time.deltaTime;
			yield return 0;
		}
		
		this.isFading = false;
	}
	
}