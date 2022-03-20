using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CollectYokai : MonoBehaviour 
{ 
    private Camera cam; 
    private bool isClicked; 
 
    [SerializeField] private GameObject descBox; 
    [SerializeField] private GameObject yokai; 
    [SerializeField] private TMP_Text yokaiText; 
    [SerializeField] private GameObject propBlock;

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
            Scene currentScene = SceneManager.GetActiveScene();
            string sceneName = currentScene.name;

            if (sceneName == "Daidarabotchi")
            {
                cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 2.6f, Time.deltaTime * 5);
                cam.transform.position = new Vector3(transform.position.x + 0.9f, transform.position.y, cam.transform.position.z);
            }
            else if (sceneName == "Kitsune")
            {
                cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 1.5f, Time.deltaTime * 5);
                cam.transform.position = new Vector3(transform.position.x + 0.9f, transform.position.y, cam.transform.position.z);
            }
            else
            {
                cam.orthographicSize = Mathf.Lerp(cam.orthographicSize, 1, Time.deltaTime * 5);
                cam.transform.position = new Vector3(transform.position.x + 0.7f, transform.position.y, cam.transform.position.z);
            }
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
                yokaiText.text = "Yogen no Tori are twin-headed birds that look like crows." +
                                 "They can speak and the gods use them to deliver important messages.\n\n"+
                                 "In 1858, near Mount Haku, a government official heard a prophecy from a Yogen no Tori.\n"+
                                 "The yokai prophesied a great disaster, which could be averted if its message was spread to the people\n"+
                                 "The official, wanting to save the citizens, spread the message across the country.\n This marked the first written record of an encounter with a Yogen no Tori."; 
                PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.YogenNoTori); 
            } 
            else if (yokai.name == "Tengu Daoshi") 
            { 
                propBlock.SetActive(false); 
                yokaiText.text = "Daitengu are a type of Tengu, Tengu meaning 'Heavenly Dog'."+
                                 "The Daitengu look closer to humans than the Tengu, but still have bird-like features.\n\n"+
                                 "Historically, the Daitengu were viewed as dangerous beings. However, over time, the Japanese began to see them as wise sages and would sometimes seek their help.\n"+
                                 "Daitengu live alone, in places away from others, practicing meditation to perfect themselves. \nThe long and big noses of a Daitengu show their power. The longer the nose, the more powerful the Daitengu."; 
                PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Tengu); 
            } 
            else if (yokai.name == "Daidarabotchi") 
            { 
                propBlock.SetActive(false); 
                yokaiText.text = "Daidarabotchi are giants that look like bald priests.\n"+
                                 "They have black skin, long snaky tongues and big rolling eyes.\n\n"+
                                 "The Daidarabotchi are so large that their very movements shaped the landscape of Japan."+
                                 "As such, many towns are named after the yokai which supposedly created them.\n"+
                                 "In legends, Mount Fuji was said to have been created by a Daidarabotchi. The yokai dug up all the dirt around the Kai province to build the mountain, which is why Mount Fuji is in a large basin."; 
                PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Daidarabotchi); 
            } 
            else if (yokai.name == "Kitsune") 
            { 
                propBlock.SetActive(false); 
                yokaiText.text = "Kitsune, are mystical foxes that can grow up to 9 tails and live for centuries.\nKitsune are highly intelligent, mischevious animals. As servants of the gods, Kitsune also have magical powers.\n\n"+
                                 "STORY TEXT PENDING..."; 
                PlayManager.Instance.CaughtAYokai(PlayManager.QuestName.Kitsune); 
            } 
            /*else if (yokai.name == "Oniibii") 
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