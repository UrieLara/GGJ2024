using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class Villager : MonoBehaviour
{
    Vector3 targetPosition;
    Vector3 towardsTarget;
    float wanderRadius = 4f;

    public float movementSpeed = 1f;
    public float rotationSpeed = 0.15f;

    GameObject player;

    private void Start()
    {
        player = GameObject.Find("Player");

        RecalcularTargetPosition();
    }

    private void Update()
    {
        towardsTarget = targetPosition - transform.position;
        MoveTowards(towardsTarget.normalized);

        if (towardsTarget.magnitude < 0.5f)
        {
            RecalcularTargetPosition();
        }

        transform.LookAt(targetPosition);

    }

    void RecalcularTargetPosition()
    {
        targetPosition = transform.position + Random.insideUnitSphere * wanderRadius;
        targetPosition.y = 0;
    }

    protected void MoveTowards(Vector3 direction)
    {
        Quaternion targetRotation = Quaternion.LookRotation(direction);
        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed);
        transform.position += direction.normalized * movementSpeed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("si");
        if (collision.collider.CompareTag("Player")){
            Debug.Log("colision");
        }
    }



}
