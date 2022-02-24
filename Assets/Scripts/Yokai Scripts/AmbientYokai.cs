using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmbientYokai : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other){
        Debug.Log("Trigger On");
    }
     void OnTriggerExit2D(Collider2D other){
        Debug.Log("Trigger Off");
        Destroy(gameObject, 2);
        
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
