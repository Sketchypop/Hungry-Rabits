using UnityEngine;
using System.Collections;

public class Carrot : MonoBehaviour {

	private Rigidbody2D rb;

	void Start(){
		rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(10, 2);
        rb.AddForce(new Vector2(300, 247.79f));
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "car")
            Destroy(gameObject);
    }
}
