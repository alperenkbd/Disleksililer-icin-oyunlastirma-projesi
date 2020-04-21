using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArkaplanKod : MonoBehaviour
{
    public float donmeHizi;

    // Update is called once per frame
    void Update()
    {

        kendiEksenindeDon();




    }



    public void kendiEksenindeDon() {

        gameObject.transform.Rotate(0,0,Time.deltaTime * donmeHizi);


    }


}
