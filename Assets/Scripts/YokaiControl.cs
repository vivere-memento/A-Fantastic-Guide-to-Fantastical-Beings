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
        yokaiNameSequence = new List<string>{ "YogenNoTori", "Daidarabotchi", "Onibi", "Raijuu", "Tengu" };;

        // yokaiName, yokaiDescription, picture, habitatText, loreboxText;
        yokaiList = new List<Yokai>();
        yokaiList.Add(new Yokai("Tengu", "Description1", "Collection Book/tengu found", "habitat1", "lorebox1"));
        yokaiList.Add(new Yokai("Onibi", "Description2", "Collection Book/onibii found","habitat2", "lorebox2"));
        yokaiList.Add(new Yokai("Raijuu", "Description3",  "Collection Book/raiju found", "habitat3", "lorebox3"));
        yokaiList.Add(new Yokai("Daidarabotchi", "Description4", "Collection Book/giant found", "habitat4", "lorebox4"));
        yokaiList.Add(new Yokai("YogenNoTori", "Description5", "Collection Book/two head crow  found",  "habitat5", "lorebox5"));
        yokaiList.Add(new Yokai("Kitsune", "Description6", "Collection Book/kitsune found", "habitat6", "lorebox6"));
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
