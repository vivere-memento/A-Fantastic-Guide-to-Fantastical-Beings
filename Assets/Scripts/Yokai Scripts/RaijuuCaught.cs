using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.SceneManagement;

public class RaijuuCaught : MonoBehaviour
{
    [SerializeField]
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponentInChildren<Canvas>().enabled = false;
    }

    public void StartUp(){
        SceneManager.LoadScene("JapanMap");
    }
    public void Stop(){
        cam.transform.position = new Vector3(15, -7 ,0);
        cam.orthographicSize = 1;
        gameObject.GetComponentInChildren<Canvas>().enabled=true;
    }
    void OnEnable(){
        RaijuuCapture.raijuuCaught += Stop;
    }
    void OnDisable(){
        RaijuuCapture.raijuuCaught -= Stop;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
