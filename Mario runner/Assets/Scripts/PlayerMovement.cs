using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController2D controller;
    public Command executer;
    public float runSpeed = 40f;
    public PinkPlayerDecorator upgradePlayer;

    float horizontalMove = 0f;
    bool jump = false;
    bool crouch = false;

    private void Start()
    {

    }


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            transform.position += new Vector3(-3f, 0, 0);
        }
    }

    private void Update()
    {

        horizontalMove = Input.GetAxisRaw("Horizontal") * runSpeed;

        if (Input.GetKeyDown(KeyCode.O))
        {
            Instantiate(Resources.Load("PinkPlayerDecorator"), transform.position, transform.rotation);
            Destroy(gameObject);
            Destroy(this);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            executer = new Shrink();
            executer.Execute(this);
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            executer = new Enlarge();
            executer.Execute(this);
        }
        if (Input.GetButtonDown("Jump"))
        {
            jump = true;
        }

        if (Input.GetButtonDown("Crouch"))
        {
            crouch = true;
        }
        else if (Input.GetButtonUp("Crouch"))
        {
            crouch = false;
        }
    }


    private void FixedUpdate()
    {
        // Move our character
        controller.Move(horizontalMove * Time.fixedDeltaTime, crouch, jump);
        jump = false;
        crouch = false;
    }
}
