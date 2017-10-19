using UnityEngine;
using System.Collections;

public class RabbitController : MonoBehaviour {

    Animator anim;
    private Rigidbody2D rigi;
    private float StopRabbit;
    bool CheckPosition = false;
    private GameObject rb;
    private RabbitSpawn rbScript;
    private bool CarrotHit = false;

    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        rigi = GetComponent<Rigidbody2D>();
        StopRabbit = Random.Range(0.9f, 0.6f);
        Flip();

        rb = GameObject.FindGameObjectWithTag("rabbit");
        rbScript = rb.GetComponent<RabbitSpawn>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "carrot" || other.tag == "car")
        {
            print("carrot hit");
            CarrotHit = true;
            if (other.tag == "carrot")
                Destroy(other.gameObject);
        }
    }

    void Update()
    {

    }
	
	// Update is called once per frame
	void FixedUpdate () {
        
        Vector3 pos = Camera.main.WorldToViewportPoint(transform.position);
        if(!CheckPosition)
            rigi.velocity = new Vector2(-15, rigi.velocity.y);

        if (pos.x < StopRabbit && !CheckPosition)
        {
            
            //rigi.velocity = new Vector2(0, rigi.velocity.y);
            rigi.velocity = Vector2.zero;
            anim.SetBool("run", false);
            CheckPosition = true;
        }

        if(CarrotHit && CheckPosition)
        {
            //Flip();
            anim.SetBool("run", true);
            rigi.velocity = new Vector2(-25, rigi.velocity.y);
        }

        if (pos.x < -1.5)
        {
            Destroy(gameObject);
            rbScript.RabbitDestroy = true;
        }
    }

    void Flip()
    {
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }

}
