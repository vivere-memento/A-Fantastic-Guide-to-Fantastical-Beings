using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OniibiiSpawner : MonoBehaviour
{
    [SerializeField]
    private int maxCount = 5;
    [SerializeField]
    private int minX=-10, maxX=15, minY=-10, maxY=10;
    
    public Onibii prefab;
    public int counter = 0;
    private bool notSpawned= true;
    private void OnEnable(){
        AmbientYokai.yokaiSpotted += countYokai;
        Onibii.onibiiCaptured += stopSpawning;
        Onibii.onibiiDespawned += spawnAgain;
        TenguOneoff.tenguCaptured += countYokai;
        //DestructableProp.propBroke += ShowNotifcation;
    }
    private void OnDisable(){
        AmbientYokai.yokaiSpotted -= countYokai;
        Onibii.onibiiCaptured -= stopSpawning;
        Onibii.onibiiDespawned -= spawnAgain;
        TenguOneoff.tenguCaptured += countYokai;
        //DestructableProp.propBroke += ShowNotifcation;
    }
    private void stopSpawning(string v){
        Debug.Log("OnibiCaught!");
        counter = 0;
    }
    private void countYokai(string v){
        //counter++;
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
        yield return new WaitForSeconds(Random.Range(6,8));
        Instantiate(prefab, new Vector3(Random.Range(minX,maxX),Random.Range(minY,maxY),0), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        if(counter >= maxCount && notSpawned){
            notSpawned = false;
            
            StartCoroutine(SpawnOnibii());
        }
    }
}
