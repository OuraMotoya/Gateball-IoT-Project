using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMapScript : MonoBehaviour
{
    public bool BallIsHere = false;
    public GameObject Ball;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(BallIsHere == true){
            Ball.SetActive(true);
        }else{
            Ball.SetActive(false);
        }
    }

    public void OnClick(){
        if(BallIsHere == false){
            BallIsHere = true;
        }else{
            BallIsHere = false;
        }
    }
}
