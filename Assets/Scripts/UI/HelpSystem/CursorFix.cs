using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class CursorFix : MonoBehaviour, IPointerEnterHandler
{
    [SerializeField]
    private Texture2D cursor;
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
      Cursor.SetCursor(cursor,Vector2.zero,CursorMode.ForceSoftware);
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        Cursor.SetCursor(cursor,Vector2.zero,CursorMode.ForceSoftware);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
