using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Start is called before the first frame update
    //

    public Transform player;
    public Vector3 vector;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vector = player.position;
        transform.position = new Vector3(transform.position.x, vector.y +4, vector.z - 6);
        //transform.position = new Vector3(vector.x, vector.y + 3, vector.z - 5);
    }
}
