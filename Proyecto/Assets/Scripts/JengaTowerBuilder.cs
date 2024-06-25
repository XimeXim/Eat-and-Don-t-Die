using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JengaTowerBuilder : MonoBehaviour
{
    public GameObject blockPrefab;
    public GameObject parent;

    public int layers = 18; // Número de capas de la torre

    void Start()
    {
        BuildTower();
    }

    void BuildTower()
    {
        // Dimensiones del bloque
        float blockLength = 0.075f; // Largo del bloque
        //float blockHeight = 0.015f; // Alto del bloque
        float blockHeight = 0.02f; // Alto del bloque
        float blockWidth = 0.025f; // Ancho del bloque
        float distance = 0f;
        Vector3 startPosition = transform.position;
        for(int i=0;i<layers;i++){
            if(i%2==0){
                for(int j=0;j<3;j++){
                    Vector3 position;
                    position = startPosition + new Vector3(0, distance+i * blockHeight, j*blockWidth);
                    GameObject block = Instantiate(blockPrefab, position, Quaternion.identity);
                    block.transform.parent = parent.transform;
                }
            }else{
                for(int j=0;j<3;j++){
                    Vector3 position;
                    position = startPosition + new Vector3(j*blockWidth, distance+i * blockHeight,0);
                    
                    GameObject block = Instantiate(blockPrefab, position, Quaternion.identity);
                    block.transform.Rotate(0, 90, 0);

                    block.transform.position = startPosition +new Vector3(j*blockWidth-blockWidth,i*blockHeight,+blockWidth);
                    block.transform.parent = parent.transform;
                }
            }

        }
    }
    public void onTargetFound(){
        GameObject parentObject = this.parent;
        Debug.Log("activando gravedad a "+parentObject.transform.childCount);

        // Iterar a través de todos los hijos
        for (int i = 0; i < parentObject.transform.childCount; i++)
        {
            // Obtener el hijo en el índice i
            Transform childTransform = parentObject.transform.GetChild(i);
            GameObject childObject = childTransform.gameObject;
            Rigidbody rb = childObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                // Activar la gravedad
                rb.useGravity = true;
                rb.isKinematic = false;
            }
            Debug.Log("Gravedad activada para: " + childObject.name);
        }
    }
    public void onTargetLost(){

    }
}