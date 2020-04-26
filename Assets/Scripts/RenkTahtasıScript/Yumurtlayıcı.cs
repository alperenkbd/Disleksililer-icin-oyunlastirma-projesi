using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yumurtlayıcı : MonoBehaviour
{
    
    public GameObject[] toplar;
    public int randomSayi;
    public float spawnTime = 2.0f;
    public float nextSpawn = 0f;
    public GameObject spawner;


    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RandomSpawner());

        spawner.transform.position = new Vector3(Random.Range(-6.5f,6.5f ),spawner.transform.position.y , spawner.transform.position.z);

    }

    // Update is called once per frame
    void Update()
    {


        if (Time.time > nextSpawn)
        {
            randomSayi = Random.Range(1, 5);

            switch (randomSayi)
            {
                case 1:
                    Instantiate(toplar[0], gameObject.transform.position, Quaternion.identity);

                    break;

                case 2:
                    Instantiate(toplar[1], gameObject.transform.position, Quaternion.identity);

                    break;

                case 3:
                    Instantiate(toplar[2], gameObject.transform.position, Quaternion.identity);

                    break;

                case 4:
                    Instantiate(toplar[3], gameObject.transform.position, Quaternion.identity);

                    break;

                

            }

            nextSpawn = Time.time + spawnTime;

        }
    }

    IEnumerator RandomSpawner()
    {



        while (true)
        {

            yield return new WaitForSeconds(spawnTime);

            spawner.transform.position = new Vector3(Random.Range(-6.5f, 6.5f), spawner.transform.position.y, spawner.transform.position.z);

        }

    }

    }
