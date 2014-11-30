using UnityEngine;
using System.Collections;

public class TextureResize : MonoBehaviour {

	private Vector2 size;
	public GUITexture texture;
	public bool debagFlag;
	public Rect texturePos;
	
	// Use this for initialization
	void Start () {
		size = new Vector2(Screen.width, Screen.height);
		texture = this.guiTexture;
		texture.pixelInset = new Rect(Screen.width * texturePos.x / 100, Screen.height * texturePos.y / 100,
		                              -Screen.width * (1-texturePos.width / 100), -Screen.height * (1-texturePos.height / 100));
	}
	
	void OnGUI(){
		if (size.x != Screen.width || size.y != Screen.height || debagFlag){
			size = new Vector2(Screen.width, Screen.height);
			texture.pixelInset = new Rect(Screen.width * texturePos.x / 100, Screen.height * texturePos.y / 100,
			                              -Screen.width * (1-texturePos.width / 100), -Screen.height * 1-texturePos.height / 100);
		}
	}
}
