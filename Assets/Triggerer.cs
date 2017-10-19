using UnityEngine;
using System.Collections;

public class Triggerer : MonoBehaviour {

	private static int triCount=0;
	public GameObject g1;
	public GameObject g2;
	public GameObject w1;
	public GameObject w2;
	private float xcordT;
	private float xcordG1;
	private float xcordG2;
	private bool WaterCheck = false;
	private float xcordW=231f;
	public bool FirstMove = false;
	public bool WaterAppearbool = false;
	private float WaterAppear = 0;
	private float WaterSelect = 0;

	void Start()
	{
		xcordG1 = g1.transform.position.x;
		xcordG2 = g2.transform.position.x;
		xcordG1 += 204;
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "car") {
			FirstMove = true;
			triCount++;
			print ("Trigger Entered at Real with trigger no. " + triCount);
			xcordT = transform.position.x;
			xcordT += 204;
			Vector3 temp = new Vector3(xcordT, -10f, 0);
			transform.position = temp;
			WaterAppear = Random.value;
			if (WaterAppear>0.4)
				WaterAppearbool = true;



			if (triCount%2==1)
			{
				print ("Moving G1 "+triCount);
				//xcordG = g1.transform.position.x;
				xcordG1+=408;
				if(WaterAppearbool)
				{
					WaterSelect = Random.value;
					xcordW=xcordG1;
					xcordG1+=204;
					xcordG2+=204;
					Vector3 tempW = new Vector3(xcordW, -40f, 0);
					if(WaterSelect>0.4)
						w1.transform.position = tempW;
					else
						w2.transform.position = tempW;
					xcordT += 204;
					Vector3 temp2 = new Vector3(xcordT, -10f, 0);
					transform.position = temp2;
					WaterAppearbool = false;
				}
				Vector3 tempG = new Vector3(xcordG1, -40f, 0);
				g1.transform.position = tempG;

			}
			else
			{
				print ("Moving G2 "+triCount);
				//xcordG = g2.transform.position.x;
				xcordG2+=408;
				Vector3 tempG = new Vector3(xcordG2, -40f, 0);
				g2.transform.position = tempG;
			}


	}

}

}
