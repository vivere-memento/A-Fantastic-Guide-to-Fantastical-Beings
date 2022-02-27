using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectYokaiForest : MonoBehaviour
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
            if (yokai.name == "yokai1")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for yokai 1";
            }
            else if (yokai.name == "yokai2")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for yokai 2";
            }
            else if (yokai.name == "yokai3")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for yokai 3";
            }
        }
    }

    void CheckAllYokaisFound()
    {
        //method to check if all yokais are found
    }
}
