using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class restart : MonoBehaviour
{
    public GAMESTART gamestart;
    static int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        x = x + 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0)
        {
         
            x = x - 1;
            Debug.Log(x);
        }
        if (x == 0)
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            

        }
     

        
            
       
    }
}
