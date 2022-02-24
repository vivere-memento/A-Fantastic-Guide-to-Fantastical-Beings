using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextWriter : MonoBehaviour
{
    private string text;
    private TMP_Text textDisplay;
    [SerializeField]
    private float ScrollSpeed = 0.1f;
    // Start is called before the first frame update
    void Start()
    {
        text = gameObject.GetComponent<TMP_Text>().text;
        textDisplay = gameObject.GetComponent<TMP_Text>();
        textDisplay.text = "";
        StartCoroutine(TypeText(ScrollSpeed));
    }
    IEnumerator TypeText(float speed){
        foreach(char c in text.ToCharArray())
        {
            textDisplay.text += c;
            //Debug.Log("Printing" + c);
            yield return new WaitForSeconds(speed);
        }
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
