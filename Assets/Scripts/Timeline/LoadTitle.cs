using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTitle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void GoToTitle(){
        SceneManager.LoadScene("TitleScreen");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
