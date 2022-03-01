using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DestroyObject : MonoBehaviour
{
    public GameObject gameObj;
    float doubleClickTime = .5f, lastClickTime;

    void Update()
    {
    }

    private void OnMouseDown()
    {
        // Checking left mouse button click, you could choose the input you want here
        if (Input.GetMouseButtonDown(0))
        {
            float timeSinceLastClick = Time.time - lastClickTime;

            if (timeSinceLastClick <= doubleClickTime)
                gameObj.SetActive(false);

            lastClickTime = Time.time;
        }
    }
}
