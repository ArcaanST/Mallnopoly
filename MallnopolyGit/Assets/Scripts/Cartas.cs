using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cartas : MonoBehaviour
{
    public GameObject[] jogador1Cartas;
    public GameObject[] jogador2Cartas;

    private int price;
    private int aluguel;

    public GameObject SRController;

    private Sistema S;
    private Sistema S2;

    public DiceScript dice;

    public DiceNumberTextScript Dtxt;

    public Text txt;
    public Text P1;
    public Text P2;
    public Text Mensagem;

    private Jogador Player1;
    public Jogador Player2;

    private GameObject sis;
    private GameObject sis2;

    private string CardName;

    public GameObject Compra;

    public bool Quero = false;

    public GameObject Comp;
    public GameObject Cartas1;
    public GameObject Cartas2;
    public GameObject passar;
    public GameObject message;
    public GameObject Cobrar1;
    public GameObject Cobrar2;

    public GameObject[] Jogador1Lojas;
    public GameObject[] Jogador2Lojas;

    private int verde = 0;
    private int rosa = 0;
    private int azul = 0;
    private int vermelho = 0;
    private int laranja = 0;
    private int outros = 0;

    public GameObject[] lojas;

    private bool green1 = false;
    private bool green1_2 = false;
    private bool green1_3 = false;
    private bool pink1 = false;
    private bool pink1_2 = false;
    private bool blue1 = false;
    private bool blue1_2 = false;
    private bool red1 = false;
    private bool red1_2 = false;
    private bool red1_3 = false;
    private bool orange1 = false;
    private bool orange1_2 = false;
    private bool orange1_3 = false;
    private bool others = false;

    private int verde2 = 0;
    private int rosa2 = 0;
    private int azul2 = 0;
    private int vermelho2 = 0;
    private int laranja2 = 0;
    private int outros2 = 0;

    private bool green2 = false;
    private bool green2_2 = false;
    private bool green2_3 = false;
    private bool pink2 = false;
    private bool pink2_2 = false;
    private bool blue2 = false;
    private bool blue2_2 = false;
    private bool red2 = false;
    private bool red2_2 = false;
    private bool red2_3 = false;
    private bool orange2 = false;
    private bool orange2_2 = false;
    private bool orange2_3 = false;
    private bool others2 = false;

    public GameObject PNLojas;
    public GameObject PNLojas2;

    public bool card1 = false;
    public bool card2 = false;
    public bool card3 = false;
    public bool card4 = false;
    public bool card5 = false;
    public bool card6 = false;
    public bool card7 = false;
    public bool card8 = false;
    public bool card9 = false;
    public bool card10 = false;
    public bool card11 = false;
    public bool card12 = false;
    public bool card13 = false;
    public bool card14 = false;
    public bool card15 = false;
    public bool card16 = false;
    public bool card17 = false;

    public bool card2_1 = false;
    public bool card2_2 = false;
    public bool card2_3 = false;
    public bool card2_4 = false;
    public bool card2_5 = false;
    public bool card2_6 = false;
    public bool card2_7 = false;
    public bool card2_8 = false;
    public bool card2_9 = false;
    public bool card2_10 = false;
    public bool card2_11 = false;
    public bool card2_12 = false;
    public bool card2_13 = false;
    public bool card2_14 = false;
    public bool card2_15 = false;
    public bool card2_16 = false;
    public bool card2_17 = false;

    private void Start()
    {
        sis = GameObject.FindGameObjectWithTag("Player1");
        sis2 = GameObject.FindGameObjectWithTag("Player2");

        S = sis.GetComponent<Sistema>();
        S2 = sis2.GetComponent<Sistema>();

        Player1 = sis.GetComponent<Jogador>();
        Player2 = sis2.GetComponent<Jogador>();

        DinheiroUpdate();
        SRController.SetActive(true);
    }
    private void Update()
    {
        if(outros == 4)
        {
            others = true;
        }

        if(outros2 == 4)
        {
            others2 = true;
        }
    }

    //1
    public void loja1()
    {
        if(verde >= 2 && Player1.Dinheiro > 100000)
        {
            green1 = true;
            lojas[0].SetActive(true);
            Player1.Dinheiro -= 100000;
            DinheiroUpdate();
            Jogador1Lojas[0].SetActive(false);
        }
    }

    public void loja2()
    {
        if (verde >= 2 && Player1.Dinheiro > 100000)
        {
            green1_2 = true;
            lojas[1].SetActive(true);
            Player1.Dinheiro -= 100000;
            DinheiroUpdate();
            Jogador1Lojas[1].SetActive(false);
        }
    }

    public void loja3()
    {
        if (verde >= 2 && Player1.Dinheiro > 100000)
        {
            green1_3 = true;
            lojas[2].SetActive(true);
            Player1.Dinheiro -= 100000;
            DinheiroUpdate();
            Jogador1Lojas[2].SetActive(false);
        }
    }

    public void loja4()
    {
        if (rosa >= 2 && Player1.Dinheiro > 400000)
        {
            pink1 = true;
            lojas[3].SetActive(true);
            Player1.Dinheiro -= 400000;
            DinheiroUpdate();
            Jogador1Lojas[3].SetActive(false);
        }
    }

    public void loja5()
    {
         if (rosa >= 2 && Player1.Dinheiro > 400000)
        {
            pink1_2 = true;
            lojas[4].SetActive(true);
            Player1.Dinheiro -= 400000;
            DinheiroUpdate();
            Jogador1Lojas[4].SetActive(false);
        }
    }
    public void loja6()
    {
        if (azul >= 2 && Player1.Dinheiro > 100000)
        {
            blue1 = true;
            lojas[5].SetActive(true);
            Player1.Dinheiro -= 100000;
            DinheiroUpdate();
            Jogador1Lojas[5].SetActive(false);
        }
    }
    public void loja7()
    {
        if (azul >= 2 && Player1.Dinheiro > 100000)
        {
            blue1_2 = true;
            lojas[6].SetActive(true);
            Player1.Dinheiro -= 100000;
            DinheiroUpdate();
            Jogador1Lojas[6].SetActive(false);
        }
    }
    public void loja8()
    {
        if (vermelho >= 2 && Player1.Dinheiro > 300000)
        {
            red1 = true;
            lojas[7].SetActive(true);
            Player1.Dinheiro -= 300000;
            DinheiroUpdate();
            Jogador1Lojas[7].SetActive(false);
        }
    }
    public void loja9()
    {
        if (vermelho >= 2 && Player1.Dinheiro > 300000)
        {
            red1_2 = true;
            lojas[8].SetActive(true);
            Player1.Dinheiro -= 300000;
            DinheiroUpdate();
            Jogador1Lojas[8].SetActive(false);
        }
    }
    public void loja10()
    {
        if (vermelho >= 2 && Player1.Dinheiro > 300000)
        {
            red1_3 = true;
            lojas[9].SetActive(true);
            Player1.Dinheiro -= 300000;
            DinheiroUpdate();
            Jogador1Lojas[9].SetActive(false);
        }
    }
    public void loja11()
    {
        if (laranja >= 2 && Player1.Dinheiro > 400000)
        {
            orange1 = true;
            lojas[10].SetActive(true);
            Player1.Dinheiro -= 400000;
            DinheiroUpdate();
            Jogador1Lojas[10].SetActive(false);
        }
    }
    public void loja12()
    {
        if (laranja >= 2 && Player1.Dinheiro > 400000)
        {
            orange1_2 = true;
            lojas[11].SetActive(true);
            Player1.Dinheiro -= 400000;
            DinheiroUpdate();
            Jogador1Lojas[11].SetActive(false);
        }
    }
    public void loja13()
    {
        if (laranja >= 2 && Player1.Dinheiro > 400000)
        {
            orange1_3 = true;
            lojas[12].SetActive(true);
            Player1.Dinheiro -= 400000;
            DinheiroUpdate();
            Jogador1Lojas[12].SetActive(false);
        }
    }
    //1
    public void loja1_2()
    {
        if (verde2 >= 2 && Player2.Dinheiro > 100000 && card2_1 == true)
        {
            green2 = true;
            lojas[0].SetActive(true);
            Player2.Dinheiro -= 100000;
            DinheiroUpdate();
            Jogador2Lojas[0].SetActive(false);
        }
    }

    public void loja2_2()
    {
        if (verde2 >= 2 && Player2.Dinheiro > 100000 && card2_2 == true)
        {
            green2_2 = true;
            lojas[1].SetActive(true);
            Player2.Dinheiro -= 100000;
            DinheiroUpdate();
            Jogador2Lojas[1].SetActive(false);
        }
    }

    public void loja3_2()
    {
        if (verde2 >= 2 && Player2.Dinheiro > 100000 && card2_3 == true)
        {
            green2_3 = true;
            lojas[2].SetActive(true);
            Player2.Dinheiro -= 100000;
            DinheiroUpdate();
            Jogador2Lojas[2].SetActive(false);
        }
    }

    public void loja4_2()
    {
        if (rosa2 >= 2 && Player2.Dinheiro > 400000 && card2_4 == true)
        {
            pink2 = true;
            lojas[3].SetActive(true);
            Player2.Dinheiro -= 400000;
            DinheiroUpdate();
            Jogador2Lojas[3].SetActive(false);
        }
    }

    public void loja5_2()
    {
        if (rosa2 >= 2 && Player2.Dinheiro > 400000 && card2_5 == true)
        {
            pink2_2 = true;
            lojas[4].SetActive(true);
            Player2.Dinheiro -= 400000;
            DinheiroUpdate();
            Jogador2Lojas[4].SetActive(false);
        }
    }
    public void loja6_2()
    {
        if (azul2 >= 2 && Player2.Dinheiro > 100000 && card2_6 == true)
        {
            blue2 = true;
            lojas[5].SetActive(true);
            Player2.Dinheiro -= 100000;
            DinheiroUpdate();
            Jogador2Lojas[5].SetActive(false);
        }
    }
    public void loja7_2()
    {
        if (azul2 >= 2 && Player2.Dinheiro > 100000 && card2_7 == true)
        {
            blue2_2 = true;
            lojas[6].SetActive(true);
            Player2.Dinheiro -= 100000;
            DinheiroUpdate();
            Jogador2Lojas[6].SetActive(false);
        }
    }
    public void loja8_2()
    {
        if (vermelho2 >= 2 && Player2.Dinheiro > 300000 && card2_8 == true)
        {
            red2 = true;
            lojas[7].SetActive(true);
            Player2.Dinheiro -= 300000;
            DinheiroUpdate();
            Jogador2Lojas[7].SetActive(false);
        }
    }
    public void loja9_2()
    {
        if (vermelho2 >= 2 && Player2.Dinheiro > 300000 && card2_9 == true)
        {
            red2_2 = true;
            lojas[8].SetActive(true);
            Player2.Dinheiro -= 300000;
            DinheiroUpdate();
            Jogador2Lojas[8].SetActive(false);
        }
    }
    public void loja10_2()
    {
        if (vermelho2 >= 2 && Player2.Dinheiro > 300000 && card2_10 == true)
        {
            red2_3 = true;
            lojas[9].SetActive(true);
            Player2.Dinheiro -= 300000;
            DinheiroUpdate();
            Jogador2Lojas[9].SetActive(false);
        }
    }
    public void loja11_2()
    {
        if (laranja2 >= 2 && Player2.Dinheiro > 400000 && card2_11 == true)
        {
            orange2 = true;
            lojas[10].SetActive(true);
            Player2.Dinheiro -= 400000;
            DinheiroUpdate();
            Jogador2Lojas[10].SetActive(false);
        }
    }
    public void loja12_2()
    {
        if (laranja2 >= 2 && Player2.Dinheiro > 400000 && card2_12 == true)
        {
            orange2_2 = true;
            lojas[11].SetActive(true);
            Player2.Dinheiro -= 400000;
            DinheiroUpdate();
            Jogador2Lojas[11].SetActive(false);
        }
    }
    public void loja13_2()
    {
        if (laranja2 >= 2 && Player2.Dinheiro > 400000 && card2_13 == true)
        {
            orange2_3 = true;
            lojas[12].SetActive(true);
            Player2.Dinheiro -= 400000;
            DinheiroUpdate();
            Jogador2Lojas[12].SetActive(false);
        }
    }
    public void Multa()
    {
        if (sis.transform.position.z == S.casas[23].transform.position.z)
        {
            StartCoroutine("mensagem3");
            S.casaAtual = 7;
            S.AtualizaPos();
        }
    }
    public void Multa2()
    {
        if (sis2.transform.position.z == S2.casas[23].transform.position.z)
        {
            S2.casaAtual = 7;
            S2.AtualizaPos();
            StartCoroutine("mensagem4");
        }
    }
    public void Recebe()
    {
        if (sis.transform.position.z == S.casas[10].transform.position.z)
        {
            StartCoroutine("mensagem5");
            S.casaAtual = 21;
            S.AtualizaPos();
        }
    }
    public void Recebe2()
    {
        if (sis2.transform.position.z == S2.casas[10].transform.position.z)
        {
            StartCoroutine("mensagem6");
            S2.casaAtual = 21;
            S2.AtualizaPos();
        }
    }
    public void DinheiroUpdate()
    {
        P2.text = Player2.Dinheiro.ToString();
        P1.text = Player1.Dinheiro.ToString();
    }
    public void desativaCobranca()
    {
        Cobrar1.SetActive(false);
        Cobrar2.SetActive(false);
    }
    public void desativarComprar()
    {
        Comp.SetActive(false);
    }
    public void ShowCard1()
    {
        Cartas1.SetActive(true);
    }
    public void ShowCard2()
    {
        Cartas2.SetActive(true);
    }
    public void Sim()
    {
        Quero = true;
        enabled = false;
        if (dice.jogador1OnPlay == true)
        {
            comprar1();
        }
        else if (dice.jogador2OnPlay == true)
        {
            comprar2();
        }
    }
    public void Nao()
    {
        Quero = false;
        enabled = false;
        if (dice.jogador1OnPlay == true)
        {
            comprar1();
        }
        else if (dice.jogador2OnPlay == true)
        {
            comprar2();
        }
    }
    public void TextOff()
    {
        Compra.SetActive(false);
    }
    public void Enable()
    {
        if (dice.jogador1OnPlay == true)
        {
            comprar1();
        }
        else if (dice.jogador2OnPlay == true)
        {
            comprar2();
        }
    }
    public void Pergunta()
    {
        txt.text = ($"Você gostaria de comprar {CardName} por {price} ?");
    }
    IEnumerator mensagem1()
    {
        message.SetActive(true);
        Mensagem.text = ($"O jogador 1 gastou {aluguel} na loja {CardName}.");
        yield return new WaitForSeconds(6);
        Player1.Dinheiro -= aluguel;
        Player2.Dinheiro += aluguel;
        message.SetActive(false);
        DinheiroUpdate();
    }
    IEnumerator mensagem2()
    {
        message.SetActive(true);
        Mensagem.text = ($"O jogador 2 gastou {aluguel} na loja {CardName}.");
        yield return new WaitForSeconds(6);
        Player2.Dinheiro -= aluguel;
        Player1.Dinheiro += aluguel;
        message.SetActive(false);
        DinheiroUpdate();
    }
    IEnumerator mensagem3()
    {
        message.SetActive(true);
        Mensagem.text = ($"O jogador 1 perdeu seu filho na Play Island. Vá buscar seu filho. Multa: 200000.");
        yield return new WaitForSeconds(6);
        Player1.Dinheiro -= 200000;
        message.SetActive(false);
        DinheiroUpdate();
    }
    IEnumerator mensagem4()
    {
        message.SetActive(true);
        Mensagem.text = ($"O jogador 2 perdeu seu filho na Play Island. Vá buscar seu filho. Multa: 200000.");
        yield return new WaitForSeconds(6);
        Player2.Dinheiro -= 200000;
        message.SetActive(false);
        DinheiroUpdate();
    }
    IEnumerator mensagem5()
    {
        message.SetActive(true);
        Mensagem.text = ($"O jogador 1 ganhou o sorteio do shopping. Vá até a central de atendimento. Prêmio: 200000");
        yield return new WaitForSeconds(6);
        Player1.Dinheiro += 200000;
        message.SetActive(false);
        DinheiroUpdate();
    }
    IEnumerator mensagem6()
    {
        message.SetActive(true);
        Mensagem.text = ($"O jogador 2 ganhou o sorteio do shopping. Vá até a central de atendimento. Prêmio: 200000");
        yield return new WaitForSeconds(6);
        Player2.Dinheiro += 200000;
        message.SetActive(false);
        DinheiroUpdate();
    }
    public void PagarConta1()
    {
        //Benner
        if (sis.transform.position.z == S.casas[2].transform.position.z && card2_1 == true)
        {
            CardName = "Benner";
            if(green2 == true)
            {
                aluguel = 90000;
            }
            else if(green2 == false)
            {
                aluguel = 6000;
            }
            StartCoroutine("mensagem1");
        }
        //B&A
        if (sis.transform.position.z == S.casas[4].transform.position.z && card2_2 == true)
        {
            CardName = "B&A";
            if (green2_2 == true)
            {
                aluguel = 90000;
            }
            else if (green2_2 == false)
            {
                aluguel = 2000;
            }
            StartCoroutine("mensagem1");
        }
        //Barisa
        if (sis.transform.position.z == S.casas[5].transform.position.z && card2_3 == true)
        {
            CardName = "Barisa";
            if (green2_3 == true)
            {
                aluguel = 90000;
            }
            else if (green2_3 == false)
            {
                aluguel = 4000;
            }
            StartCoroutine("mensagem1");
        }
        //Cavivara
        if (sis.transform.position.z == S.casas[8].transform.position.z && card2_4 == true)
        {
            CardName = "Cavivara";
            if (pink2 == true)
            {
                aluguel = 600000;
            }
            else if (pink2 == false)
            {
                aluguel = 45000;
            }
            StartCoroutine("mensagem1");
        }
        //Pantora
        if (sis.transform.position.z == S.casas[9].transform.position.z && card2_5 == true)
        {
            CardName = "Pantora";
            if (pink2_2 == true)
            {
                aluguel = 600000;
            }
            else if (pink2_2 == false)
            {
                aluguel = 50000;
            }
            StartCoroutine("mensagem1");
        }
        //Kaiso
        if (sis.transform.position.z == S.casas[13].transform.position.z && card2_6 == true)
        {
            CardName = "Kaiso";
            if (blue2 == true)
            {
                aluguel = 100000;
            }
            else if (blue2 == false)
            {
                aluguel = 8000;
            }
            StartCoroutine("mensagem1");
        }
        //Niniso
        if (sis.transform.position.z == S.casas[15].transform.position.z && card2_7 == true)
        {
            CardName = "Niniso";
            if (blue2_2 == true)
            {
                aluguel = 100000;
            }
            else if (blue2_2 == false)
            {
                aluguel = 6000;
            }
            StartCoroutine("mensagem1");
        }
        //McRonalds
        if (sis.transform.position.z == S.casas[16].transform.position.z && card2_8 == true)
        {
            CardName = "McRonalds";
            if (red2 == true)
            {
                aluguel = 300000;
            }
            else if (red2 == false)
            {
                aluguel = 10000;
            }
            StartCoroutine("mensagem1");
        }
        //Burger Queen
        if (sis.transform.position.z == S.casas[18].transform.position.z && card2_9 == true)
        {
            CardName = "Burger Queen";
            if (red2_2 == true)
            {
                aluguel = 300000;
            }
            else if (red2_2 == false)
            {
                aluguel = 12000;
            }
            StartCoroutine("mensagem1");
        }
        //QFC
        if (sis.transform.position.z == S.casas[20].transform.position.z && card2_10 == true)
        {
            CardName = "QFC";
            if (red2_3 == true)
            {
                aluguel = 300000;
            }
            else if (red2_3 == false)
            {
                aluguel = 10000;
            }
            StartCoroutine("mensagem1");
        }
        //Gasolina
        if (sis.transform.position.z == S.casas[22].transform.position.z && card2_11 == true)
        {
            CardName = "Gasolina";
            if (orange2 == true)
            {
                aluguel = 450000;
            }
            else if (orange2 == false)
            {
                aluguel = 28000;
            }
            StartCoroutine("mensagem1");
        }
        //Kelvin Cleim
        if (sis.transform.position.z == S.casas[24].transform.position.z && card2_12 == true)
        {
            CardName = "Kelvin Cleim";
            if (orange2_2 == true)
            {
                aluguel = 450000;
            }
            else if (orange2_2 == false)
            {
                aluguel = 26000;
            }
            StartCoroutine("mensagem1");
        }
        //Varezzo
        if (sis.transform.position.z == S.casas[27].transform.position.z && card2_13 == true)
        {
            CardName = "Varezzo";
            if (orange2_3 == true)
            {
                aluguel = 450000;
            }
            else if (orange2_3 == false)
            {
                aluguel = 26000;
            }
            StartCoroutine("mensagem1");
        }
        //Mobel
        if (sis.transform.position.z == S.casas[3].transform.position.z && card2_14 == true)
        {
            CardName = "Mobel";
            if (others2 == true)
            {
                aluguel = Dtxt.dices * 80000;
            }
            else if (others2 == false)
            {
                aluguel = Dtxt.dices * 40000;
            }
            StartCoroutine("mensagem1");
        }
        //Saraivada
        if (sis.transform.position.z == S.casas[12].transform.position.z && card2_15 == true)
        {
            CardName = "Saraivada";
            if (others2 == true)
            {
                aluguel = Dtxt.dices * 80000;
            }
            else if (others2 == false)
            {
                aluguel = Dtxt.dices * 40000;
            }
            StartCoroutine("mensagem1");
        }
        //LivrariaCult
        if (sis.transform.position.z == S.casas[17].transform.position.z && card2_16 == true)
        {
            CardName = "Livraria Cult";
            if (others2 == true)
            {
                aluguel = Dtxt.dices * 80000;
            }
            else if (others2 == false)
            {
                aluguel = Dtxt.dices * 40000;
            }
            StartCoroutine("mensagem1");
        }
        //cinemarcos
        if (sis.transform.position.z == S.casas[26].transform.position.z && card2_17 == true)
        {
            CardName = "Cinemarcos";
            if (others2 == true)
            {
                aluguel = Dtxt.dices * 80000;
            }
            else if (others2 == false)
            {
                aluguel = Dtxt.dices * 40000;
            }
            StartCoroutine("mensagem1");
        }
        Cobrar1.SetActive(false);
        Cobrar2.SetActive(false);
        //3-12-17-26
    }
    public void PagarConta2()
    {
        //Benner
        if (sis2.transform.position.z == S2.casas[2].transform.position.z && card1 == true)
        {
            CardName = "Benner";
            if (green1 == true)
            {
                aluguel = 90000;
            }
            else if (green1 == false)
            {
                aluguel = 6000;
            }
            StartCoroutine("mensagem2");
        }
        //B&A
        if (sis2.transform.position.z == S2.casas[4].transform.position.z && card2 == true)
        {
            CardName = "B&A";
            if (green1_2 == true)
            {
                aluguel = 90000;
            }
            else if (green1_2 == false)
            {
                aluguel = 2000;
            }
            StartCoroutine("mensagem2");
        }
        //Barisa
        if (sis2.transform.position.z == S2.casas[5].transform.position.z && card3 == true)
        {
            CardName = "Barisa";
            if (green1_3 == true)
            {
                aluguel = 90000;
            }
            else if (green1_3 == false)
            {
                aluguel = 4000;
            }
            StartCoroutine("mensagem2");
        }
        //Cavivara
        if (sis2.transform.position.z == S2.casas[8].transform.position.z && card4 == true)
        {
            CardName = "Cavivara";
            if (pink1 == true)
            {
                aluguel = 600000;
            }
            else if (pink1 == false)
            {
                aluguel = 45000;
            }
            StartCoroutine("mensagem2");
        }
        //Pantora
        if (sis2.transform.position.z == S2.casas[9].transform.position.z && card5 == true)
        {
            CardName = "Pantora";
            if (pink1_2 == true)
            {
                aluguel = 600000;
            }
            else if (pink1_2 == false)
            {
                aluguel = 50000;
            }
            StartCoroutine("mensagem2");
        }
        //Kaiso
        if (sis2.transform.position.z == S2.casas[13].transform.position.z && card6 == true)
        {
            CardName = "Kaiso";
            if (blue1 == true)
            {
                aluguel = 100000;
            }
            else if (blue1 == false)
            {
                aluguel = 8000;
            }
            StartCoroutine("mensagem2");
        }
        //Niniso
        if (sis2.transform.position.z == S2.casas[15].transform.position.z && card7 == true)
        {
            CardName = "Niniso";
            if (blue1_2 == true)
            {
                aluguel = 100000;
            }
            else if (blue1_2 == false)
            {
                aluguel = 6000;
            }
            StartCoroutine("mensagem2");
        }
        //McRonalds
        if (sis2.transform.position.z == S2.casas[16].transform.position.z && card8 == true)
        {
            CardName = "McRonalds";
            if (red1 == true)
            {
                aluguel = 300000;
            }
            else if (red1 == false)
            {
                aluguel = 10000;
            }
            StartCoroutine("mensagem2");
        }
        //Burger Queen
        if (sis2.transform.position.z == S2.casas[18].transform.position.z && card9 == true)
        {
            CardName = "Burger Queen";
            if (red1_2 == true)
            {
                aluguel = 300000;
            }
            else if (red1_2 == false)
            {
                aluguel = 12000;
            }
            StartCoroutine("mensagem2");
        }
        //QFC
        if (sis2.transform.position.z == S2.casas[20].transform.position.z && card10 == true)
        {
            CardName = "QFC";
            if (red1_3 == true)
            {
                aluguel = 300000;
            }
            else if (red1_3 == false)
            {
                aluguel = 10000;
            }
            StartCoroutine("mensagem2");
        }
        //Gasolina
        if (sis2.transform.position.z == S2.casas[22].transform.position.z && card11 == true)
        {
            CardName = "Gasolina";
            if (orange1 == true)
            {
                aluguel = 450000;
            }
            else if (orange1 == false)
            {
                aluguel = 28000;
            }
            StartCoroutine("mensagem2");
        }
        //Kelvin Cleim
        if (sis2.transform.position.z == S2.casas[24].transform.position.z && card12 == true)
        {
            CardName = "Kelvin Cleim";
            if (orange1_2 == true)
            {
                aluguel = 450000;
            }
            else if (orange1_2 == false)
            {
                aluguel = 26000;
            }
            StartCoroutine("mensagem2");
        }
        //Varezzo
        if (sis2.transform.position.z == S2.casas[27].transform.position.z && card13 == true)
        {
            CardName = "Varezzo";
            if (orange1_3 == true)
            {
                aluguel = 450000;
            }
            else if (orange1_3 == false)
            {
                aluguel = 26000;
            }
            StartCoroutine("mensagem2");
        }
        //Mobel
        if (sis2.transform.position.z == S2.casas[3].transform.position.z && card14 == true)
        {
            CardName = "Mobel";
            if (others == true)
            {
                aluguel = Dtxt.dices * 80000;
            }
            else if (others == false)
            {
                aluguel = Dtxt.dices * 40000;
            }
            StartCoroutine("mensagem2");
        }
        //Saraivada
        if (sis2.transform.position.z == S2.casas[12].transform.position.z && card15 == true)
        {
            CardName = "Saraivada";
            if (others == true)
            {
                aluguel = Dtxt.dices * 80000;
            }
            else if (others == false)
            {
                aluguel = Dtxt.dices * 40000;
            }
            StartCoroutine("mensagem2");
        }
        //LivrariaCult
        if (sis2.transform.position.z == S2.casas[17].transform.position.z && card16 == true)
        {
            CardName = "Livraria Cult";
            if (others == true)
            {
                aluguel = Dtxt.dices * 80000;
            }
            else if (others == false)
            {
                aluguel = Dtxt.dices * 40000;
            }
            StartCoroutine("mensagem2");
        }
        if (sis2.transform.position.z == S2.casas[26].transform.position.z && card17 == true)
        {
            CardName = "Cinemarcos";
            if (others == true)
            {
                aluguel = Dtxt.dices * 80000;
            }
            else if (others == false)
            {
                aluguel = Dtxt.dices * 40000;
            }
            StartCoroutine("mensagem2");
        }
        Cobrar1.SetActive(false);
        Cobrar2.SetActive(false);
    }
    public void comprar2()
    {
        //Benner1
        if (sis2.transform.position.z == S2.casas[2].transform.position.z && card1 == false && card2_1 == false)
        {
            price = 100000;
            CardName = "Benner";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Benner");
                card2_1 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[0].SetActive(true);
                Jogador2Lojas[0].SetActive(true);
                verde2 += 1;
            }
        }
        
        //B&A2
        if (sis2.transform.position.z == S2.casas[4].transform.position.z && card2 == false && card2_2 == false)
        {
            price = 75000;
            CardName = "B&A";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu B&A");
                card2_2 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[1].SetActive(true);
                Jogador2Lojas[1].SetActive(true);
                verde2 += 1;
            }
        }
        
        //Barisa3
        if (sis2.transform.position.z == S2.casas[5].transform.position.z && card3 == false && card2_3 == false)
        {
            price = 60000;
            CardName = "Barisa";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Barisa");
                card2_3 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[2].SetActive(true);
                Jogador2Lojas[2].SetActive(true);
                verde2 += 1;
            }
        }
        
        //Cavivara4
        if (sis2.transform.position.z == S2.casas[8].transform.position.z && card4 == false && card2_4 == false)
        {
            CardName = "Cavivara";
            price = 350000;
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Cavivara");
                card2_4 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[3].SetActive(true);
                Jogador2Lojas[3].SetActive(true);
                rosa2 += 1;
            }
        }
        
        //Pantora5
        if (sis2.transform.position.z == S2.casas[9].transform.position.z && card5 == false && card2_5 == false)
        {
            price = 400000;
            CardName = "Pantora";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Pantora");
                card2_5 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[4].SetActive(true);
                Jogador2Lojas[4].SetActive(true);
                rosa2 += 1;
            }
        }
        
        //Kaiso6
        if (sis2.transform.position.z == S2.casas[13].transform.position.z && card6 == false && card2_6 == false)
        {
            price = 120000;
            CardName = "Kaiso";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Kaiso");
                card2_6 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[5].SetActive(true);
                Jogador2Lojas[5].SetActive(true);
                azul2 += 1;
            }
        }
        
        //Niniso7
        if (sis2.transform.position.z == S2.casas[15].transform.position.z && card7 == false && card2_7 == false)
        {
            price = 100000;
            CardName = "Niniso";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Niniso");
                card2_7 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[6].SetActive(true);
                Jogador2Lojas[6].SetActive(true);
                azul2 += 1;
            }
        }
       
        //McRonalds8
        if (sis2.transform.position.z == S2.casas[16].transform.position.z && card8 == false && card2_8 == false)
        {
            price = 140000;
            CardName = "McRonalds";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu McRonalds");
                card2_8 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[7].SetActive(true);
                Jogador2Lojas[7].SetActive(true);
                vermelho2 += 1;
            }
        }
        
        //Burger Queen9
        if (sis2.transform.position.z == S2.casas[18].transform.position.z && card9 == false && card2_9 == false)
        {
            price = 160000;
            CardName = "Burger Queen";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Burguer Queen");
                card2_9 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[8].SetActive(true);
                Jogador2Lojas[8].SetActive(true);
                vermelho2 += 1;
            }
        }
        
        //QFC10
        if (sis2.transform.position.z == S2.casas[20].transform.position.z && card10 == false && card2_10 == false)
        {
            price = 140000;
            CardName = "QFC";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu QFC");
                card2_10 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[9].SetActive(true);
                Jogador2Lojas[9].SetActive(true);
                vermelho2 += 1;
            }
        }
        
        //Gasolina11
        if (sis2.transform.position.z == S2.casas[22].transform.position.z && card11 == false && card2_11 == false)
        {
            price = 320000;
            CardName = "Gasolina";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Gasolina");
                card2_11 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[10].SetActive(true);
                Jogador2Lojas[10].SetActive(true);
                laranja2 += 1;
            }
        }
        
        //Kelvin Cleim12
        if (sis2.transform.position.z == S2.casas[24].transform.position.z && card12 == false && card2_12 == false)
        {
            price = 300000;
            CardName = "Kelvin Cleim";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Kelvin Cleim");
                card2_12 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[11].SetActive(true);
                Jogador2Lojas[11].SetActive(true);
                laranja2 += 1;
            }
        }
        //Varezzo13
        if (sis2.transform.position.z == S2.casas[27].transform.position.z && card13 == false && card2_13 == false)
        {
            price = 300000;
            CardName = "Varezzo";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Varezzo");
                card2_13 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[12].SetActive(true);
                Jogador2Lojas[12].SetActive(true);
                laranja2 += 1;
            }
        }
        //Mobel14
        if (sis2.transform.position.z == S2.casas[3].transform.position.z && card14 == false && card2_14 == false)
        {
            price = 200000;
            CardName = "Mobel";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Mobel");
                card2_14 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[13].SetActive(true);
                outros2 += 1;
            }
        }

        //Saraivada
        if (sis2.transform.position.z == S2.casas[12].transform.position.z && card15 == false && card2_15 == false)
        {
            price = 200000;
            CardName = "Saraivada";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Saraivada");
                card2_15 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[14].SetActive(true);
                outros2 += 1;
            }
        }

        //Livraria Cult
        if (sis2.transform.position.z == S2.casas[17].transform.position.z && card16 == false && card2_16 == false)
        {
            price = 200000;
            CardName = "Livraria Cult";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Livraria Cult");
                card2_16 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[15].SetActive(true);
                outros2 += 1;
            }
        }
        //Cinemarcos
        if (sis2.transform.position.z == S2.casas[26].transform.position.z && card17 == false && card2_17 == false)
        {
            price = 200000;
            CardName = "Cinemarcos";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 2 adquiriu Cinemarcos");
                card2_17 = true;
                Player2.Dinheiro -= price;
                Debug.LogError(Player2.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador2Cartas[16].SetActive(true);
                outros2 += 1;
            }
        }
    }
    public void comprar1()
    {
        //Benner1
        if (sis.transform.position.z == S.casas[2].transform.position.z && card1 == false && card2_1 == false)
        {
            price = 100000;
            CardName = "Benner";
            Pergunta();
            Compra.SetActive(true);
            if(Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Benner");
                card1 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[0].SetActive(true);
                Jogador1Lojas[0].SetActive(true);
                verde += 1;
            }
        }
     

        //B&A2
        if (sis.transform.position.z == S.casas[4].transform.position.z && card2 == false && card2_2 == false)
        {
            price = 75000;
            CardName = "B&A";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu B&A");
                card2 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[1].SetActive(true);
                Jogador1Lojas[1].SetActive(true);
                verde += 1;
            }     
        }

        //Barisa3
        if (sis.transform.position.z == S.casas[5].transform.position.z && card3 == false && card2_3 == false)
        {
            price = 60000;
            CardName = "Barisa";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Barisa");
                card3 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[2].SetActive(true);
                Jogador1Lojas[2].SetActive(true);
                verde += 1;
            }
        }

        //Cavivara4
        if (sis.transform.position.z == S.casas[8].transform.position.z && card4 == false && card2_4 == false)
        {
            price = 350000;
            CardName = "Cavivara";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Cavivara");
                card4 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[3].SetActive(true);
                Jogador1Lojas[3].SetActive(true);
                rosa += 1;
            }
        }

        //Pantora5
        if (sis.transform.position.z == S.casas[9].transform.position.z && card5 == false && card2_5 == false)
        {
            price = 400000;
            CardName = "Pantora";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Pantora");
                card5 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[4].SetActive(true);
                Jogador1Lojas[4].SetActive(true);
                rosa += 1;
            }
        }

        //Kaiso6
        if (sis.transform.position.z == S.casas[13].transform.position.z && card6 == false && card2_6 == false)
        {
            price = 120000;
            CardName = "Kaiso";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Kaiso");
                card6 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[5].SetActive(true);
                Jogador1Lojas[5].SetActive(true);
                azul += 1;
            }
        }

        //Niniso7
        if (sis.transform.position.z == S.casas[15].transform.position.z && card7 == false && card2_7 == false)
        {
            price = 100000;
            CardName = "Niniso";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Niniso");
                card7 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[6].SetActive(true);
                Jogador1Lojas[6].SetActive(true);
                azul += 1;
            }
        }

        //McRonalds8
        if (sis.transform.position.z == S.casas[16].transform.position.z && card8 == false && card2_8 == false)
        {
            price = 140000;
            CardName = "McRonalds";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu McRonalds");
                card8 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[7].SetActive(true);
                Jogador1Lojas[7].SetActive(true);
                vermelho += 1;
            }    
        }

        //Burger Queen9
        if (sis.transform.position.z == S.casas[18].transform.position.z && card9 == false && card2_9 == false)
        {
            price = 160000;
            CardName = "Burger Queen";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Burguer Queen");
                card9 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[8].SetActive(true);
                Jogador1Lojas[8].SetActive(true);
                vermelho += 1;
            }
        }

        //QFC10
        if (sis.transform.position.z == S.casas[20].transform.position.z && card10 == false && card2_10 == false)
        {
            price = 140000;
            CardName = "QFC";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu QFC");
                card10 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[9].SetActive(true);
                Jogador1Lojas[9].SetActive(true);
                vermelho += 1;
            }    
        }

        //Gasolina11
        if (sis.transform.position.z == S.casas[22].transform.position.z && card11 == false && card2_11 == false)
        {
            price = 320000;
            CardName = "Gasolina";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Gasolina");
                card11 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[10].SetActive(true);
                Jogador1Lojas[10].SetActive(true);
                laranja += 1;
            }   
        }

        //Kelvin Cleim12
        if (sis.transform.position.z == S.casas[24].transform.position.z && card12 == false && card2_12 == false)
        {
            price = 300000;
            CardName = "Kelvin Cleim";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Kelvin Cleim");
                card12 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[11].SetActive(true);
                Jogador1Lojas[11].SetActive(true);
                laranja += 1;
            }  
        }

        //Varezzo13
        if (sis.transform.position.z == S.casas[27].transform.position.z && card13 == false && card2_13 == false)
        {
            price = 300000;
            CardName = "Varezzo";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Varezzo");
                card13 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[12].SetActive(true);
                Jogador1Lojas[12].SetActive(true);
                laranja += 1;
            }  
        }

        //Mobel
        if (sis.transform.position.z == S.casas[3].transform.position.z && card14 == false && card2_14 == false)
        {
            price = 200000;
            CardName = "Mobel";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Mobel");
                card14 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[13].SetActive(true);
                outros += 1;
            }
        }

        //Saraivada
        if (sis.transform.position.z == S.casas[12].transform.position.z && card15 == false && card2_15 == false)
        {
            price = 200000;
            CardName = "Saraivada";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Saraivada");
                card15 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[14].SetActive(true);
                outros += 1;
            }
        }

        //Livraria Cult
        if (sis.transform.position.z == S.casas[17].transform.position.z && card16 == false && card2_16 == false)
        {
            price = 200000;
            CardName = "Livraria Cult";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Livraria Cult");
                card16 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[15].SetActive(true);
                outros += 1;
            }
        }
        //Cinemarcos
        if (sis.transform.position.z == S.casas[26].transform.position.z && card17 == false && card2_17 == false)
        {
            price = 200000;
            CardName = "Cinemarcos";
            Pergunta();
            Compra.SetActive(true);
            if (Quero == true)
            {
                Debug.LogError("Jogador 1 adquiriu Cinemarcos");
                card17 = true;
                Player1.Dinheiro -= price;
                Debug.LogError(Player1.Dinheiro);
                Quero = false;
                DinheiroUpdate();
                jogador1Cartas[16].SetActive(true);
                outros += 1;
            }
        }
    }
    public void PainelLojas()
    {
        PNLojas.SetActive(true);
    }
    public void PainelLojas2()
    {
        PNLojas2.SetActive(true);
    }
}
