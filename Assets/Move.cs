using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	private Vector3 velocity = Vector3.zero;
	public Transform target;
	public float CameraCheck=0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (target)
		{
			Vector3 point = GetComponent<Camera>().WorldToViewportPoint(target.position);
			Vector3 delta = target.position - GetComponent<Camera>().ViewportToWorldPoint(new Vector3(0.2f, 0f, point.z)); //(new Vector3(0.5, 0.5, point.z));
			Vector3 destination = transform.position;
			CameraCheck = delta.x;
			if (delta.x>0)
				destination.x = destination.x+delta.x; 
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, 0);
		}
	
	}
}
