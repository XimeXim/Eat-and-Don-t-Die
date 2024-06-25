using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu_Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject statsPanel;
    public Text perdidasText;
    public Text ganadoText;
    public Text bloquesText;

    void Start()
    {
        CargarEstadisticas();
        ActualizarEstadisticasUI();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void CargarEstadisticas()
    {
        Estadistica.Instancia.lose = PlayerPrefs.GetInt("Perdidas", 0);
        Estadistica.Instancia.win = PlayerPrefs.GetInt("Ganado", 0);
        Estadistica.Instancia.blocks_drop = PlayerPrefs.GetInt("Bloques", 0);
    }

    void GuardarEstadisticas()
    {
        PlayerPrefs.SetInt("Perdidas", Estadistica.Instancia.lose);
        PlayerPrefs.SetInt("Ganado", Estadistica.Instancia.win);
        PlayerPrefs.SetInt("Bloques", Estadistica.Instancia.blocks_drop);
    }

    public void IncrementarPerdidas()
    {
        Estadistica.Instancia.lose++;
        GuardarEstadisticas();
    }

    public void IncrementarGanado()
    {
        Estadistica.Instancia.win++;
        GuardarEstadisticas();
    }

    public void IncrementarBloques()
    {
        Estadistica.Instancia.blocks_drop++;
        GuardarEstadisticas();
    }

    void ActualizarEstadisticasUI()
    {
        perdidasText.text = "Cantidad de LOSE: " + Estadistica.Instancia.lose;
        ganadoText.text = "Cantidad de WIN: " + Estadistica.Instancia.win;
        bloquesText.text = "Bloques eliminados: " + Estadistica.Instancia.blocks_drop;
    }

    public void MostrarPanelEstadisticas()
    {
        statsPanel.SetActive(true);
        ActualizarEstadisticasUI();
    }

    public void PlayJugar()
    {
        SceneManager.LoadScene(3);
    }
}
    
