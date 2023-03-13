using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour
{
    public Text timerText;
    public Text crazyWord;

    public GameObject timerTextObject;
    public GameObject crazyWordObject;
 
	public float totalTime;
	int seconds;
 
	// Use this for initialization
	void Start () {
		timerTextObject.SetActive(true);
	}
 
	// Update is called once per frame
	void Update () {
		totalTime -= Time.deltaTime;
		seconds = (int)totalTime;
		timerText.text= seconds.ToString();
        crazyWordObject.SetActive(false);

        if(totalTime <= 0){
           timerTextObject.SetActive(false);
           crazyWordObject.SetActive(true);
        }
	}
}
