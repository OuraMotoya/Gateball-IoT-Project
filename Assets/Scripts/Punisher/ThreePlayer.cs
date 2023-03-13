using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThreePlayer : MonoBehaviour
{
    public static int ThreePlayerScoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + ThreePlayerScoreValue;
        if(Input.GetButtonDown("3") && ThreePlayerScoreValue <= 10){
            ThreePlayerScoreValue += 1;
        }else if(ThreePlayerScoreValue == 10){
            ThreePlayerScoreValue = 0;
        }
    }
}
