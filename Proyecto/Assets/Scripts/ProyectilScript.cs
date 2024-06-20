using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilScript : MonoBehaviour
{
    // Start is called before the first frame update

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
<<<<<<< Updated upstream
    
=======

    private void OnCollisionEnter(Collision collision)
    {
     if(particulas!=null)
        {
            particulas.Play();
        }  
    }
    private void OnTriggerEnter(Collider other)
    {
        //implementar
        if (particulas !=null) {
            particulas.Play();
        }
    }

>>>>>>> Stashed changes
}
