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
    [SerializeField] GameObject JapanTitle;
    [SerializeField] GameObject buttonRight;
    [SerializeField] GameObject buttonLeft;
    [SerializeField] GameObject pageNumber;

    private string currentYokaiName;

    private string yokaiNotFoundPic = "yokai_notFound";
    void OnDisable(){
        if (locales != null)
        {
            locales.SetActive(true);
        }
        if (JapanTitle != null)
        {
            JapanTitle.SetActive(true);
        }
    }
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (collectionBook.activeSelf && Input.GetMouseButtonDown(0)) {
            Vector2 worldPoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            RaycastHit2D hit = Physics2D.Raycast(worldPoint, Vector2.zero);

            //next page
            if (hit.collider != null && hit.collider.gameObject.tag == "nextPage") {
                goToNextPage();
            }

            // prev page
            if (hit.collider != null && hit.collider.gameObject.tag == "prevPage") {
                goToPrevPage();
            }
        }
    }

    private void setCollectionBookByYokaiName(string yokaiNameText, bool isCatched)
    {
        int pageNumber = YokaiControl.Instance.getPageNumber(yokaiNameText);
        this.pageNumber.GetComponent<Text>().text = pageNumber + "/6";
        if (isCatched) {

            // name
            yokaiName.GetComponent<Text>().text = yokaiNameText;

            // pic
            string picUrl = YokaiControl.Instance.getYokaiPic(yokaiNameText);
            var yokaiPicSprite = Resources.Load<Sprite>(picUrl);
            SpriteRenderer yokaiPicRender = yokaiPic.GetComponent<SpriteRenderer>();
            yokaiPicRender.sprite = yokaiPicSprite;

            // description
            string yokaiDescriptionText = YokaiControl.Instance.getDescriptionText(yokaiNameText);
            descriptionText.GetComponent<Text>().text = yokaiDescriptionText;
            // lore
            string yokaiLoreboxText = YokaiControl.Instance.getLoreboxText(yokaiNameText);
            loreboxText.GetComponent<Text>().text = yokaiLoreboxText;

            // habitat
            string yokaiHabitat = YokaiControl.Instance.getHabitatText(yokaiNameText);
            habitatText.GetComponent<Text>().text = yokaiHabitat;
        }
        else {
            // name
            yokaiName.GetComponent<Text>().text = "??????";

            // pic
            string picUrl = YokaiControl.Instance.getYokaiPic(yokaiNameText);
            // replace "found" to "unfound"
            picUrl.Replace("found", "unfound");
            var yokaiPicSprite = Resources.Load<Sprite>(picUrl);
            SpriteRenderer yokaiPicRender = yokaiPic.GetComponent<SpriteRenderer>();
            yokaiPicRender.sprite = yokaiPicSprite;

            // description
            string yokaiDescriptionText = YokaiControl.Instance.getDescriptionText(yokaiNameText);
            descriptionText.GetComponent<Text>().text = "??????";
            // lore
            string yokaiLoreboxText = YokaiControl.Instance.getLoreboxText(yokaiNameText);
            loreboxText.GetComponent<Text>().text = "??????";

            // habitat
            string yokaiHabitat = YokaiControl.Instance.getHabitatText(yokaiNameText);
            habitatText.GetComponent<Text>().text = "??????";
        }
    }
    public void initialCollectionBookOnActive(string firstYokaiName, bool isFistYokaiCached) 
    {
        currentYokaiName = firstYokaiName;
        setCollectionBookByYokaiName(firstYokaiName, isFistYokaiCached);
    }

    private void goToNextPage() {
        string nextYokaiName = YokaiControl.Instance.getNextYokaiName(currentYokaiName);
        bool isCatched = PlayManager.Instance.GetCaughtYokai(
            (PlayManager.QuestName)System.Enum.Parse(
                typeof(PlayManager.QuestName), nextYokaiName)
        );
        if (nextYokaiName != null) {
            setCollectionBookByYokaiName(nextYokaiName, isCatched);
            currentYokaiName = nextYokaiName;
        }
    }

    private void goToPrevPage() {
        string prevYokaiName = YokaiControl.Instance.getPrevYokaiName(currentYokaiName);
        bool isCatched = PlayManager.Instance.GetCaughtYokai(
            (PlayManager.QuestName)System.Enum.Parse(
                typeof(PlayManager.QuestName), prevYokaiName)
        );
        if (prevYokaiName != null) {
            setCollectionBookByYokaiName(prevYokaiName, isCatched);
            currentYokaiName = prevYokaiName;
        }
    }
}
