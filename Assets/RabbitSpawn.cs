using UnityEngine;
using System.Collections;

public class RabbitSpawn : MonoBehaviour {

    public GameObject obj;
    protected GameObject YellowRabbit;
    private float min=5;
    private float max=15;
    public bool RabbitDestroy=true;

	// Use this for initialization
	void Start () {
        RabbitSpawnfunc();
	}

    void RabbitSpawnfunc()
    {
        if (RabbitDestroy)
         {
            YellowRabbit = Instantiate(obj, transform.position, Quaternion.identity) as GameObject;
            RabbitDestroy = false;
        }
        Invoke("RabbitSpawnfunc", Random.Range(min, max));
    }
	
}
