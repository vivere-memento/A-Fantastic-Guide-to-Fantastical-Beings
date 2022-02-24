using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToIntro : MonoBehaviour
{
     public void NextScene(){
       GetComponentInParent<Canvas>().gameObject.SetActive(false);
     }
}
