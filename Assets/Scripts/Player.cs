using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class Player : MoveEntity
{
    CharacterController controller;
    public float speed = 4;
    Vector3 lastPosition;
    float footstepDistance = 1.2f;


    public Transform cam;

    AudioSource audioSource;
  //  public AudioClip footstepSound;


    private void Start()
    {
        controller = GetComponent<CharacterController>();
        audioSource = GetComponent<AudioSource>();

        lastPosition = transform.position;
    }

    private void Update()
    {
        
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");

        float distance = Vector3.Distance(transform.position, lastPosition);

        if (distance >= footstepDistance)
        {
            PlaySoundWalk();
        }

        if (hor != 0 || ver != 0)
        {
           Vector3 movement = new Vector3(hor, -1, ver);
           MovePlayer(movement);
        }

    }

    void MovePlayer(Vector3 movement)
    {
        Vector3 moveDir;
        moveDir = RotateCharacter(movement, cam);
        controller.Move(moveDir.normalized * speed * Time.deltaTime);
    }

    void PlaySoundWalk()
    {
        audioSource.Play();
        lastPosition = transform.position;

    }

}
