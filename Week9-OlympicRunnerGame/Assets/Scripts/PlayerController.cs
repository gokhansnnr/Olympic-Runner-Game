using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Animator animator;
    public float moveSpeed;
    public CharacterController characterController;
    public Transform cam;
    public float lookSensivity; //Ayarlardan fare hassasiyeti kontrolü al!
    public float maxXRot;
    public float minXRot;
    private float curXRot;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S))
        {
            Move();
            animator.SetBool("isFastRun", true);
        }
        else
        {
            animator.SetBool("isFastRun", false);
        }

        if (Cursor.lockState == CursorLockMode.Locked)
        {
            Look();
        }
    }

    private void Move() //Klavye
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");



        Vector3 dir = transform.right * x + transform.forward * z;
        dir.Normalize();

        dir *= moveSpeed * Time.deltaTime;
        characterController.Move(dir);
    }

    public void Look() //Mouse
    {
        float x = Input.GetAxis("Mouse X") * lookSensivity;
        float y = Input.GetAxis("Mouse Y") * lookSensivity;

        transform.eulerAngles += Vector3.up * x;

        curXRot += y;
        curXRot = Mathf.Clamp(curXRot, minXRot, maxXRot);
        cam.localEulerAngles = new Vector3(-curXRot, 0.0f, 0.0f);

    }
}
