using UnityEngine;
using System.Collections;

public class AlphaChanger : MonoBehaviour {

	void Awake(){
		Color tempColor = GetComponent<MeshRenderer>().material.color;
		tempColor.a = 0.5f;

		GetComponent<MeshRenderer>().material.color = tempColor;

	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
