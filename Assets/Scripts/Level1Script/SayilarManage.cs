using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SayilarManage : MonoBehaviour
{
    [SerializeField] Button b1, b2, b3, b4, b5, b6, b7, b8, b9, b0, bsilme,bnokta ;
    [SerializeField] Text SonucText;



    

   


    public void B1Action()
    {

        SonucText.text = SonucText.text + "1";


    }

    public void B2Action()
    {

        SonucText.text = SonucText.text + "2";


    }

    public void B3Action()
    {

        SonucText.text = SonucText.text + "3";


    }


    public void B4Action()
    {

        SonucText.text = SonucText.text + "4";


    }

    public void B5Action()
    {

        SonucText.text = SonucText.text + "5";


    }

    public void B6Action()
    {

        SonucText.text = SonucText.text + "6";


    }

    public void B7Action()
    {

        SonucText.text = SonucText.text + "7";


    }

    public void B8Action()
    {

        SonucText.text = SonucText.text + "8";


    }

    public void B9Action()
    {

        SonucText.text = SonucText.text + "9";


    }


    public void B0Action()
    {

        SonucText.text = SonucText.text + "0";


    }

    public void BsilmeAction()
    {

        if (SonucText.text.Length != 0) {

            SonucText.text = SonucText.text.Remove(SonucText.text.Length -1);

        }
      
        
      
            
        


    }

    public void BNoktaAction()
    {

        SonucText.text = SonucText.text + ".";


    }


}
