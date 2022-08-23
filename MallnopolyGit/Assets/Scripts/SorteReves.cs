using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SorteReves : MonoBehaviour
{
    public GameObject[] casasSR;
    public GameObject[] casasSR2;

    public GameObject SorR;
    public Text txt;
    public Text Sr;
    public Text receba;
    public DiceNumberTextScript Dtxt;

    private Jogador Player1;
    private Jogador Player2;

    private GameObject sis;
    private GameObject sis2;

    private Sistema S;
    private Sistema S2;

    public Cartas cards;

    private int SR;
    public bool s_r;
    public bool s_r2;

    // Start is called before the first frame update
    void Start()
    {
        s_r = false;
        s_r2 = false;
        sis = GameObject.FindGameObjectWithTag("Player1");
        sis2 = GameObject.FindGameObjectWithTag("Player2");

        S = sis.GetComponent<Sistema>();
        S2 = sis2.GetComponent<Sistema>();

        Player1 = sis.GetComponent<Jogador>();
        Player2 = sis2.GetComponent<Jogador>();
    }
    
    public void SortRev1()
    {
        if(sis.transform.position.z == casasSR[0].transform.position.z || sis.transform.position.z == casasSR[1].transform.position.z || sis.transform.position.z == casasSR[2].transform.position.z || sis.transform.position.z == casasSR[3].transform.position.z || sis.transform.position.z == casasSR[4].transform.position.z && s_r == true)
        {
            SorR.SetActive(true);
            SR = Random.Range(1, 15);

            if(SR == 1)
            {
                Sr.text = "Sorte";
                txt.text = "Seu livro será vendido na Mobel.";
                receba.text = "Receba: 50.000";

                Player1.Dinheiro += 50000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 2)
            {
                Sr.text = "Revés";
                txt.text = "Seu filho decidiu comprar um MePhone.";
                receba.text = "Pague: 20.000";

                Player1.Dinheiro -= 20000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 3)
            {
                Sr.text = "Sorte";
                txt.text = "Sua loja recebeu investimento estrangeiro.";
                receba.text = "Receba: 75.000";

                Player1.Dinheiro += 50000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 4)
            {
                Sr.text = "Revés";
                txt.text = "O caminhão com as mercadorias da sua loja foi roubado.";
                receba.text = "Pague: 100.000";

                Player1.Dinheiro -= 100000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 5)
            {
                Sr.text = "Sorte";
                txt.text = "Ganhou sorteio do shopping, vá até a central de atendimento e...";
                S.casaAtual = 21;
                S.AtualizaPos();
                receba.text = "Receba: 200.000";

                Player1.Dinheiro += 200000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 6)
            {
                Sr.text = "Revés";
                txt.text = "Reformou sua loja.";
                receba.text = "Pague: 50.000";

                Player1.Dinheiro -= 50000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 7)
            {
                Sr.text = "Sorte";
                txt.text = "Sua loja pegou fogo, mas você tinha seguro.";
                receba.text = "Receba: 25.000";

                Player1.Dinheiro += 25000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 8)
            {
                Sr.text = "Revés";
                txt.text = "Perdeu seu filho na PlayIsland. Vá buscá-lo.";
                receba.text = "Pague: 200.000";
                Player1.Dinheiro -= 200000;
                S.casaAtual = 7;
                S.AtualizaPos();
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 9)
            {
                Sr.text = "Sorte";
                txt.text = "Recebeu o prêmio de lojista do ano.";
                receba.text = "Receba: 10.000";

                Player1.Dinheiro += 10000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 10)
            {
                Sr.text = "Revés";
                txt.text = "Vai começar um curso de Marketing e ganhou desconto à vista.";
                receba.text = "Pague: 20.000";

                Player1.Dinheiro -= 20000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 11)
            {
                Sr.text = "Sorte";
                txt.text = "Tirou 1º lugar no torneio de Basketball na PlayIsland.";
                receba.text = "Receba: 60.000";

                Player1.Dinheiro += 60000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 12)
            {
                Sr.text = "Revés";
                txt.text = "Férias com a família.";
                receba.text = "Pague: 35.000";

                Player1.Dinheiro -= 35000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 13)
            {
                Sr.text = "Sorte";
                txt.text = "Ganhou na TVSena.";
                receba.text = "Receba: 80.000";

                Player1.Dinheiro += 80000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 14)
            {
                Sr.text = "Revés";
                txt.text = "Carro precisa de manutenção.";
                receba.text = "Pague: 9.000";

                Player1.Dinheiro -= 9000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }
            s_r = false;
        }
    }

    public void SortRev2()
    {
        if (sis2.transform.position.z == casasSR2[0].transform.position.z || sis2.transform.position.z == casasSR2[1].transform.position.z || sis.transform.position.z == casasSR[2].transform.position.z || sis2.transform.position.z == casasSR2[3].transform.position.z || sis2.transform.position.z == casasSR2[4].transform.position.z && s_r2 == true)
        {
            SorR.SetActive(true);
            SR = Random.Range(1, 15);

            if (SR == 1)
            {
                Sr.text = "Sorte";
                txt.text = "Seu livro será vendido na Mobel.";
                receba.text = "Receba: 50.000";

                Player2.Dinheiro += 50000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 2)
            {
                Sr.text = "Revés";
                txt.text = "Seu filho decidiu comprar um MePhone.";
                receba.text = "Pague: 20.000";

                Player2.Dinheiro -= 20000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 3)
            {
                Sr.text = "Sorte";
                txt.text = "Sua loja recebeu investimento estrangeiro.";
                receba.text = "Receba: 75.000";

                Player2.Dinheiro += 50000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 4)
            {
                Sr.text = "Revés";
                txt.text = "O caminhão com as mercadorias da sua loja foi roubado.";
                receba.text = "Pague: 100.000";

                Player2.Dinheiro -= 100000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 5)
            {
                Sr.text = "Sorte";
                txt.text = "Ganhou sorteio do shopping, vá até a central de atendimento e...";
                S2.casaAtual = 21;
                S2.AtualizaPos();
                receba.text = "Receba: 200.000";

                Player2.Dinheiro += 200000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 6)
            {
                Sr.text = "Revés";
                txt.text = "Reformou sua loja.";
                receba.text = "Pague: 50.000";

                Player2.Dinheiro -= 50000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 7)
            {
                Sr.text = "Sorte";
                txt.text = "Sua loja pegou fogo, mas você tinha seguro.";
                receba.text = "Receba: 25.000";

                Player2.Dinheiro += 25000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 8)
            {
                Sr.text = "Revés";
                txt.text = "Perdeu seu filho na PlayIsland. Vá buscá-lo.";
                receba.text = "Pague: 200.000";
                Player2.Dinheiro -= 200000;
                S2.casaAtual = 7;
                S2.AtualizaPos();
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 9)
            {
                Sr.text = "Sorte";
                txt.text = "Recebeu o prêmio de lojista do ano.";
                receba.text = "Receba: 10.000";

                Player2.Dinheiro += 10000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 10)
            {
                Sr.text = "Revés";
                txt.text = "Vai começar um curso de Marketing e ganhou desconto à vista.";
                receba.text = "Pague: 20.000";

                Player2.Dinheiro -= 20000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 11)
            {
                Sr.text = "Sorte";
                txt.text = "Tirou 1º lugar no torneio de Basketball na PlayIsland.";
                receba.text = "Receba: 60.000";

                Player2.Dinheiro += 60000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 12)
            {
                Sr.text = "Revés";
                txt.text = "Férias com a família.";
                receba.text = "Pague: 35.000";

                Player2.Dinheiro -= 35000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 13)
            {
                Sr.text = "Sorte";
                txt.text = "Ganhou na TVSena.";
                receba.text = "Receba: 80.000";

                Player2.Dinheiro += 80000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }

            if (SR == 14)
            {
                Sr.text = "Revés";
                txt.text = "Carro precisa de manutenção.";
                receba.text = "Pague: 9.000";

                Player2.Dinheiro -= 9000;
                cards.DinheiroUpdate();
                StartCoroutine("Fechar");
            }
        s_r2 = false;
        }
    }

    public void fechaCarta()
    {
        SorR.SetActive(false);
    }

    IEnumerator Fechar()
    {
        yield return new WaitForSeconds(12);
        SorR.SetActive(false);
    }

}
