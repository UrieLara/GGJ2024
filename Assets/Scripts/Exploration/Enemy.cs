using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MoveEntity
{
    
    Vector3 targetPosition;
    Vector3 towardsTarget;
    float wanderRadius = 5f;

    void RecalcularTargetPosition()
    {
        targetPosition = transform.position + Random.insideUnitSphere * wanderRadius;
        targetPosition.y = 0;
    }

    void Start()
    {
        RecalcularTargetPosition();
    }

    // Update is called once per frame
    void Update()
    {
        towardsTarget = targetPosition - transform.position;
        MoveTowards(towardsTarget.normalized);

        if (towardsTarget.magnitude < 0.25f)
        {
            RecalcularTargetPosition();
        }

        transform.LookAt(targetPosition);

        //Debug.DrawLine(transform.position, targetPosition, Color.green);
    }

    public void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene("combate");
    }

}
