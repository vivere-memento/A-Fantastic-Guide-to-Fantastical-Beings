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
    public List<string> NotifText;
    public int CurrentTextIndex = 0;
    void OnEnable(){
        NotifButton.buttonClicked += UpdateCurrentText;
        PropClicked.propClicked += UpdateCurrentText;
    }

    void OnDisable(){

    }

    private IEnumerator StayAndGo(){
        yield return new WaitForSeconds(3);
        panel.SetActive(false);
    }

    public void ShowNotif(){
        panel.SetActive(true);
        UpdateCurrentText();
        StartCoroutine("StayAndGo");
    }
    void UpdateCurrentText(string s){

    }

    public void UpdateCurrentText(){
        helpText.text = NotifText[CurrentTextIndex];
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
