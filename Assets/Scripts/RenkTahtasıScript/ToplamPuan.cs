using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToplamPuan : MonoBehaviour
{
    public puanSistemi puansis1;
    public puanSistemi puansis2;
    public puanSistemi puansis3;
    public puanSistemi puansis4;
    public AltDuvarKod can3kontrol;
    public int toplampn;
    public Text puanyazi;
    public Text oyunicipuan;
    public int initalizer;


    private void Start()
    {

        

    }


    // Update is called once per frame
    void Update()
    {
        toplampn = puansis1.puan + puansis2.puan + puansis3.puan + puansis4.puan;

        puanyazi.text = toplampn.ToString();

        oyunicipuan.text = "puan:" + toplampn.ToString();

        oyunsonuverileri();

    }


    public void oyunsonuverileri()
    {

        

        if (can3kontrol.can3 == null) {


            if (PlayerPrefs.GetInt("init") == 0) {
                PlayerPrefs.SetInt("init", 1);
            } else if(PlayerPrefs.GetInt("init") == 1)
            {
                PlayerPrefs.SetInt("init", 2);
            }
            else if (PlayerPrefs.GetInt("init") == 2)
            {
                PlayerPrefs.SetInt("init", 3);
            }
            else if (PlayerPrefs.GetInt("init") == 3)
            {
                PlayerPrefs.SetInt("init", 4);
            }
            else if (PlayerPrefs.GetInt("init") == 4)
            {
                PlayerPrefs.SetInt("init", 0);
            }


            if (PlayerPrefs.GetInt("init") % 1 == 0) {

                PlayerPrefs.SetInt("puan1" , toplampn);

            }

            if (PlayerPrefs.GetInt("init") % 2 == 0)
            {

                PlayerPrefs.SetInt("puan2", toplampn);

            }

            if (PlayerPrefs.GetInt("init") % 3 == 0)
            {

                PlayerPrefs.SetInt("puan3", toplampn);

            }

            if (PlayerPrefs.GetInt("init") % 4 == 0) {

                PlayerPrefs.SetInt("puan4" , toplampn);

            }

            

        }
        
    }


}
