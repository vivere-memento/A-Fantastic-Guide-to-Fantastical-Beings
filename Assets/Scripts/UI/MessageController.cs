using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class MessageController : MonoBehaviour
{
#region Fields
    public static Action birdStarted, birdStopped;

    [SerializeField]
    private Button closeButton,nextButton;
    [SerializeField]
    private float speed = 0.05f;
    [SerializeField]
    private CanvasGroup cGroup; 
    [SerializeField]
    private List<string> helpMessages = new List<string>();
    private Canvas canvas;
    private TMP_Text helperText;
    private int currentMessageIndex=0;
    private string playerName ="";
#endregion

#region Methods
    public void FixText(){
        for(int i = 0; i < helpMessages.Count; i++)
        {
            helpMessages[i] = helpMessages[i].Replace("{playername}", playerName);
            helpMessages[i] = helpMessages[i].Replace("\\n","\n"); 
        }
    }
    IEnumerator fadeIn()
     {
         float waitTime = 2f;                        
         // increase alpha until max
         while (cGroup.alpha < 1) {
             cGroup.alpha += Time.deltaTime / waitTime;        // Increase intensity
             yield return null;
         }
         yield return null;
     }
    IEnumerator fadeOut()
     {
         float waitTime = 2f;                        
         // increase alpha until min
         while (cGroup.alpha > 0) {
             cGroup.alpha -= Time.deltaTime / waitTime;        // Increase intensity
             yield return null;
         }
         
         yield return null;
         this.gameObject.SetActive(false);
        
     }
    IEnumerator typeText(float speed){
        nextButton.interactable = false;
        foreach(char c in helpMessages[currentMessageIndex].ToCharArray())
        {
            helperText.text += c;
            //Debug.Log("Printing" + c);
            yield return new WaitForSeconds(speed);
        }
        if(!(currentMessageIndex>=(helpMessages.Count-1)))
        nextButton.interactable=true;
    }
    public void StartFadeIn(){
        StartCoroutine(fadeIn());
    }
    public void StartFadeOut(){
        StartCoroutine(fadeOut());
    }
    public void StartTyping(){
        StartCoroutine(typeText(speed));
    }
    public void GoNextText(){
        if(currentMessageIndex<=(helpMessages.Count-1)){
            currentMessageIndex++;
            helperText.text="";
            StartTyping();
            if(currentMessageIndex>=(helpMessages.Count-1)){
                nextButton.interactable=false;
            }
        }
    }
    public void ByeBye(){
        birdStopped?.Invoke();
        StartFadeOut();
    }
#endregion

#region Unity MonoBehaviour Functions
    void OnEnable(){
        birdStarted?.Invoke();
        cGroup.alpha= 0;
        StartFadeIn();
    }
    void OnDisable(){
        birdStopped?.Invoke();
    }
    void Awake(){

    }
    // Start is called before the first frame update
    void Start()
    {
        cGroup = gameObject.GetComponent<CanvasGroup>();
        canvas = gameObject.GetComponent<Canvas>();
        PlayerPrefs.GetString("Player Name", playerName);
        FixText();
        helperText = gameObject.GetComponentInChildren<TMP_Text>();
        StartTyping();
        //helperText.text = helpMessages[currentMessageIndex];
    }

    // Update is called once per frame
    void Update()
    {
        
    }
#endregion
}
