using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painel2 : MonoBehaviour
{
    public GameObject Player2;
    public GameObject Pai2;
    public GameObject Dados;
    public GameObject Cartas;
    public GameObject wim;

    public void Esolha2()
    {
        Player2.SetActive(true);
        Pai2.SetActive(false);
        Dados.SetActive(true);
        Cartas.SetActive(true);
        wim.SetActive(true);
    }

}
