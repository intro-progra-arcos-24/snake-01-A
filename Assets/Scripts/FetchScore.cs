using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FetchScore : MonoBehaviour
{
    public TextMeshProUGUI text;
    public GridArenaManager manager;

    // Start is called before the first frame update
    void Start()
    {
        GetScore();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void GetScore()
    {
        text.text = "Score: " + manager.score;
    }
}
