using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class canvasScript : MonoBehaviour
{
    public Text txtTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        txtTime.text = DateTime.Now.ToString("h:mm , d/M/yyyy");
        //Debug.Log(DateTime.Now.ToString("h:mm , d/M/yyyy"));
    }
}
