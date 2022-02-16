using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JournalClick : MonoBehaviour
{
    public GameObject journal1;

    // Start is called before the first frame update
    void Start()
    {
        journal1.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnMouseDown()
    {
        if(journal1.activeSelf)
        {
            journal1.SetActive(false);
        }
        else
        {
            journal1.SetActive(true);
        }
    }
}
