using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GAMESTART : MonoBehaviour
{
    public GAMESTART gamestart; 
    public restart restart;
    static int x ;
    [SerializeField] obsgen obstaclegenerator;
    [SerializeField] Image startscreen;
    // Start is called before the first frame update
    void Start()
    {
        startscreen = GetComponent<Image>();
        startscreen.enabled = true;
        obstaclegenerator.enabled = false;
        x = 1;
    }

    // Update is called once per frame
    void Update()
    {
        restart.enabled = false;
        if (Input.touchCount > 0)
        {
            startscreen.enabled = false;
            x = 0;

        }
       
        if (x == 0)
        {
           
            obstaclegenerator.enabled = true;
            gamestart.enabled = false;

        }
      /*  else
        {
            startscreen.enabled = true;
            obstaclegenerator.enabled = false;
        }*/
    }
}
