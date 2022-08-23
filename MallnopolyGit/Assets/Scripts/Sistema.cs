using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Sistema : MonoBehaviour
{
    public Transform[] casas;
    public int casaAtual;
    public DiceNumberTextScript dado;
    public Transform spawn;
    private NavMeshAgent nav;

    public Transform Tform;

    public Transform checkTransform;

    public Jogador player;
    public GameObject Passar;
    public GameObject Comprar;

    public Cartas cards;
    public SorteReves SR;


    public bool allow1;
    public bool allow2;
    void Start()
    {
        casaAtual = 0;
        nav = GetComponent<NavMeshAgent>();
        Tform = GetComponent<Transform>();

        allow1 = false;
        allow2 = false;
    }

    public void Play()
    {
        if (player.count % 2 != 0)
        {
            casaAtual = casaAtual + dado.dices;
            if (casaAtual < casas.Length)
            {
                nav.destination = (casas[casaAtual].position);
                StartCoroutine("wait");
                StartCoroutine("Passe");
            }
            else
            {
                casaAtual -= casas.Length;
                nav.destination = (casas[casaAtual].position);
                StartCoroutine("wait");
                StartCoroutine("Passe");
                player.Dinheiro += 200000;
                cards.DinheiroUpdate();
            }
        }
        player.count += 1;
    }

    public void AtualizaPos()
    {
        nav.destination = casas[casaAtual].position;
    }

    public void alw()
    {
        allow1 = true;
    }

    public void alw2()
    {
        allow2 = true;
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(13);
        checkTransform.position = casas[casaAtual].position;
        //Tform.position + new Vector3(Tform.position.x * 0.1f, Tform.position.y * 0.1f, Tform.position.z * 0.1f);
        if(player.posicao == 1 && allow1 == true)
        {
            Debug.Log("Batatinha 1 2 3");
            StartCoroutine("S");
            SR.SortRev1();
            allow1 = false;
        }
        if(player.posicao == 1)
        {
            Debug.Log("Batatinha 1 2 3");
            cards.Multa();
            cards.Recebe();
        }
        if(player.posicao == 2 && allow2 == true)
        {
            Debug.Log("Batatinha 1 2 3");
            StartCoroutine("R");
            SR.SortRev2();
            allow2 = false;
        }
        if(player.posicao == 2)
        {
            Debug.Log("Batatinha 1 2 3");
            cards.Multa2();
            cards.Recebe2();
        }
    }
    IEnumerator Passe()
    {
        yield return new WaitForSeconds(4);
        Passar.SetActive(true);
        Comprar.SetActive(true);
    }
    IEnumerator S()
    {
        yield return new WaitForSeconds(3);
        SR.s_r = true;
    }

    IEnumerator R()
    {
        yield return new WaitForSeconds(3);
        SR.s_r2 = true;
    }
}
