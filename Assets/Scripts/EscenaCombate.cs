using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EscenaCombate : Enemy
{
    private void OnTriggerEnter(Collider other)
    {
        other.transform.position = new  Vector3(0,0,0);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
