using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class QuestManager : MonoBehaviour
{
    private Quest currentQuest;
    private int textMarker= 0;
    private int questMarker = 0;
    public List<Quest> allQuests;
    public TMP_Text questText;
    public Button leftButton, rightButton, mainButton;
    public Quest GetCurrentQuest(){
        return currentQuest;
    }

    public void SetCurrentQuest(int questId){
        Quest ChangeQuest = allQuests.Find(x => x.id == questId);
        currentQuest=  ChangeQuest;
    }
    public void SetCurrentQuest(string questName){
        Quest ChangeQuest = allQuests.Find(x => x.name == questName);
        currentQuest=  ChangeQuest;
    }
    public void ForceNextQuest(){
        //questMarker++;
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Tutorial);
        SceneManager.LoadScene("JapanMap");
        //SetCurrentQuest(questMarker);
        /*textMarker = 0;
        updateText();*/
    }
    public void NextText(){
        textMarker++;
        //Debug.Log("Marker is at " + textMarker.ToString()+ " Adding 1");
        CheckOutOfRange();
        //Debug.Log("Marker is at " + textMarker.ToString());
        updateText();
    }
    
    public void PrevText(){
        textMarker--;
        //Debug.Log("Marker is at " + textMarker.ToString()+ " Reducing 1");
        CheckOutOfRange();
        //Debug.Log("Marker is at"  + textMarker.ToString());
        updateText();
    }
    private void CheckOutOfRange(){
        if(textMarker> (currentQuest.questText.Count-1)){
            //Debug.Log("Max Marker is at "+currentQuest.questText.Count.ToString());
            textMarker = 0;
        }
        if(textMarker <0){
            //Debug.Log("Max Marker is at "+ currentQuest.questText.Count.ToString());
            textMarker = currentQuest.questText.Count - 1;
        }
    }
    private void updateText(){
        questText.text = currentQuest.questText[textMarker];
    }
    // Start is called before the first frame update
    void Awake()
    {

    }

    void Start(){
        PlayManager.Instance.UpdateCurrentQuests();
        SetCurrentQuest(PlayManager.Instance.GetCurrentQuest());
        updateText();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
