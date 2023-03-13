using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OnePlayerNameChanger : MonoBehaviour
{
    public InputField OnePlayerInputField;
    public Text OnePlayerText;

    void Start () {
    //Componentを扱えるようにする
        OnePlayerInputField = OnePlayerInputField.GetComponent<InputField> ();
        OnePlayerText = OnePlayerText.GetComponent<Text> ();
    }

    public void InputText(){
         OnePlayerText.text = OnePlayerInputField.text;
     }
}
