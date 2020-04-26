using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class MuzikYonetici : MonoBehaviour
{

    public enum Sound
    {
        OyunMuzik,

        carpma,

        sevinc,

        Gameovr,
    }


    private static AudioClip OyunMuzik, carpma,sevinc, Gameovr;

     static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {

        OyunMuzik = Resources.Load<AudioClip>("Audio/oyunmuzik");
        carpma = Resources.Load<AudioClip>("Audio/topcarpma");
        sevinc = Resources.Load<AudioClip>("Audio/sevinc");
        Gameovr = Resources.Load<AudioClip>("Audio/GameOver");

        audioSrc = GetComponent<AudioSource>();

    }

   

    public static void sescal(Sound sound)
    {

        Resources.UnloadUnusedAssets();

        switch (sound)
        {

            case Sound.OyunMuzik:

                audioSrc.PlayOneShot(OyunMuzik);

                break;

            case Sound.carpma:

                audioSrc.PlayOneShot(carpma);

                break;

            case Sound.sevinc:

                audioSrc.PlayOneShot(sevinc);
                audioSrc.volume = 0.1f;
                break;

            case Sound.Gameovr:

                audioSrc.PlayOneShot(Gameovr);

                break;


        }

    }

    

}
