using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OKButton : MonoBehaviour
{
    [SerializeField] private PlayManager.QuestName yokaiName = PlayManager.QuestName.Tutorial;

    public void ReturnToMap()
    {
//        PlayManager.Instance.CaughtAYokai(yokaiName);
        SceneManager.LoadScene("JapanMap");
    }
}

