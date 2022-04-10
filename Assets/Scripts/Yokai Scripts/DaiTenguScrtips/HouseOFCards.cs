using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HouseOFCards : MonoBehaviour
{
    private Canvas c;
    // Start is called before the first frame update
    void Start()
    {
        c = gameObject.GetComponentInChildren<Canvas>();
        c.enabled=false;
    }
    void COn(){
        if(c)
        c.enabled=true;
    }
    public void GoToJapan(){
        SceneManager.LoadScene("JapanMap");
    }
    void OnEnable(){
        MessageController.birdStopped+=COn;
    }
    void Disable(){
        MessageController.birdStopped-=COn;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
