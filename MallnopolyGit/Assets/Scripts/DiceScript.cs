using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceScript : MonoBehaviour
{
    static Rigidbody rb;
    public Transform tf;
    public static Vector3 diceVelocity;

    public float x;
    public float y;
    public float z;

    public bool podeJogar;
    public bool jogador1OnPlay = false;
    public bool jogador2OnPlay = false;

    private GameObject sis;
    private GameObject sis2;

    private Sistema S;
    private Sistema S2;

    public GameObject Passando;
    public GameObject Rolar;
    public GameObject Cobrar1;
    public GameObject Cobrar2;
    public GameObject Criar1;
    public GameObject Criar2;

    private Jogador Player1;
    private Jogador Player2;

    public int Xpos;

    public int turno;
    public bool livre;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();

        sis = GameObject.FindGameObjectWithTag("Player1");
        sis2 = GameObject.FindGameObjectWithTag("Player2");

        S = sis.GetComponent<Sistema>();
        S2 = sis2.GetComponent<Sistema>();

        Player1 = sis.GetComponent<Jogador>();
        Player2 = sis2.GetComponent<Jogador>();

        turno = 1;

        livre = false;
    }

    void Update()
    {
        diceVelocity = rb.velocity;
    }

    public void RollAgain()
    {
        rnd();
        tf.position = new Vector3(Xpos, 10, 0);
        tf.Rotate(x, y, z);
        StartCoroutine("GO");
        Rolar.SetActive(false);
        livre = true;
    }

    public void Passar()
    {
        Rolar.SetActive(true);
        Passando.SetActive(false);
        jogador1OnPlay = false;
        jogador2OnPlay = false;
        Criar1.SetActive(false);
        Criar2.SetActive(false);
        livre = false;
    }
   
    public void rnd()
    {
        x = Random.Range(0, 180);
        y = Random.Range(0, 180);
        z = Random.Range(0, 180);
    }

    IEnumerator GO()
    {
        yield return new WaitForSeconds(6);
        if(turno % 2 != 0)
        {
            S.Play();
            turno += 1;
            jogador1OnPlay = true;
            Criar1.SetActive(true);
            StartCoroutine("Esperarparacobrar2");
        }
        else if(turno % 2 == 0)
        {
            S2.Play();
            turno += 1;
            jogador2OnPlay = true;
            Criar2.SetActive(true);
            StartCoroutine("Esperarparacobrar");
        }
    }

    IEnumerator Esperarparacobrar()
    {
        yield return new WaitForSeconds(6);
        Cobrar1.SetActive(true);
        S2.alw2();
    }
    IEnumerator Esperarparacobrar2()
    {
        yield return new WaitForSeconds(6);
        Cobrar2.SetActive(true);
        S.alw();
    }
}
