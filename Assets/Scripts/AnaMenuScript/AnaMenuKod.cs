using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnaMenuKod : MonoBehaviour
{

    public GameObject RenkTahKazanim;
    public GameObject MüzikKazanim;
    public GameObject OyunBitti;
    public GameObject nasilOyanir;

   





    public void OyunaBaslaRenk() {

       

         SceneManager.LoadScene("RenkTahtası");
  

    }

    public void OyunaBaslaMuzik()
    {



        SceneManager.LoadScene("MüzikKutusu");


    }


    public void kazanimRenk() {


            RenkTahKazanim.SetActive(true);

           
    }

    public void kazaniMüzik()
    {


        MüzikKazanim.SetActive(true);


    }


    public void tamam() {

        RenkTahKazanim.SetActive(false);

        MüzikKazanim.SetActive(false);
    }

    public void tekrarOyna() {

        SceneManager.LoadScene("RenkTahtası");

    }

    public void AnaMenu() {

        SceneManager.LoadScene("MainMenu");

    }


    public void basla() {

        
        nasilOyanir.SetActive(false);
        Time.timeScale = 1;
        PlayerPrefs.SetInt("baslatikla", 1);

    }


   


}
