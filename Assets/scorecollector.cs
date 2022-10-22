using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scorecollector : MonoBehaviour
{
    public hithead scorein;
    [SerializeField] TextMeshProUGUI scoreui;
    // Start is called before the first frame update
    void Start()
    {
        scoreui = GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreui.text = scorein.score.ToString();
    }
}
