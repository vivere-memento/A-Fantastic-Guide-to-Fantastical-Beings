using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheatConsole : MonoBehaviour
{
    private Canvas c;
    private bool showing=false;
    // Start is called before the first frame update
    void Start()
    {
        c = gameObject.GetComponentInChildren<Canvas>();
        c.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.BackQuote)){
            if(!showing){
            c.enabled = true;
            showing=true;
            }
            else{
                showing=false;
                c.enabled=false;
            }
        }
    }

    public void CatchAClue(){
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Tutorial);
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Daidarabotchi);
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.YogenNoTori);
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Kitsune);
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Onibi);
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Tengu);
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Raijuu);
    }
    public void CatchBird(){
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Tutorial);
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.YogenNoTori);
    }
    public void CatchGiant(){
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Tutorial);
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Daidarabotchi);
    }
    public void CatchGhost(){
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Tutorial);
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Onibi);

    }
    public void CatchADog(){
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Tutorial);
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Tengu);

    }
    public void CatchWolf(){
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Tutorial);
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Raijuu);
    }
    public void CatchFOx(){
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Tutorial);
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Kitsune);
    }

    public void GoToTitle(){
        SceneManager.LoadScene("TitleScreen");
        c.enabled=false;
    }
    public void GoToJapan(){
        SceneManager.LoadScene("JapanMap");
        c.enabled=false;
    }
    public void GoToBirdScene(){
        SceneManager.LoadScene("Yogen No Tori_EA_Checked");
        c.enabled=false;
    }
    public void GoToGiant(){
        SceneManager.LoadScene("Daidarabotchi_EA_Checked");
        c.enabled=false;
    }
    public void GoToGhost(){
        SceneManager.LoadScene("Onibi_EA_Checked");
        c.enabled=false;
    }
    public void GoToDaitengu(){
       SceneManager.LoadScene("Daitengu_EA_Checked");
       c.enabled=false;
    }
    public void GoToRaijuu(){
        SceneManager.LoadScene("Raijuu_EA_Checked");
        c.enabled=false;
    }
    public void GoToKitsune(){
        SceneManager.LoadScene("Kitsune_EA_Checked");
        c.enabled=false;
    }
}
