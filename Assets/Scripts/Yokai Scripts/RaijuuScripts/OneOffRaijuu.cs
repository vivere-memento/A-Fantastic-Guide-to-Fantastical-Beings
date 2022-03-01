using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OneOffRaijuu : MonoBehaviour
{
    [SerializeField]
    private RaijuuCapture raijuu;
    private ParticleSystem trail;
    [SerializeField]
    private NotificationSystem noti;
    private int anger = 0;
    void OnEnable(){
        DragObject.propFiddled += RaiseAnger;
        DestructableProp.propBroke +=RaiseAnger;
        RaijuuCapture.raijuuCaught += notify;
    }
    void OnDisable(){
        DragObject.propFiddled -= RaiseAnger;
        DestructableProp.propBroke -=RaiseAnger;
        RaijuuCapture.raijuuCaught -= notify;
    }
    void notify(){
        noti.ShowNotifcation("Raijuu");
    }
    public void RaiseAnger(){
        Debug.Log("Angery" + anger.ToString());
        anger++;
        trail.Play(true);
    }

    // Start is called before the first frame update
    void Start()
    {
        trail = raijuu.GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(anger > 8){
            Debug.Log("Angery");
            raijuu.SetCapturable();
            var main = trail.main;
            main.loop = true;
            trail.Play();
            anger = 0;
        }
    }
}
