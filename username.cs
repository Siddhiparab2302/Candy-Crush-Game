using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class username : MonoBehaviour
{
    public GameObject levelPanel;
    public GameObject InputFieldPanel;
    public Text obj_text;
    
    public InputField display;
    


    // Start is called before the first frame update
    void Start()
    {
        obj_text.text = PlayerPrefs.GetString("username");
        
    }
    public void Create()
    {
        obj_text.text = display.text;
        PlayerPrefs.SetString("username", obj_text.text);
        PlayerPrefs.Save();
        levelPanel.SetActive(true);
        InputFieldPanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
