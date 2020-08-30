using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeManagment : MonoBehaviour
{

    
  

    // Update is called once per frame
    void Update()
    {
        if(gameObject.transform.position.y <= -1)
        {
            gameObject.SetActive(false);
        } 
    }

    
}
