using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;
    Vector2 oldPos;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (isBeingHeld == true)
        {
            Vector2 mousePos; //create variable
            mousePos = Input.mousePosition; //set value to position of mouse in entire screen
            mousePos = Camera.main.ScreenToWorldPoint(mousePos); //set value to position of mouse in game screen

            this.gameObject.transform.localPosition = new Vector2(mousePos.x - startPosX, mousePos.y - startPosY);
        }
    }

    private void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            oldPos = transform.position;

            Vector2 mousePos; //create variable
            mousePos = Input.mousePosition; //set value to position of mouse in entire screen
            mousePos = Camera.main.ScreenToWorldPoint(mousePos); //set value to position of mouse in game screen

            startPosX = mousePos.x - this.transform.localPosition.x;
            startPosY = mousePos.y - this.transform.localPosition.y;
            isBeingHeld = true;
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;

        if (gameObject.name != "bush")
        {
            transform.position = oldPos;
        }
    }
}
