using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RenkKontrol : MonoBehaviour
{

    public Button[] cshButton;
    public Button[] e4Button;
    public Button b3Button;
    public Button[] dsh4Button;
    public GameObject baslabtn;
    public Text baslatxt;
    public GameObject basilacak;
    public GameObject basilan;
    Text basilacaktxt;
    public Text basari;
    public int sayac;
    public bool kontrol1;
    public bool kontrol2;
    public bool kontrol3;




    // Start is called before the first frame update
    void Start()
    {

        basilan = gameObject.gameObject;

        basilacaktxt = basilacak.GetComponent<Text>();

        basilacak.SetActive(false);

        for(int i = 0; i < 3; i++)
        {
            cshButton[i].enabled = false;
            e4Button[i].enabled = false;

        }
        dsh4Button[0].enabled = false;
        dsh4Button[1].enabled = false;
        b3Button.enabled = false;


    }

    // Update is called once per frame
    void Update()
    {

        ilkdurum();

        ilkbasarikontrol();

        


    }

    public void ilkbasarikontrol()
    {
        if (kontrol1 == true && kontrol2 == true && kontrol3 == true)
        {


            basari.text = "Başardın";
            
        }

        if (sayac == 3 && kontrol1 == false)
        {


            basari.text = "tekrar dene";

        }
        if (sayac == 3 && kontrol2 == false)
        {


            basari.text = "tekrar dene";
        }

        if (sayac == 3 && kontrol3 == false)
        {


            basari.text = "tekrar dene";
        }

    }


    public void ilkdurum()
    {

        if (basilan.name == "c#Button" && sayac==1)
        {

            kontrol1 = true;

        }

        if (basilan.name == "e4Button1"  && sayac==2 )
        {

            kontrol2 = true;

        }

        if (basilan.name == "c#Button2" && sayac==3)
        {

            kontrol3 = true;

                    
        }
    }

   public void cshbutton1()
    {

        basilan = cshButton[0].gameObject;

        cshButton[0].GetComponent<Image>().color = new Color(255, 255, 255, 255);

        MuzikYonetici.sescal("c#");

        sayac++;

    }

    public void cshbutton2()
    {

        basilan = cshButton[1].gameObject;

        cshButton[1].GetComponent<Image>().color = new Color(255, 255, 255, 255);

        MuzikYonetici.sescal("c#");

        sayac++;
    }

    public void cshbutton3()
    {

        basilan = cshButton[2].gameObject;

        cshButton[2].GetComponent<Image>().color = new Color(255, 255, 255, 255);

        MuzikYonetici.sescal("c#");

        sayac++;
    }

    public void e4Button1()
    {

        basilan = e4Button[0].gameObject;

        e4Button[0].GetComponent<Image>().color = new Color(255, 255, 255, 255);

        MuzikYonetici.sescal("e4");

        sayac++;
    }

    public void e4Button2()
    {

        basilan = e4Button[1].gameObject;

        e4Button[1].GetComponent<Image>().color = new Color(255, 255, 255, 255);

        MuzikYonetici.sescal("e4");

        sayac++;
    }

    public void e4Button3()
    {

        basilan = e4Button[2].gameObject;

        e4Button[2].GetComponent<Image>().color = new Color(255, 255, 255, 255);

        MuzikYonetici.sescal("e4");

        sayac++;
    }

    public void b3Button1()
    {

        basilan = b3Button.gameObject;

        b3Button.GetComponent<Image>().color = new Color(255, 255, 255, 255);

        MuzikYonetici.sescal("b3");

        sayac++;
    }

    public void dsh4Button1()
    {

        basilan = dsh4Button[0].gameObject;

        dsh4Button[0].GetComponent<Image>().color = new Color(255, 255, 255, 255);

        MuzikYonetici.sescal("d#4");

        sayac++;
    }

    public void dsh4Button2()
    {

        basilan = dsh4Button[1].gameObject;

        dsh4Button[1].GetComponent<Image>().color = new Color(255, 255, 255, 255);

        MuzikYonetici.sescal("d#4");

        sayac++;
    }

    public void baslabuton()
    {
        basilacak.SetActive(true);

        Destroy(baslatxt);
        Destroy(baslabtn);

        StartCoroutine(geleceksayilar());

        

    }


    IEnumerator geleceksayilar()
    {

        basilacaktxt.text = " Hazır ";

        yield return new WaitForSeconds(1);

        basilacaktxt.text = "1";

        yield return new WaitForSeconds(1);

        basilacaktxt.text = "1 8";

        yield return new WaitForSeconds(1);

        basilacaktxt.text = "1 8 6";

        yield return new WaitForSeconds(1);

        basilacaktxt.enabled = false;

        for (int i = 0; i < 3; i++)
        {
            cshButton[i].enabled = true;
            e4Button[i].enabled = true;

        }
        dsh4Button[0].enabled = true;
        dsh4Button[1].enabled = true;
        b3Button.enabled = true;
    }



}
