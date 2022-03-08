using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectYokai : MonoBehaviour
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
    }

   void OnMouseDown()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Yokai clicked");

            //zoom in to yokai
            cam.transform.position = new Vector3(transform.position.x + 0.7f, transform.position.y, cam.transform.position.z);
            //cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 1, Time.deltaTime * 5);
            cam.orthographicSize = 1;

            //enable description box
            descBox.SetActive(true);

            //when the yokais are found, remove the props that are blocking them
            //set description text depending on which yokai is clicked
            if (yokai.name == "Yogen No Tori")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for Yogen No Tori";
                PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.YogenNoTori);
            }
            /*else if (yokai.name == "Kitsune")
            {
                propBlock.SetActive(false);
                yokaiText.text = "Description for Kitsune";
            }*/
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
        }
    }
}
