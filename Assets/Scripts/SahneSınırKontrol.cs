using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SahneSınırKontrol : MonoBehaviour
{

    Rigidbody2D rigi;

    // Start is called before the first frame update
    void Start()
    {
        rigi = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        if (rigi.velocity.y > 0 && gameObject.transform.position.y > 7) {

            Destroy(gameObject);
        }


    }
}
