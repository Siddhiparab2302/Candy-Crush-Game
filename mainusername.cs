using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class mainusername : MonoBehaviour
{
    public Text namebox;
    public Text namebox1;
    // Start is called before the first frame update
    void Start()
    {
        namebox.text = PlayerPrefs.GetString("username");
        namebox1.text = PlayerPrefs.GetString("username");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
