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
        text.text = "Dear " + playerName+", \n\nOur world is shared with beings of myth and legend, creatures called Yokai.\nThey exist all around us, yet we know so little about them.\nLet this book guide you towards uncovering their mysteries!";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
