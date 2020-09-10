using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class SonrakiSeviyeKodlari : MonoBehaviour
{
    

    public void AnaMenu()
    {

        SceneManager.LoadScene(0);

    }


    public void sonrakiseviye1()
    {

        SceneManager.LoadScene(3);

        PlayerPrefs.SetInt("levelkontrol1", 1);

    }

    public void sonrakiseviye2()
    {

        SceneManager.LoadScene(4);

        PlayerPrefs.SetInt("levelkontrol2", 2);

    }

    public void sonrakiseviye3()
    {

        SceneManager.LoadScene(5);

        PlayerPrefs.SetInt("levelkontrol3", 3);

    }


    public void sonrakiseviye4()
    {

        SceneManager.LoadScene(6);

        PlayerPrefs.SetInt("levelkontrol4", 4);

    }


    public void sonrakiseviye5()
    {

        SceneManager.LoadScene(7);

        PlayerPrefs.SetInt("levelkontrol5", 5);

    }

    public void sonrakiseviye6()
    {

        SceneManager.LoadScene(8);

        PlayerPrefs.SetInt("levelkontrol6", 6);

    }

}
