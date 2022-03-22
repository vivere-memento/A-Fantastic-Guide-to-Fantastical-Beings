using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePropAndActive : MonoBehaviour
{
    public GameObject footprint;
    private float startPosX;
    private Animator myAnim;
    private float startPosY;
    private bool playOnce=true;
    public TooltipTrigger ts;
    private bool isBeingHeld = false;
    private void OnMouseDown()
    {
        //if(playOnce){myAnim.SetBool("Lifted",true); playOnce=false;}
            

            Debug.Log("Props dragged");

            footprint.SetActive(true);
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

    private void OnMouseUp()
    {
        isBeingHeld = false;
        ts.isActive = true;
        gameObject.GetComponent<SpriteRenderer>().color = Color.clear;
        myAnim.SetBool("Lifted",true);
        Destroy(gameObject,.55f);
        
    }
    private IEnumerator Begon(){
        if(playOnce){myAnim.SetBool("Lifted",true); playOnce=false;}
        yield return new WaitForSeconds(3);
        gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        footprint.SetActive(false);
        myAnim = GetComponentInChildren<Animator>();
    }

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
}
