using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{
    public void playGame()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("SampleScene");
    }
 
    public void exitGame()
    {
        Application.Quit();
    }
}
