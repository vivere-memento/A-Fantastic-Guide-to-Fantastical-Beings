using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OKButton : MonoBehaviour
{
    private bool shown= true;
    [SerializeField] private PlayManager.QuestName yokaiName = PlayManager.QuestName.Tutorial;

    public void ReturnToMap()
    {
//        PlayManager.Instance.CaughtAYokai(yokaiName);
        SceneManager.LoadScene("JapanMap");
    }
    public void CreditMap()
    {
        if(shown){
            SceneManager.LoadSceneAsync("Credits",LoadSceneMode.Additive);
        }
        else{
            SceneManager.LoadScene("JapanMap");
        }
    }
}

