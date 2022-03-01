using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class delete : MonoBehaviour
{
    public void clickclick(){
        bool caught = PlayManager.Instance.GetCaughtYokai(PlayManager.QuestName.Onibi); 
        if(caught){
            gameObject.GetComponentInChildren<Text>().text = "Yes";
        }
        else{
            gameObject.GetComponentInChildren<Text>().text = "No";
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
