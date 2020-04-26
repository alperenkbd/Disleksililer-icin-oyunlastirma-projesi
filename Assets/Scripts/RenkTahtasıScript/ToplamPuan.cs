using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ToplamPuan : MonoBehaviour
{
    public puanSistemi puansis1;
    public puanSistemi puansis2;
    public puanSistemi puansis3;
    public puanSistemi puansis4;
    public int toplampn;
    public Text puanyazi;
    public Text oyunicipuan;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        toplampn = puansis1.puan + puansis2.puan + puansis3.puan + puansis4.puan;

        puanyazi.text = toplampn.ToString();

        oyunicipuan.text = "puan:" + toplampn.ToString();

    }
}
