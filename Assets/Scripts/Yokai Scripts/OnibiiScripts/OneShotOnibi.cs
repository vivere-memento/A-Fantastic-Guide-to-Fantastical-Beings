using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class OneShotOnibi : MonoBehaviour
{
    public Volume vol;
    private Vignette vig;
    public static Action movedScene;
    public NotifiSystem sys;
    private SpriteRenderer sR;
    private AudioSource aS;
    public Canvas c;
    public Camera cam;
    public OniibiiSpawner spawner;
    private bool done = true;
    // Start is called before the first frame update
    void Start()
    {
        sR = gameObject.GetComponent<SpriteRenderer>();
        sR.enabled=false;
        aS = gameObject.GetComponentInChildren<AudioSource>();
        c.enabled = false;
        vol.profile.TryGet<Vignette>(out vig);
    }
    private IEnumerator WaitforFade(){
        yield return new WaitForSeconds(5);
        sR.enabled = true;
        aS.Play();
        yield return new WaitForSeconds(2.5f);
        sR.enabled=false;
        yield return new WaitForSeconds(3);
        sys.UpdateCurrentText("s");
        yield return new WaitForSeconds(3);
        c.enabled = true;
    }
      public IEnumerator fadeNow()
     {
         float waitTime = 3 / 3;                        
         // Get half of the seconds (One half to get brighter and one to get darker)
         while (vig.intensity.value < 1f) {
             vig.intensity.value += Time.deltaTime / waitTime;        // Increase intensity
             yield return null;
         }
         yield return null;
         //AudioManager.instance.PlaySound2D("Thunder");
     }
    public void GoToNextForest(){
        StartCoroutine(fadeNow());
        cam.transform.position = new Vector3(100,0,-10);
        movedScene?.Invoke();
        spawner.counter= 10;
        Destroy(gameObject);
    }
    // Update is called once per frame
    void Update()
    {
        if(sys.CurrentTextIndex == 2 && done){
            done = false;
            StartCoroutine(WaitforFade());
        }
    }
}
