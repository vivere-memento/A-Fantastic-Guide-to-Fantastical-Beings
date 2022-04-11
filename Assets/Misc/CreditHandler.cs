using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
 using UnityEngine.EventSystems;
public class CreditHandler : MonoBehaviour, IPointerDownHandler
{
    public void STOPCREDITSFROMPLAYING(){
        SceneManager.UnloadSceneAsync("Credits");
    }
    // Start is called before the first frame update
    public void OnPointerDown (PointerEventData eventData) 
    {
        STOPCREDITSFROMPLAYING();
    }
    void Start()
    {
        
    }
    void OnEnable(){
        AudioListener.pause = true;
    }
    void OnDisable(){
        AudioListener.pause = false;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
