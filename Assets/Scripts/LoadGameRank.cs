using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;

public class LoadGameRank : MonoBehaviour
{
    // Display the player info
    public Text bestPlayerName;

    // Player data
    private static int bestScore;
    private static string bestPlayer;

    void Awake()
    {
        LoadGameRankk(); 
    }

    private void SetBestPlayer()
    {
        if(bestPlayer == null && bestScore == 0)
        {
            bestPlayerName.text = "";
        }
        else
        {
            bestPlayerName.text = $"Best Score - {bestPlayer}:{bestScore}";
        }
    }

    public void LoadGameRankk()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if(File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestPlayer = data.theBestPlayer;
            bestScore = data.highestScore;
            SetBestPlayer();
        }
    }

    [System.Serializable]
    class SaveData
    {
        public int highestScore;
        public string theBestPlayer;
    }
}
