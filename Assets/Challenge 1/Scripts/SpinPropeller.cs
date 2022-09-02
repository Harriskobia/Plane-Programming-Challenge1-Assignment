using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinPropeller : MonoBehaviour
{
    // private variable to for propeller speed
    private float propellerSpeed = 1500f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward, propellerSpeed * Time.deltaTime);
    }
}
