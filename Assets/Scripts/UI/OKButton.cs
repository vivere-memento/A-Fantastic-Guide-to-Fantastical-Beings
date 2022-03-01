using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OKButton : MonoBehaviour
{
    public GameObject descBox;
    private Camera cam;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //when click on 'ok' button
    public void CloseDescriptionBox()
    {
        /*//disable description box
        descBox.SetActive(false);

        //zoom out to normal
        cam.transform.position = new Vector3(transform.position.x, transform.position.y, cam.transform.position.z);
        cam.orthographicSize = 5;*/

        SceneManager.LoadScene("JapanMap");
    }


}

