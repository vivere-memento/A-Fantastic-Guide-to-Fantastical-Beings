using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class YokaiCardController : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{   
    [SerializeField]
  private GameObject g;
    private Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = gameObject.GetComponent<Animator>();
    }

        public void OnPointerEnter(PointerEventData pointerEventData)
    {
        //Output to console the GameObject's name and the following message
        Debug.Log("Cursor Entering " + name + " GameObject");
        myAnim.SetBool("MouseIn",true);
        //myAnim.SetBool("MouseOut",false);
    }

        public void OnPointerExit(PointerEventData pointerEventData)
    {
        //Output the following message with the GameObject's name
        Debug.Log("Cursor Exiting " + name + " GameObject");
        myAnim.SetBool("MouseOut",true);
        myAnim.SetBool("MouseIn",false);
    }

    public void Transition(){
        myAnim.Play("IntroCardIn");
        StartCoroutine(StartIntro());
        PlayerPrefs.SetString("Player Name", gameObject.GetComponentInChildren<TMPro.TMP_InputField>().text);
    }

    private IEnumerator StartIntro(){
    yield return new WaitForSeconds(2.1f);
    AudioManager.instance.PlaySound2D("LongBookOpen");
    GetComponentInParent<Canvas>().enabled = false;
    g.SetActive(true);
  }
    // Update is called once per frame
    void Update()
    {
        
    }
}
