using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilScript : MonoBehaviour
{
    public GameObject particlePrefab;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Bloque"))
        {
            Instantiate(particlePrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }  
    }
    
}
