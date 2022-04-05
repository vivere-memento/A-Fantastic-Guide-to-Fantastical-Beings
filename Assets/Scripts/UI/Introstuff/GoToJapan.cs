using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
using System;

public class GoToJapan : MonoBehaviour
{
    public static Action MovingToMain;
    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Image>().color= Color.clear;
        gameObject.GetComponentInChildren<TMP_Text>().color = Color.clear;
        StartCoroutine("FadeIn");
    }
    private IEnumerator FadeIn(){
        yield return new WaitForSeconds(5);
        this.gameObject.GetComponent<Image>().color = Color.white;
        gameObject.GetComponentInChildren<TMP_Text>().color = Color.black;
    }
    public void GoToNext(){
        AudioManager.instance.PlaySound2D("ButtonPress");
        MovingToMain?.Invoke();
        SceneManager.LoadScene("JapanMap");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
