using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelControl : MonoBehaviour
{
    [SerializeField]
    Button[] buttons;
    [SerializeField]
    Image[] LockImage;
    [SerializeField]
    Image[] Tamamladin;

    private void Start()
    {

        for(int i = 1; i <= 9; i++)
        {

            buttons[i].interactable = false;

        }

       

        
    }
    private void Update()
    {

        if (PlayerPrefs.GetInt("levelkontrol1") == 1 && PlayerPrefs.GetInt("levelkontrol2") != 2)
        {

            buttons[1].interactable = true;

            Destroy(LockImage[1]);

            Tamamladin[0].gameObject.SetActive(true);

        }
        if (PlayerPrefs.GetInt("levelkontrol2") == 2 && PlayerPrefs.GetInt("levelkontrol3") != 3)
        {
            buttons[0].interactable = false;
            buttons[1].interactable = false;
            buttons[2].interactable = true;

            Destroy(LockImage[1]);
            Destroy(LockImage[2]);

            Tamamladin[0].gameObject.SetActive(true);
            Tamamladin[1].gameObject.SetActive(true);
        }

        if (PlayerPrefs.GetInt("levelkontrol3") == 3 &&  PlayerPrefs.GetInt("levelkontrol4") != 4)
        {
            buttons[0].interactable = false;
            buttons[1].interactable = false;
            buttons[2].interactable = false;
            buttons[3].interactable = true;

            Destroy(LockImage[1]);
            Destroy(LockImage[2]);
            Destroy(LockImage[3]);

            Tamamladin[0].gameObject.SetActive(true);
            Tamamladin[1].gameObject.SetActive(true);
            Tamamladin[2].gameObject.SetActive(true);
        }

        if (PlayerPrefs.GetInt("levelkontrol4") == 4 && PlayerPrefs.GetInt("levelkontrol5") != 5)
        {
            buttons[0].interactable = false;
            buttons[1].interactable = false;
            buttons[2].interactable = false;
            buttons[3].interactable = false;
            buttons[4].interactable = true;

            Destroy(LockImage[1]);
            Destroy(LockImage[2]);
            Destroy(LockImage[3]);
            Destroy(LockImage[4]);

            Tamamladin[0].gameObject.SetActive(true);
            Tamamladin[1].gameObject.SetActive(true);
            Tamamladin[2].gameObject.SetActive(true);
            Tamamladin[3].gameObject.SetActive(true);
        }

        if (PlayerPrefs.GetInt("levelkontrol5") == 5 && PlayerPrefs.GetInt("levelkontrol6") != 6)
        {
            buttons[0].interactable = false;
            buttons[1].interactable = false;
            buttons[2].interactable = false;
            buttons[3].interactable = false;
            buttons[4].interactable = false;
            buttons[5].interactable = true;

            Destroy(LockImage[1]);
            Destroy(LockImage[2]);
            Destroy(LockImage[3]);
            Destroy(LockImage[4]);
            Destroy(LockImage[5]);

            Tamamladin[0].gameObject.SetActive(true);
            Tamamladin[1].gameObject.SetActive(true);
            Tamamladin[2].gameObject.SetActive(true);
            Tamamladin[3].gameObject.SetActive(true);
            Tamamladin[4].gameObject.SetActive(true);
        }

        
        if (PlayerPrefs.GetInt("levelkontrol6") == 6 )
        {
            buttons[0].interactable = false;
            buttons[1].interactable = false;
            buttons[2].interactable = false;
            buttons[3].interactable = false;
            buttons[4].interactable = false;
            buttons[5].interactable = false;
            buttons[6].interactable = true;

            Destroy(LockImage[1]);
            Destroy(LockImage[2]);
            Destroy(LockImage[3]);
            Destroy(LockImage[4]);
            Destroy(LockImage[5]);
            Destroy(LockImage[6]);

            Tamamladin[0].gameObject.SetActive(true);
            Tamamladin[1].gameObject.SetActive(true);
            Tamamladin[2].gameObject.SetActive(true);
            Tamamladin[3].gameObject.SetActive(true);
            Tamamladin[4].gameObject.SetActive(true);
            Tamamladin[5].gameObject.SetActive(true);
        }

    }

    public void level1Basla()
    {

        SceneManager.LoadScene(3);


    }

    public void level2Basla()
    {

        SceneManager.LoadScene(4);


    }

    public void level3Basla()
    {

        SceneManager.LoadScene(5);


    }

    public void level4Basla()
    {

        SceneManager.LoadScene(6);


    }

    public void level5Basla()
    {

        SceneManager.LoadScene(7);


    }

    public void level6Basla()
    {

        SceneManager.LoadScene(8);


    }

    public void level7Basla()
    {

        SceneManager.LoadScene(9);


    }

}
