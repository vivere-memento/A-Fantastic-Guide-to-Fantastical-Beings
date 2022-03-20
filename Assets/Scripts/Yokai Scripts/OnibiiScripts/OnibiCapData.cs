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
    [SerializeField]
    private GameObject Onibi1, Onibi2;
    [SerializeField]
    private Camera cam;
    bool showOni1= false, showOni2=false;
    void OnEnable(){
        Onibii.onibiiCaptured += ShowFirstPanel;
        OniGroup.oniGroupCaptured += ShowSecondPanel;
    }
    void OnDisable(){
        Onibii.onibiiCaptured -= ShowFirstPanel;
        OniGroup.oniGroupCaptured -= ShowSecondPanel;
    }
    public void BackToJapan(){
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Onibi);
        SceneManager.LoadScene("JapanMap");
    }
    void ShowSecondPanel(){
        panel2.enabled=true;
        showOni2=true;
    }
    void ShowFirstPanel(string s){
        panel1.enabled = true;
        showOni1 = true;
    }
    public void ClosePanel(){
        panel1.enabled=false;
        cam.transform.position = new Vector3(100f,0f, -10);
        cam.orthographicSize = 16.2f;
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
        if(showOni1){
            cam.transform.position = new Vector3(176.2616f,-17.39878f, -10);
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 4.1f, Time.deltaTime * 5);
            cam.transform.position = new Vector3(Onibi1.GetComponent<Transform>().position.x + 0.7f, Onibi1.GetComponent<Transform>().position.y, -10);
            if(cam.orthographicSize < 4.5f){
            showOni1= false;
            }
        }
        else if(showOni2){
            cam.transform.position = new Vector3(176.2616f,-17.39878f, -10);
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 4.1f, Time.deltaTime * 5);
            cam.transform.position = new Vector3(Onibi2.GetComponent<Transform>().position.x + 0.7f, Onibi2.GetComponent<Transform>().position.y, -10);
            if(cam.orthographicSize < 4.5f){
            showOni2= false;
            }
        }
    }
}
