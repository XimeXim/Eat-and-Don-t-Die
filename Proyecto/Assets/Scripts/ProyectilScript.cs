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
        if (particlePrefab!=null)
        {
            ContactPoint contact = collision.contacts[0];
            GameObject particleSystem = Instantiate(particlePrefab, contact.point, transform.rotation);
            particleSystem.transform.SetParent(collision.transform);
            ParticleSystem particle = particleSystem.GetComponent<ParticleSystem>();
            if(particle != null)
            {
                particle.Play();
            }
            if (collision.gameObject.CompareTag("Block"))
            {
                FindObjectOfType<ThrowObject>().OnBlockRemoved();
            }
        }  
    }
    private void OnTriggerEnter(Collider other)
    {
        if (particlePrefab!=null)
        {
            GameObject particleSystem = Instantiate(particlePrefab, other.transform.position, transform.rotation);
            particleSystem.transform.SetParent(other.transform);
            ParticleSystem particle = particleSystem.GetComponent<ParticleSystem>();
            if (particle != null)
            {
                particle.Play();
            }
            if (other.gameObject.CompareTag("Block"))
            {
                FindObjectOfType<ThrowObject>().OnBlockRemoved();
            }
        }
    }
}
