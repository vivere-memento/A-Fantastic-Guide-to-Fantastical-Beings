using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class RaijuuInfoController : MonoBehaviour
{
    [SerializeField]
    private Canvas panel1,panel2;
    private bool showSecond= false;
    public static Action showingPane;
    public static Action paneClosed;
    void OnEnable(){
        RaijuuCapture.raijuuCaught+= Judge;
    }
    void OnDisable(){
        RaijuuCapture.raijuuCaught+= Judge;
    }
    void Judge(){
        if(showSecond){
            ShowSecondPanel();
        }
        else{
            ShowFirstPanel();
        }
    }
    public void BackToJapan(){
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Raijuu);
        SceneManager.LoadScene("JapanMap");
    }
    void ShowSecondPanel(){
        panel2.enabled=true;
        showingPane?.Invoke();
    }
    void ShowFirstPanel(){
        showSecond=true;
        panel1.enabled = true;
        showingPane?.Invoke();
    }
    public void ClosePanel(){
        panel1.enabled=false;
        paneClosed?.Invoke();
    }
    // Start is called before the first frame update
    void Start()
    {
        panel1.enabled=false;
        panel2.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
