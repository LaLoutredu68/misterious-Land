using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float speed = 6f;
    public float jumpspeed = 8f;
    public float gravity = 20f;
    private Vector3 moveD = Vector3.zero;
    private CharacterController Cac;
    void Start()
    {
        Cac = GetComponent<CharacterController>();
    }
    
    void Update()
    {
        if (Cac.isGrounded)
        {
            moveD = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Horizontal"));
            moveD = transform.TransformDirection(moveD);
            moveD *= speed;

            if (Input.GetButton("Jump"))
            {
                moveD.y = jumpspeed;
            }
        }

        moveD.y -= gravity * Time.deltaTime;
        transform.Rotate (Vector3.up * Input.GetAxis("Mouse X") * Time.deltaTime * speed * 50);

        Cac.Move(moveD * Time.deltaTime);
    }
}
