using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BolumSonuParaAnim3 : MonoBehaviour
{

    [SerializeField]
    Text CasaText;
    [SerializeField]
    dogrulukKontrol Dogrulukkontrol;
    [SerializeField]
    bool kntrl = true;
    [SerializeField]
    GameObject KazandinPanel;


    private void Update()
    {

        if (Dogrulukkontrol.GetGectimi() == true && kntrl==true)
        {

            StartCoroutine(paraanimasyon());

            StartCoroutine(kazandinPanelCagir());

            kntrl = false;

        }


    }



    IEnumerator paraanimasyon()
    {

        CasaText.fontSize = 40;

        for (int i = 45; i <= 76; i++)
        {

            CasaText.text = i.ToString();

            yield return new WaitForSeconds(0.2f);
        }

        CasaText.fontSize = 20;

        CasaText.text = "76 tl";


    }


    IEnumerator kazandinPanelCagir()
    {

        yield return new WaitForSeconds(3);

        KazandinPanel.SetActive(true);

    }

}
