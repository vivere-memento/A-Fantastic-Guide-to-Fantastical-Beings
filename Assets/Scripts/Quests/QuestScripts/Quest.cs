using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName =  "New Quest", menuName =  "Quests")]
public class Quest : ScriptableObject
{
    public string questName;
    public int id;
    public List<string> questText;

}
