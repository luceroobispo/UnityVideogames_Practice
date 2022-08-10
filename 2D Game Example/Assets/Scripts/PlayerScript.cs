using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public int Score;
    public Text ScoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        Score = 0;
        Score.text = "Score: " + Score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
