using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveEntity : MonoBehaviour
{
    public float turnSmoothTime = 0.2f;
    float turnSmoothVelocity;
  
    public Vector3 RotateCharacter(Vector3 direction)
    {

        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

        Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0) * Vector3.forward;

        transform.rotation = Quaternion.Euler(0f, angle, 0f);
        
        return moveDir;
    }

    public Vector3 RotateCharacter(Vector3 direction, Transform target)
    {

        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + target.eulerAngles.y;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

        Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0) * Vector3.forward;

        transform.rotation = Quaternion.Euler(0f, angle, 0f);

        return moveDir;
    }
}
