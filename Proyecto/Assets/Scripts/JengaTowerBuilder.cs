using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JengaTowerBuilder : MonoBehaviour
{
    public GameObject blockPrefab;
    public int layers = 18; // Número de capas de la torre

    void Start()
    {
        BuildTower();
    }

    void BuildTower()
    {
        // Dimensiones del bloque
        float blockLength = 0.075f; // Largo del bloque
        float blockHeight = 0.015f; // Alto del bloque
        float blockWidth = 0.025f; // Ancho del bloque

        Vector3 startPosition = transform.position;
        for(int i=0;i<layers;i++){
            if(i%2==0){
                for(int j=0;j<3;j++){
                    Vector3 position;
                    position = startPosition + new Vector3(0, i * blockHeight, j*blockWidth);
                    GameObject block = Instantiate(blockPrefab, position, Quaternion.identity);
                    block.transform.parent = transform;
                }
            }else{
                for(int j=0;j<3;j++){
                    Vector3 position;
                    position = startPosition + new Vector3(j*blockWidth, i * blockHeight,0);
                    
                    GameObject block = Instantiate(blockPrefab, position, Quaternion.identity);
                    block.transform.Rotate(0, 90, 0);

                    block.transform.position = startPosition +new Vector3(j*blockWidth-blockWidth,i*blockHeight,+blockWidth);
                    block.transform.parent = transform;
                }
            }

        }
    }
}