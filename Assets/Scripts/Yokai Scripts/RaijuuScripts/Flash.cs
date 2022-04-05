using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

 public class Flash : MonoBehaviour
 {
 
     public float totalSeconds;     // The total of seconds the flash wil last
     public float maxIntensity;     // The maximum intensity the flash will reach
     public Light2D myLight;        // Your light
    
    void Start(){
        
    }

    void OnEnable(){
        HelpController.allCluesFound +=FlashLight;
    }
    void OnDisable(){
        HelpController.allCluesFound -=FlashLight;
    }

    void FlashLight(){
        StartCoroutine("flashNow");
    }

     public IEnumerator flashNow ()
     {
         float waitTime = totalSeconds / 3;                        
         // Get half of the seconds (One half to get brighter and one to get darker)
         while (myLight.intensity < maxIntensity) {
             myLight.intensity += Time.deltaTime / waitTime;        // Increase intensity
             yield return null;
         }
         while (myLight.intensity > 1) {
             myLight.intensity -= Time.deltaTime / waitTime;        //Decrease intensity
             yield return null;
         }
        while (myLight.intensity < maxIntensity) {
             myLight.intensity += Time.deltaTime / waitTime;        // Increase intensity
             yield return null;
        }
         while (myLight.intensity > 1) {
             myLight.intensity -= Time.deltaTime / waitTime;        //Decrease intensity
             yield return null;
         }
         yield return null;
         AudioManager.instance.PlaySound2D("Thunder");
     }
 }
