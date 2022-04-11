using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ignoremenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().ignoreListenerPause=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
