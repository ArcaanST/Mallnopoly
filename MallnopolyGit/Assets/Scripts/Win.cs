using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win : MonoBehaviour
{
    public GameObject Win1;
    public GameObject Win2;

    public string menu;

    private Jogador P1;
    private Jogador P2;

    private GameObject Sis1;
    private GameObject Sis2;
    // Start is called before the first frame update
    void Start()
    {
        Sis1 = GameObject.FindGameObjectWithTag("Player1");
        Sis2 = GameObject.FindGameObjectWithTag("Player2");

        P1 = Sis1.GetComponent<Jogador>();
        P2 = Sis2.GetComponent<Jogador>();
    }

    // Update is called once per frame
    void Update()
    {
        if(P1.Dinheiro <= 0)
        {
            Win2.SetActive(true);
            StartCoroutine("Vence1");
        }
        if(P2.Dinheiro <= 0)
        {
            Win1.SetActive(true);
            StartCoroutine("Vence2");
        }
    }

    IEnumerator Vence1()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(menu);
    }
    IEnumerator Vence2()
    {
        yield return new WaitForSeconds(10);
        SceneManager.LoadScene(menu);
    }
}
