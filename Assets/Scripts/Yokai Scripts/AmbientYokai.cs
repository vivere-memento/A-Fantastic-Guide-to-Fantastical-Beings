using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class AmbientYokai : MonoBehaviour
{
    public static event Action<string> yokaiSpotted;
    //public static event Action yokaiFleed;
    public string yokaiName = "Generic Yokai";
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Trigger On");
    }
     void OnTriggerStay2D(Collider2D other){
        Debug.Log("Trigger On");
    }
    void OnTriggerExit2D(Collider2D other){
        if(yokaiSpotted != null) yokaiSpotted(this.yokaiName);
        Debug.Log("Trigger Off");
        ByeBye();
    }
    public void ByeBye(){
        
        Destroy(gameObject, 2);
    }
    private void OnDisable(){
        yokaiSpotted?.Invoke(yokaiName);
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
