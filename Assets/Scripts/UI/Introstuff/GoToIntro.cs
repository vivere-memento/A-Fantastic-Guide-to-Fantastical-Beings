using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToIntro : MonoBehaviour
{
  [SerializeField]
  private GameObject g;
  [SerializeField] 
  private Animator bookOpen;
    private void Start(){
      g.SetActive(false);
    }
  public void NextScene(){
    GetComponentInParent<Canvas>().enabled = false;
    StartCoroutine(StartIntro());
  }
  private IEnumerator StartIntro(){
    AudioManager.instance.PlaySound2D("LongBookOpen");
    bookOpen.Play("BookOpen",-1);
    yield return new WaitForSeconds(1);
    g.SetActive(true);
  }
}
