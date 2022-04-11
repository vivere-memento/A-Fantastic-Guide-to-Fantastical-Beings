using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadTitle : MonoBehaviour
{
    [SerializeField]
    private Texture2D cursor;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursor,Vector2.zero,CursorMode.ForceSoftware);
    }
    public void GoToTitle(){
        SceneManager.LoadScene("TitleScreen");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
