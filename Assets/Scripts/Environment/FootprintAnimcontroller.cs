using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootprintAnimcontroller : MonoBehaviour
{
    private Animator anim;
    void OnEnable(){
        MessageController.birdStopped+=StartAnimation;
        PropClicked.propClicked += StopAnimation;
    }
    void OnDisable(){
        MessageController.birdStopped-=StartAnimation;
        PropClicked.propClicked -= StopAnimation;
    }
    void StartAnimation(){
        anim.enabled = true;
        anim.Play("Footprint");
    }
    void StopAnimation(string s){
        anim.enabled = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
        anim.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
