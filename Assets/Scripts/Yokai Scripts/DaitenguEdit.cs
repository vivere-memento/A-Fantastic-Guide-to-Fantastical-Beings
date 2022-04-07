using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DaitenguEdit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void GoToExtras()
    {
        //PlayManager.Instance.CaughtAYokai(yokaiName);
        SceneManager.LoadScene("Daitengu_Extra");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
