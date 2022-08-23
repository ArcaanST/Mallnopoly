using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    private int c = 1;
    public GameObject cam;
    public Transform T1;
    public Transform T2;
    public Transform T3;
    public Transform T4;
    Quaternion q;
    public void aumentaGira()
    {
        c += 1;
        atualiza();
    }
    public void atualiza()
    {
        if(c == 1)
        {
            cam.transform.position = new Vector3(-1.7f, 37.1f, -11.1f);
            q = T1.transform.rotation;
            cam.transform.rotation = q;
        }

        if(c == 2)
        {
            cam.transform.position = new Vector3(-11.5f, 37.1f, -0.85f);
            q = T2.transform.rotation;
            cam.transform.rotation = q;
        }

        if(c == 3)
        {
            cam.transform.position = new Vector3(-3.15f, 37.1f, 8f);
            q = T3.transform.rotation;
            cam.transform.rotation = q;
        }
        
        if(c == 4)
        {
            cam.transform.position = new Vector3(7.4f, 37.1f, -1.4f);
            q = T4 .transform.rotation;
            cam.transform.rotation = q;
        }

        if(c > 4)
        {
            c = 1;
            atualiza();
        }
    }
}
