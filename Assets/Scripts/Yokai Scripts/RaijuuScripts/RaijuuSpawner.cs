using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class RaijuuSpawner : MonoBehaviour
{
    [SerializeField]
    private RaijuuCapture raijuu;
    [SerializeField]
    private RaijuuCapture decoy;
    [SerializeField]
    private int angerLevel= 0;
    [SerializeField]
    private Light2D global;
    private float lightStr= 1.0f;

    private bool stop;
    private ParticleSystem raijuuTrail;
    private ParticleSystem decoyTrail;
    void OnEnable(){
        DestructableProp.propBroke += IncreaseRaijuuAnger;
    }
    void OnDisable(){
        DestructableProp.propBroke -= IncreaseRaijuuAnger;
    }
    private void IncreaseRaijuuAnger(){
        if(!stop){
        angerLevel++;
        if(decoyTrail)
        decoyTrail.Play(true);
        lightStr -= 0.1f;
        global.intensity= lightStr;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        raijuuTrail = raijuu.GetComponentInChildren<ParticleSystem>();
        decoyTrail = decoy.GetComponentInChildren<ParticleSystem>();
    }

    // Update is called once per frame
    void Update()
    {
        if(angerLevel >= 5){
            Debug.Log("ANGERY");
            stop = true;
            raijuu.SetCapturable();
            raijuuTrail.Play(true);
            angerLevel = 0;
        }
    }
}
