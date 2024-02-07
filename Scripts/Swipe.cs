using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swipe : MonoBehaviour
{
    private Vector3 myvector1;
    private Vector3 myvector2;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            myvector1 = Input.GetTouch(0).position;
        }
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            myvector2 = Input.GetTouch(0).position;

            if(myvector2.x < myvector1.x)
            {
                Debug.Log("great");
            }
            if (myvector2.x > myvector1.x)
            {
                Debug.Log("back");
            }
        }

    }
}
