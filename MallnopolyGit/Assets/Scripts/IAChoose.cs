using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IAChoose : MonoBehaviour
{
    public GameObject[] pawns;
    public GameObject IAc;
    private int rnd;
    public int el;
    public GameObject dices;
    public GameObject cartas;
    public GameObject win;
    public GameObject IAct;

    private void Start()
    {
        Rand();
    }

    public void Act()
    {
        pawns[rnd].SetActive(true);
        IAc.SetActive(false);
        dices.SetActive(true);
        cartas.SetActive(true);
        win.SetActive(true);
        IAct.SetActive(true);
    }

    public void Rand()
    {
        rnd = Random.Range(0, 6);
        if(rnd == el)
        {
            Rand();
        }
        else if(rnd != el)
        {
            Act();
        }
    }
}
