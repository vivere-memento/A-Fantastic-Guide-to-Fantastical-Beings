using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RaijuuCapture : MonoBehaviour
{
    [SerializeField]
    private bool canCapture;
    public static Action raijuuCaught;
    public void SetCapturable(){
        canCapture = true;
    }
    private void OnMouseDown(){
        if(canCapture){
        Debug.Log("Caught a Raijuu!");
        raijuuCaught?.Invoke();
        //PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Raijuu);
        }
    }
    private void OnMouseUp(){
        this.gameObject.SetActive(false);
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
