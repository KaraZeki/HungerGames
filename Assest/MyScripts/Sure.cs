using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Sure : MonoBehaviour
{

    public float zaman;
    public Text Timer;

    void Start()
    {
        zaman = Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        zaman += Time.deltaTime;
        Timer.text = zaman.ToString("f1");
    }
}
