using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
//using UnityEngine.SceneManagement;

public class Villager : MoveEntity
{
    Vector3 targetPosition;
    Vector3 towardsTarget;
    float wanderRadius = 4f;

    public float speed = 1f;
    //public float rotationSpeed = 0.15f;

    Rigidbody rb;
    GameObject player;
    
 
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");

        RecalcularTargetPosition();
    }

    private void Update()
    {
        towardsTarget = targetPosition - transform.position;
        MoveVillager();

    }

    void RecalcularTargetPosition()
    {
        targetPosition = transform.position + Random.insideUnitSphere * wanderRadius;
        targetPosition.y = 0;
    }

    void MoveVillager()
    {

        RotateCharacter(towardsTarget);
        transform.position += towardsTarget.normalized * speed * Time.deltaTime;

        if (towardsTarget.magnitude < 0.5f)
        {
            RecalcularTargetPosition();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {

        // FALTA CORREGIR - NO SE DETECTA LA COLISION
        Debug.Log("si");
        if (collision.collider.CompareTag("Player")){
            Debug.Log("colision");
        }
    }



}
