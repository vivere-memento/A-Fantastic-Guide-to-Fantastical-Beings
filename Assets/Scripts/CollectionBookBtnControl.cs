using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CollectionBookBtnControl : MonoBehaviour
{
    [SerializeField] GameObject collectionBook;
    [SerializeField] GameObject locales;
    [SerializeField] GameObject JapanTitle;
    [SerializeField] GameObject CollectionAnimator;
    [SerializeField] int AnimationTime = 2;
    [SerializeField] GameObject CollectionBookBtn;
    [SerializeField] GameObject monster1;
    [SerializeField] GameObject monster2;
    [SerializeField] GameObject monster3;
    [SerializeField] GameObject monster4;
    [SerializeField] GameObject monster5;
    [SerializeField] GameObject monster6;

    private string yokaiNotFoundPic = "yokai_notFound";

    // Animation related
    private bool isDoingAnimation = false;
    private Vector3 startPosition;
    private Vector3 endPosition;
    float t;

    void Start()
    {
        GameObject.Find("CollectionBookButton").GetComponent<Button>().onClick.AddListener(OnOpenCollectionBook);
        // Collection book initial state
        collectionBook.SetActive(false);
        CollectionAnimator.SetActive(false);

        string currentSceneName = SceneManager.GetActiveScene().name;
        int collectedQuest = getCollectedQuest();
        if (currentSceneName.Equals("JapanMap") && collectedQuest >= 1 && collectedQuest <= 6) {
            // initialize position
            Dictionary<int, GameObject> monsterSequence = new Dictionary<int, GameObject>() {
                { 1, monster1 },
                { 2, monster2 },
                { 3, monster3 },
                { 4, monster4 },
                { 5, monster5 },
                { 6, monster6 }
            };
            endPosition = CollectionBookBtn.transform.position;
            endPosition.z = 0;

            GameObject monsterPosition;
            monsterSequence.TryGetValue(collectedQuest, out monsterPosition);
            if (monsterPosition != null) {
                //startPosition = new Vector3((float)-2.55, (float)-3.6, 0);
                startPosition = Camera.main.ScreenToWorldPoint(monsterPosition.transform.position);
                startPosition.z = 0;
                CollectionAnimator.transform.position = startPosition;
                CollectionAnimator.SetActive(true);
                isDoingAnimation = true;
            }
        }
    }

    void Update()
    {
        if (isDoingAnimation) {
            t += Time.deltaTime / AnimationTime;
            CollectionAnimator.transform.position = Vector3.Lerp(startPosition, endPosition, t);

            if (CollectionAnimator.transform.position.Equals(endPosition))
            {
                isDoingAnimation = false;
                CollectionAnimator.SetActive(false);
            }
        }
    }

    void OnOpenCollectionBook()
    {
        //Play Short Book open
        AudioManager.instance.PlaySound2D("LongBookOpen");
        // open collection book
        if (!collectionBook.activeSelf) {
            // update yokai isCatched status
            // updateYokaiStatus();
            collectionBook.SetActive(true);
            string firstYokaiName = YokaiControl.Instance.getFirstYokaiName();
            bool isCatched = PlayManager.Instance.GetCaughtYokai(
                (PlayManager.QuestName)System.Enum.Parse(
                    typeof(PlayManager.QuestName), firstYokaiName)
            );
            collectionBook.GetComponent<CollectionBookControl>()
                .initialCollectionBookOnActive(firstYokaiName, isCatched);

            if (locales != null)
            {
                locales.SetActive(false);
            }
            if (JapanTitle != null)
            {
                JapanTitle.SetActive(false);
            }
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

    private int getCollectedQuest() {
        int currentQuest = PlayManager.Instance.GetCurrentQuest();
        int prevQuest = YokaiControl.collectedQuest;

        if (!prevQuest.Equals(currentQuest))
        {
            YokaiControl.collectedQuest = currentQuest;
            return prevQuest;
        }
        else {
            return 0;
        }
    }
}
