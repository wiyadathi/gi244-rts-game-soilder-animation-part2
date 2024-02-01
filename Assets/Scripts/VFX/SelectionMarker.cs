using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionMarker : MonoBehaviour
{
    
    [SerializeField] private float lifetime = 1f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
