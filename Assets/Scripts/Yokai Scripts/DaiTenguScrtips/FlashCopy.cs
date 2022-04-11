using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using System;

public class FlashCopy : MonoBehaviour
{
    public static Action doneFlashing;
    public float totalSeconds;     // The total of seconds the flash wil last
    public float maxIntensity;     // The maximum intensity the flash will reach
    public Light2D myLight;        // Your light
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WAIT());
        IEnumerator WAIT(){
            yield return new WaitForSeconds(2);
            StartCoroutine("flashNow");
        }
        
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
         doneFlashing?.Invoke();
     }
    // Update is called once per frame
    void Update()
    {
        
    }
}
