using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameStartManager : MonoBehaviour
{
    public GameObject levelPanel;
    public GameObject InputFieldPanel;
    public string sceneToLoad;
    public string sceneToLoad2;
    
    // Start is called before the first frame update
    void Start()
    {
        
        levelPanel.SetActive(false);
        InputFieldPanel.SetActive(true);
    }
    public void PlayGame()
    {
        levelPanel.SetActive(false);
        SceneManager.LoadScene(sceneToLoad);
    }
    public void Home()
    {
        SceneManager.LoadScene(sceneToLoad2);
        
    }
    public void View()
    {
        
        levelPanel.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
       
    }
}
