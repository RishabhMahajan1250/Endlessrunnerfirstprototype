using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelgenerator : MonoBehaviour
{
   [SerializeField] GameObject level; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Player"))
        {
           GameObject a = Instantiate(level) as GameObject;
        }
    }
}
