using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class OnibiCapData : MonoBehaviour
{
    public static Action activeOniGroup;
    [SerializeField]
    private Canvas panel1,panel2;
    void OnEnable(){
        Onibii.onibiiCaptured += ShowFirstPanel;
        OniGroup.oniGroupCaptured += ShowSecondPanel;
    }
    void OnDisable(){
        Onibii.onibiiCaptured -= ShowFirstPanel;
        OniGroup.oniGroupCaptured -= ShowSecondPanel;
    }
    public void BackToJapan(){
        SceneManager.LoadScene("JapanMap");
    }
    void ShowSecondPanel(){
        panel2.enabled=true;
    }
    void ShowFirstPanel(string s){
        panel1.enabled = true;
    }
    public void ClosePanel(){
        panel1.enabled=false;
        activeOniGroup?.Invoke();
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
