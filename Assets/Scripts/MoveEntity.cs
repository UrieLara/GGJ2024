using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MoveEntity : MonoBehaviour
{
    public float turnSmoothTime = 0.2f;
    float turnSmoothVelocity;

     Vector3 RotateCharacterBase(Vector3 direction, float targetAngleOffset = 0f)
    {
        float targetAngle = Mathf.Atan2(direction.x, direction.z) * Mathf.Rad2Deg + targetAngleOffset;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, ref turnSmoothVelocity, turnSmoothTime);

        Vector3 moveDir = Quaternion.Euler(0f, targetAngle, 0) * Vector3.forward;

        transform.rotation = Quaternion.Euler(0f, angle, 0f);

        return moveDir;
    }

    public Vector3 RotateCharacter(Vector3 direction)
    {
        return RotateCharacterBase(direction);
    }

    public Vector3 RotateCharacter(Vector3 direction, Transform target)
    {
        float targetAngleOffset = target.eulerAngles.y;
        return RotateCharacterBase(direction, targetAngleOffset);
    }


}
