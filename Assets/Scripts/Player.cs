using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Player : MonoBehaviour
{

    //private CharacterController controller;
    CharacterController controller;
    public float speed = 4;
    public float turnSmoothTime = 0.1f;
    float turnSmoothVelocity;
  

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
            Vector3 movement = new Vector3(hor * speed, 0 , ver * speed);
            MovePlayer(movement);
           
        }
    }

    void MovePlayer( Vector3 direction )
    {
        controller.SimpleMove(direction.normalized * speed);

       /* float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0f, targetAngle, 0f);*/
    }   



}
