﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Fungus;

[RequireComponent(typeof(CharacterController))]
public class MoventmentController : MonoBehaviour
{
    private float InputX, InputZ, Speed;
    private Camera cam;
    private CharacterController characterController;

    private Vector3 desiredMoveDirection;

    public Animator ani;
    public float JumpPower;
    public float RunSpeed;
    public GameObject Cam;
    public Flowchart Talk;
    //public GameObject Jump_Object;
    //public CinemachineFreeLook freeLook_cam;

    [SerializeField] float rotationSpeed = 0.3f;
    [SerializeField] float allowRotation = 0.1f;
    [SerializeField] float movementSpeed = 3f;
    [SerializeField] float gravity;
    [SerializeField] float gravityMultipler;
    //Start is called before the first frame update

    void Start()
    {
        characterController = GetComponent<CharacterController>();
        cam = Camera.main;
        //rig = GetComponent<Rigidbody>();
    }
    // Update is called once per frame

    private void Update()
    {
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");

       
        MovementController();

    }
    void InputDecider()
    {
        Speed = new Vector2(InputX, InputZ).sqrMagnitude;

        if(Speed > allowRotation)
        {
            RotationManger();
        }
        else
        {
            desiredMoveDirection = Vector3.zero;
        }
    }

    void RotationManger()
    {
        var forward = cam.transform.forward;
        var right = cam.transform.right;

        forward.y = 0;
        right.y = 0;

        forward.Normalize();
        right.Normalize();

        desiredMoveDirection = forward * InputZ + right * InputX;

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(desiredMoveDirection), rotationSpeed);
     
    }
    void MovementManager()
    {
        gravity -= 100f* Time.deltaTime*Time.fixedDeltaTime;
        gravity = gravity * gravityMultipler;

        Vector3 moveDirection = desiredMoveDirection * (movementSpeed*Time.deltaTime)*0.08f;
        moveDirection = new Vector3  (moveDirection.x, gravity, moveDirection.z);
        
        characterController.Move(moveDirection);
        
        ani.SetBool("走路", moveDirection.x !=0);
        ani.SetBool("Idle", false);


        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveDirection = desiredMoveDirection * (RunSpeed * Time.deltaTime) * 0.08f;
            moveDirection = new Vector3(moveDirection.x, gravity, moveDirection.z);

            characterController.Move(moveDirection);
            ani.SetBool("跑步", true);
        }
        else
        {
            ani.SetBool("跑步", false);
        }

    }
    void Jump()
    {
        if (characterController.isGrounded)
        {
            gravity = 0;
            if (Input.GetKeyDown(KeyCode.Space) && gravity == 0)
            {
                gravity += (JumpPower * Time.fixedDeltaTime) *0.08f ;
                ani.SetTrigger("跳");
                ani.SetBool("Idle", false);
            }
            else
            {
                ani.SetBool("Idle", true);
            }
        }
    }
    void  MovementController()
    {
        if(Talk.GetBooleanVariable("對話中") ==false)
        {
            MovementManager();
            Jump();
            InputDecider();
        }
        if (Talk.GetBooleanVariable("對話中") == true)
        {
            ani.SetBool("Idle", true);
            ani.SetBool("跑步", false);
            ani.SetBool("走路", false);
        }

    }
}
