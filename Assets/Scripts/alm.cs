using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alm : MonoBehaviour
{
    private int x = 1000, y = 1000, z = 1000;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Victoria());
    }

    private IEnumerator Victoria()
    {
        yield return new WaitForSeconds(2.5f);
        transform.position = new Vector3(x, y, z);
    }
}
