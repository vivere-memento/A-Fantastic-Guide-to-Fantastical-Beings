using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using TMPro;


public class ButtonOneoff : MonoBehaviour
{
    [SerializeField]
    private Image img;
    [SerializeField]
    private TMP_Text text;
    [SerializeField]
    private Camera cam;

    private bool raijuu,onibii;
    void OnEnable(){
        Onibii.onibiiCaptured += Oni;
        RaijuuCapture.raijuuCaught += Rai;
    }
    void OnDisable(){
        Onibii.onibiiCaptured -= Oni;
        RaijuuCapture.raijuuCaught -= Rai;
    }

    private void Rai(){
        raijuu = true;
    }
    private void Oni(string v){
        onibii = true;
    }
    // Start is called before the first frame update
    void Start()
    {
        img.enabled= false;
        text.enabled = false;
    }
    void DoEverything(string v){
        gameObject.GetComponentInChildren<Button>().interactable = true;
        img.enabled = true;
        text.enabled= true;
        StartCoroutine(RestAndVest());
    }

    private IEnumerator RestAndVest(){
        yield return new WaitForSeconds(2);
        img.enabled = false;
        text.enabled = false;
    }
    public void TakeMeAway(){
        cam.transform.position = new Vector3(21,0,-10); 
        gameObject.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if(onibii && raijuu){
            DoEverything("");
        }
    }
}
