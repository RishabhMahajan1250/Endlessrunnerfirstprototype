using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class screenappear : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI highscore;
    public restart restart;
    [SerializeField] Image endscreen;
    // Start is called before the first frame update
    void Start()
    {
        endscreen = GetComponent<Image>();
         
      
    }

    // Update is called once per frame
    void Update()
    {
        endscreen.enabled = true;
        restart.enabled = true;
        score.enabled = true;
        highscore.enabled = true;

    }
}
