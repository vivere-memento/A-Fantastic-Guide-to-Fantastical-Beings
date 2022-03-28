using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;


public class FootprintController : MonoBehaviour
{
    public bool Active;
    public static Action revealed;
    [SerializeField]
    private List<PropClicked> footsteps;
    void OnEnable(){
        PropClicked.propClicked += RevealNext;
    }
    void OnDisable(){
        PropClicked.propClicked -= RevealNext;
    }
    void RevealNext(string s){
        revealed?.Invoke();
        footsteps[0].gameObject.SetActive(false);
        footsteps[1].gameObject.SetActive(true);
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
