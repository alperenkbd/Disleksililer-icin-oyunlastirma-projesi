using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CustomerScript : MonoBehaviour
{
    [SerializeField]
    Rigidbody2D rbCustomer;
    private bool crashControl=false;
    [SerializeField]
    Animator animator;
    [SerializeField]
    public Button SatisYapButton;


    private void Start()
    {

        Time.timeScale = 1;

        SatisYapButton.gameObject.SetActive(false);

        rbCustomer = gameObject.GetComponent<Rigidbody2D>();

       
    }

    // Update is called once per frame
    void Update()
    {

        if (crashControl == false)
        {

            rbCustomer.velocity = new Vector3(3, 0, 0);

        }
        else{

            rbCustomer.velocity = new Vector3(0, 0, 0);
        }

        


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.tag == "customerControl")
        {

            crashControl = true;

            animator.SetBool("iswalking", false);

            SatisYapButton.gameObject.SetActive(true);
            

        }


    }

    
    
}
