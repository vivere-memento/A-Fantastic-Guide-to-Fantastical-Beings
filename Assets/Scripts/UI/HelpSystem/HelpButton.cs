using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HelpButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField]
    private Animator mAc;
    private Vector3 target = new Vector3 (80,-80,0);
    private RectTransform rectTransform;
    public void OnPointerEnter(PointerEventData pointerEventData)
    {

        mAc.SetBool("isActive",true);
        Debug.Log("Entered!");
        Debug.Log(transform.position.ToString());
    }
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        mAc.SetBool("isActive",false);
        Debug.Log("Left!");
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
