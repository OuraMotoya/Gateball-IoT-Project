using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FivePlayer : MonoBehaviour
{
    public static int FivePlayerScoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + FivePlayerScoreValue;
        if(Input.GetButtonDown("5") && FivePlayerScoreValue <= 10){
            FivePlayerScoreValue += 1;
        }else if(FivePlayerScoreValue == 10){
            FivePlayerScoreValue = 0;
        }
    }
}
