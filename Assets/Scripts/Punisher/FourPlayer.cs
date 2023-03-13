using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FourPlayer : MonoBehaviour
{
    public static int FourPlayerScoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + FourPlayerScoreValue;
        if(Input.GetButtonDown("4") && FourPlayerScoreValue <= 10){
            FourPlayerScoreValue += 1;
        }else if(FourPlayerScoreValue == 10){
            FourPlayerScoreValue = 0;
        }
    }
}
