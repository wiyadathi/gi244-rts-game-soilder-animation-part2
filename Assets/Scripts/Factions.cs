using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Nation
{
    Neutral = 0,
    British,
    Pirates,
    France,
    Spain,
    Protugal,
    Natherland
}

public class Factions : MonoBehaviour
{
    [SerializeField] private Nation nation;
    public Nation Nation
    {
        get { return nation; }
    }
    
    //[Header("Resources")]
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
