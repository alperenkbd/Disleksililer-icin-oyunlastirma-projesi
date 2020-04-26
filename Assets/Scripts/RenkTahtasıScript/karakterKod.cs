using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class karakterKod : MonoBehaviour
{
    public float karakterHiz;
    public Rigidbody2D rb;
    public kameraSarsıntı sarsinti;
    public GameObject karakterparcacik;
    public bool degdimi;
    public AnaMenuKod baslamakıcın;

    public void Awake()
    {
        if (PlayerPrefs.GetInt("baslatikla") != 1) {

            baslamakıcın.nasilOyanir.SetActive(true);
        }
        


    }

    // Start is called before the first frame update
    void Start()
    {

        Time.timeScale = 1;

        rb = gameObject.GetComponent<Rigidbody2D>(); //rigidbody componentinin oyun başladığında atanmasını sağlıyor.
        

    }

    // Update is called once per frame
    void Update()
    {

        hareket(); //hareket kodları update de çağrılıyor 

    }

    //hareket kodları
    public void hareket() {


        if (Input.GetKey(KeyCode.LeftArrow))//yukarı hareket için sol ok 
        {

            rb.velocity = new Vector3(-karakterHiz, 0, 0);


        } else
                 if (Input.GetKey(KeyCode.RightArrow))//aşağı hareket için sağ ok
        {

            rb.velocity = new Vector3(karakterHiz, 0, 0);


        } else {

            rb.velocity = new Vector3(0, 0, 0);
        }



        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7.75f, 7.75f), transform.position.y, transform.position.z);
        //karakterin ekran sınırları içersinde kalmasını sağlayan kısım

    }

    public void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "top") {

            degdimi = true;

            Rigidbody2D Toprb = collision.gameObject.GetComponent<Rigidbody2D>();
            Vector3 çarpmaNok = collision.contacts[0].point;
            Vector3 karakterOrta = new Vector3(this.gameObject.transform.position.x, this.gameObject.transform.position.y);

            Toprb.velocity = Vector2.zero;

            float fark = karakterOrta.x - çarpmaNok.x;

            if (çarpmaNok.x < karakterOrta.x)
            {

                Toprb.AddForce(new Vector2(-(Mathf.Abs(fark * 200)), 250));

            }
            else {

                Toprb.AddForce(new Vector2((Mathf.Abs(fark * 200)), 250));

            }

            MuzikYonetici.sescal(MuzikYonetici.Sound.carpma);
            //0.15f,0.1f
            StartCoroutine(sarsinti.salla(0.15f, 0.1f));
           

            Instantiate(karakterparcacik, gameObject.transform);
            
        }
    }

   



}






