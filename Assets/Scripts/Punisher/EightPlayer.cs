using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EightPlayer : MonoBehaviour
{
    public static int EightPlayerScoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + EightPlayerScoreValue;
        if(Input.GetButtonDown("8") && EightPlayerScoreValue <= 10){
            EightPlayerScoreValue += 1;
        }else if(EightPlayerScoreValue == 10){
            EightPlayerScoreValue = 0;
        }
    }
}
