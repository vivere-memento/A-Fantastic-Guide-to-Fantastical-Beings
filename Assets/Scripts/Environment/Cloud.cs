using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    public float speed = 1f;
    Vector3 origPos;
    // Start is called before the first frame update
    void Start()
    {
        origPos = gameObject.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.x >= 32){
            transform.position = origPos;
        }
        transform.position += transform.right * Time.deltaTime*speed;
    }
}
