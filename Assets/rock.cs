using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    public stoprock sR;

    private Rigidbody2D rb;
    private bool hasHit;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hasHit == false)
        {
            float angle = Mathf.Atan2(rb.velocity.y, rb.velocity.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
            velozero();
        }
    }

    private void velozero()
    {
        if(sR.colltrawarock == true)
        {
            hasHit = true;
            rb.velocity = Vector2.zero;
            rb.isKinematic = true;
        }
    }
}
