using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fechar : MonoBehaviour
{
    public GameObject painel;

    public void Close()
    {
        painel.SetActive(false);
    }
}
