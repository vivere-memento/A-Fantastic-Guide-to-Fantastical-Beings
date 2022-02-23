using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    #region Fields
    public enum QuestName{
        Tutorial,
        Kappa,
        Onibi,
        Raijuu,
        Daidarabotchi,
        YogenNoTori,
        Kitsune
    }
    private static PlayManager i;
    private static string message= "Hey there!";
    public static PlayManager Instance{get; private set;}
    private bool TutorialDone, KappaCaught, OnibiCaught, RaijuuCaught, DaidarabotchiCaught, YogenNoToriCaught,KitsuneCaught;

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
            case QuestName.Kappa:
            return KappaCaught;

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
            case QuestName.Kappa:
                KappaCaught = true;
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
            SetCurrentQuestByName(QuestName.Kappa);
        }
        else if(KappaCaught){
            SetCurrentQuestByName(QuestName.Onibi);

        }
        else if(OnibiCaught){
            SetCurrentQuestByName(QuestName.Daidarabotchi);

        }
        else if(DaidarabotchiCaught){
            SetCurrentQuestByName(QuestName.YogenNoTori);

        }
        else if(YogenNoToriCaught){
            SetCurrentQuestByName(QuestName.Raijuu);
            
        }
        else if(RaijuuCaught){
            SetCurrentQuestByName(QuestName.Kitsune);
            
        }
        else if(KitsuneCaught){
            Debug.Log("Caught them all!");
        }
        else{
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
