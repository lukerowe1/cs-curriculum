using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float xSpeed;
    private float xVector;
    private float xDirection;
    private Rigidbody2D rb;

  
    public bool overworld; 

    private void Start()
    {
       // rb = GetComponent,Rigidbody2d.();

        GetComponentInChildren<TopDown_AnimatorController>().enabled = overworld;
        GetComponentInChildren<Platformer_AnimatorController>().enabled = !overworld; //what do you think ! means?
        
        
        if (overworld)
        {
            GetComponent<Rigidbody2D>().gravityScale = 0f;
        }
        else
        {
            GetComponent<Rigidbody2D>().gravityScale = 1;
        }




        xSpeed = 5f;




    }

    private void Update()
    {
    

        xDirection = Input.GetAxis("Horizontal");
        xVector = xSpeed * xDirection * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, 0, 0);


        //xVector = 
    }
    
    //for organization, put other built-in Unity functions here
    
    
    
    
    
    //after all Unity functions, your own functions can go here
}