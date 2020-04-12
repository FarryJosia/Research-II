using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class URL : MonoBehaviour
{

    public GameObject OpenWA;

    public void WhatsApp()
    {
        Application.OpenURL("https://api.whatsapp.com/send?phone=6282189116781");
    }

}
