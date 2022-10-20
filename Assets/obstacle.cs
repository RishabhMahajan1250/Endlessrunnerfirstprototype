using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacle : MonoBehaviour
{
    [SerializeField] GameObject obstacleobject;
    int x ;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (x = 1; x < 17; x++)
        {
            Vector3 a = new Vector3(transform.position.x, transform.position.y  , transform.position.z + x * 0.01f);
            GameObject b = Instantiate(obstacleobject) as GameObject;
            b.transform.localScale = obstacleobject.transform.localScale;
            b.transform.position = a;
        }
    }
  /*  void obsg()
    {
        for(x = 1; x < 29; x++) 
        { 
        Vector3 a = new Vector3(transform.position.x, transform.position.y, transform.position.z + x*14);
            GameObject b = Instantiate(obstacleobject) as GameObject;
            b.transform.position = a; 
        }
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.CompareTag("Respawn"))
        {
            obsg();
            Debug.Log("trigger activated");
        }
    }*/

}
