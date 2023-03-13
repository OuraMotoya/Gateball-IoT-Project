using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GraphicTimer : MonoBehaviour
{
    public float span = 3f;
    public float currentTime = 0f;

    public GameObject Gra1;
    public GameObject Gra2;

    public float Pattern = 1; 

    void Update () {
        currentTime += Time.deltaTime;

        if(currentTime > span){
            if(Pattern == 1){
                Pattern = 2;
            }else if(Pattern == 2){
                Pattern = 1;
            }

            if(Pattern == 1){
                Gra1.SetActive(true);
                Gra2.SetActive(false);
            }else if(Pattern == 2){
                Gra1.SetActive(false);
                Gra2.SetActive(true);
            }

            Debug.LogFormat ("{0}秒経過", span);
            currentTime = 0f;
        }
    }
}
