using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

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
    public CinemachineFreeLook freeLook_cam;

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
    void Update()
    {
        InputX = Input.GetAxis("Horizontal");
        InputZ = Input.GetAxis("Vertical");

        InputDecider();
        MovementManager();
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
        gravity -= 9.8f * Time.deltaTime;
        gravity = gravity * gravityMultipler;

        Vector3 moveDirection = desiredMoveDirection * (movementSpeed*Time.deltaTime)*0.08f;
        moveDirection = new Vector3  (moveDirection.x, gravity, moveDirection.z);
        
        characterController.Move(moveDirection);
        
        ani.SetBool("走路", moveDirection.x !=0);

        if(Input.GetKey(KeyCode.LeftShift))
        {
            moveDirection = desiredMoveDirection * (RunSpeed * Time.deltaTime);
            moveDirection = new Vector3(moveDirection.x, gravity, moveDirection.z);

            characterController.Move(moveDirection);
            ani.SetBool("跑步", true);
        }
        else
        {
            ani.SetBool("跑步", false);
        }

        if (characterController.isGrounded)
        {
            gravity = 0;
            if (Input.GetKeyDown(KeyCode.Space))
            {
                gravity = JumpPower * Time.deltaTime;
                ani.SetTrigger("跳");
            }
        }

    }

}
