using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OniGroup : MonoBehaviour
{
    public static Action oniGroupCaptured;
    public static Action oniGroupDespawned;
    private bool wasClicked = false;
    public void Disable(){
        gameObject.SetActive(false);
    }
    public void Enable(){
        gameObject.SetActive(true);
    }

    void OnMouseDown(){
        wasClicked= true;
        Destroy(gameObject);
    }

    void OnDisable(){
        if(wasClicked){
            oniGroupCaptured?.Invoke();
        }
        else{
            oniGroupDespawned?.Invoke();
        }
    }

    void OnEnable(){
        gameObject.GetComponent<AudioSource>().Play();
        StartCoroutine(DespawnOnibi());
    }

    IEnumerator DespawnOnibi(){
        yield return new WaitForSeconds(UnityEngine.Random.Range(4,7));
        gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<AudioSource>().Play();
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
