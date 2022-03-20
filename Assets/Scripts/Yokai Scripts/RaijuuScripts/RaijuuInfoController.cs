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
    public Camera cam;
    public GameObject raijuu1,raijuu2;
    private bool rai1= false, rai2=false;
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
        rai2=true;
        showingPane?.Invoke();
    }
    void ShowFirstPanel(){
        showSecond=true;
        panel1.enabled = true;
        rai1=true;
        showingPane?.Invoke();
    }
    public void ClosePanel(){
        panel1.enabled=false;
        cam.transform.position = new Vector3(0f,0f, -10);
        cam.orthographicSize = 16.2f;
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
        if(rai1){
            cam.transform.position = new Vector3(176.2616f,-17.39878f, -10);
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 6.1f, Time.deltaTime * 5);
            cam.transform.position = new Vector3((raijuu1.GetComponent<Transform>().position.x-5) + 0.7f, raijuu1.GetComponent<Transform>().position.y, -10);
            if(cam.orthographicSize < 6.5f){
            rai1= false;
            }
        }
        else if(rai2){
            cam.transform.position = new Vector3(176.2616f,-17.39878f, -10);
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 6.1f, Time.deltaTime * 5);
            cam.transform.position = new Vector3((raijuu2.GetComponent<Transform>().position.x-5) + 0.7f, raijuu2.GetComponent<Transform>().position.y, -10);
            if(cam.orthographicSize < 6.5f){
            rai2= false;
            }
        }
    }
}
