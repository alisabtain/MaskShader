using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vect = new Vector3(0,-30, 0);
        transform.Rotate(vect * Time.deltaTime);
    }
}
