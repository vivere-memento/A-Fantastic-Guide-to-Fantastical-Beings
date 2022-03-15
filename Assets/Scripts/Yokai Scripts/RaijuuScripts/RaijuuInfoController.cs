using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class RaijuuInfoController : MonoBehaviour
{
    [SerializeField]
    private Canvas panel1,panel2;
    void OnEnable(){
        RaijuuCapture.raijuuCaught+= ShowFirstPanel;
    }
    void OnDisable(){
        RaijuuCapture.raijuuCaught+= ShowFirstPanel;
    }
    public void BackToJapan(){
        SceneManager.LoadScene("JapanMap");
    }
    void ShowSecondPanel(){
        panel2.enabled=true;
    }
    void ShowFirstPanel(){
        panel1.enabled = true;
    }
    public void ClosePanel(){
        panel1.enabled=false;
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
