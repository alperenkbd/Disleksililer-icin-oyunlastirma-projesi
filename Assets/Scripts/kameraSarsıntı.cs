using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kameraSarsıntı : MonoBehaviour
{
    
    public IEnumerator sallanti(float sure, float siddet)
    {

        Vector3 gercekPozisyon = transform.localPosition;

        float gecmis = 0.0f;

        while(gecmis < sure)
        {

            float x = Random.Range(-1f, 1f) * siddet;

            float y = Random.Range(-1f, 1f) * siddet;

            transform.localPosition = new Vector3(x,y,gercekPozisyon.z);

            gecmis += Time.deltaTime;

            yield return null;

        }

        transform.localPosition = gercekPozisyon;


    }



}
