using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO.Ports;

public class arduinoManager : MonoBehaviour
{
    public GameObject cubeButton;
    private bool led = false;
    private Color originalColor;
    private SerialPort arduinoPort = new SerialPort("COM4",19200);
    private string msg;

    public void Button_Clicked()
    {
        Debug.Log("led status clicked");
        if (led == false)
        {
            led = true;
            cubeButton.GetComponent<Renderer>().material.color = Color.yellow;
            msg = "on";
        }
        else
        {
            led = false;
            cubeButton.GetComponent<Renderer>().material.color = originalColor;
            msg = "off";
        }
        updateLed();
    }

    private void updateLed()
    {
        if (!arduinoPort.IsOpen)
        {
            arduinoPort.Open();
        }
        arduinoPort.Write(msg);
        arduinoPort.Close();
    }


    // Start is called before the first frame update
    void Start()
    {
        originalColor= cubeButton.GetComponent<Renderer>().material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
