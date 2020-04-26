using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class puanSistemi : MonoBehaviour
{
    public karakterKod dgd;
    public string isim;
    public int puan=0;
    public GameObject prtkl;
    



    public void OnTriggerEnter2D(Collider2D collision)
    {


        if (collision.GetComponent<Rigidbody2D>().velocity.y > 0) {
            if (collision.gameObject.name == isim)
            {
                puan++;

                Instantiate(prtkl,new Vector3(collision.transform.position.x, collision.transform.position.y,-5),Quaternion.identity);

                Destroy(collision.gameObject);

                MuzikYonetici.sescal(MuzikYonetici.Sound.sevinc);

                Debug.Log(dgd.degdimi);

            }


        }


        /*if (dgd.degdimi==true )
            {

                if(collision.gameObject.name == isim)
            {
                puan++;
                MuzikYonetici.sescal("sevinc");

                Debug.Log(dgd.degdimi);

            }
                
            }*/

        
            



       



    }


}
