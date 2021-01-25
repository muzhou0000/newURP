using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Fungus;

[RequireComponent(typeof(CharacterController))]
public class LV2_Movent : MonoBehaviour
{
    private float InputX, InputZ, Speed;
    private Camera cam;
    private CharacterController characterController;

    private Vector3 desiredMoveDirection;

    public Animator ani;
    public float JumpPower;
    public float RunSpeed;
    public V_Follow V;
    //private float curDistance;
    private bool P_Jump;

    //public GameObject Cam;
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

    private void FixedUpdate()
    {
        MovementManager();
        InputDecider();
        if (P_Jump)
        {
            Jump();
            P_Jump = false;
        }
    }
    private void Update()
    {
        //V.curDis = curDistance;
        InputX = Input.GetAxis("Horizontal");
        //InputZ = Input.GetAxis("Vertical");
       
        if(characterController.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space)| Input.GetButtonDown("XboxB"))
            {
                P_Jump = true;
                ani.SetTrigger("跳");
                ani.SetBool("Idle", false);
            }
            else
            {
                ani.SetBool("Idle", true);
            }
        }

       V.Follow(transform.position,10f);
    }
    void InputDecider()
    {
        Speed = new Vector2(InputX, InputZ).sqrMagnitude;

        //Speed = new Vector2(InputX, 0).sqrMagnitude;

        if (Speed > allowRotation)
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
        gravity -= 0.8f * Time.deltaTime;
        gravity = gravity * gravityMultipler;

        Vector3 moveDirection = desiredMoveDirection * (movementSpeed * Time.deltaTime) * 0.08f;
        //moveDirection = new Vector3(moveDirection.x, gravity, moveDirection.z);
        moveDirection = new Vector3(moveDirection.x, gravity, movementSpeed * Time.deltaTime * 0.08f);

        characterController.Move(moveDirection);

        if (characterController.isGrounded)
        {
            gravity = 0;
        }
        ani.SetBool("走路",true);
        ani.SetBool("跑步", moveDirection.z != 0);
        ani.SetBool("Idle", false);


        //if (Input.GetKey(KeyCode.LeftShift))
        //{
        //    moveDirection = desiredMoveDirection * (RunSpeed * Time.deltaTime) * 0.08f;
        //    moveDirection = new Vector3(moveDirection.x, gravity, moveDirection.z);

        //    characterController.Move(moveDirection);
        //    ani.SetBool("跑步", true);
        //}
        //else
        //{
        //    ani.SetBool("跑步", false);
        //}

    }
    void Jump()
    {
        gravity += (JumpPower * Time.fixedDeltaTime);
    }
}
