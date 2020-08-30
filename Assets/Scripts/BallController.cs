using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    [SerializeField]
    private float thrust = 150f;

    [SerializeField]
    private Rigidbody rb;
    [SerializeField]
    private float wallDistance = 9.5f;
    [SerializeField]
   private float minCamDistance = 3f;

    private Vector2 lastMousePos;


    void Update()
    {
        //rb.AddForce(0, 0, 10);
        Vector2 deltaPos = Vector2.zero;

        if (Input.GetMouseButton(0))
        {
            Vector2 currentMousePos = Input.mousePosition;

            if(lastMousePos == Vector2.zero)
            
                lastMousePos = currentMousePos;

            deltaPos = currentMousePos - lastMousePos;
            lastMousePos = currentMousePos;

            Vector3 force = new Vector3(deltaPos.x, 0, deltaPos.y)*thrust;

            rb.AddForce(force);
            


        }
        else
        {
            lastMousePos = Vector2.zero;
        }


    }
    private void LateUpdate()
    {
        Vector3 pos = transform.position;
        if (transform.position.x < -wallDistance)
        {
            pos.x = -wallDistance;

        }
        else if (transform.position.x > wallDistance)
        {
            pos.x = wallDistance;
        }
        if (transform.position.z < Camera.main.transform.position.z + minCamDistance)
        {
            pos.z = Camera.main.transform.position.z + minCamDistance;
        }

        transform.position = pos;
    }
}
