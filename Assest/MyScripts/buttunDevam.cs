using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttunDevam : MonoBehaviour
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

        if (GUI.Button(new Rect(60, 55, 55, 50), "Devam"))
        {
            Time.timeScale = 1f;
        }


    }
}
