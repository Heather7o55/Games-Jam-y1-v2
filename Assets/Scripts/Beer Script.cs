using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeerScript : MonoBehaviour
{
    // Update is called once per frame
    private float timer = 0f;
    void Update()
    {
        timer += Time.deltaTime;
        if(gameObject.GetComponent<Rigidbody2D>().velocity.magnitude < 0.4f)
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 0f);
        }
        if(timer > 3f) Destroy(gameObject);
    }
}
