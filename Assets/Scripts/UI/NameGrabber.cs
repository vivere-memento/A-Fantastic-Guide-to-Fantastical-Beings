using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NameGrabber : MonoBehaviour
{   
    string playerName;

    
    // Start is called before the first frame update
    void Start()
    {
        GetPlayerName();
    }

    string GetPlayerName(){
        playerName = gameObject.GetComponentInChildren<TMPro.TMP_InputField>().text;
        Debug.Log(playerName);
        return playerName;
    }

    public void UpdatePlayerName(){
        GetPlayerName();
        PlayerPrefs.SetString("Player Name", playerName);
        Debug.Log(playerName + " Saved to Disk!");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
