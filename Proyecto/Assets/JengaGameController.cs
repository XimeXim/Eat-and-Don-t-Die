using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class JengaGameController : MonoBehaviour
{
    public Rigidbody[] jengaBlocks;
    private DefaultObserverEventHandler observerEventHandler;

    void Start()
    {
        observerEventHandler = GetComponent<DefaultObserverEventHandler>();

        if (observerEventHandler)
        {
            observerEventHandler.OnTargetFound.AddListener(OnTargetFound);
            observerEventHandler.OnTargetLost.AddListener(OnTargetLost);
        }

        // Desactiva la física al inicio
        foreach (Rigidbody rb in jengaBlocks)
        {
            rb.isKinematic = true;
        }
    }

    void OnTargetFound()
    {
        ActivatePhysics();
    }

    void OnTargetLost()
    {
        DeactivatePhysics();
    }

    void ActivatePhysics()
    {
        foreach (Rigidbody rb in jengaBlocks)
        {
            rb.isKinematic = false;
        }
    }

    void DeactivatePhysics()
    {
        foreach (Rigidbody rb in jengaBlocks)
        {
            rb.isKinematic = true;
        }
    }

    private void OnDestroy()
    {
        if (observerEventHandler)
        {
            observerEventHandler.OnTargetFound.RemoveListener(OnTargetFound);
            observerEventHandler.OnTargetLost.RemoveListener(OnTargetLost);
        }
    }
}