using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;
using Fungus;

[RequireComponent(typeof(CharacterController))]
public class LV1_Movent : MonoBehaviour
{
    private float InputX, InputZ, Speed;
    private Camera cam;
    private CharacterController characterController;

    private Vector3 desiredMoveDirection;
    public Animator ani;
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

        //if (characterController.isGrounded&&gravity==0&& Input.GetKeyDown(KeyCode.Space)
        //    ||characterController.isGrounded && gravity == 0 && Input.GetButtonDown("XboxB"))
        //{
        //        P_Jump = true;
        //        ani.SetTrigger("跳");
        //        ani.SetBool("Idle", false);
        //}
        //else
        //{
        //    ani.SetBool("Idle", true);
        //}
        if (!ani.GetBool("跑步"))
        {
            ani.SetBool("Idle", true);
        }
      
    }
    private void FixedUpdate()
    {
        MovementController();
    }
    void InputDecider()
    {
        Speed = new Vector2(InputX, InputZ).sqrMagnitude;

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
        gravity -= 100f * Time.deltaTime * Time.fixedDeltaTime;
        gravity = gravity * gravityMultipler;

        Vector3 moveDirection = desiredMoveDirection * (movementSpeed * Time.fixedDeltaTime) * 0.08f;
        moveDirection = new Vector3(moveDirection.x, gravity, moveDirection.z);

        characterController.Move(moveDirection);

        ani.SetBool("跑步", moveDirection.x != 0);
        ani.SetBool("Idle", false);

        characterController.Move(moveDirection);

        if (characterController.isGrounded)
        {
            gravity = 0;
        }
    }
    //void Jump()
    //{
    //    if (P_Jump)
    //    {
    //        gravity += (JumpPower * Time.fixedDeltaTime) * 0.08f;
    //        P_Jump = false;
    //    }


    //}
    void MovementController()
    {
        if (Talk.GetBooleanVariable("對話中") == false)
        {

            MovementManager();
            InputDecider();
            //Jump();
            Cam.GetComponent<CinemachineFreeLook>().m_XAxis.m_MaxSpeed = 3000;
            Cam.GetComponent<CinemachineFreeLook>().m_YAxis.m_MaxSpeed = 25;
        }
        if (Talk.GetBooleanVariable("對話中") == true)
        {
            ani.SetBool("Idle", true);
            ani.SetBool("跑步", false);
            ani.SetBool("走路", false);
            Cam.GetComponent<CinemachineFreeLook>().m_XAxis.m_MaxSpeed = 0;
            Cam.GetComponent<CinemachineFreeLook>().m_YAxis.m_MaxSpeed = 0;
        }

    }
}
