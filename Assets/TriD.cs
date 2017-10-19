using UnityEngine;
using System.Collections;

public class TriD : MonoBehaviour {

	public GameObject Ground;
	private float xcord;



	void OnTriggerEnter2D(Collider2D other)
	{
		print ("Trigger Entered at Duplicate");
		xcord = Ground.transform.position.x;
		xcord += 135;
		Vector3 temp = new Vector3(xcord, -40f, 0);
		Ground.transform.position = temp;
	}
}
