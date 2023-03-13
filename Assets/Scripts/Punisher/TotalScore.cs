using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TotalScore : MonoBehaviour
{
    public static int TotalScoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + TotalScoreValue;
        TotalScoreValue = OnePlayer.scoreValue + TwoPlayer.TwoPlayerScoreValue + ThreePlayer.ThreePlayerScoreValue + FourPlayer.FourPlayerScoreValue + FivePlayer.FivePlayerScoreValue;
    }
}
