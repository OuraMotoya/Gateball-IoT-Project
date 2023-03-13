using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TwoPlayer : MonoBehaviour
{
    public static int TwoPlayerScoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + TwoPlayerScoreValue;
        if(Input.GetButtonDown("2") && TwoPlayerScoreValue <= 10){
            TwoPlayerScoreValue += 1;
        }else if(TwoPlayerScoreValue == 10){
            TwoPlayerScoreValue = 0;
        }
    }
}
