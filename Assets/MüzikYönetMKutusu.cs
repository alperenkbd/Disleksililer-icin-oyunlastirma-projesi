using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MüzikYönetMKutusu : MonoBehaviour
{
    public static AudioClip  cshses, e4ses, b3, dsh4;

    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        

        cshses = Resources.Load<AudioClip>("Audio/c#");
        e4ses = Resources.Load<AudioClip>("Audio/e4");
        b3 = Resources.Load<AudioClip>("Audio/b3");
        dsh4 = Resources.Load<AudioClip>("Audio/d#4");


        audioSrc = GetComponent<AudioSource>();

    }


    public static void sescalMkutusu(string clip)
    {

        Resources.UnloadUnusedAssets();

        switch (clip)
        {

            case "c#":
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
