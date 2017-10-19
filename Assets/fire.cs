using UnityEngine;
using System.Collections;

public class fire : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)){
			print(" fire button is pressed");
		}

		for (var i = 0; i < Input.touchCount; ++i) {


			if (Input.GetTouch(i).phase == TouchPhase.Began) {
				RaycastHit2D hitInfo = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.GetTouch(i).position), Vector2.zero);
				// RaycastHit2D can be either true or null, but has an implicit conversion to bool, so we can use it like this
				if(hitInfo)
				{
					Debug.Log( hitInfo.transform.gameObject.name );
					print ("Fire is pressed");
					// Here you can check hitInfo to see which collider has been hit, and act appropriately.
				}
			}
		}
	
	}
}
