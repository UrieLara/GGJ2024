using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Fade : MonoBehaviour
{ 
    public Animator animator;
    void Start()
    {
        Invoke("FadeOut",2);

    }

    // Update is called once per frame
    void Update()
    {
        animator.Play("FadeOut");
          

    }
}
