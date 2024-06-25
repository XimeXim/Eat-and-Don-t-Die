using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Estadistica : MonoBehaviour
{
    private static Estadistica _instancia;
    public int win;
    public int lose;
    public int blocks_drop;
     public static Estadistica Instancia
    {
        get
        {
            if (_instancia == null)
            {
                _instancia = FindObjectOfType<Estadistica>();
                if (_instancia == null)
                {
                    GameObject singletonObject = new GameObject(typeof(Estadistica).ToString());
                    _instancia = singletonObject.AddComponent<Estadistica>();
                }
            }
            return _instancia;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        if (_instancia == null)
        {
            _instancia = this;
            DontDestroyOnLoad(gameObject);
        }
        else if (_instancia != this)
        {
            Destroy(gameObject);
        }
    }


    public void IncrementBlocks()
    {
        blocks_drop++;
        if (blocks_drop >= 5)
        {
            win++;
            SceneManager.LoadScene(5); // Scene 5 for winning
        }
    }

    public void IncrementLose()
    {
        lose++;
        SceneManager.LoadScene(4); // Scene 4 for losing
    }

}
