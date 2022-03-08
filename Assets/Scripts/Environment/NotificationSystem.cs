using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using TMPro;
public class NotificationSystem : MonoBehaviour
{
    private Canvas NotifCanvas;
    private TMP_Text NotifText;
    Queue<string> notifcations = new Queue<string>();
    private void OnEnable(){
        AmbientYokai.yokaiSpotted += ShowNotifcation;
        //Onibii.onibiiCaptured += ShowNotifcation;
        Onibii.onibiiDespawned += ShowNotifcation;
        TenguOneoff.tenguCaptured += ShowNotifcation;
        //DestructableProp.propBroke += ShowNotifcation;
    }
    private void OnDisable(){
        AmbientYokai.yokaiSpotted -= ShowNotifcation;
        Onibii.onibiiDespawned -= ShowNotifcation;
        TenguOneoff.tenguCaptured -= ShowNotifcation;
        //DestructableProp.propBroke -= ShowNotifcation;
    }

    public void QueueNotification(){
        notifcations.Enqueue("");
    }
    public void SendNotification(){
        notifcations.Dequeue();
    }
    public void ShowNotifcation(string text){
        Debug.Log("Showing Notification");
        NotifCanvas.enabled=true;
        NotifText.text = text + " ran away!";
        StartCoroutine("WaitAWhile");
    }
    private void LootNotification(){
        
    }
    private IEnumerator WaitAWhile(){
        Debug.Log("GoingOffNow");
        yield return new WaitForSecondsRealtime(2f);
        NotifCanvas.enabled=false;
    }
    // Start is called before the first frame update
    void Start()
    {
        NotifCanvas = this.GetComponentInChildren<Canvas>();
        NotifText= this.GetComponentInChildren<TMP_Text>();
        NotifCanvas.enabled=false;
    }

    // Update is called once per frame
    void Update()
    {
        if(notifcations.Count != 0){
            if(!NotifCanvas.enabled){
                SendNotification();
            }
        }
    }
}
