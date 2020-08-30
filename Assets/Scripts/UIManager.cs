using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    
   public void startGame()
    {
        SceneManager.LoadScene(1);
    }
    public void exitGame()
    {
        
    }
    public void nextLevel()
    {
        SceneManager.LoadScene(2);
    }
    public void deathPanel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //int scene= SceneManager.GetActiveScene().buildIndex;

        // SceneManager.LoadScene(scene, LoadSceneMode.Single);
        // Time.timeScale = 1;
        Debug.Log("hey");
    }
}
