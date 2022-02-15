using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToIntro : MonoBehaviour
{
    public GameObject[] stuffToClose;

     public void NextScene(){
         foreach(GameObject thingy in stuffToClose){
             thingy.SetActive(false);
         }
     }
}
