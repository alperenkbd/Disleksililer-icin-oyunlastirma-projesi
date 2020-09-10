using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class dogrulukKontrol : MonoBehaviour
{
    [SerializeField]
    Text InputFieldText;
    [SerializeField]
    ButtonControl buttoncontrol;
    [SerializeField]
    GameObject ParaKonfeti;
    [SerializeField]
    bool gectimi=false; //başka classta çağrılıyor
    [SerializeField]
    GameObject KaybettinizPanel;

    
    public void onaylaButton()
    {

        if (InputFieldText.text == "15" )
        {

            buttoncontrol.getsatispanel().SetActive(false);

            buttoncontrol.getborcuhesaplabutton().interactable = false;

            Instantiate(ParaKonfeti);

            gectimi = true;


        }
        else
        {


            KaybettinizPanel.SetActive(true);

            Time.timeScale = 0;

        }

    }

    public void onaylaButton1()
    {

        if (InputFieldText.text == "30")
        {

            buttoncontrol.getsatispanel().SetActive(false);

            buttoncontrol.getborcuhesaplabutton().interactable = false;

            Instantiate(ParaKonfeti);

            gectimi = true;


        }
        else
        {


            KaybettinizPanel.SetActive(true);

            Time.timeScale = 0;

        }

    }

    public void onaylaButton3()
    {

        if (InputFieldText.text == "31")
        {

            buttoncontrol.getsatispanel().SetActive(false);

            buttoncontrol.getborcuhesaplabutton().interactable = false;

            Instantiate(ParaKonfeti);

            gectimi = true;


        }
        else
        {


            KaybettinizPanel.SetActive(true);

            Time.timeScale = 0;

        }

    }

    public void onaylaButton4()
    {

        if (InputFieldText.text == "36")
        {

            buttoncontrol.getsatispanel().SetActive(false);

            buttoncontrol.getborcuhesaplabutton().interactable = false;

            Instantiate(ParaKonfeti);

            gectimi = true;


        }
        else
        {


            KaybettinizPanel.SetActive(true);

            Time.timeScale = 0;

        }

    }

    public void onaylaButton5()
    {

        if (InputFieldText.text == "48")
        {

            buttoncontrol.getsatispanel().SetActive(false);

            buttoncontrol.getborcuhesaplabutton().interactable = false;

            Instantiate(ParaKonfeti);

            gectimi = true;


        }
        else
        {


            KaybettinizPanel.SetActive(true);

            Time.timeScale = 0;

        }

    }

    public void onaylaButton6()
    {

        if (InputFieldText.text == "13.7")
        {

            buttoncontrol.getsatispanel().SetActive(false);

            buttoncontrol.getborcuhesaplabutton().interactable = false;

            Instantiate(ParaKonfeti);

            gectimi = true;


        }
        else
        {


            KaybettinizPanel.SetActive(true);

            Time.timeScale = 0;

        }

    }

    public void onaylaButton7()
    {

        if (InputFieldText.text == "23.2")
        {

            buttoncontrol.getsatispanel().SetActive(false);

            buttoncontrol.getborcuhesaplabutton().interactable = false;

            Instantiate(ParaKonfeti);

            gectimi = true;


        }
        else
        {


            KaybettinizPanel.SetActive(true);

            Time.timeScale = 0;

        }

    }

    public bool GetGectimi()
    {


        return gectimi;


    }
    
    


}
