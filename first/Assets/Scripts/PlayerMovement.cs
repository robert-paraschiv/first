using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{


    private Vector3 touchPosition;
    private Rigidbody rb;
    private float direction;
    private Vector3 RayDirection;

    private float TransformPositionX;//x;
    private float RayPositionX;//r;
    public float moveSpeed = 3;
    public float forwardForce = 50;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        TransformPositionX = transform.position.x; //x

    }



    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0, 0, forwardForce * Time.deltaTime, ForceMode.VelocityChange);
        rb.velocity = new Vector3(0, 0, forwardForce * Time.deltaTime);

        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            TransformPositionX = transform.position.x; //x

            var ray = Camera.main.ScreenPointToRay(touch.position);
            RayDirection = ray.origin;
            RayDirection.z = 0;
            RayPositionX = RayDirection.x; //r

            //Debug.Log(ray);

            direction = (RayPositionX - TransformPositionX); // r - x

             rb.velocity = new Vector3(direction * moveSpeed, 0, forwardForce * Time.deltaTime);

            Debug.Log(rb.velocity);

            if (touch.phase == TouchPhase.Ended)
                rb.velocity = new Vector3(0, 0, forwardForce * Time.deltaTime);
        }
    }
}
