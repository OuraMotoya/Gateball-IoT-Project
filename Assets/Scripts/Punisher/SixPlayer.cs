using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SixPlayer : MonoBehaviour
{
    public static int SixPlayerScoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + SixPlayerScoreValue;
        if(Input.GetButtonDown("6") && SixPlayerScoreValue <= 10){
            SixPlayerScoreValue += 1;
        }else if(SixPlayerScoreValue == 10){
            SixPlayerScoreValue = 0;
        }
    }
}
