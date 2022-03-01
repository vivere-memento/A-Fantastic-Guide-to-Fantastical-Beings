using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectionBookBtnControl : MonoBehaviour
{
    [SerializeField] GameObject collectionBook;
    private string yokaiNotFoundPic = "yokai_notFound";

    void Start()
    {
        GameObject.Find("CollectionBookButton").GetComponent<Button>().onClick.AddListener(OnOpenCollectionBook);
        // Collection book initial state
        collectionBook.SetActive(false);
    }
    void OnOpenCollectionBook()
    {
        // open collection book
        if (!collectionBook.activeSelf) {
            // update yokai isCatched status
            updateYokaiStatus();
            collectionBook.SetActive(true);
        }
    }

    // update the yokai name card by isCatched or not
    private void updateYokaiStatus()
    {
        List<string> yokaiNameList = YokaiControl.Instance.getFullYokaiList();
        foreach(string yokaiName in yokaiNameList)
        {
            bool isCatched = PlayManager.Instance.GetCaughtYokai(
                (PlayManager.QuestName)System.Enum.Parse(
                    typeof(PlayManager.QuestName), yokaiName)
            );
            GameObject yokaiAvatar = findChildFromParent(collectionBook, yokaiName);

            // update avatar
            Sprite yokaiPicSprite;
            if (isCatched) {
                string picUrl = YokaiControl.Instance.getYokaiPic(yokaiName);
                yokaiPicSprite = Resources.Load<Sprite>(picUrl);
            } else {
                yokaiPicSprite = Resources.Load<Sprite>(yokaiNotFoundPic);
            }
            SpriteRenderer yokaiAvatarRender = yokaiAvatar.GetComponent<SpriteRenderer>();
            yokaiAvatarRender.drawMode = SpriteDrawMode.Sliced;
            yokaiAvatarRender.sprite = yokaiPicSprite;

            // update yokai title
            GameObject yokaiTitle = findChildFromParent(yokaiAvatar, "Text");
            if (isCatched) {
                yokaiTitle.GetComponent<Text>().text = yokaiName;
            } else {
                yokaiTitle.GetComponent<Text>().text = "??????";
            }
        }
    }

    private GameObject findChildFromParent(GameObject parent, string childName)
    {
        Component[] trs= parent.GetComponentsInChildren(typeof(Transform), true);
        foreach(Component t in trs){
            if(t.name == childName){
                return t.gameObject;
            }
        }
        return null;
    }
}
