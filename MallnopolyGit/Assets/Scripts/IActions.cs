using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IActions : MonoBehaviour
{
    public DiceScript DS;
    public DiceScript DS2;
    public Cartas cards;
    public GameObject comprar;
    public GameObject img;
    public GameObject cobrar;
    
    public void Roll()
    {
        pay();
        if (DS.turno % 2 == 0 && DS2.turno % 2 == 0)
        {
            img.SetActive(true);
            DS.RollAgain();
            DS2.RollAgain();
        }
        if (DS.livre == true && DS2.livre == true)
        {
            StartCoroutine("compra");
        }
    }

    public void pay()
    {
        cards.PagarConta1();
    }


    IEnumerator compra()
    {
        yield return new WaitForSeconds(16);
        cards.Quero = true;
        if(cards.Player2.Dinheiro >= 450000)
        {
            cards.comprar2();
            comprar.SetActive(false);
            
        }
        if (cards.Player2.Dinheiro >= 400000)
        {
            cards.loja1_2();
            cards.loja2_2();
            cards.loja3_2();
        }

        if(cards.Player2.Dinheiro >= 900000)
        {
            cards.loja4_2();
            cards.loja5_2();
        }

        if(cards.Player2.Dinheiro >= 300000)
        {
            cards.loja6_2();
            cards.loja7_2();
        }

        if(cards.Player2.Dinheiro >= 700000)
        {
            cards.loja8_2();
            cards.loja9_2();
            cards.loja10_2();
        }

        if(cards.Player2.Dinheiro >= 1000000)
        {
            cards.loja11_2();
            cards.loja12_2();
            cards.loja13_2();
        }

        DS.Passar();
        cobrar.SetActive(true);
        img.SetActive(false);
        cards.Quero = false;
    }
}

