using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplaceControl : MonoBehaviour
{
    Material mat;
    // Start is called before the first frame update
    float dis = 0f;
    private bool stop=true;
    void Start()
    {
        mat = GetComponent<SpriteRenderer>().material;
    }
    void OnEnable(){
        Start();
    }
    // Update is called once per frame
    void Update()
    {   
        if(stop){
        dis += Time.deltaTime;
        if(dis >= 1f){
            //dis = 0f;
            stop =false;
        }
        mat.SetFloat("_DissolveStrength",dis);
        }
  
    }
}
