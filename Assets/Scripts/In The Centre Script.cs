using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InTheCentreScript : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude == 0f && collision.CompareTag("Centre"))
        {
            Score.AddScore(100);
        }
    }
}
