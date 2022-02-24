using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaijuuCapture : MonoBehaviour
{
    [SerializeField]
    private bool canCapture;
    private void OnMouseDown(){
        if(canCapture){
        Debug.Log("Caught a Raijuu!");
        PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Raijuu);
        }
    }
    private void OnMouseUp(){
        this.gameObject.GetComponentInParent<GameObject>().SetActive(false);
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
