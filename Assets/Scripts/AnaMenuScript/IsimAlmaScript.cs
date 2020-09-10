using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IsimAlmaScript : MonoBehaviour
{
    [SerializeField]
    GameObject isimAlmaPaneli;
    public Text Isim;

    

    public void Update()
    {



        if (PlayerPrefs.GetInt("acildimi") == 1)
        {

            isimAlmaPaneli.SetActive(false);

        }


    }

    public void Isimtamam()
    {

        PlayerPrefs.SetString("RestoranIsim", Isim.text);

        PlayerPrefs.SetInt("acildimi", 1);

        Debug.Log(PlayerPrefs.GetInt("acildimi"));

        Debug.Log(PlayerPrefs.GetInt("RestoranIsim"));
    }

    public void ResetPlayerprefs() {

        PlayerPrefs.DeleteAll();

    }



}
