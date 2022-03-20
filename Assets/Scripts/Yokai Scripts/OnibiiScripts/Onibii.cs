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
    Material mat;
    float dis = 0f;
    bool canDissolve =true;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DespawnOnibii());
        mat = GetComponent<SpriteRenderer>().material;
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
        if(canDissolve){
            dis += Time.deltaTime;
            if(dis >= 2f){
            dis = 0f;
            canDissolve= false;
            }
            mat.SetFloat("_DissolveStrength",dis);
        }
        if(!canDissolve){
            dis -= Time.deltaTime;
            if(dis <= 2f){
            dis = 2f;
            canDissolve= true;
            }
            mat.SetFloat("_DissolveStrength",dis);
        }
    }
}
