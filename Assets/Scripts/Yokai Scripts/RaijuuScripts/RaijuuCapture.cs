using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RaijuuCapture : MonoBehaviour
{
    [SerializeField]
    private bool canCapture;
    public static Action raijuuCaught;
    private int timesCaught;
    public void SetCapturable(){
        canCapture = true;
        GetComponentInChildren<ParticleSystem>().Play(true);
    }
    private void OnMouseDown(){
        if(canCapture){
        Debug.Log("Caught a Raijuu!");
        raijuuCaught?.Invoke();
        if(timesCaught>=2){
        this.gameObject.SetActive(false);
        }
        //PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Raijuu);
        }
    }
    private void OnMouseUp(){
        
    }

    void OnEnable(){
        HelpController.allCluesFound += SetCapturable;
    }
    void OnDisable(){
        HelpController.allCluesFound -= SetCapturable;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
