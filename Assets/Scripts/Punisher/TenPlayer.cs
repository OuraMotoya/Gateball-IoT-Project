using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TenPlayer : MonoBehaviour
{
    public static int TenPlayerScoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "" + TenPlayerScoreValue;
        if(Input.GetButtonDown("0") && TenPlayerScoreValue <= 10){
            TenPlayerScoreValue += 1;
        }else if(TenPlayerScoreValue == 10){
            TenPlayerScoreValue = 0;
        }
    }
}
