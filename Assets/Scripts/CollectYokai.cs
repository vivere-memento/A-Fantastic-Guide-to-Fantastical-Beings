using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectYokai : MonoBehaviour
{
    private Camera cam;
    private bool isClicked;

    [SerializeField] private GameObject descBox;
    [SerializeField] private GameObject yokai;
    [SerializeField] private Text yokaiText;
    [SerializeField] private GameObject propBlock;
    [SerializeField] private float target;

    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        descBox.SetActive(false);
        isClicked = false;
    }

    // Update is called once per frame
    void Update()
    {
        //zoom in to yokai when clicked
        if (isClicked)
        {
            cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 1, Time.deltaTime * 5);
            cam.transform.position = new Vector3(transform.position.x + 0.7f, transform.position.y, cam.transform.position.z);
        }
    }

   void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Yokai clicked");

            isClicked = true;

            //enable description box
            descBox.SetActive(true);

            //when the yokais are found,
            //remove the props that are blocking them
            //set description text depending on which yokai is clicked
            //quest is completed
            if (yokai.name == "Yogen No Tori")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for Yogen No Tori";
                PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.YogenNoTori);
            }
            else if (yokai.name == "Tengu Daoshi")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for Tengu Daoshi";
                PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Tengu);
            }
            else if (yokai.name == "Daidarabotchi")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for Daidarabotchi";
                PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Daidarabotchi);
            }
            /*else if (yokai.name == "Kitsune")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for Kitsune";
                PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Kitsune);
            }
            else if (yokai.name == "Oniibii")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for Oniibii";
                PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Onibi);
            }
            else if (yokai.name == "Raijuu")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for Raiju";
                PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Raijuu);
            }*/
        }
    }
}
