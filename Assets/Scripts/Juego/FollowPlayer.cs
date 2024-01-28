using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : Player
{
    private Rigidbody _playerRigidbody;

    // Offset
    public Vector3 offset = new Vector3(0, 0, 0);

    void Start()
    {
        // Encuentra el Rigidbody del jugador
        _playerRigidbody = GameObject.FindGameObjectWithTag("Player").GetComponent<Rigidbody>();
        
    }

    void Update()
    {
        // Actualiza las coordenadas del objeto para que sean las mismas que las del jugador, pero con el offset
        transform.position = _playerRigidbody.position + offset;
    }
}
