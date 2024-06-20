using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectilScript : MonoBehaviour
{
    // Start is called before the first frame update
    public ParticleSystem particulas;
    public GameObject particleSystemPrefab;
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
     if(particulas!=null)
        {
            Vector3 position;
            position = new Vector3(0, 0, 0);
            GameObject block = Instantiate(particleSystemPrefab, position, Quaternion.identity);

            block.transform.parent = transform;
            particulas.Play();
        }  
    }
    private void OnTriggerEnter(Collider other)
    {

        if (particulas !=null) {
            particulas.Play();
        }
    }

}
