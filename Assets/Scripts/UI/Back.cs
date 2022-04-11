using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Back : MonoBehaviour
{
    private Button backToMenu;

    private void Start()
    {
        backToMenu = GetComponent<Button>();
    }
    public void BackToMap()
    {
        SceneManager.LoadScene("JapanMap");
    }

    public void BackToMenu()
    {
        //for how to play back button
        if (backToMenu.name == "toMenu")
        {
            SceneManager.LoadScene("TitleScreen");
        }
    }
}
