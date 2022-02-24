using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPlayerName : MonoBehaviour
{
    public string playerName = "";
    // Start is called before the first frame update
    void Awake()
    {
        playerName = PlayerPrefs.GetString("Player Name");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
