using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GAMESTART : MonoBehaviour
{
    static int x = 0;
    [SerializeField] obsgen obstaclegenerator;
    [SerializeField] Image startscreen;
    // Start is called before the first frame update
    void Start()
    {
        startscreen = GetComponent<Image>();
        startscreen.enabled = true;
        obstaclegenerator.enabled = false;
        x = x + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            startscreen.enabled = false;
            x = x - 1; 
            
        }
        if (x == 0)
        {
            obstaclegenerator.enabled = true;
        }
    }
}
