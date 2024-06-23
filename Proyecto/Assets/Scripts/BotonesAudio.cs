using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonSound : MonoBehaviour
{
    public AudioClip clickSound;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        Button button = GetComponent<Button>();
        button.onClick.AddListener(OnButtonClick);
    }


    public void OnButtonClick()
    {
        audioSource.PlayOneShot(clickSound);
    }

// Update is called once per frame
    void Update()
    {
        
    }
}
