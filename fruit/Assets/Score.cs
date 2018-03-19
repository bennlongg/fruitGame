using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{

    private Text myText;
    static public int score;
    // Use this for initialization
    void Start()
    {
        myText = GetComponent<Text>();
        Reset();
    }

    public void Points(int points)
    {
        score += points;
        myText.text = score.ToString();
    }

    public void Reset()
    {
        score = 0;
        myText.text = score.ToString();
    }
}
