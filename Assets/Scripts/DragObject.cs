using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DragObject : MonoBehaviour
{
    private float startPosX;
    private float startPosY;
    private bool isBeingHeld = false;
    Vector2 oldPos;

    // Update is called once per frame
    void Update()
    {
        if (isBeingHeld == true)
        {
            Vector2 mousePos;
            mousePos = Input.mousePosition;
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            //position of object is set to center of object minus the difference in position
            gameObject.transform.localPosition = new Vector2(mousePos.x - startPosX, mousePos.y - startPosY);
        }
    }

    private void OnMouseDown()
    {
        //if the left mouse is clicked
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Props dragged");

            oldPos = transform.position;

            //create variable
            Vector2 mousePos;

            //set value to position of mouse in entire screen
            mousePos = Input.mousePosition;

            //set value to position of mouse in game screen
            mousePos = Camera.main.ScreenToWorldPoint(mousePos);

            //difference between the current mouse position on the object and the center of the object
            startPosX = mousePos.x - transform.localPosition.x;
            startPosY = mousePos.y - transform.localPosition.y;

            isBeingHeld = true;

            Vector2 limit = new Vector2(transform.position.x + 1, transform.position.y + 1);
            if (mousePos == limit)
            {
                isBeingHeld = false;
            }
        }
    }

    private void OnMouseUp()
    {
        isBeingHeld = false;

        //if there are no yokais behind the props, snap them back to their original position
        if (gameObject.tag != "Yokai Behind")
        {
            transform.position = oldPos;
        }
    }
}
