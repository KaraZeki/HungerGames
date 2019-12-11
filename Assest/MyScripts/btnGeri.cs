using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnGeri : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        if (GUI.Button(new Rect(10, 5, 105, 50), "GERİ"))
        {
            Application.LoadLevel(3);
            Time.timeScale = 1f;
        }


    }
}
