using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Player : MoveEntity
{
    CharacterController controller;

    public float speed = 4;
    public Transform cam;


    private void Start()
    {
        controller = GetComponent<CharacterController>();

    }

    private void Update()
    {
        
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        if (hor != 0 || ver != 0)
        {
            Vector3 movement = new Vector3(hor, 0, ver);
            MovePlayer(movement);

            transform.position = new Vector3(this.transform.position.x, -1, this.transform.position.z);
        }
    }

    void MovePlayer(Vector3 movement)
    {

        Vector3 moveDir;
        moveDir = RotateCharacter(movement, cam);
        controller.Move(moveDir.normalized * speed * Time.deltaTime);
    }

}
