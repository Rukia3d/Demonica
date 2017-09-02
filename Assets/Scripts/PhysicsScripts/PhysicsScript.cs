using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PhysicsScript : MonoBehaviour {

	public float gravityMod = 1f;

	protected Vector2 velocity;
	protected Rigidbody2D rigBody;
	protected ContactFilter2D contactFilter;
	protected const float minMoveDistance = 0.001f;


	void OnEnable(){
		rigBody = GetComponent<Rigidbody2D>();
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	// Every physical frame
	void FixedUpdate(){
		velocity += gravityMod * Physics2D.gravity * Time.deltaTime;

		Vector2 deltaPosition = velocity * Time.deltaTime;

		Vector2 move = Vector2.up * deltaPosition.y;

		Movement(move);
	}

	void Movement(Vector2 move){
		float distance = move.magnitude;

		if(distance > minMoveDistance){
			
		}

		rigBody.position = rigBody.position + move;
	}


}
