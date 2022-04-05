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
    void OnEnable(){
        QuestManager.clicked += Start;
    }
    void OnDisable(){
        QuestManager.clicked -= Start;
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
        SceneManager.LoadScene("Yogen No Tori_EA_Checked");
        AudioManager.instance.PlaySound2D("KotoGliss");
    }
    public void GoToDaidara(){
        SceneManager.LoadScene("Daidarabotchi_EA_Checked");
        AudioManager.instance.PlaySound2D("KotoGliss");
    }
    public void GoToOniiBii(){
        SceneManager.LoadScene("Onibi_EA_Checked");
        AudioManager.instance.PlaySound2D("KotoGliss");
    }
    public void GoToTengu(){
        SceneManager.LoadScene("Daitengu_EA_Checked");
        AudioManager.instance.PlaySound2D("KotoGliss");
    }
    public void GoToRaijuu(){
        SceneManager.LoadScene("Raijuu_EA_Checked");
        AudioManager.instance.PlaySound2D("KotoGliss");
    }
    public void GoToKitsune(){
        SceneManager.LoadScene("Kitsune_EA_Checked");
        AudioManager.instance.PlaySound2D("KotoGliss");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
