using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionBookControl : MonoBehaviour
{
    [SerializeField]
    public GameObject descriptionText;
    [SerializeField]
    public GameObject picContainer;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //If the left mouse button is clicked.
        if (Input.GetMouseButtonDown(0))
        {
            //Get the mouse position on the screen and send a raycast into the game world from that position.
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            //If something was hit, the RaycastHit2D.collider will not be null.
            if (hit.collider != null && hit.collider.name.Contains("Monster"))
            {
                string yokaiName = hit.collider.name;
                string description = YokaiControl.Instance.getYokaiDescription(yokaiName);
                string picUrl = YokaiControl.Instance.getYokaiPic(yokaiName);
                Debug.Log(picUrl);
                var yokaiPicSprite = Resources.Load<Sprite>(picUrl);
                Debug.Log(yokaiPicSprite);
                if (!description.Equals("Default")) {
                    descriptionText.GetComponent<Text>().text = description;
                    picContainer.GetComponent<SpriteRenderer>().sprite = yokaiPicSprite;
                }
            }
        }
    }
}
