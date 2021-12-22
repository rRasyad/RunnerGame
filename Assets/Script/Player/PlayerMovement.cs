using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameManager gameManager;

    public float moveSpeed = 5;//forward speed
    public float sideSpeed = 4;//side speed

    public float velocity;//jump gravity
    private Rigidbody rb;

    //Animator anim;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //automatically move to forward
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);

        //allow to left
        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow) ||
            Input.GetKey(KeyCode.Mouse0))
        {
            //make a barrier in left
            if (this.gameObject.transform.position.x > LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * sideSpeed);
            }
        }

        //allow to right
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) ||
            Input.GetKey(KeyCode.Mouse1))
        {
            //make a barrier in right
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * sideSpeed * -1);
            }
        }

        //allow to Jump
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || 
            Input.GetKey(KeyCode.Space))
        {
            if (this.gameObject.transform.position.y < LevelBoundary.upSide)
            {
                //anim.SetTrigger("Jump");
                rb.velocity = Vector3.up * velocity;
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //when player crash the block with tag "Dead"
        if (other.gameObject.tag == "Dead")
        {
            gameManager.GameOver();//call the method in GameManager.cs
        }
    }
}
