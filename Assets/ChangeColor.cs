using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour
{
    public Text textInteger;
    public Material mat;


    private Color originalColor;
    private bool clicked=false;
    // Start is called before the first frame update
    void Start()
    {
        originalColor = GetComponent<Renderer>().material.color;
    }

    public void enter()
    {
        if(clicked==false)
          GetComponent<Renderer>().material.color = Color.blue;
    }

    public void exit()
    {
        if (clicked == false)
            GetComponent<Renderer>().material.color = originalColor;
    }

    public void preesed()
    {
        int score = int.Parse(textInteger.text);
        if (clicked == false)   
            score++;
        clicked = true;
        textInteger.text = score + "";
        GetComponent<Renderer>().material.color = Color.black;
    }



}
