using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraManager : MonoBehaviour
{
    public GameObject Sphere;
    public Vector3 offSet = new Vector3(0, 15, -6);
   

   
    void Update()
    {
        gameObject.transform.position = Vector3.Lerp(gameObject.transform.position, (Sphere.transform.position + offSet), 1.0f);
      
    }
  
}
