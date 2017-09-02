using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EffectsScript : MonoBehaviour {

	private static EffectsScript instance;

	public ParticleSystem leafExplosion;
	public GameObject leafTrail;

	// Before initialization
	void Awake () {
		instance = this;
	}

	public static ParticleSystem MakeExplosion(Vector3 position){
		Debug.Log("Make explosion called");
		if(instance==null){
			Debug.LogError("There is no Special Effect Script!");
			return null;
		}
		ParticleSystem effect = Instantiate(instance.leafExplosion) as ParticleSystem;
		effect.transform.position = position;

		Destroy(effect.gameObject, effect.duration);

		return effect;
	}

	public static GameObject MakeTrail(Vector3 position){
		if(instance==null){
			Debug.LogError("There is no Special Effect Script!");
			return null;
		}
		GameObject trial = Instantiate(instance.leafTrail) as GameObject;
		trial.transform.position = position;

		return trial;
	}
}
