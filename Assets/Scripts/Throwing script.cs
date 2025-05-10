using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class ThrowingScript : MonoBehaviour
{
    public GameObject beer;
    public float throwingForceModifier;
    public float throwingForceMax;
    private float throwingForce;
    // Update is called once per frame
    void Update()
    {
        if(Input.GetButton("Fire1"))
        {
            throwingForce += throwingForceModifier;
            if(throwingForce > throwingForceMax) throwingForce = throwingForceMax;
            return;
        }
        else if(throwingForce > 0f)
        {
            Debug.Log(throwingForce);
            GameObject beerLocal = Instantiate(beer, transform);
            beerLocal.GetComponent<Rigidbody2D>().AddForce(transform.right * throwingForce, ForceMode2D.Impulse);
            throwingForce = 0f;
        }
    }
}
