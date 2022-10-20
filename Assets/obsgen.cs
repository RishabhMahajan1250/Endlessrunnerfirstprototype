using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsgen : MonoBehaviour
{
    public float speed;
    bool spawn; 
    public GameObject obstacle;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
        for (int i = 0; i <= 26; i++)
        {


            GameObject a = Instantiate(obstacle) as GameObject;
            a.transform.position = new Vector3(Random.Range(-4, 4), transform.position.y, transform.position.z + i * 7);
           
        }
        
           
        
    }
    // Update is called once per frame
    void Update()
    {
      
         /*   if (transform.position.z > 131f )
            {
            
               
            }*/
        
        transform.position += new Vector3(0f, 0f, -7f * Time.deltaTime * speed);
        if (transform.position.z <= -21.9f)
        {
            transform.position += new Vector3(0f, 0f, 171f);
            for (int i = 0; i <= 26; i++)
            {


                GameObject a = Instantiate(obstacle) as GameObject;
                a.transform.position = new Vector3(Random.Range(-4, 4), transform.position.y, transform.position.z + i * 7);
                /*if (i > 25)
                {

                }*/
            }

        }
       
        
       



    }

}
