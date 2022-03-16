using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OKButton : MonoBehaviour
{
    public GameObject descBox;
    private Camera cam;
    [SerializeField]
    private PlayManager.QuestName yokaiName = PlayManager.QuestName.Tutorial;

    void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {

    }

    public void CloseDescriptionBox()
    {
        /*
        descBox.SetActive(false);

        //zoom out to normal
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, cam.transform.position.z);
        cam.orthographicSize = 5;
        */

        PlayManager.Instance.CaughtAYokai(yokaiName);
        SceneManager.LoadScene("JapanMap");
    }
}

