using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.UI;
public class highscore : MonoBehaviour
{
    public hithead score; 
 
     TextMeshProUGUI Scoreui;  
    // Start is called before the first frame update
    void Start()
    {
        Scoreui = GetComponent<TextMeshProUGUI>();
        Scoreui.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        int scorecomparator = score.score;

        if(scorecomparator > PlayerPrefs.GetInt("Highscore",0 ))
        {
            PlayerPrefs.SetInt("Highscore", scorecomparator) ;
            Scoreui.text = scorecomparator.ToString();

        }

        
    }
}
