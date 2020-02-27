using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuController : MonoBehaviour
{
    // Start is called before the first frame update
    public void playGame() {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Scenes/SampleScene");
    }
 
    public void exitGame() {
        Application.Quit();
    }
}

    // Update is called once per frame
    
