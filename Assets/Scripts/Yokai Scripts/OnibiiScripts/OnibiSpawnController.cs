using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OnibiSpawnController : MonoBehaviour
{
    [SerializeField]
    private bool canSpawn =false;
    public List<OniGroup> ListOfGroups;

    void OnEnable(){
        OnibiCapData.activeOniGroup += StartSpawning;
        OniGroup.oniGroupCaptured += stopSpawning;
        OniGroup.oniGroupDespawned += StartSpawning;
    }
    void OnDisable(){
        OnibiCapData.activeOniGroup -= StartSpawning;
    }
    // Start is called before the first frame update
    void Start()
    {
        foreach(OniGroup i in ListOfGroups){
            i.Disable();
        } 
    }
    private IEnumerator SpawnGroup(){
        yield return new WaitForSeconds(UnityEngine.Random.Range(3,6));
        ListOfGroups[UnityEngine.Random.Range(0, ListOfGroups.Count)].gameObject.SetActive(true);
    }
    void StartSpawning(){
        canSpawn = true;
    }
    void stopSpawning(){
        canSpawn = false;
    }
    // Update is called once per frame
    void Update()
    {
        if(canSpawn){
            canSpawn = false;
            StartCoroutine(SpawnGroup());
        }
    }
}
