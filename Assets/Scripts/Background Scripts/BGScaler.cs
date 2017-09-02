using UnityEngine;
using System.Collections;

public class BGScaler : MonoBehaviour {

	public float offsetWidth;
	public float offsetHeight;
	public float zOrder;

	private Vector3 startPosition;

	// Use this for initialization
	void Awake () {
		var height = Camera.main.orthographicSize * 2f;
		var width = height * Screen.width / Screen.height;

		transform.localScale = new Vector3(offsetWidth*width, height/offsetHeight, 0);

		if(gameObject.name=="Horizon"){
			transform.position = new Vector3(0, 0, zOrder);
		}
	}
		
}
