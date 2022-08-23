using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogador : MonoBehaviour
{
    public int posicao;
    public int count;
    public int Dinheiro;
    private void Start()
    {
        Dinheiro = 2000000;


        if(posicao == 1)
        {
            count = 3;
        }
        else if(posicao == 2)
        {
            count = 2;
            
        }
    }
}
