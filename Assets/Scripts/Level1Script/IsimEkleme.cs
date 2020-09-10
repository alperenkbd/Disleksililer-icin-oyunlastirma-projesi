using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class IsimEkleme : MonoBehaviour
{

    [SerializeField]
    Text RestoranIsim;
    [SerializeField]
    Image RestoranIsimImage;
    [SerializeField]
    ButtonControl buttoncontrol;


    public void Start()
    {

        RestoranIsim.text = PlayerPrefs.GetString("RestoranIsim") + RestoranIsim.text;

        
    }


    private void Update()
    {

        if (buttoncontrol.SatisPanelGonder()) {


            RestoranIsimImage.gameObject.SetActive(true);

        }
        



    }

}
