using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuScript : MonoBehaviour
{
    public void EnigmeSelected(int id)
    {
        Debug.Log(id);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + id);
    }

    public void Exit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
} 
