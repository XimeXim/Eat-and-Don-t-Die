using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance;
    public AudioClip menuMusic;
    public AudioClip gameMusic;
    public  AudioSource audioSource;

    void Awake()
    {
        // Asegura que solo hay una instancia de AudioManager
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        audioSource = GetComponent<AudioSource>();
    }

    void Start()
    {
        

    }

    public void PlayMenuMusic()
    {
        if (audioSource.clip != menuMusic)
        {
            audioSource.clip = menuMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void PlayGameMusic()
    {
        //deberia morir la musica pero por alguna razon mistica si funciona...
        if(audioSource==null){
            return;
        }
        if (audioSource.clip != gameMusic)
        {
            audioSource.clip = gameMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
