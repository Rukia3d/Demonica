using UnityEngine;
using System.Collections;

public class BGScroller : MonoBehaviour {

	public float scrollSpeed;
	public float offset;

	private Vector3 startPosition;
	private Vector3 offsetPosition;

	private float tileSize;

	// Use this for initialization
	void Start () {
		var renderer = GetComponent<Renderer>();
		var z = GetComponent<BGScaler>().zOrder;
		if(gameObject.name=="Clouds"){
			transform.position = new Vector3(0, renderer.bounds.size.y/2, z);
		} 
		else if(gameObject.name=="Reflection"){
			transform.position = new Vector3(0, -renderer.bounds.size.y/2.5f, z);
		} 
		else {
			transform.position = new Vector3(0, 0, z);
		}
		offsetPosition =  new Vector3(offset*renderer.bounds.size.x, 0, 0);
		tileSize = renderer.bounds.size.x;
		startPosition = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSize);
		transform.position = startPosition + Vector3.left * newPosition + offsetPosition;
		Debug.Log(transform.position.x);
	}
}
