using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class screenappear : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI score;
  
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
        score.enabled = true;

    }
}
