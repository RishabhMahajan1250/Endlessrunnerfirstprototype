using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enabler : MonoBehaviour
{
    static int x = 0;
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
            x = 1;
        }
        if (x == 1)
        {
            startlevel.enabled = true;
        }
    }
}
