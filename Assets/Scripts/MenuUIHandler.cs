using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using static UnityEngine.Rendering.DebugUI;
using TMPro;

[DefaultExecutionOrder(1000)]

public class MenuUIHandler : MonoBehaviour
{
    public TMP_Text PlayerNameInput;

    // Start the game from the menu
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    // Handle the playername
    public void SetPlayerName()
    {
        PlayerDataHandle.Instance.playerName = PlayerNameInput.text;
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
