using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NinePlayer : MonoBehaviour
{
    public static int NinePlayerScoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + NinePlayerScoreValue;
        if(Input.GetButtonDown("9") && NinePlayerScoreValue <= 10){
            NinePlayerScoreValue += 1;
        }else if(NinePlayerScoreValue == 10){
            NinePlayerScoreValue = 0;
        }
    }
}
