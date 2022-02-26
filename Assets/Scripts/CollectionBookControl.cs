using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionBookControl : MonoBehaviour
{
    [SerializeField]
    public GameObject descriptionText;
    private MonsterData[] monsterDataList;
    // Start is called before the first frame update
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
                string description = MonsterData.Instance.getMonsterDescription(hit.collider.name);
                if (!description.Equals("Default")) {
                    descriptionText.GetComponent<Text>().text = description;
                }
            }
        }
    }

    private string searchMonsterData(string monsterName) {
        return "test";
    }
}
