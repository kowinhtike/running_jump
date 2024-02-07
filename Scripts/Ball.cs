using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Ball : MonoBehaviour
{
    private Rigidbody rb;
    public float runSpeed;
    private float jumpSpeed = 7;

    private int desiredLane = 0;
    private float laneDistance = 2.5f;

    public GameObject[] roadList;
    private int roadLength = 10;
    private float zRoad = 20;
    //to delete
    private int currentRoadList = 0;
    private int jumpNumber = 0;

    // Start is called before the first frame update
    void Start()
    {
 

    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
        //loop 
        for (int i = 0; i < roadLength; i++)
        {
            roadTitle(Random.Range(0, 3));
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        //to run as forward straight 
         transform.Translate(new Vector3(0,0,runSpeed) * Time.deltaTime);
        

        //for jump as most 2 jump
        if (Input.GetKeyDown(KeyCode.Space) && jumpNumber < 2)
        {
            rb.velocity += new Vector3(0,jumpSpeed, 0);
            jumpNumber++;
            //to reset
            rb.rotation = Quaternion.Euler(0, 0, 0);
        }

        //to change left and right

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if (desiredLane == 2)
            {
                desiredLane = 1;
            }
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if (desiredLane == -2)
            {
                desiredLane = -1;
            }
        }

    }

    private void FixedUpdate()
    {
        //to change the lane left or mid or right
        transform.position = new Vector3(desiredLane * laneDistance, transform.position.y, transform.position.z);
    }

    public void roadTitle(int roadIndex)
    {
        //the first road index 0 can be double at the first lane , so we need to change as default 1 value
        Instantiate(roadList[roadIndex],(transform.forward * zRoad * currentRoadList) ,transform.rotation);
        currentRoadList++;
        //currentRoad++;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Danger")
        {
            Destroy(gameObject);
            SceneManager.LoadScene("HomeMenu");
        }

        if (collision.gameObject.tag == "Ground")
        {
            transform.rotation = Quaternion.identity;
            jumpNumber = 0;
        }
    }

}
