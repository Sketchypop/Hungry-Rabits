using UnityEngine;
using System.Collections;

public class SpawnScript : MonoBehaviour {

	public GameObject[] obj;
	public GameObject des;
	public GameObject trig;
	public destroyer DesScript;
	public Triggerer TrigScript;
	public float spawnMin = 5f;
	public float spawnMax = 10f;
	private bool RockCheck = false;
	private bool WaterCheck = false;
	private bool FirstMoveSpawn = false;


	// Use this for initialization
	void Start () {

		des = GameObject.FindGameObjectWithTag ("destroy");
		DesScript = des.GetComponent<destroyer> ();

		trig = GameObject.FindGameObjectWithTag ("MoveGround");
		TrigScript = trig.GetComponent<Triggerer> ();

		Spawn ();
	}

	void Spawn()
	{
		RockCheck = DesScript.RockKill;
		WaterCheck = !(TrigScript.WaterAppearbool);
		FirstMoveSpawn = TrigScript.FirstMove;
		if (RockCheck && WaterCheck && FirstMoveSpawn) {
			Instantiate (obj [Random.Range (0, obj.GetLength (0))], transform.position, Quaternion.identity);
			DesScript.RockKill=false;
		}
		Invoke ("Spawn",Random.Range(spawnMin,spawnMax));

	}

}
