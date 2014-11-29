using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LaserBulletController : MonoBehaviour {

	private const float DELEATE_TIME = 5.0f;
	private float restTime = 0.0f;

	private float speed = 2.0f;

//	private List<float> deltaSizes = new List<float>();
//	private List<ParticleSystem> laserEffects = new List<ParticleSystem>();

	// Use this for initialization
	void Start () {

		restTime = DELEATE_TIME;

		//laserEffects = this.gameObject.GetComponentInChildren<ParticleSystem>();
//		laserEffects.Add(this.gameObject.GetComponentInChildren<ParticleSystem>());
//		for (int i=0; i < laserEffects.Count; i++) {
//			//deltaSize[i] = laserEffects[i].startSize / DELEATE_TIME;
//			deltaSizes.Add(laserEffects[i].startSize / DELEATE_TIME);
//		}
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void LateUpdate(){

		restTime -= Time.deltaTime;
		if (restTime < 0)
				Object.Destroy (this.gameObject);

		this.transform.position += this.transform.forward * speed;

//		for( int i=0; i < laserEffects.Count; ++i )
//		{
//			laserEffects[i].startSize -= deltaSizes[i] * Time.deltaTime;
//		}

	}
}
