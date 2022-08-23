 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PanelControl : MonoBehaviour
{
    public GameObject pausePanel;
    public GameObject Pane2;
    public string cena;
    public string menu;

    public void pause()
    {
        Time.timeScale = 0;
        pausePanel.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausePanel.SetActive(false);
    }

    public void reload()
    {
        SceneManager.LoadScene(cena);
    }

    public void sair()
    {
        Application.Quit();
    }

    public void VoltaMenu()
    {
        SceneManager.LoadScene(menu);
    }

    public void regras()
    {
        Pane2.SetActive(true);
    }

    public void Ferchar()
    {
        Pane2.SetActive(false);
    }
}
