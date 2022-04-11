using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JapanMapControl : MonoBehaviour
{
    [SerializeField] GameObject Yogen;
    [SerializeField] GameObject Daidara;
    [SerializeField] GameObject Oniibii;
    [SerializeField] GameObject Tengu;
    [SerializeField] GameObject Raiijuu;
    [SerializeField] GameObject Kitsune;
    [SerializeField] GameObject Ending;
    [SerializeField] GameObject TalkingBird;
    [SerializeField] GameObject UI;
    [SerializeField] GameObject JapanMapText;
    [SerializeField] GameObject QuestBtn;
    [SerializeField] GameObject EndingCanvas;
    [SerializeField] GameObject BackBtn;

    // Start is called before the first frame update
    void Start()
    {
        Ending.SetActive(false);
        TalkingBird.SetActive(false);
        EndingCanvas.SetActive(false);

        int caughtCount = 0;
        var caughtSprite = Resources.Load<Sprite>("Others/Japan Map Event indicator Caught");
        Dictionary<PlayManager.QuestName, GameObject> monsterList = new Dictionary<PlayManager.QuestName, GameObject>() {
            { PlayManager.QuestName.YogenNoTori, Yogen},
            { PlayManager.QuestName.Daidarabotchi, Daidara },
            { PlayManager.QuestName.Onibi, Oniibii },
            { PlayManager.QuestName.Tengu, Tengu },
            { PlayManager.QuestName.Raijuu, Raiijuu },
            { PlayManager.QuestName.Kitsune, Kitsune }
        };

        // if catched
        foreach(PlayManager.QuestName monsterName in monsterList.Keys) {
            if (PlayManager.Instance.GetCaughtYokai(monsterName))
            {
                monsterList[monsterName].GetComponent<Image>().sprite = caughtSprite;
                caughtCount++;
            }
        }

        // caught all
        if (caughtCount == monsterList.Count) {
            UI.SetActive(false);
            JapanMapText.SetActive(false);

            Ending.SetActive(true);
            TalkingBird.SetActive(true);
            EndingCanvas.SetActive(true);

            QuestBtn.GetComponent<Button>().onClick.AddListener(showEnding);
        }

        BackBtn.GetComponent<Button>().onClick.AddListener(hideEnding);
    }

    private void hideEnding()
    {
        UI.SetActive(true);
        JapanMapText.SetActive(true);

        Ending.SetActive(false);
        TalkingBird.SetActive(false);
        EndingCanvas.SetActive(false);
    }

    private void showEnding() {
        UI.SetActive(false);
        JapanMapText.SetActive(false);

        Ending.SetActive(true);
        TalkingBird.SetActive(true);
        EndingCanvas.SetActive(true);
    }
}
