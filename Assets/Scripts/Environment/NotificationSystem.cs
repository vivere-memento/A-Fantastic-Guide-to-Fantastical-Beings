using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class NotificationSystem : MonoBehaviour
{
    private Canvas NotifCanvas;
    private TMP_Text NotifText;
    private void OnEnable(){
        AmbientYokai.yokaiSpotted += ShowNotifcation;
        //DestructableProp.propBroke += ShowNotifcation;
    }
    private void OnDisable(){
        AmbientYokai.yokaiSpotted -= ShowNotifcation;
        //DestructableProp.propBroke -= ShowNotifcation;
    }
    private void ShowNotifcation(string text){
        NotifCanvas.enabled=true;
        NotifText.text = text + " ran away!";
        StartCoroutine("WaitAWhile");
    }
    private IEnumerator WaitAWhile(){
        Debug.Log("GoingOffNow");
        yield return new WaitForSecondsRealtime(2f);
        
        NotifCanvas.enabled=false;
    }
    // Start is called before the first frame update
    void Start()
    {
        NotifCanvas = this.gameObject.GetComponentInChildren<Canvas>();
        NotifText= this.gameObject.GetComponentInChildren<TMP_Text>();
        NotifCanvas.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
