using UnityEngine;
using System.Collections;

public class DestroyMyself : MonoBehaviour {

	Camera camera;

	// Use this for initialization
	void Start () {
		camera = GetComponent<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
		if (screenPosition.y < 0)
			print ("Reached to destroy gameobject");
			Destroy(this.gameObject);
	}
}
