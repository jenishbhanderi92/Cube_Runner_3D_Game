using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    /*
    Rigidbody rigidBody;
    public float moveForce;
    public float Jumpforce;
    bool isGrounde = false;
    float xInpute,zInpute;
    // Start is called before the first frame update
    void Start()
    {
        rigidBody = GetComponent<Rigidbody>();  
    }

    // Update is called once per frame
    void Update()
    {
        xInpute = Input.GetAxis("Horizontal");
        zInpute = Input.GetAxis("Vertical");
        move();
       if(Input.GetButtonDown("Jump")& isGrounde)
        {
            isGrounde = false;
            jump();
        }
    }

    void move()
    {   
       rigidBody.AddForce(new Vector3(xInpute,0,zInpute) * moveForce);
      
    }

    void jump()
    {
        rigidBody.AddForce(Vector3.up * Jumpforce, ForceMode.Impulse); // Impulse for instant apply force
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            isGrounde = true;
        }
    }
    */

    Rigidbody Rigidbody;
    public float force;
    public float jumpforce;
    float xpos, zpos;
    bool isground = false;

    private void Start()
    {
        Rigidbody = GetComponent<Rigidbody>();  
    }

    private void Update()
    {
        xpos = Input.GetAxis("Horizontal");
        zpos = Input.GetAxis("Vertical");
        move();

        if(Input.GetButtonDown("Jump") & isground)
        {
            isground = false;
            jump();
        }
    }

    private void move()
    {
        Rigidbody.AddForce(new Vector3 (xpos,0,zpos) * force);
    }

    private void jump()
    {
        Rigidbody.AddForce(Vector3.up * jumpforce, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            isground = true;
        }
    }
}

