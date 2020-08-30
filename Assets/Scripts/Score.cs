using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    
    Vector3 zero = new Vector3(0, 0, 482);
    public Text scoreText;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        

     scoreText.text =(zero.z+player.position.z).ToString("0");
        
    }

}
