using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RefereeButton : MonoBehaviour
{
    public void OnClick()
    {
      SceneManager.LoadScene("Scenes/Score Calculator");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
