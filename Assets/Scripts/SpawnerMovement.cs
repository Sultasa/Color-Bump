using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerMovement : MonoBehaviour
{
    public Rigidbody rb;
    
    // Start is called before the first frame update
    private void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
            rb.AddForce(300 * Time.deltaTime, 0, 0);
        

        
        if (rb.transform.position.y <= -2.5)
        {
            gameObject.SetActive(false);
        }
    }
    
}
