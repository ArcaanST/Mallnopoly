using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Painel : MonoBehaviour
{
    public GameObject Jogador1;
    public GameObject Botao;
    public GameObject Paine1l;
    public GameObject Painel2;



    public void Escolha()
    {
        Jogador1.SetActive(true);
        Botao.SetActive(false);
        Paine1l.SetActive(false);
        Painel2.SetActive(true);

    }
}
