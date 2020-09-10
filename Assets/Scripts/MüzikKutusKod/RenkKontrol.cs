using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class RenkKontrol : MonoBehaviour
{

    [SerializeField]
    GameObject OyunSonuButtonlari;
    [SerializeField]
    Rigidbody2D OyunSonuButtonlarirb;
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
    public bool kontrol4;
    public bool kontrol5;
    public bool kontrol6;
    public bool kontrol7;
    public bool kontrol8;
    public bool kontrol9;
    public bool kontrol10;
    public DevamEtButonlarıKontrol dvmetkod;
    [SerializeField]
    GameObject basaDon;
    public Button DevamEt;


    // Start is called before the first frame update
    void Start()
    {

        DevamEt.gameObject.SetActive(false);

        basilan = gameObject.gameObject;

        basilacaktxt = basilacak.GetComponent<Text>();

        basilacak.SetActive(false);

        interaktifKapat();

        OyunSonuButtonlarirb = OyunSonuButtonlari.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        if (dvmetkod.devamsayac == 0)
        {
            ilkdurum();

            ilkbasarikontrol();

        }

        if(dvmetkod.devamsayac == 1)
        {
            ikincidurum();

            ikincibasarikontrol();
        }

        if(dvmetkod.devamsayac == 2)
        {
            ucuncudurum();

            ucuncubasarikontrol();
        }
        if(dvmetkod.devamsayac == 3)
        {
            sondurum();

            sonbasarikontrol();
        }


    }

    public void ilkbasarikontrol()
    {
        if (kontrol1 == true && kontrol2 == true && kontrol3 == true)
        {

            basari.text = "çok güzel";

            interaktifKapat();

            DevamEt.gameObject.SetActive(true);

        }

        if (sayac == 3 && kontrol1 == false)
        {


            basari.text = "tekrar dene";


            basaDon.SetActive(true);

            interaktifKapat();


        }
        if (sayac == 3 && kontrol2 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 3 && kontrol3 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        

    }

    public void ikincibasarikontrol()
    {
        if (kontrol1 == true && kontrol2 == true && kontrol3 == true && kontrol4==true && kontrol5==true)
        {

            basari.enabled = true;

            basari.text = "devam edelim";

            interaktifKapat();

            DevamEt.interactable = true;

            DevamEt.gameObject.SetActive(true);

        }

        if (sayac == 5 && kontrol1 == false)
        {


            basari.text = "tekrar dene";


            basaDon.SetActive(true);

            interaktifKapat();


        }
        if (sayac == 5 && kontrol2 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 5 && kontrol3 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 5 && kontrol4 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 5 && kontrol5 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

    }

    public void ucuncubasarikontrol()
    {
        if (kontrol1 == true && kontrol2 == true && kontrol3 == true && kontrol4 == true && kontrol5 == true && kontrol6==true && kontrol7==true)
        {

            basari.enabled = true;

            basari.text = "az kaldı";

            interaktifKapat();

            DevamEt.interactable = true;

            DevamEt.gameObject.SetActive(true);

        }

        if (sayac == 7 && kontrol1 == false)
        {


            basari.text = "tekrar dene";


            basaDon.SetActive(true);

            interaktifKapat();


        }
        if (sayac == 7 && kontrol2 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 7 && kontrol3 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 7 && kontrol4 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 7 && kontrol5 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 7 && kontrol6 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 7 && kontrol7 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

    }

    public void sonbasarikontrol()
    {
        if (kontrol1 == true && kontrol2 == true && kontrol3 == true && kontrol4 == true && kontrol5 == true //alt satıra geçildi
            && kontrol6 == true && kontrol7 == true && kontrol8 == true && kontrol9 == true && kontrol10 == true)
        {

            basari.enabled = true;

            basari.text = "TEBRİKLER BAŞARDIN";

            interaktifKapat();

            if (OyunSonuButtonlari.transform.position.y >= 200)
            {

                OyunSonuButtonlarirb.velocity = new Vector3(0, -100, 0);

            }
            else
            {

                OyunSonuButtonlarirb.velocity = new Vector3(0, 0, 0);
            }
            

        }

        if (sayac == 10 && kontrol1 == false)
        {


            basari.text = "tekrar dene";


            basaDon.SetActive(true);

            interaktifKapat();


        }
        if (sayac == 10 && kontrol2 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 10 && kontrol3 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 10 && kontrol4 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 10 && kontrol5 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 10 && kontrol6 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 10 && kontrol7 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 10 && kontrol8 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 10 && kontrol9 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
        }

        if (sayac == 10 && kontrol10 == false)
        {


            basari.text = "tekrar dene";

            basaDon.SetActive(true);

            interaktifKapat();
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

    public void ikincidurum()
    {

        if (basilan.name == "c#Button" && sayac == 1)
        {

            kontrol1 = true;

        }

        if (basilan.name == "e4Button1" && sayac == 2)
        {

            kontrol2 = true;

        }

        if (basilan.name == "c#Button2" && sayac == 3)
        {

            kontrol3 = true;


        }

        if (basilan.name == "e4Button2" && sayac == 4)
        {

            kontrol4 = true;


        }

        if (basilan.name == "c#Button1" && sayac == 5)
        {

            kontrol5 = true;


        }
    }

    public void ucuncudurum()
    {

        if (basilan.name == "c#Button" && sayac == 1)
        {

            kontrol1 = true;

        }

        if (basilan.name == "e4Button1" && sayac == 2)
        {

            kontrol2 = true;

        }

        if (basilan.name == "c#Button2" && sayac == 3)
        {

            kontrol3 = true;


        }

        if (basilan.name == "e4Button2" && sayac == 4)
        {

            kontrol4 = true;


        }

        if (basilan.name == "c#Button1" && sayac == 5)
        {

            kontrol5 = true;


        }

        if (basilan.name == "e4Button" && sayac == 6)
        {

            kontrol6 = true;


        }

        if (basilan.name == "c#Button" && sayac == 7)
        {

            kontrol7 = true;


        }
    }

    public void sondurum()
    {

        if (basilan.name == "c#Button" && sayac == 1)
        {

            kontrol1 = true;

        }

        if (basilan.name == "e4Button1" && sayac == 2)
        {

            kontrol2 = true;

        }

        if (basilan.name == "c#Button2" && sayac == 3)
        {

            kontrol3 = true;


        }

        if (basilan.name == "e4Button2" && sayac == 4)
        {

            kontrol4 = true;


        }

        if (basilan.name == "c#Button1" && sayac == 5)
        {

            kontrol5 = true;


        }

        if (basilan.name == "e4Button" && sayac == 6)
        {

            kontrol6 = true;


        }

        if (basilan.name == "c#Button" && sayac == 7)
        {

            kontrol7 = true;


        }

        if (basilan.name == "d#4Button" && sayac == 8)
        {

            kontrol8 = true;


        }

        if (basilan.name == "c#Button2" && sayac == 9)
        {

            kontrol9 = true;


        }

        if (basilan.name == "b3Button" && sayac == 10)
        {

            kontrol10 = true;


        }
    }


    public void cshbutton1()
    {

        basilan = cshButton[0].gameObject;

        

        MüzikYönetMKutusu.sescalMkutusu("c#");

        sayac++;

    }

    public void cshbutton2()
    {

        basilan = cshButton[1].gameObject;

        MüzikYönetMKutusu.sescalMkutusu("c#");

        sayac++;
    }

    public void cshbutton3()
    {

        basilan = cshButton[2].gameObject;

        MüzikYönetMKutusu.sescalMkutusu("c#");

        sayac++;
    }

    public void e4Button1()
    {

        basilan = e4Button[0].gameObject;

        MüzikYönetMKutusu.sescalMkutusu("e4");

        sayac++;
    }

    public void e4Button2()
    {

        basilan = e4Button[1].gameObject;

        MüzikYönetMKutusu.sescalMkutusu("e4");

        sayac++;
    }

    public void e4Button3()
    {

        basilan = e4Button[2].gameObject;

        MüzikYönetMKutusu.sescalMkutusu("e4");

        sayac++;
    }

    public void b3Button1()
    {

        basilan = b3Button.gameObject;

        MüzikYönetMKutusu.sescalMkutusu("b3");

        sayac++;
    }

    public void dsh4Button1()
    {

        basilan = dsh4Button[0].gameObject;

        MüzikYönetMKutusu.sescalMkutusu("d#4");

        sayac++;
    }

    public void dsh4Button2()
    {

        basilan = dsh4Button[1].gameObject;

        MüzikYönetMKutusu.sescalMkutusu("d#4");

        sayac++;
    }

    public void sarkiyaGit()
    {

        Application.OpenURL("https://www.youtube.com/watch?v=JGwWNGJdvx8");

    }

    public void AnaMenuyeDon()
    {

        SceneManager.LoadScene(0);

    }


    public void baslabuton()
    {
        basilacak.SetActive(true);

        Destroy(baslatxt);
        Destroy(baslabtn);

        StartCoroutine(ilkgeleceksayilar());

       
    }

    public void BasaDonFonk()
    {

        SceneManager.LoadScene(2);

    }

    public IEnumerator IkinciDurumDondur()
    {

        yield return StartCoroutine(ikincigeleceksayilar());


    }

    public IEnumerator ucuncuDurumDondur()
    {

        yield return StartCoroutine(ucuncugeleceksayilar());


    }

    public IEnumerator sonDurumDondur()
    {

        yield return StartCoroutine(songeleceksayilar());

    }


    IEnumerator ilkgeleceksayilar()
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

        interaktifAc();

    }

    private IEnumerator ikincigeleceksayilar()
    {

        DevamEt.gameObject.SetActive(false);

        basari.enabled = false;

        basilacaktxt.enabled = true;

        basilacaktxt.text = " önceki sayıları sakın unutma ";

        yield return new WaitForSeconds(2);

        basilacaktxt.text = "3";

        yield return new WaitForSeconds(1);

        basilacaktxt.text = "3 7";

        yield return new WaitForSeconds(1);

        basilacaktxt.enabled = false;

        interaktifAc();

        kontrol1 = false;
        kontrol2 = false;
        kontrol3 = false;
        sayac = 0;
        

    }

    private IEnumerator ucuncugeleceksayilar()
    {

        DevamEt.gameObject.SetActive(false);

        basari.enabled = false;

        basilacaktxt.enabled = true;

        basilacaktxt.text = " önceki sayıları unutma ";

        yield return new WaitForSeconds(2);

        basilacaktxt.text = "4";

        yield return new WaitForSeconds(1);

        basilacaktxt.text = "4 1";

        yield return new WaitForSeconds(1);

        basilacaktxt.enabled = false;

        interaktifAc();

        kontrol1 = false;
        kontrol2 = false;
        kontrol3 = false;
        kontrol4 = false;
        kontrol5 = false;
        sayac = 0;
    }

    private IEnumerator songeleceksayilar()
    {

        DevamEt.gameObject.SetActive(false);

        basari.enabled = false;

        basilacaktxt.enabled = true;

        basilacaktxt.text = " önceki sayıları unutma ";

        yield return new WaitForSeconds(2);

        basilacaktxt.text = "5";

        yield return new WaitForSeconds(1);

        basilacaktxt.text = "5 6";

        yield return new WaitForSeconds(1);

        basilacaktxt.text = "5 6 2";

        yield return new WaitForSeconds(1);

        basilacaktxt.enabled = false;

        interaktifAc();

        kontrol1 = false;
        kontrol2 = false;
        kontrol3 = false;
        kontrol4 = false;
        kontrol5 = false;
        kontrol6 = false;
        kontrol7 = false;

        sayac = 0;
    }



    void interaktifAc()
    {
        for (int i = 0; i < 3; i++)
        {
            cshButton[i].interactable = true;
            e4Button[i].interactable = true;

        }
        dsh4Button[0].interactable = true;
        dsh4Button[1].interactable = true;
        b3Button.interactable = true;

    }

    void interaktifKapat()
    {
        for (int i = 0; i < 3; i++)
        {
            cshButton[i].interactable = false;
            e4Button[i].interactable = false;

        }
        dsh4Button[0].interactable = false;
        dsh4Button[1].interactable = false;
        b3Button.interactable = false;

    }





}
