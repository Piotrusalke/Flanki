using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar : MonoBehaviour
{
    public GameObject projectile;
    public float launchForce;
    public Transform shotPoint;

    private int shotnumber;

    void Start()
    {
        gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 barPosition = transform.position;
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - barPosition;
        transform.right=direction;

        if(shotnumber == 0)
        {
            if(Input.GetMouseButton(0))
            {
                Shoot();
                shotnumber = 1;
                gameObject.SetActive(false);
            }
        }
        

        void Shoot()
        {
            GameObject newProjectile = Instantiate(projectile, shotPoint.position, shotPoint.rotation);
            newProjectile.GetComponent<Rigidbody2D>().velocity = transform.right * launchForce;
        }
    }
}
