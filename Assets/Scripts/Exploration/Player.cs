using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MoveEntity
{
    private void Update()
    {
        Vector3 direccion = Vector3.zero;

        if (Input.GetKey(KeyCode.A))
        {
            direccion += Vector3.left;
        }
        if (Input.GetKey(KeyCode.D))
        {
            direccion += Vector3.right;
        }
        if (Input.GetKey(KeyCode.W))
        {
            direccion += Vector3.forward;
        }
        if (Input.GetKey(KeyCode.S))
        {
            direccion += Vector3.back;
        }

        if (direccion!= Vector3.zero)
        {
            MoveTowards(direccion.normalized);
        }
    }

  
}
