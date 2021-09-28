using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerController : MonoBehaviour
{
    [SerializeField] float speed = 10;
    [SerializeField] float rotationSpeed = 120;
    private float rotation = 0f;
    private float gravity = 8;
    private Vector3 moveDirection = Vector3.zero;
    public GameObject character;

    CharacterController controller;
    Animator anim;

    private void Start()
    {
        controller = GetComponent<CharacterController>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        Movement();
    }

    void Movement()
    {

        if (Input.GetKey(KeyCode.W))
        {
            anim.SetInteger("Run", 1);
            moveDirection = new Vector3(0, 0, 1);
            moveDirection *= speed;
            moveDirection = transform.TransformDirection(moveDirection);
        }

        if (Input.GetKeyUp(KeyCode.W))
        {
            anim.SetInteger("Run", 0);
            moveDirection = new Vector3(0, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            anim.SetInteger("Run", 2);
            moveDirection = new Vector3(0, 0, -1);
            moveDirection *= speed/3f;
            moveDirection = transform.TransformDirection(moveDirection);
        }

        if (Input.GetKeyUp(KeyCode.S))
        {
            anim.SetInteger("Run", 0);
            moveDirection = new Vector3(0, 0, 0);
        }

        rotation += Input.GetAxis("Horizontal") * rotationSpeed * Time.deltaTime;
        transform.eulerAngles = new Vector3(0, rotation, 0);

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);
    }

    void FixedUpdate()
    {
#if UNITY_EDITOR
        RunCharacter(Input.GetAxis("Horizontal"));
#endif
    }

    private void RunCharacter(float horizontalInput)
    {
        anim.SetInteger("Run", 1);
        moveDirection = new Vector3(0, 0, 45 * Time.deltaTime);
        moveDirection *= speed;
        moveDirection = transform.TransformDirection(moveDirection);
    }
}
