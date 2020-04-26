using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class DevamEtButonlarıKontrol : MonoBehaviour
{
    public RenkKontrol ikincidurumicin;
    [SerializeField]
    Button DevamButton1Obje;
    public int sayac;

    public void DevamEtButon1()
    {
        sayac++;

        if (sayac == 1)
        {

            StartCoroutine(ikincidurumicin.IkinciDurumDondur());

            DevamButton1Obje.interactable = false;

        }

            



    }




}
