using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PainelCopy : MonoBehaviour
{
    public GameObject Jogador1;
    public int element;
    public GameObject Paine1l;
    public GameObject IAc;
    public IAChoose ia;
   

    public void Escolha()
    {
        Jogador1.SetActive(true);
        Paine1l.SetActive(false);
        IAc.SetActive(true);
        ia.el = element;
    }
}
