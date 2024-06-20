using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilScript : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem particulas;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
<<<<<<< side/Ximena
=======
<<<<<<< Updated upstream
    
=======
>>>>>>> main

    private void OnCollisionEnter(Collision collision)
    {
     if(particulas!=null)
        {
            particulas.Play();
        }  
    }
    private void OnTriggerEnter(Collider other)
    {
<<<<<<< side/Ximena
=======
        //implementar
>>>>>>> main
        if (particulas !=null) {
            particulas.Play();
        }
    }

<<<<<<< side/Ximena
=======
>>>>>>> Stashed changes
>>>>>>> main
}
