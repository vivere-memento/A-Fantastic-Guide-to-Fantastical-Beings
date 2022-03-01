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
        yokaiList.Add(new Yokai("Monster1", "Description1", "yokai1", "yokai story"));
        yokaiList.Add(new Yokai("Monster2", "Description2", "pic", "yokai story"));
        yokaiList.Add(new Yokai("Monster3", "Description3", "pic", "yokai story"));
        yokaiList.Add(new Yokai("Monster4", "Description4", "pic", "yokai story"));
        yokaiList.Add(new Yokai("Monster5", "Description5", "pic", "yokai story"));
        yokaiList.Add(new Yokai("Monster6", "Description6", "pic", "yokai story"));
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
