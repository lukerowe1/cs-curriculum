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


    public float ySpeed;
    private float yVector;
    private float yDirection;

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

        ySpeed = 5f;


    }

    private void Update()
    {


        xDirection = Input.GetAxis("Horizontal");
        xVector = xSpeed * xDirection * Time.deltaTime;
        transform.position = transform.position + new Vector3(xVector, 0, 0);


        yDirection = Input.GetAxis("Vertical");
        yVector = ySpeed * yDirection * Time.deltaTime;
        transform.position = transform.position + new Vector3(0, yVector, 0);


        //xVector = 
    }

    //for organization, put other built-in Unity functions here

    private void OnTriggerEnter2D(Collider2D other)

    {
        if (other.gameObject.CompareTag("Coin"))
        {
            Destroy(other.gameObject);
        }
    }

    private void onCollisionEnter2d(Collision2D other)
     {
        if(other.gameObject.CompareTag("Wall"))
        {
            print("we hit a wall");
        }
     }
    //after all Unity functions, your own functions can go here
}
