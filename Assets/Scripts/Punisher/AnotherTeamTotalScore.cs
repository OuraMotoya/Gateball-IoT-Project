using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AnotherTeamTotalScore : MonoBehaviour
{
    public int AnotherTeamTotalScoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + AnotherTeamTotalScoreValue;
        AnotherTeamTotalScoreValue = SixPlayer.SixPlayerScoreValue + SevenPlayer.SevenPlayerScoreValue + EightPlayer.EightPlayerScoreValue + NinePlayer.NinePlayerScoreValue + TenPlayer.TenPlayerScoreValue;
    }
}
