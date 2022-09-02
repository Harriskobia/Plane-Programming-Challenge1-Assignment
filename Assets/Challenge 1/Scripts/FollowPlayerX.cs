using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset = new Vector3(6.36f, 1.11f, 6.1f);

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void LateUpdate()
    {
        // offset the camera beside the player by adding to the players position ()
        transform.position = plane.transform.position + offset;
    }
}
