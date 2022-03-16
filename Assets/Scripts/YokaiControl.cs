using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Yokai
{
    private string yokaiName;
    private string yokaiDescription;
    private string picture;
    private string yokaiStory;

    public Yokai(
        string yokaiName,
        string yokaiDescription,
        string picture,
        string yokaiStory
    ) {
        this.yokaiName = yokaiName;
        this.yokaiDescription = yokaiDescription;
        this.picture = picture;
        this.yokaiStory = yokaiStory;
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

    public string getYokaiStory() {
        return this.yokaiStory;
    }
}

public class YokaiControl : MonoBehaviour
{
    // yokai control instence
    private static YokaiControl i;
    public static YokaiControl Instance{get; private set;}

    // yokai data list
    private List<Yokai> yokaiList;

    void Start() {
        yokaiList = new List<Yokai>();
        yokaiList.Add(new Yokai("Tengu", "Description2", "tengu fullbody alt", "yokai story"));
        yokaiList.Add(new Yokai("Onibi", "Description3", "onibii 03", "yokai story"));
        yokaiList.Add(new Yokai("Raijuu", "Description4", "raiju 01", "yokai story"));
        yokaiList.Add(new Yokai("Daidarabotchi", "Description5", "giant copy", "yokai story"));
        yokaiList.Add(new Yokai("YogenNoTori", "Description1", "two head crow  04", "yokai story"));
        yokaiList.Add(new Yokai("Kitsune", "Description6", "kitsune full body 01", "yokai story"));
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
