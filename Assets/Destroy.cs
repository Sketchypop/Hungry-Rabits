using UnityEngine;
using System.Collections;

public class Destroy : MonoBehaviour {

    public GameObject Car;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnCollisionEnter2D(Collision2D col)
    {
        print("Collision entered");
        if (col.gameObject.tag == "car")
        {
            
            //Destroy(Car);
        }
        }
    }
