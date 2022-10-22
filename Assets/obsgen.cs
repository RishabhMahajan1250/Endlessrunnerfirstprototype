using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsgen : MonoBehaviour
{
    public float speed;
    bool spawn;
    public GameObject crystal;
    public GameObject obstacle;
    public GameObject obstacleslide;
    // Start is called before the first frame update
    void Start()
    {
        speed = 1;
        transform.position += new Vector3(0f, 0f, 30f);
        for (int i = 0; i <= 26/3f; i++)
        {
           

            GameObject a = Instantiate(obstacle) as GameObject;
            a.transform.position = new Vector3(Random.Range(-2, 4),transform.position.y , transform.position.z + i * 7*3f);
            a.transform.localScale = new Vector3(Random.Range(100, 200), a.transform.localScale.y, a.transform.localScale.z);
        }
        for (int i = 0; i <= 13/3f; i++)
        {


            GameObject a = Instantiate(obstacleslide) as GameObject;
            a.transform.position = new Vector3(transform.position.x - 2, 1.5f, transform.position.z + i * 14*3f);

        }
        for (int i = 0; i <= 26 * 4f; i++)
        {


            GameObject a = Instantiate(crystal) as GameObject;
            a.transform.position = new Vector3(Random.Range(-2, 4), transform.position.y+0.75f, transform.position.z + i * 7/4f);
           // a.transform.localScale = new Vector3(Random.Range(100, 400), a.transform.localScale.y, a.transform.localScale.z);
        }




    }
    // Update is called once per frame
    void Update()
    {
      
         /*   if (transform.position.z > 131f )
            {
            
               
            }*/
        
        transform.position += new Vector3(0f, 0f, -20f * Time.deltaTime * speed);
        if (transform.position.z <= -21.9f)
        {
            transform.position += new Vector3(0f, 0f, 171f+30f);
            for (int i = 0; i <= 26/3f; i++)
            {
               

                GameObject a = Instantiate(obstacle) as GameObject;
                a.transform.position = new Vector3(Random.Range(-2, 4), transform.position.y , transform.position.z + i * 7*3f);
                a.transform.localScale = new Vector3(Random.Range(100, 200), a.transform.localScale.y, a.transform.localScale.z);
                /*if (i > 25)
                {

                }*/
            }
            for (int i = 0; i <= 13/3f; i++)
            {


                GameObject a = Instantiate(obstacleslide) as GameObject;
                a.transform.position = new Vector3(transform.position.x - 2, 1.5f, transform.position.z + i * 14*3f);

            }
            for (int i = 0; i <= 26 * 4f; i++)
            {


                GameObject a = Instantiate(crystal) as GameObject;
                a.transform.position = new Vector3(Random.Range(-2, 4), transform.position.y+ 0.75f, transform.position.z + i * 7 / 4f);
                //a.transform.localScale = new Vector3(Random.Range(100, 400), a.transform.localScale.y, a.transform.localScale.z);
            }

        }
       
        
       



    }

}
