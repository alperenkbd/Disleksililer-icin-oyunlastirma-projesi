using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class graph : MonoBehaviour
{


    public Image colon1;
    public Image colon2;
    public Image colon3;
    public Image colon4;
    public int puan1;
    public int puan2;
    public int puan3;
    public int puan4;
    


    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {

        puan1 = PlayerPrefs.GetInt("puan1");
        puan2 = PlayerPrefs.GetInt("puan2");
        puan3 = PlayerPrefs.GetInt("puan3");
        puan4 = PlayerPrefs.GetInt("puan4");

        yukseklikolcekle();

    }


    public void yukseklikolcekle()
    {
        colon1.rectTransform.sizeDelta = new Vector2(colon1.rectTransform.rect.width, 14);
        colon2.rectTransform.sizeDelta = new Vector2(colon1.rectTransform.rect.width, 26);
        colon3.rectTransform.sizeDelta = new Vector2(colon1.rectTransform.rect.width, 6);
        colon4.rectTransform.sizeDelta = new Vector2(colon1.rectTransform.rect.width, 18);
    }



}
