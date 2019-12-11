using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class buttunDurdur : MonoBehaviour
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
        
        if (GUI.Button(new Rect(10, 55, 50, 50), "Dur"))
        {
            Time.timeScale = 0f;
        }


    }
}
