using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class PlayAnimOnClick : MonoBehaviour
{
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
    }

    void OnMouseDown(){
        anim.SetBool("Lifted",true);
        Destroy(gameObject,.55f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
