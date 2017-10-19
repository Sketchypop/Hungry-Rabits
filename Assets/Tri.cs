using UnityEngine;
using System.Collections;

public class Tri : MonoBehaviour {

	public GameObject Ground;
	private static int triCount=0;



	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "car") {
			triCount++;
			print ("Trigger Entered at Real with trigger no. " + triCount);
		}
	}
}
