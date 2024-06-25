using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ThrowObject : MonoBehaviour
{
    public GameObject projectilePrefab;
    public float throwForce = 10f;
    public int blocksToWin = 5;
    private int blocksRemoved = 0;

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

    public void Throw()
    {
        GameObject projectile = Instantiate(projectilePrefab, transform.position, transform.rotation);
        Rigidbody rb = projectile.GetComponent<Rigidbody>();
        Destroy(projectile,3.5f);
        rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }

    public void OnGameWon()
    {
        Estadistica.Instancia.IncrementBlocks();
        SceneManager.LoadScene(5);
    }

    public void OnGameLost()
    {
        Estadistica.Instancia.IncrementLose();
        SceneManager.LoadScene(4);
    }

    public void OnBlockRemoved()
    {
        blocksRemoved++;
        if (blocksRemoved >= blocksToWin)
        {
            OnGameWon();
        }
    }
}
