using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestructableProp : MonoBehaviour
{
    [SerializeField]
    private int Health= 2;
    Vector3 origPos;
    void OnMouseDown(){
        if(Health<1){
            Destroy(this.gameObject,2);
        }
        else{
            Health--;
            StartCoroutine("ShakeMe");
        }
    }
    IEnumerator ShakeMe(){
        
        float t = 0.0f;
        while(t<.5f){
            float x = Random.Range(-1f,1f) * 0.1f;
            float y = Random.Range(-1f,1f) * 0.1f;
            transform.localPosition = origPos + new Vector3(x,y,origPos.z);
            t += Time.deltaTime;
            yield return null;
        }
        transform.localPosition = origPos;
    }
    // Start is called before the first frame update
    void Start()
    {
        origPos = transform.localPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
