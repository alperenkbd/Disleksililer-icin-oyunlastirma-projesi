using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DevamEtButonlarıKontrol : MonoBehaviour
{
    public RenkKontrol NumControl;
    [SerializeField]
    Button DevamButton1Obje;
    public int devamsayac;

    public void DevamEtButon1()
    {
        devamsayac++;

        if (devamsayac == 1)
        {

            StartCoroutine(NumControl.IkinciDurumDondur());

            DevamButton1Obje.interactable = false;

        }

        if (devamsayac == 2)
        {

            StartCoroutine(NumControl.ucuncuDurumDondur());

            DevamButton1Obje.interactable = false;
        }

        if(devamsayac == 3)
        {

            StartCoroutine(NumControl.sonDurumDondur());

            DevamButton1Obje.interactable = false;
        }

    }




}
