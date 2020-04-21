using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MuzikYonetici : MonoBehaviour
{
    public static AudioClip OyunMuzik, carpma,sevinc, Gameovr,cshses,e4ses,b3,dsh4;

    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {

        OyunMuzik = Resources.Load<AudioClip>("oyunmuzik");
        carpma = Resources.Load<AudioClip>("topcarpma");
        sevinc = Resources.Load<AudioClip>("sevinc");
        Gameovr = Resources.Load<AudioClip>("GameOver");

        cshses = Resources.Load<AudioClip>("c#");
        e4ses = Resources.Load<AudioClip>("e4");
        b3 = Resources.Load<AudioClip>("b3");
        dsh4 = Resources.Load<AudioClip>("d#4");


        audioSrc = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {

    }

    public static void sescal(string clip)
    {
        switch (clip)
        {

            case "OyunMuzik":

                audioSrc.PlayOneShot(OyunMuzik);

                break;

            case "topcarpma":

                audioSrc.PlayOneShot(carpma);

                break;

            case "sevinc":

                audioSrc.PlayOneShot(sevinc);
                audioSrc.volume = 0.1f;
                break;

            case "GameOver":

                audioSrc.PlayOneShot(Gameovr);

                break;

            case "c#" :
                audioSrc.PlayOneShot(cshses);
                break;

            case "e4":
                audioSrc.PlayOneShot(e4ses);
                break;

            case "b3":
                audioSrc.PlayOneShot(b3);
                break;


            case "d#4":
                audioSrc.PlayOneShot(dsh4);
                break;

        }

    }
}
