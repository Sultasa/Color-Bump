using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerManagment : MonoBehaviour
{
   
    public GameObject Menu;
    
    public GameObject endLevel;
    public GameObject deathPanel;
    public Vector3 originalPosition;
  
   


   
    // Start is called before the first frame update
    void Start()
    {
       
        originalPosition = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
  
        
       


    }
        
       






    private void OnCollisionEnter(Collision cube)
    {
        
       
        if (cube.collider.tag == "kup")
        {

            deathPanel.SetActive(true);
            gameObject.SetActive(false);


           
           
        }
      
        if (cube.collider.tag == "enemy")
        {
          
            deathPanel.SetActive(true);
            gameObject.SetActive(false);
        }
        if (cube.collider.tag == "finish")
        {
            endLevel.SetActive(true);
        }

       
    }
    public void Panel()
    {
       
            SceneManager.LoadScene("gameLevel0");
        
        
    }
  

    private void OnTriggerEnter(Collider sideline)
    {
        if (sideline.tag == "wall")
        {
           
        }  
    }
   
}
