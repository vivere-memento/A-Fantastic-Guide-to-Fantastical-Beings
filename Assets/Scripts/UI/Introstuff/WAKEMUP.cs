using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;

public class WAKEMUP : MonoBehaviour
{
    public static Action MovingToMain;
    public void WAKEMEUP(){
        MovingToMain?.Invoke();
        SceneManager.LoadScene("JapanMap");
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
