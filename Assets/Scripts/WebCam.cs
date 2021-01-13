using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WebCam : MonoBehaviour
{

    int currentCameraIndex = 0;
    WebCamTexture cameraTexture;

    public RawImage display;

    public void SwapCamp_Clicked()
    {
        if (WebCamTexture.devices.Length > 0)
        {
            currentCameraIndex++;
            currentCameraIndex %= WebCamTexture.devices.Length;
        }
        Debug.Log("Clicked");
    }

    public void StartStopCam_CLicked()
    {
        Debug.Log("Start Clicked");
        if (cameraTexture != null)
        {
            display.texture = null;
            cameraTexture.Stop();
            cameraTexture = null;
        }
        else
        {
            WebCamDevice device = WebCamTexture.devices[currentCameraIndex];
            cameraTexture = new WebCamTexture(device.name);
            display.texture = cameraTexture;

            cameraTexture.Play(); // starts the camera
        }

    }




    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Yay");
       // StartStopCam_CLicked();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
