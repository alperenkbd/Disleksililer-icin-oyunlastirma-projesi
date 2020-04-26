using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AltDuvarKod : MonoBehaviour
{

    public Image can1, can2, can3;
    public GameObject oyunbitti;


    public int sayac=0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "top") {

            sayac++;

            if (sayac == 1) {
                Destroy(can1);

            }else if (sayac == 2)
            {
                Destroy(can2);

            }
            else if (sayac == 3)
            {
                Destroy(can3);
                oyunbitti.SetActive(true);
                Time.timeScale = 0;
            }


        }




    }
}
