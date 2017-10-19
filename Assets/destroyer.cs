using UnityEngine;
using System.Collections;

public class destroyer : MonoBehaviour {

	public bool RockKill=true;
	public bool TreeKill=true;

void OnTriggerEnter2D(Collider2D other) {
		print ("Trigger Entered at Destroyer");

		if (other.tag == "rock") {

			//if (other.gameObject.transform.parent) {
				//print ("OBJECT DESTROY");
				//Destroy (other.gameObject.transform.parent.gameObject);

			//} else {
				print ("OBJECT DESTROY");
				Destroy (other.gameObject);
			//}

			RockKill = true;
		}

		if (other.tag == "Tree") {
			Destroy(other.gameObject);
			TreeKill=true;
		}

	}
}
