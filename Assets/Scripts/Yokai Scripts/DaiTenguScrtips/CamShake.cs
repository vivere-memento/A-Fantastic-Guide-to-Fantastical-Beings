using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour
{
    public float durat, mag;
    public IEnumerator Shake(float duration,float magnitude){
        Vector3 oPos = transform.localPosition;
        float elapsed = 0f;
        while(elapsed<duration){
            float x = Random.Range(-1f,1f)*magnitude;
            float y = Random.Range(-1f,1f)*magnitude;
            transform.localPosition= new Vector3(x,y,oPos.z);
            elapsed+=Time.deltaTime;
            yield return null;
        }
        transform.localPosition = oPos;
    }
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WAIT());
        IEnumerator WAIT(){
            yield return new WaitForSeconds(2);
            StartCoroutine(Shake(durat,mag));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
