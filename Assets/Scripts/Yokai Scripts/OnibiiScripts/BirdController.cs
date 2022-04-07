using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public GameObject secondBird;
    private bool shown=false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    void OnEnable(){
        OneShotOnibi.movedScene+=ShowBird;
    }
    void OnDisable(){
        OneShotOnibi.movedScene-=ShowBird;
    }
    void ShowBird(){
        secondBird.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
