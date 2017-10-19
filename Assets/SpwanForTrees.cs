using UnityEngine;
using System.Collections;

public class SpwanForTrees : MonoBehaviour {

	public GameObject[] obj;
	public GameObject des;
	public GameObject trig;
	public GameObject cam;
	public destroyer DesScript;
	public Triggerer TrigScript;
	public Move CamScript;
	public float spawnMin = 1f;
	public float spawnMax = 5f;
	private bool TreeCheck = false;
	private bool WaterCheck = false;
	private bool FirstMoveSpawn = false;
	private bool CamCheck=false;
	
	
	// Use this for initialization
	void Start () {
		
		des = GameObject.FindGameObjectWithTag ("destroy");
		DesScript = des.GetComponent<destroyer> ();
		
		trig = GameObject.FindGameObjectWithTag ("MoveGround");
		TrigScript = trig.GetComponent<Triggerer> ();

		cam = GameObject.FindGameObjectWithTag ("MainCamera");
		CamScript = cam.GetComponent<Move>();
		
		Spawn ();
	}
	
	void Spawn()
	{
		//TreeCheck = DesScript.TreeKill;
		WaterCheck = !(TrigScript.WaterAppearbool);
		FirstMoveSpawn = TrigScript.FirstMove;
		print ("Delta.x is "+CamScript.CameraCheck);
		if (CamScript.CameraCheck > 0.5)
			CamCheck = true;

		if (FirstMoveSpawn && CamCheck && WaterCheck) {
			int objno=Random.Range(0,obj.GetLength(0));
			float xcord=transform.position.x;
			Vector3 temp = new Vector3 (xcord, -3.91f, 0);
			if(objno==0)
				temp = new Vector3 (xcord, -25.1f, 0);
			else if(objno==1)
				temp = new Vector3 (xcord, -29.9f, 0);
			else if(objno==2)
				temp = new Vector3 (xcord, -27.6f, 0);
			else if(objno==3)
				temp = new Vector3 (xcord, -27.5f, 0);
			Instantiate (obj [objno], temp, Quaternion.identity);
			//DesScript.TreeKill=false;
			CamCheck=false;
		}
		//Invoke ("Spawn",Random.Range(spawnMin,spawnMax));
		Invoke ("Spawn",5);
		
	}
}
