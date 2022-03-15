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
        Debug.Log("Raijuu Active");
        canCapture = true;
        GetComponentInChildren<ParticleSystem>().Play(true);
    }
    private void OnMouseDown(){
        Debug.Log("Raijuu Moused");
        if(canCapture){
        Debug.Log("Caught a Raijuu!");
        raijuuCaught?.Invoke();
        timesCaught++;
        if(timesCaught>=2){
        this.gameObject.SetActive(false);
        }
        //PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Raijuu);
        }
    }
    private void OnMouseUp(){
        
    }

    private void Uncapturable(){
        canCapture = false;
    }

    void OnEnable(){
        HelpController.allCluesFound += SetCapturable;
        RaijuuInfoController.showingPane += Uncapturable;
        RaijuuInfoController.paneClosed +=SetCapturable;
    }
    void OnDisable(){
        HelpController.allCluesFound -= SetCapturable;
        RaijuuInfoController.showingPane -= Uncapturable;
        RaijuuInfoController.paneClosed -=SetCapturable;
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
