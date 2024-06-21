using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject mainMenuPanel;
    public GameObject statsPanel;
    public Text perdidasText;
    public Text ganadoText;
    public Text bloquesText;

    private int perdidas;
    private int ganado;
    private int bloques;
    void Start()
    {
        CargarEstadisticas();
        ActualizarEstadisticasUI();
        MostrarMenuPrincipal();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CargarEstadisticas()
    {
        perdidas = PlayerPrefs.GetInt("Perdidas", 0);
        ganado = PlayerPrefs.GetInt("Ganado", 0);
        bloques = PlayerPrefs.GetInt("Bloques", 0);
    }

    void GuardarEstadisticas()
    {
        PlayerPrefs.SetInt("Perdidas", perdidas);
        PlayerPrefs.SetInt("Ganado", ganado);
        PlayerPrefs.SetInt("Bloques", bloques);
    }

    public void IncrementarPerdidas()
    {
        perdidas++;
        GuardarEstadisticas();
    }

    public void IncrementarGanado()
    {
        ganado++;
        GuardarEstadisticas();
    }

    public void IncrementarBloques()
    {
        bloques++;
        GuardarEstadisticas();
    }

    void ActualizarEstadisticasUI()
    {
        perdidasText.text = "Cantidad de LOSE: " + perdidas;
        ganadoText.text = "Cantidad de WIN: " + ganado;
        bloquesText.text = "Bloques eliminados: " + bloques;
    }

    public void MostrarMenuPrincipal()
    {
        mainMenuPanel.SetActive(true);
        statsPanel.SetActive(false);
    }

    public void MostrarPanelEstadisticas()
    {
        mainMenuPanel.SetActive(false);
        statsPanel.SetActive(true);
        ActualizarEstadisticasUI();
    }

    public void PlayJugar()
    {
        SceneManager.LoadScene("GameScene");
    }
    public void Salir()
    {
        Application.Quit();
    }
}
