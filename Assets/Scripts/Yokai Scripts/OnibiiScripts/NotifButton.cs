using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;

public class NotifButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    public static Action buttonClicked;
    private Animator mAni;

    private void UpdateText(){
        buttonClicked?.Invoke();
    }
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        Debug.Log("Cursor Entering " + name + " GameObject");
        mAni.SetBool("isActive",true);
    }

    //Detect when Cursor leaves the GameObject
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        Debug.Log("Cursor Exiting " + name + " GameObject");
        mAni.SetBool("isActive",false);
        //StartCoroutine("StayAWhile");
    }
    // Start is called before the first frame update
    void Start()
    {
        mAni = gameObject.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
