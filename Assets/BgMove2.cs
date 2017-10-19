using UnityEngine;
using System.Collections;

public class BgMove2 : MonoBehaviour {

	public GameObject bg1;
	private float xcordbg1;

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "FrontWheel") {
			xcordbg1 = bg1.transform.position.x;
			xcordbg1 += 272;
			Vector3 temp = new Vector3 (xcordbg1, -18f, 0);
			bg1.transform.position = temp;
		}
	}
}
