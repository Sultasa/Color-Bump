using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyManager : MonoBehaviour
{
  Vector3 direction=new Vector3(3,0,0);

    void Update()
    {
        transform.Translate(direction * Time.deltaTime);
           
    }

    private void OnTriggerEnter(Collider hit) 
    {
        if(hit.tag =="wall")
        {
            direction.x *= -1;
        }
    }

}
