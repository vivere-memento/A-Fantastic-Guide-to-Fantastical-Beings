using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class FootprintController : MonoBehaviour
{
    [SerializeField]
    private List<Footprint> footsteps;

    public List<Footprint> GetListOfPrints(){
        return this.footsteps;
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
