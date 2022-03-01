using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    #region Fields
    public enum QuestName{
        Tutorial,
        Tengu,
        Onibi,
        Raijuu,
        Daidarabotchi,
        YogenNoTori,
        Kitsune
    }
    private static PlayManager i;
    private static string message= "Hey there!";
    public static PlayManager Instance{get; private set;}
    private bool TutorialDone=false, TenguCaught=false, OnibiCaught=false, RaijuuCaught=false, DaidarabotchiCaught=false, YogenNoToriCaught=false,KitsuneCaught=false;

    //private int currentQuestId = 0;
    //private QuestName currentQuestName = QuestName.Tutorial;
    private int currentQuest = 1;
    #endregion
    //////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    #region Getters and Setters
    public bool GetCaughtYokai(QuestName yokai){
        switch(yokai){
            case QuestName.Tutorial:
            return TutorialDone;     
            case QuestName.Tengu:
            return TenguCaught;

            case QuestName.Onibi:
            return OnibiCaught;

            case QuestName.Raijuu:
            return RaijuuCaught;

            case QuestName.Daidarabotchi:
            return DaidarabotchiCaught;

            case QuestName.YogenNoTori:
            return YogenNoToriCaught;

            case QuestName.Kitsune:
            return KitsuneCaught;
            default:
                Debug.Log("What are you doing?");
            return false;
        }
    }
    public void CaughtAYokai(QuestName yokai){
        switch(yokai){
            case QuestName.Tutorial:
                TutorialDone= true;
                UpdateCurrentQuests();
            break;
            case QuestName.Tengu:
                TenguCaught = true;
                UpdateCurrentQuests();
            break;
            case QuestName.Onibi:
                OnibiCaught = true;
                UpdateCurrentQuests();
            break;
            case QuestName.Raijuu:
                RaijuuCaught = true;
                UpdateCurrentQuests();
            break;
            case QuestName.Daidarabotchi:
                DaidarabotchiCaught = true;
                UpdateCurrentQuests();
            break;
            case QuestName.YogenNoTori:
                YogenNoToriCaught = true;
                UpdateCurrentQuests();
            break;
            case QuestName.Kitsune:
                KitsuneCaught = true;
                UpdateCurrentQuests();
            break;
            default:
                Debug.Log("What are you doing?");
            break;
        }
    }
    public int GetCurrentQuest(){
        return currentQuest;
    }

    public void SetCurrentQuestById(int questId){
        currentQuest = questId;
    }
    public void SetCurrentQuestByName(QuestName questName){
        currentQuest = (int)questName;
    }
    #endregion

    //Forbidden code here
    #region Dont Look at my shame
    public void UpdateCurrentQuests(){
        if(TutorialDone){
            SetCurrentQuestByName(QuestName.YogenNoTori);
            currentQuest = 1;
        }
        if(YogenNoToriCaught){
            SetCurrentQuestByName(QuestName.Daidarabotchi);
            currentQuest = 2;
        }
        if(DaidarabotchiCaught){
            SetCurrentQuestByName(QuestName.Onibi);
            currentQuest = 3;
        }
        if(OnibiCaught){
            SetCurrentQuestByName(QuestName.Tengu);
            currentQuest = 4;
        }
        if(TenguCaught){
            SetCurrentQuestByName(QuestName.Raijuu);
            currentQuest = 5;
        }
        if(RaijuuCaught){
            SetCurrentQuestByName(QuestName.Kitsune);
            currentQuest = 6;
        }
        if(KitsuneCaught){
            Debug.Log("Caught them all!");
        }
        if(!(TutorialDone||YogenNoToriCaught||DaidarabotchiCaught||OnibiCaught||TenguCaught||RaijuuCaught||KitsuneCaught)){
            Debug.Log("Set the current quest to Tutorial Quest");
            SetCurrentQuestByName(QuestName.Tutorial);
        }
    }
    #endregion
    private void Awake(){
        if( Instance != null){
            Destroy(gameObject);
        }
        else{
            Instance = this;
            message = "Playmanager started...";
            DontDestroyOnLoad(gameObject);
        }
    }
    void Start()
    {
        Debug.Log(message);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
