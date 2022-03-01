using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LocaleSelector : MonoBehaviour
{
    [SerializeField]
    private List<Canvas> locales;
    [SerializeField]
    private Camera cam;
    [SerializeField]
    private List<GameObject> SceneEntry;
    // Start is called before the first frame update
    void Start()
    {
        SetAllCanvasInActive();
        SetActiveCanvases();
    }

    private void SetActiveCanvases(){
        if(PlayManager.Instance.GetCaughtYokai(PlayManager.QuestName.Tutorial)){
            locales[0].enabled = true;
        }
        if(PlayManager.Instance.GetCaughtYokai(PlayManager.QuestName.YogenNoTori)){
            locales[1].enabled = true;
        }
        if(PlayManager.Instance.GetCaughtYokai(PlayManager.QuestName.Daidarabotchi)){
            locales[2].enabled = true;
        }
        if(PlayManager.Instance.GetCaughtYokai(PlayManager.QuestName.Onibi)){
            locales[3].enabled = true;
        }   
        if(PlayManager.Instance.GetCaughtYokai(PlayManager.QuestName.Tengu)){
            locales[4].enabled = true;
        }
        if(PlayManager.Instance.GetCaughtYokai(PlayManager.QuestName.Raijuu)){
            locales[5].enabled = true;
        }
        if(PlayManager.Instance.GetCaughtYokai(PlayManager.QuestName.Kitsune)){
            //locales[1].enabled = true;
        }
    }
    private void SetAllCanvasInActive(){
        foreach(Canvas i in locales){
        i.enabled = false; 
        }
    }
    public void GoToYogen(){
        SceneManager.LoadScene("Yogen No Tori");
    }
    public void GoToDaidara(){
        SceneManager.LoadScene("Daidarabotchi");
    }
    public void GoToOniiBii(){
        SceneManager.LoadScene("OniiBii");
    }
    public void GoToTengu(){
        SceneManager.LoadScene("Tengu Daoshi");
    }
    public void GoToRaijuu(){
        SceneManager.LoadScene("Raijuu");
    }
    public void GoToKitsune(){
        SceneManager.LoadScene("Kitsune");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
