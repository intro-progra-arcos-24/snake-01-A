using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Quirky : MonoBehaviour
{
    public TextMeshProUGUI texty;
    public string[] tips = new string[5] {"You really shouldn't touch your tail.", "Properly distributing your body is key if you wish to survive.", "Walls count as hazards too.", "Using your own tail, you can force apples to spawn closer or further from you.", "Keep your calm and be able to think clearly."};

    private int rand;

    // Start is called before the first frame update
    void Start()
    {
        RandomNumber();
        texty.text = tips[rand];
    }

    void RandomNumber()
    {
        rand = Random.Range(0, tips.Length);
    }
}
