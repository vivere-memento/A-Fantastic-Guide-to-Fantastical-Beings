using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;

public class NotifiSystem : MonoBehaviour
{
    [SerializeField]
    private TMP_Text helpText,scoreText;
    [SerializeField]
    private GameObject panel;
    public List<string> NotifTextList;
    public int CurrentTextIndex = 0;
    void OnEnable(){
        NotifButton.buttonClicked += UpdateCurrentText;
        PropClicked.propClicked += UpdateCurrentText;
        AmbientYokai.yokaiFleed += ShowModdedNotif;
    }

    void OnDisable(){
        NotifButton.buttonClicked -= UpdateCurrentText;
        PropClicked.propClicked -= UpdateCurrentText;
        AmbientYokai.yokaiFleed += ShowModdedNotif;
    }

    private IEnumerator StayAndGo(){
        yield return new WaitForSeconds(3);
        panel.SetActive(false);
    }

    public void ShowModdedNotif(){
        AudioManager.instance.PlaySound2D("Shift");
        helpText.text = "Animals flee from Onibi...";
        panel.SetActive(true);
        StartCoroutine("StayAndGo");
    }

    public void ShowNotif(){
        AudioManager.instance.PlaySound2D("Shift");
        panel.SetActive(true);
        StartCoroutine("StayAndGo");
    }
    public void UpdateCurrentText(string s){
        if(CurrentTextIndex < NotifTextList.Count){CurrentTextIndex++;}
        else if(CurrentTextIndex >= NotifTextList.Count || CurrentTextIndex < 0){CurrentTextIndex= NotifTextList.Count;}
        helpText.text = NotifTextList[CurrentTextIndex];
        Debug.Log("Current index is" + CurrentTextIndex.ToString());
        ShowNotif();
    }

    public void UpdateCurrentText(){
        helpText.text = NotifTextList[CurrentTextIndex];
        ShowNotif();
    }

    public void ChangeTextByIndex(int index){

    }
    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
