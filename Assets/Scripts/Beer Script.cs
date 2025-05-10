using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if(gameObject.GetComponent<Rigidbody2D>().velocity.magnitude < 0.4f)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }
    }
}
