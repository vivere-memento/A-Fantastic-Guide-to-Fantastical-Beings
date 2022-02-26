using System.Collections;
using System.Collections.Generic;

public class MonsterData
{
    private string monsterName;
    private string monsterDescription;

    public string getMonsterDescription(string monsterName) {
        switch(monsterName) 
        {
        case "Monster1":
            return "Description for monster 1";
        case "Monster2":
            return "Description for monster 2";
        case "Monster3":
            return "Description for monster 3";
        case "Monster4":
            return "Description for monster 4";
        case "Monster5":
            return "Description for monster 5";
        case "Monster6":
            return "Description for monster 6";
        default:
            return "Default";
        }
    }

    public static MonsterData Instance { get; private set; } = new MonsterData();

    private MonsterData(){ }
}
