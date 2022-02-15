using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    //Text looks like "localVariable.fieldName"
    public static string playerName = "Timemore";
    
    void FixedUpdate(){
        playerName = PlayerPrefs.GetString("Player Name");
    }
}
