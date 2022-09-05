using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quit : MonoBehaviour
{
    public static CursorLockMode lockState;

    void Start()
    {
        //Set Cursor to not be visible
        Cursor.visible = true;
    }
   
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        //Just to make sure its working

  
    }
}