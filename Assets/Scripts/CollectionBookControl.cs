using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionBookControl : MonoBehaviour
{
    [SerializeField] GameObject collectionBook;
    [SerializeField] GameObject descriptionText;
    [SerializeField] GameObject yokaiPic;
    [SerializeField] GameObject loreboxText;
    [SerializeField] GameObject habitatText;
    [SerializeField] GameObject yokaiName;
    [SerializeField] GameObject locales;
    [SerializeField] GameObject buttonRight;
    [SerializeField] GameObject buttonLeft;
    [SerializeField] GameObject pageNumber;

    private string yokaiNotFoundPic = "yokai_notFound";
    void OnDisable(){
        locales.SetActive(true);
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void initialCollectionBookOnActive(string firstYokaiName, bool isFistYokaiCached) 
    {
        pageNumber.GetComponent<Text>().text = "1/6";
        if (isFistYokaiCached) {

            // name
            yokaiName.GetComponent<Text>().text = firstYokaiName;

            // pic
            string picUrl = YokaiControl.Instance.getYokaiPic(firstYokaiName);
            var yokaiPicSprite = Resources.Load<Sprite>(picUrl);
            SpriteRenderer yokaiPicRender = yokaiPic.GetComponent<SpriteRenderer>();
            yokaiPicRender.drawMode = SpriteDrawMode.Sliced;
            yokaiPicRender.sprite = yokaiPicSprite;

            // description
            string yokaiDescriptionText = YokaiControl.Instance.getDescriptionText(firstYokaiName);
            descriptionText.GetComponent<Text>().text = yokaiDescriptionText;
            // lore
            string yokaiLoreboxText = YokaiControl.Instance.getLoreboxText(firstYokaiName);
            loreboxText.GetComponent<Text>().text = yokaiLoreboxText;

            // habitat
            string yokaiHabitat = YokaiControl.Instance.getHabitatText(firstYokaiName);
            habitatText.GetComponent<Text>().text = yokaiHabitat;
        } 
        // else {

        // }
    }
    // private void onClickYokaiName() {
    //     //If the left mouse button is clicked.
    //     if (collectionBook.activeSelf && Input.GetMouseButtonDown(0))
    //     {
    //         //Get the mouse position on the screen and send a raycast into the game world from that position.
    //         Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    //         RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

    //         //If something was hit, the RaycastHit2D.collider will not be null.
    //         if (hit.collider != null && hit.collider.gameObject.tag == "YokaiAvatar")
    //         {
    //             string yokaiName = hit.collider.name;
    //             bool isCatched = PlayManager.Instance.GetCaughtYokai(
    //                 (PlayManager.QuestName)System.Enum.Parse(
    //                     typeof(PlayManager.QuestName), yokaiName)
    //             );
    //             if (!isCatched) {
    //                 // If not catched, show not found
    //                 yokaiNameContainer.GetComponent<Text>().text = "unkown";
    //                 descriptionText.GetComponent<Text>().text = "Not Found!";
    //                 picContainer.GetComponent<SpriteRenderer>().sprite = Resources.Load<Sprite>(yokaiNotFoundPic);;
    //             } else {
    //                 // If catched, show infomation
    //                 string description = YokaiControl.Instance.getYokaiDescription(yokaiName);
    //                 string picUrl = YokaiControl.Instance.getYokaiPic(yokaiName);
    //                 var yokaiPicSprite = Resources.Load<Sprite>(picUrl);
    //                 yokaiNameContainer.GetComponent<Text>().text = yokaiName;
    //                 if (!description.Equals("Default")) {
    //                     descriptionText.GetComponent<Text>().text = description;
    //                     picContainer.GetComponent<SpriteRenderer>().sprite = yokaiPicSprite;
    //                 }
    //             }
    //         }
    //     }
    // }
}
