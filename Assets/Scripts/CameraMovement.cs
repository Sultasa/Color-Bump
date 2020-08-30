using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    
    public float speed;
    [SerializeField]
    private float playerDistance = 15f;
    [SerializeField]
    private GameObject player;
   
   
    void Update()
    {
        transform.Translate(0, 0, speed);
    }
    
    
    private void LateUpdate()
    {
        Vector3 pos = transform.position;
       
        if (transform.position.z < player.transform.position.z+playerDistance )
        {
            

            pos.z = Mathf.Lerp(pos.z, player.transform.position.z + playerDistance, 0.05f);

        }

       transform.position = pos;
    }
}
