using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class OneShotOnibi : MonoBehaviour
{
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
    public void GoToNextForest(){
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
