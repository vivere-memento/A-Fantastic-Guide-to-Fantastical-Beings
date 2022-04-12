using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHover : MonoBehaviour
{
    Vector3 start;

    // Start is called before the first frame update
    void Start()
    {
        start = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseEnter()
    {
        transform.localScale += new Vector3(10,10,0);
        Debug.Log("Button Hovered");
    }
    public void OnMouseExit()
    {

        transform.localScale = start;
    }
}
