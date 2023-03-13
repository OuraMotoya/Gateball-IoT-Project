using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SevenPlayer : MonoBehaviour
{
    public static int SevenPlayerScoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + SevenPlayerScoreValue;
        if(Input.GetButtonDown("7") && SevenPlayerScoreValue <= 10){
            SevenPlayerScoreValue += 1;
        }else if(SevenPlayerScoreValue == 10){
            SevenPlayerScoreValue = 0;
        }
    }
}
