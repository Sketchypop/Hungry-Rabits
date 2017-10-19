using UnityEngine;
using System.Collections;

public class Bg_Move : MonoBehaviour {

	private static int triCount=0;
	public GameObject bg1;
	public GameObject bg2;
	private float xcordT;
	private float xcordBG;

	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "car") {
			triCount++;
			print ("Trigger Entered at BG Trigger " + triCount);
			xcordT = transform.position.x;
			xcordT += 230;
			Vector3 temp = new Vector3(xcordT, -10f, 0);
			transform.position = temp;

			if (triCount%2==1)
			{
				print ("Moving B1 "+triCount);
				xcordBG = bg1.transform.position.x;
				xcordBG+=460;
				Vector3 tempG = new Vector3(xcordBG, -19.7f, 0);
				bg1.transform.position = tempG;
				
			}
			else
			{
				print ("Moving G2 "+triCount);
				xcordBG = bg2.transform.position.x;
				xcordBG+=460;
				Vector3 tempG = new Vector3(xcordBG, -19.7f, 0);
				bg2.transform.position = tempG;
			}
		}
	}
}
