using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawEffectScript : MonoBehaviour {

	private Dictionary<int, GameObject> trails = new Dictionary<int, GameObject>();
	// Update is called once per frame
	void Update () {
		//Debug.Log("DrawEffect called");
		for(int i=0; i<Input.touchCount; i++){
			Touch touch = Input.GetTouch(i);
			if(touch.phase == TouchPhase.Ended && touch.tapCount == 1){
				Vector3 position = Camera.main.ScreenToWorldPoint(touch.position);

				EffectsScript.MakeExplosion(position);
			}
			else if(touch.phase == TouchPhase.Began){
				Vector3 position = Camera.main.ScreenToWorldPoint(touch.position);
				position.z = 0;

				GameObject trail = EffectsScript.MakeTrail(position);

				if(trail != null){
					trails.Add(i, trail);
				}
			}
			else if(touch.phase == TouchPhase.Moved){
				if(trails.ContainsKey(i)){
					GameObject trail = trails[i];

					Camera.main.ScreenToWorldPoint(touch.position);
					Vector3 position = Camera.main.ScreenToWorldPoint(touch.position);
					position.z = 0;

					trail.transform.position = position;
				}
			}
			else if(touch.phase == TouchPhase.Ended){
				if(trails.ContainsKey(i)){
					GameObject trail = trails[i];

					Destroy(trail, trail.GetComponent<TrailRenderer>().time);
					trails.Remove(i);
				}
			}
		}
			

	}
}
