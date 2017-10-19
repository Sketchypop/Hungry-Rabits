using UnityEngine;
using System.Collections;

public class BgMove1 : MonoBehaviour {

	public GameObject bg2;
	private float xcordbg2;

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "FrontWheel") {
			xcordbg2 = bg2.transform.position.x;
			xcordbg2 += 272;
			Vector3 temp = new Vector3 (xcordbg2, -18f, 0);
			bg2.transform.position = temp;
		}
	}
}
