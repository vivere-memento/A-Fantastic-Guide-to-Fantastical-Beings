using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class HelpController : MonoBehaviour
{
    public static Action allCluesFound;
    public TMP_Text scoreText;
    public TMP_Text helpText;
    private string Text = "Search for traces of the Raijuu!";
    private string Score;
    public int score=0;
    private bool treeClicked=true,footClicked=true;
    void OnEnable(){
        PropClicked.propClicked += SetText;
    }
    void OnDisable(){
        PropClicked.propClicked -= SetText;
    }
    void SetText(string text){
        if(text == "Tree"){
            if(treeClicked){
            Text = "Lightning has struck this tree, the Raijuu must have been here!";
            score++;
            treeClicked = false;
            }
        }
        if(text == "Footprint"){
            if(footClicked){
            Text = "These tracks are still fresh, the Raijuu must be close!";
            score++;
            footClicked= false;
            }
        }
        GetComponentInChildren<HelpButtonSystem>().ClickMe();
        helpText.text = Text;
        Debug.Log(Text);
        scoreText.text = score.ToString() +"/2";

        if(!footClicked && !treeClicked){
            StartCoroutine(StayAWhile());
        }
        
    }

    private IEnumerator StayAWhile(){
        yield return new WaitForSeconds(4);
        allCluesFound?.Invoke();
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
