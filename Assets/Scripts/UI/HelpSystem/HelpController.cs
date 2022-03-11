using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HelpController : MonoBehaviour
{
    public TMP_Text scoreText;
    public TMP_Text helpText;
    private string Text;
    private string Score;
    private int score;
    void OnEnable(){
        PropClicked.propClicked += SetText;
    }
    void OnDisable(){
        PropClicked.propClicked -= SetText;
    }
    void SetText(string text){
        if(text == "Tree"){
            Text = "Lightning has struck this tree, the Raijuu must have been here!";
            score++;
        }
        if(text == "Footprint"){
            Text = "These tracks are still fresh, the Raijuu must be close!";
            score++;
        }
        if(score >= 2 ){
            score = 2;
            Score = "2/2";
        }
        else if(score == 1){
            Score = "1/2";
        }
        else{
            Score = "0/2";
        }

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
