using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public float Speed = 0.1f;
    public float SpeedRotate = 0.1f;
    public float jumpForce = 100f;
    public Transform Camera_transform;

    private Rigidbody Rigidbody_my;

    private void Awake()
    {
        Rigidbody_my = GetComponent<Rigidbody>();
    }

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        float inputHoriz = Input.GetAxis("Horizontal");
        float inputVert = Input.GetAxis("Vertical");
        float inputMouseX = Input.GetAxis("Mouse X");
        float inputMouseY = Input.GetAxis("Mouse Y");

        Camera_transform.Rotate(-1 *  inputMouseY * SpeedRotate * Time.deltaTime, 0, 0);
        transform.Rotate(0, inputMouseX * SpeedRotate * Time.deltaTime, 0);
        Rigidbody_my.MovePosition(Rigidbody_my.position + (transform.forward * inputVert + transform.right * inputHoriz) * Speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody_my.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
        }
        //  transform.position += new Vector3(Speed * inputHoriz, 0, Speed * inputVert) * Time.deltaTime;
       // Rigidbody_my.MovePosition(Rigidbody_my.position + new Vector3(Speed * inputHoriz, 0, Speed * inputVert) * Time.deltaTime);
    }
}
