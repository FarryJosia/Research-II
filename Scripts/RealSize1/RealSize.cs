using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealSize : MonoBehaviour
{
    public GameObject dome;
    public GameObject mpiano;
    public GameObject p4;
    public GameObject ppersegi;
    public GameObject ppolos;
    public GameObject c8;
    public GameObject c12;
    public GameObject piano;
    public GameObject sbesar;
    public GameObject vpolos;

    public void realSize()
    {

        //tipe1
        dome.transform.localScale = new Vector3(5f, 5f, 5f);
        dome.transform.localPosition = new Vector3(0f, -1f, 0f);

        mpiano.transform.localScale = new Vector3(5f, 5f, 5f);
        p4.transform.localScale = new Vector3(5f, 5f, 5f);
        ppersegi.transform.localScale = new Vector3(5f, 5f, 5f);
        ppolos.transform.localScale = new Vector3(5f, 5f, 5f);

        //tipe2
        c8.transform.localScale = new Vector3(5f, 5f, 5f);
        c8.transform.localPosition = new Vector3(0f, -0.1f, 0f);

        c12.transform.localScale = new Vector3(5f, 5f, 5f);
        c12.transform.localPosition = new Vector3(0f, -0.1f, 0f);

        piano.transform.localScale = new Vector3(5f, 5f, 5f);
        piano.transform.localPosition = new Vector3(0f, -0.1f, 0f);

        sbesar.transform.localScale = new Vector3(5f, 5f, 5f);
        sbesar.transform.localPosition = new Vector3(0f, -0.1f, 0f);

        vpolos.transform.localScale = new Vector3(5f, 5f, 5f);
        vpolos.transform.localPosition = new Vector3(0f, -0.1f, 0f);
    }

    public void normalSize()
    {
        //tipe1
        dome.transform.localScale = new Vector3(1f, 1f, 1f);
        dome.transform.localPosition = new Vector3(0f, 0f, 0f);

        mpiano.transform.localScale = new Vector3(1f, 1f, 1f);
        p4.transform.localScale = new Vector3(1f, 1f, 1f);
        ppersegi.transform.localScale = new Vector3(1f, 1f, 1f);
        ppolos.transform.localScale = new Vector3(1f, 1f, 1f);

        //tipe2
        c8.transform.localScale = new Vector3(1f, 1f, 1f);
        c8.transform.localPosition = new Vector3(0f, 0f, 0f);

        c12.transform.localScale = new Vector3(1f, 1f, 1f);
        c12.transform.localPosition = new Vector3(0f, 0f, 0f);

        piano.transform.localScale = new Vector3(1f, 1f, 1f);
        piano.transform.localPosition = new Vector3(0f, 0f, 0f);

        sbesar.transform.localScale = new Vector3(1f, 1f, 1f);
        sbesar.transform.localPosition = new Vector3(0f, 0f, 0f);

        vpolos.transform.localScale = new Vector3(1f, 1f, 1f);
        vpolos.transform.localPosition = new Vector3(0f, 0f, 0f);
    }
}
