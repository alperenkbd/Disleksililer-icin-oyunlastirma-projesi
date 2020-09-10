using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ButtonControl : MonoBehaviour
{

    [SerializeField]
    Image LoadingBar;
    [SerializeField]
    float MaxTime = 5, CurrentTime;
    [SerializeField]
    bool kontrol=false;
    [SerializeField]
    Text SatisYapiliyorText;
    [SerializeField]
    CustomerScript customerscript;
    [SerializeField]
    Button BorcuHesaplaButton;
    [SerializeField]
    GameObject SatisPanel;
    [SerializeField]
    private bool SatisPanelBool;
    [SerializeField]
    private bool BorcuHesaplaBool;
    [SerializeField]
    Text TimerText;
    [SerializeField]
    float TimerTime;
    [SerializeField]
    dogrulukKontrol Dogrulukkontrol;
    [SerializeField]
    GameObject OyunBittiPanel;



    void Start()
    {

        SatisPanel.SetActive(false);

        SatisPanelBool = true;

        BorcuHesaplaButton.gameObject.SetActive(false);

        SatisYapiliyorText.gameObject.SetActive(false);

        CurrentTime = MaxTime;

        LoadingBar.gameObject.SetActive(false);

        BorcuHesaplaBool = false;

    }

     void Update()
    {

        if (kontrol==true)
        {
            barReduce();


        }


        if (BorcuHesaplaBool == true)
        {

            TimerTime -= Time.deltaTime;

            TimerText.text = TimerTime.ToString("###");

        }

        if (TimerTime < 0 && Dogrulukkontrol.GetGectimi()==false)
        {
            
            
            TimerText.color = Color.red;

            Time.timeScale = 0;

            OyunBittiPanel.SetActive(true);

        }

    }


    public void SatisYap()
    {
        SatisYapiliyorText.gameObject.SetActive(true);

        LoadingBar.gameObject.SetActive(true);

        kontrol = true;

        customerscript.SatisYapButton.gameObject.SetActive(false);
    }

    public void BorcuHesapla()
    {

        SatisPanel.SetActive(true);

        SatisPanelBool = false;

        BorcuHesaplaBool = true;

        
    }



    void barReduce()
    {
        if (CurrentTime > 0)
        {

            CurrentTime -= Time.deltaTime;
            LoadingBar.fillAmount = CurrentTime / MaxTime;
        }
        else
        {
            SatisYapiliyorText.gameObject.SetActive(false);

            BorcuHesaplaButton.gameObject.SetActive(true);
        }



    }

    public bool SatisPanelGonder()
    {

        return SatisPanelBool;

    }

    


    public GameObject getsatispanel()
    {


        return SatisPanel;

    }

    public Button getborcuhesaplabutton()
    {

        return BorcuHesaplaButton;


    }
}
