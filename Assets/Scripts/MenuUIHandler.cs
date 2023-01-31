using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{
    // Handle the player name
    public void PlayerName()
    {

    }

    private void Start()
    {
        
    }

    // Start the game from the menu
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    // Quit the game from the menu
    public void Exit()
    {
#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }
}
