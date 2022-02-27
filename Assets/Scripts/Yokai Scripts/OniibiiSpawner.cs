using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OniibiiSpawner : MonoBehaviour
{
    public Onibii prefab;
    private int counter = 0;
    private bool notSpawned= true;
    private void OnEnable(){
        AmbientYokai.yokaiSpotted += countYokai;
        Onibii.onibiiCaptured += stopSpawning;
        Onibii.onibiiDespawned += spawnAgain;
        //DestructableProp.propBroke += ShowNotifcation;
    }
    private void OnDisable(){
        AmbientYokai.yokaiSpotted -= countYokai;
        Onibii.onibiiCaptured -= stopSpawning;
        Onibii.onibiiDespawned -= spawnAgain;
        //DestructableProp.propBroke += ShowNotifcation;
    }
    private void stopSpawning(string v){
        counter = 0;
    }
    private void countYokai(string v){
        counter++;
        Debug.Log("Increased the count by 1. Count is now" + counter.ToString());
    }
    private void spawnAgain(string v){
        notSpawned=true;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private IEnumerator SpawnOnibii(){
        yield return new WaitForSeconds(Random.Range(5,10));
        Instantiate(prefab, new Vector3(Random.Range(-10,15),Random.Range(-10,10),0), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        if(counter >= 3 && notSpawned){
            notSpawned = false;
            
            StartCoroutine(SpawnOnibii());
        }
    }
}
