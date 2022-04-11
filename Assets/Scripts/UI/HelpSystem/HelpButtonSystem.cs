using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using TMPro;

public class HelpButtonSystem : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator mAni;
    [SerializeField]
    private GameObject panel;
    [SerializeField]
    private TMP_Text text;
    [SerializeField]
    private TMP_Text score;

    private string displayText;
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
    private IEnumerator StayAWhile(){
        yield return new WaitForSeconds(3);
        panel.SetActive(false);
    }
    public void ClickMe(){
        if(GetComponentInParent<HelpController>().score >= 2){
            text.text = "Look for the Raijuu in the sky!";
            score.text= "";
        }
        panel.SetActive(true);
        StartCoroutine("StayAWhile");
        AudioManager.instance.PlaySound2D("Shift");
    }
    // Start is called before the first frame update
    void Start()
    {
        mAni = gameObject.GetComponentInChildren<Animator>();
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
