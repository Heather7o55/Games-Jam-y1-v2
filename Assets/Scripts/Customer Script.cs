using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerScript : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.GetComponent<Rigidbody2D>().velocity.magnitude == 0f)
        {
            CustomerSpawningScript.activeCustomers--;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
