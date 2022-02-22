using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayManager : MonoBehaviour
{
    private static PlayManager i;
    public static PlayManager Instance{
        get{
            if(! i){
                i = new GameObject().AddComponent<PlayManager>();
                i.name = i.GetType().ToString();
                DontDestroyOnLoad(i.gameObject);
            }
            return i;
        }
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
