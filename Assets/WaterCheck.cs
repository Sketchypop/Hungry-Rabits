using UnityEngine;
using System.Collections;

public class WaterCheck : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "rock" || other.tag=="Tree") {
			Destroy(other.gameObject);
		}
	}
}
