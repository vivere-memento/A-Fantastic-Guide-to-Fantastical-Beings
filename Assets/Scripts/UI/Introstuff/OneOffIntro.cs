using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class OneOffIntro : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        string playerName = PlayerPrefs.GetString("Player Name");
        TMP_Text text = gameObject.GetComponent<TMP_Text>();
        text.text = "Hello " + playerName+ " this is the introduction text where we will set the scene and briefly familiarize the user with the lore and goals of the project.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
