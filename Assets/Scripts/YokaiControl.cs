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

    private string firstYokaiName = "Tengu";
    void Start() {
        yokaiList = new List<Yokai>();
        yokaiList.Add(new Yokai("Tengu", "Description1", "habitat1","tengu found", "lorebox1"));
        yokaiList.Add(new Yokai("Onibi", "Description2", "habitat2","onibii found", "lorebox2"));
        yokaiList.Add(new Yokai("Raijuu", "Description3", "habitat3", "raiju found", "lorebox3"));
        yokaiList.Add(new Yokai("Daidarabotchi", "Description4", "habitat4", "giant found", "lorebox4"));
        yokaiList.Add(new Yokai("YogenNoTori", "Description5", "habitat5", "two head crow  found", "lorebox5"));
        yokaiList.Add(new Yokai("Kitsune", "Description6", "habitat6", "kitsune found", "lorebox6"));
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
        return this.firstYokaiName;
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
