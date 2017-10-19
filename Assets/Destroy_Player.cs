using UnityEngine;
using System.Collections;

public class Destroy_Player : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "car")
        {
            Destroy(other.gameObject);
        }
    }
}