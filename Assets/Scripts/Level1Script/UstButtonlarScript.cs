using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UstButtonlarScript : MonoBehaviour
{

    [SerializeField]
    GameObject YenilenlerPanel, MenuPanel, HesaplaPanel;
    [SerializeField]
    Button YenilenlerButton, MenuButton, HesaplaButton;

    void Start()
    {
        YenilenlerButton.image.color = Color.green;

        HesaplaPanel.SetActive(false);
        MenuPanel.SetActive(false);
        YenilenlerPanel.SetActive(true);

    }


    public void hesapla()
    {
        HesaplaPanel.SetActive(true);
        MenuPanel.SetActive(false);
        YenilenlerPanel.SetActive(false);

        HesaplaButton.image.color = Color.green;
        MenuButton.image.color = Color.white;
        YenilenlerButton.image.color = Color.white;

    }


    public void yenilenler()
    {

        HesaplaPanel.SetActive(false);
        MenuPanel.SetActive(false);
        YenilenlerPanel.SetActive(true);

        HesaplaButton.image.color = Color.white;
        MenuButton.image.color = Color.white;
        YenilenlerButton.image.color = Color.green;
    }



    public void menu()
    {

        HesaplaPanel.SetActive(false);
        MenuPanel.SetActive(true);
        YenilenlerPanel.SetActive(false);

        HesaplaButton.image.color = Color.white;
        MenuButton.image.color = Color.green;
        YenilenlerButton.image.color = Color.white;

    }

}
