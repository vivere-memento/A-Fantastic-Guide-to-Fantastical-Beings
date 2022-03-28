using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yokai
{
    private string yokaiName;
    private string yokaiDescription;
    private string picture;
    private string habitatText;
    private string loreboxText;

    public Yokai(
        string yokaiName,
        string yokaiDescription,
        string picture,
        string habitatText,
        string loreboxText
    ) {
        this.yokaiName = yokaiName;
        this.yokaiDescription = yokaiDescription;
        this.picture = picture;
        this.habitatText = habitatText;
        this.loreboxText = loreboxText;
    }

    public string getYokaiName() {
        return this.yokaiName;
    }

    public string getYokaiDescription() {
        return this.yokaiDescription;
    }

    public string getYokaiPic() {
        return this.picture;
    }

    public string getHabitatText() {
        return this.habitatText;
    }
    public string getLoreboxText() {
        return this.loreboxText;
    }
}

public class YokaiControl : MonoBehaviour
{
    // yokai control instence
    private static YokaiControl i;
    public static YokaiControl Instance{get; private set;}

    // yokai data list
    private List<Yokai> yokaiList;
    private List<string> yokaiNameSequence;

    void Start() {
        // yokai sequence list
        yokaiNameSequence = new List<string>{ "YogenNoTori", "Daidarabotchi", "Onibi", "Raijuu", "Kitsune", "Tengu"};;

        // yokaiName, yokaiDescription, picture, habitatText, loreboxText;
        yokaiList = new List<Yokai>();
        yokaiList.Add(new Yokai("Tengu", 
            "Historically, the Daitengu were viewed as dangerous and violent beings. However, over time, the people of Japan started to see them as wise sages and would sometimes seek their help.Daitengu live alone, in places away from others, practicing meditation to perfect themselves. The long and big noses of a Daitengu show their power. The longer the nose, the more powerful the Daitengu.", 
            "Collection Book/tengu found", "Mountain/Forest", 
            "Daitengu are a type of Tengu, Tengu meaning 'Heavenly Dog'.The Daitengu look closer to humans than the Tengu, but still have bird-like features."));
        yokaiList.Add(new Yokai("Onibi", 
            "Onibi are most commonly seen during periods of rain, yet their mystical fire is not put out by water. Some of these fires are said to produce no heat, but the Onibi instead consume the souls of approaching creatures.These yokai mostly appear in large groups, but can sometimes be seen in groups of one or two. Onibi are said to be formed from the negative spirit energy from human or animal bodies.", 
            "Collection Book/onibii found"," Forest", 
            "Onibi are a kind of ghost, that appear as floating balls of fire. The name Onibi, literally translates to 'Demon Fire'."));
        yokaiList.Add(new Yokai("Raijuu", 
            "When the Raijuu move, they cause lightning strikes and can damage things around them. In the past, the Japanese thought lightning bolts were Raijuu, sent by the gods to punish them. A common superstition in Japan is to cover your belly button when lightning strikes.Children were told that small Raijuu would hide in their navels, thus starting the above practice.",  
            "Collection Book/raiju found", "Thunderbolt", 
            "Raijuu are the manifestations of thunder and lightning.Raijuu appear as wolves but also take the form of other creatures, such as cats, insects or dragons."));
        yokaiList.Add(new Yokai("Daidarabotchi", 
            "The Daidarabotchi are so large that their very movements shaped the landscape of Japan. As such, many towns are named after the yokai which supposedly created them.In legends, Mount Fuji was said to have been created by a Daidarabotchi. The yokai dug up all the dirt around the Kai province to build the mountain, which is why Mount Fuji is in a large basin.", 
            "Collection Book/giant found", "Mountain", 
            "Daidarabotchi are giants that look like bald priests. They have black skin, long snaky tongues and big rolling eyes."));
        yokaiList.Add(new Yokai("YogenNoTori", 
            "In 1858, near Mount Haku, a government official reported receiving a prophecy from a Yogen no Tori.The yokai prophesied a great disaster, which could be averted if people saw its image and believed in the prophecy. The official, wanting to save the citizens, spread the message across the country.This marked the first written record of an encounter with a Yogen no Tori.", 
            "Collection Book/two head crow  found",  "Forest", 
            "Yogen no Tori are twin-headed birds that look like crows. They can speak and are sent by the gods to deliver important messages to humans. "));
        yokaiList.Add(new Yokai("Kitsune", 
            "Kitsune, are mystical foxes that can grow up to 9 tails and live for centuries.Kitsune are highly intelligent, mischevious animals. As servants of the gods, Kitsune also have magical powers.",
            "Collection Book/kitsune found", "Forest/Rural", 
            "Kitsune, are mystical foxes that can grow up to 9 tails and live for centuries. Kitsune are highly intelligent, mischievous animals."));
    }

    public List<string> getFullYokaiList()
    {
        List<string> yokaiNameList = new List<string>();
        foreach (Yokai aYokai in yokaiList)
        {
            yokaiNameList.Add(aYokai.getYokaiName());
        }
        return yokaiNameList;
    } 

    // get description by yokaiName
    public string getYokaiDescription(string yokaiName)
    {
        foreach (Yokai aYokai in yokaiList)
        {
            if (aYokai.getYokaiName().Equals(yokaiName)) {
                return aYokai.getYokaiDescription();
            }
        }
        // If cannot find yokaiName
        return "";
    }

    // get yokai picUrl by yokai name
    public string getYokaiPic(string yokaiName) 
    {
        foreach (Yokai aYokai in yokaiList)
        {
            if (aYokai.getYokaiName().Equals(yokaiName)) {
                return aYokai.getYokaiPic();
            }
        }
        // If cannot find yokaiName
        return "";
    }

    public string getFirstYokaiName() {
        return this.yokaiNameSequence[0];
    }

    public string getDescriptionText(string yokaiName)
    {
        foreach (Yokai aYokai in yokaiList)
        {
            if (aYokai.getYokaiName().Equals(yokaiName)){
                return aYokai.getYokaiDescription();
            }
        }
        return "";
    }
    public string getLoreboxText(string yokaiName)
    {
        foreach (Yokai aYokai in yokaiList)
        {
            if (aYokai.getYokaiName().Equals(yokaiName)){
                return aYokai.getLoreboxText();
            }
        }
        return "";
    }
    public string getHabitatText(string yokaiName)
    {
        foreach (Yokai aYokai in yokaiList)
        {
            if (aYokai.getYokaiName().Equals(yokaiName)){
                return aYokai.getHabitatText();
            }
        }
        return "";
    }

    public int getPageNumber(string yokaiName)
    {
        for (int index = 0; index < yokaiNameSequence.Count; index++)
        {
            if (yokaiNameSequence[index].Equals(yokaiName))
            {
                return index + 1;
            }
        }
        return 0;
    }

    public string getNextYokaiName(string currentYokaiName) 
    {
        for (int index = 0; index < yokaiNameSequence.Count; index++)
        {
            if (yokaiNameSequence[index].Equals(currentYokaiName))
            {
                if (index == (yokaiNameSequence.Count - 1)) {
                    return yokaiNameSequence[0];
                }
                else
                {
                    return yokaiNameSequence[index+1];
                }
            }
        }
        return null;
    }

    public string getPrevYokaiName(string currentYokaiName) 
    {
        for (int index = 0; index < yokaiNameSequence.Count; index++)
        {
            if (yokaiNameSequence[index].Equals(currentYokaiName))
            {
                if (index == 0) {
                    return yokaiNameSequence[yokaiNameSequence.Count - 1];
                }
                else
                {
                    return yokaiNameSequence[index-1];
                }
            }
        }
        return null;
    }

    private void Awake(){
        if( Instance != null){
            Destroy(gameObject);
        }
        else{
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }
}
