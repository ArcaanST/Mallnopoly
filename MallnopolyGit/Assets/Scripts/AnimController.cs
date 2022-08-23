using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    public bool Andando;
    private Animator anim;
    public Sistema sis;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (sis.Tform.position == sis.checkTransform.position)
        {
            Andando = false;
            Ani();
        }

        else if (sis.Tform.position != sis.checkTransform.position)
        {
            Andando = true;
            Ani();
            StartCoroutine("wait");
        }
    }

    public void Ani()
    {
        anim.SetBool("Andando", Andando);
    }

    IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
        sis.checkTransform.position = sis.Tform.position;
    }
}
