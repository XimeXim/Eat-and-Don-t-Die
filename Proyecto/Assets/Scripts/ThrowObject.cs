using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowObject : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float throwForce = 10f;

    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            Throw();
        }
         if (Input.GetKey("a"))
    {
         Throw();
    }
    }

    void Throw()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        Destroy(projectile,3.5f);
        rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }
}
