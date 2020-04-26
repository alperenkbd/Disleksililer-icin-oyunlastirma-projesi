using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


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


    }

    // Update is called once per frame
    void Update()
    {

        if (dvmetkod.sayac == 0)
        {
            ilkdurum();

            ilkbasarikontrol();

        }

        

        


    }

    public void ilkbasarikontrol()
    {
        if (kontrol1 == true && kontrol2 == true && kontrol3 == true)
        {

            basari.text = "Başardın";

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

        basilacaktxt.text = " Hazır ";

        yield return new WaitForSeconds(1);

        basilacaktxt.text = "1";

        yield return new WaitForSeconds(1);

        basilacaktxt.text = "1 8";

        yield return new WaitForSeconds(1);

        basilacaktxt.text = "1 8 6";

        yield return new WaitForSeconds(1);

        basilacaktxt.text = "1 8 6 3";

        yield return new WaitForSeconds(1);

        basilacaktxt.text = "1 8 6 3 7";

        yield return new WaitForSeconds(1);

        basilacaktxt.enabled = false;

        interaktifAc();
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
