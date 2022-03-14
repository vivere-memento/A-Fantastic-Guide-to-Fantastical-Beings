using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Onibii : MonoBehaviour
{
    public static Action<string> onibiiCaptured;
    public static Action<string> onibiiDespawned;
    private bool captured= false;
    private bool despawned = false;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DespawnOnibii());
    }

    IEnumerator DespawnOnibii(){
        yield return new WaitForSeconds(UnityEngine.Random.Range(4,7));
        despawned = true;
        Destroy(this.gameObject);
    }
    private void OnDisable(){
        if(captured){
        onibiiCaptured?.Invoke("Onibii");
        }
        else if(despawned){
        onibiiDespawned?.Invoke("Onibii");
        }
    }
    
    void OnMouseDown(){
        captured = true;
        Destroy(this.gameObject, 0.1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
