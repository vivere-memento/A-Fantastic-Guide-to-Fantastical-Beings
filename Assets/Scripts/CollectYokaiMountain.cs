using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectYokaiMountain : MonoBehaviour
{
    private Camera cam;
    public GameObject descBox;
    public GameObject yokai;
    public Text yokaiText;
    public GameObject propBlock;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        descBox.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        CheckAllYokaisFound();
    }

    void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Yokai clicked");

            //zoom in to yokai
            cam.transform.position = new Vector3(transform.position.x + 0.7f, transform.position.y, cam.transform.position.z);
            cam.orthographicSize = 1;

            //enable description box
            descBox.SetActive(true);

            //when the yokais are found, remove the props that are blocking them
            //set description text depending on which yokai is clicked
            if (yokai.name == "yokai4")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for yokai 4";
            }
            else if (yokai.name == "yokai5")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for yokai 5";
            }
            else if (yokai.name == "yokai6")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for yokai 6";
            }
        }
    }

    void CheckAllYokaisFound()
    {
        //method to check if all yokais are found
    }
}

