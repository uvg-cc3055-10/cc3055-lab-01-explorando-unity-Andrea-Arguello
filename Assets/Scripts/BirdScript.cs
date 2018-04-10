using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour {

    public float forwardSpeed = 2f;
    public float jumpForce = 100f;
    public Rigidbody2D rb;
    public GameObject cam;
    public Boolean dead = false;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        if (dead == false)
        {
            if (Input.GetButtonDown("Jump"))
            {
                rb.velocity = Vector2.zero;
                rb.AddForce(new Vector2(0, 1) * (jumpForce));
            }
            rb.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
            cam.transform.Translate(new Vector3(1, 0, 0) * forwardSpeed * Time.deltaTime);
        }
        if(rb.transform.position.x >= 54)
        {
            dead = true;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        dead = true;
    }

    

}
