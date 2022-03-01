using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OniibiiCaught : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponentInChildren<Canvas>().enabled = false;
    }

    public void StartUp(string v){
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Onibi);
        SceneManager.LoadScene("JapanMap");
    }
    public void Stop(string v){
        gameObject.GetComponentInChildren<Canvas>().enabled=true;
    }
    void OnEnable(){
        Onibii.onibiiCaptured += Stop;
    }
    void OnDisable(){
        Onibii.onibiiCaptured -= Stop;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
