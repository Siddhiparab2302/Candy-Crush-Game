using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ConfirmPanel2 : MonoBehaviour
{
    private GameData gameData;
    public int level;
    
    private int score;

    [Header("UI stuff")]
    
   
    
    public Text scoreText;
    // Start is called before the first frame update
    void OnEnable()
    {
        gameData = FindObjectOfType<GameData>();
        LoadData();
        
        SetText();
    }

    void LoadData()
    {
        if (gameData != null)
        {
            
            
            score = gameData.saveData.score[level - 1];
        }
    }

    void SetText()
    {
        
        scoreText.text = "" + score;
    }

    

    // Update is called once per frame
    

    public void Cancel()
    {

        this.gameObject.SetActive(false);
    }

    public void Play()
    {
        gameData.Save();
        PlayerPrefs.SetInt("Current Level", level - 1);
        
    }

}


