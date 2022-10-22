using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enabler : MonoBehaviour
{
    
    [SerializeField] obsgen startlevel;// Start is called before the first frame update
    void Start()
    {
        startlevel.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            startlevel.enabled = true;
        }
       
    }
}
