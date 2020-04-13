using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class showHide : MonoBehaviour
{
    public GameObject Dome;
    public GameObject MPiano;
    public GameObject P4;
    public GameObject PPersegi;
    public GameObject PPolos;

    public GameObject LDome;
    public GameObject LMPiano;
    public GameObject LP4;
    public GameObject LPPersegi;
    public GameObject LPPolos;

    public GameObject C8;
    public GameObject C12;
    public GameObject piano;
    public GameObject SBesar;
    public GameObject VersaseP;

    public GameObject LC8;
    public GameObject LC12;
    public GameObject Lpiano;
    public GameObject LSBesar;
    public GameObject LVersaseP;

    public GameObject arSize;
    public GameObject realSize;


    public GameObject HorizontalScrollType1;
    public GameObject HorizontalScrollType2;

    public GameObject labeltipe1;
    public GameObject labeltipe2;

    int activeState1 = 0;
    int activeState2 = 0;
    string nameType = "";
    

    private void Start()
    {
        Dome.SetActive(false);
        MPiano.SetActive(false);
        P4.SetActive(false);
        PPersegi.SetActive(false);
        PPolos.SetActive(false);

        LDome.SetActive(false);
        LMPiano.SetActive(false);
        LP4.SetActive(false);
        LPPersegi.SetActive(false);
        LPPolos.SetActive(false);

        C8.SetActive(false);
        C12.SetActive(false);
        piano.SetActive(false);
        SBesar.SetActive(false);
        VersaseP.SetActive(false);

        LC8.SetActive(false);
        LC12.SetActive(false);
        Lpiano.SetActive(false);
        LSBesar.SetActive(false);
        LVersaseP.SetActive(false);

        arSize.SetActive(false);
        realSize.SetActive(false);

        HorizontalScrollType1.SetActive(false);
        HorizontalScrollType2.SetActive(false);

        labeltipe1.SetActive(false);
        labeltipe2.SetActive(false);

    }

    public void shDome()
    {
        Dome.SetActive(true);
        MPiano.SetActive(false);
        P4.SetActive(false);
        PPersegi.SetActive(false);
        PPolos.SetActive(false);

        LDome.SetActive(true);
        LMPiano.SetActive(false);
        LP4.SetActive(false);
        LPPersegi.SetActive(false);
        LPPolos.SetActive(false);

        C12.SetActive(false);
        piano.SetActive(false);
        SBesar.SetActive(false);
        VersaseP.SetActive(false);
        C8.SetActive(false);

        LC8.SetActive(false);
        LC12.SetActive(false);
        Lpiano.SetActive(false);
        LSBesar.SetActive(false);
        LVersaseP.SetActive(false);
    }
    public void shMPiano()
    {
        Dome.SetActive(false);
        MPiano.SetActive(true);
        P4.SetActive(false);
        PPersegi.SetActive(false);
        PPolos.SetActive(false);

        LDome.SetActive(false);
        LMPiano.SetActive(true);
        LP4.SetActive(false);
        LPPersegi.SetActive(false);
        LPPolos.SetActive(false);

        C12.SetActive(false);
        piano.SetActive(false);
        SBesar.SetActive(false);
        VersaseP.SetActive(false);
        C8.SetActive(false);

        LC8.SetActive(false);
        LC12.SetActive(false);
        Lpiano.SetActive(false);
        LSBesar.SetActive(false);
        LVersaseP.SetActive(false);
    }
    public void shP4()
    {
        Dome.SetActive(false);
        MPiano.SetActive(false);
        P4.SetActive(true);
        PPersegi.SetActive(false);
        PPolos.SetActive(false);

        LDome.SetActive(false);
        LMPiano.SetActive(false);
        LP4.SetActive(true);
        LPPersegi.SetActive(false);
        LPPolos.SetActive(false);

        C12.SetActive(false);
        piano.SetActive(false);
        SBesar.SetActive(false);
        VersaseP.SetActive(false);
        C8.SetActive(false);

        LC8.SetActive(false);
        LC12.SetActive(false);
        Lpiano.SetActive(false);
        LSBesar.SetActive(false);
        LVersaseP.SetActive(false);
    }

    public void shPPersegi()
    {
        Dome.SetActive(false);
        MPiano.SetActive(false);
        P4.SetActive(false);
        PPersegi.SetActive(true);
        PPolos.SetActive(false);

        LDome.SetActive(false);
        LMPiano.SetActive(false);
        LP4.SetActive(false);
        LPPersegi.SetActive(true);
        LPPolos.SetActive(false);

        C12.SetActive(false);
        piano.SetActive(false);
        SBesar.SetActive(false);
        VersaseP.SetActive(false);
        C8.SetActive(false);

        LC8.SetActive(false);
        LC12.SetActive(false);
        Lpiano.SetActive(false);
        LSBesar.SetActive(false);
        LVersaseP.SetActive(false);
    }
    public void shPPolos()
    {
        Dome.SetActive(false);
        MPiano.SetActive(false);
        P4.SetActive(false);
        PPersegi.SetActive(false);
        PPolos.SetActive(true);

        LDome.SetActive(false);
        LMPiano.SetActive(false);
        LP4.SetActive(false);
        LPPersegi.SetActive(false);
        LPPolos.SetActive(true);

        C12.SetActive(false);
        piano.SetActive(false);
        SBesar.SetActive(false);
        VersaseP.SetActive(false);
        C8.SetActive(false);

        LC8.SetActive(false);
        LC12.SetActive(false);
        Lpiano.SetActive(false);
        LSBesar.SetActive(false);
        LVersaseP.SetActive(false);
    }

    public void shC8()
    {
        Dome.SetActive(false);
        MPiano.SetActive(false);
        P4.SetActive(false);
        PPersegi.SetActive(false);
        PPolos.SetActive(false);

        LDome.SetActive(false);
        LMPiano.SetActive(false);
        LP4.SetActive(false);
        LPPersegi.SetActive(false);
        LPPolos.SetActive(false);

        C8.SetActive(true);
        C12.SetActive(false);
        piano.SetActive(false);
        SBesar.SetActive(false);
        VersaseP.SetActive(false);

        LC8.SetActive(true);
        LC12.SetActive(false);
        Lpiano.SetActive(false);
        LSBesar.SetActive(false);
        LVersaseP.SetActive(false);
    }
    public void shC12()
    {
        Dome.SetActive(false);
        MPiano.SetActive(false);
        P4.SetActive(false);
        PPersegi.SetActive(false);
        PPolos.SetActive(false);

        LDome.SetActive(false);
        LMPiano.SetActive(false);
        LP4.SetActive(false);
        LPPersegi.SetActive(false);
        LPPolos.SetActive(false);

        C8.SetActive(false);
        C12.SetActive(true);
        piano.SetActive(false);
        SBesar.SetActive(false);
        VersaseP.SetActive(false);

        LC8.SetActive(false);
        LC12.SetActive(true);
        Lpiano.SetActive(false);
        LSBesar.SetActive(false);
        LVersaseP.SetActive(false);
    }
    public void shPiano()
    {
        Dome.SetActive(false);
        MPiano.SetActive(false);
        P4.SetActive(false);
        PPersegi.SetActive(false);
        PPolos.SetActive(false);

        LDome.SetActive(false);
        LMPiano.SetActive(false);
        LP4.SetActive(false);
        LPPersegi.SetActive(false);
        LPPolos.SetActive(false);

        C8.SetActive(false);
        C12.SetActive(false);
        piano.SetActive(true);
        SBesar.SetActive(false);
        VersaseP.SetActive(false);

        LC8.SetActive(false);
        LC12.SetActive(false);
        Lpiano.SetActive(true);
        LSBesar.SetActive(false);
        LVersaseP.SetActive(false);
    }
    public void shSBesar()
    {
        Dome.SetActive(false);
        MPiano.SetActive(false);
        P4.SetActive(false);
        PPersegi.SetActive(false);
        PPolos.SetActive(false);

        LDome.SetActive(false);
        LMPiano.SetActive(false);
        LP4.SetActive(false);
        LPPersegi.SetActive(false);
        LPPolos.SetActive(false);

        C8.SetActive(false);
        C12.SetActive(false);
        piano.SetActive(false);
        SBesar.SetActive(true);
        VersaseP.SetActive(false);

        LC8.SetActive(false);
        LC12.SetActive(false);
        Lpiano.SetActive(false);
        LSBesar.SetActive(true);
        LVersaseP.SetActive(false);
    }
    public void shVersaseP()
    {
        Dome.SetActive(false);
        MPiano.SetActive(false);
        P4.SetActive(false);
        PPersegi.SetActive(false);
        PPolos.SetActive(false);

        LDome.SetActive(false);
        LMPiano.SetActive(false);
        LP4.SetActive(false);
        LPPersegi.SetActive(false);
        LPPolos.SetActive(false);

        C8.SetActive(false);
        C12.SetActive(false);
        piano.SetActive(false);
        SBesar.SetActive(false);
        VersaseP.SetActive(true);

        LC8.SetActive(false);
        LC12.SetActive(false);
        Lpiano.SetActive(false);
        LSBesar.SetActive(false);
        LVersaseP.SetActive(true);
    }
    public void shType1()
    {
        if(activeState1 == 0 || activeState2 == 1)
        {
            C8.SetActive(false);
            C12.SetActive(false);
            piano.SetActive(false);
            SBesar.SetActive(false);
            VersaseP.SetActive(false);

            LC8.SetActive(false);
            LC12.SetActive(false);
            Lpiano.SetActive(false);
            LSBesar.SetActive(false);
            LVersaseP.SetActive(false);

            arSize.SetActive(true);
            realSize.SetActive(true);

            HorizontalScrollType1.SetActive(true);
            HorizontalScrollType2.SetActive(false);
            
            labeltipe1.SetActive(true);
            labeltipe2.SetActive(false);
            
            activeState1 = 1;
            activeState2 = 0;
        }

        else if (activeState1 == 1)
        {
            HorizontalScrollType1.SetActive(false);

            arSize.SetActive(false);
            realSize.SetActive(false);

            activeState1 = 0;
        }
    }

    public void shType2()
    {
        if (activeState2 == 0 || activeState1 == 1)
        {
            Dome.SetActive(false);
            MPiano.SetActive(false);
            P4.SetActive(false);
            PPersegi.SetActive(false);
            PPolos.SetActive(false);

            LDome.SetActive(false);
            LMPiano.SetActive(false);
            LP4.SetActive(false);
            LPPersegi.SetActive(false);
            LPPolos.SetActive(false);

            arSize.SetActive(true);
            realSize.SetActive(true);

            HorizontalScrollType2.SetActive(true);
            HorizontalScrollType1.SetActive(false);

            labeltipe1.SetActive(false);
            labeltipe2.SetActive(true);

            activeState2 = 1;
            activeState1 = 0;
        }
        else if (activeState2 == 1)
        {
            HorizontalScrollType2.SetActive(false);

            arSize.SetActive(false);
            realSize.SetActive(false);

            activeState2 = 0;
        }
    }
}
