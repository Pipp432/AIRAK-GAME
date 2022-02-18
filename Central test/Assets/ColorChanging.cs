using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanging : MonoBehaviour
{
    public Material[] Materialarr;
    Renderer objectRenderer;
    public Material highLightMat;

    public Color startColor;
    public Color endColor;
    public float duration = 1.0f;
    public float value;
    private bool valuesIn=false;

    void Start()
    {
        objectRenderer = gameObject.GetComponent<Renderer>();
        objectRenderer.material = Materialarr[0];
    }

    
    void Update()
    {
        if (valuesIn) {
            valueInputs();
        }
        

        if (Input.GetKeyDown(KeyCode.Q)) {
            if (valuesIn)
            {
                valuesIn = false;
            }
            else {
                valuesIn = true;
            }
           
        }
        if (!valuesIn) {
           keyboardInput();
        }
       

    }
    private void keyboardInput()
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                objectRenderer.material = Materialarr[1];
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                objectRenderer.material = Materialarr[2];
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                objectRenderer.material = Materialarr[0];
            }
            if (Input.GetKey(KeyCode.F))
            {
                objectRenderer.material = Materialarr[3];
                highLightMat.color = Color.Lerp(endColor, startColor, Mathf.PingPong(Time.time, duration));
            }
            if (Input.GetKeyDown(KeyCode.G))
            {
                objectRenderer.material = Materialarr[4];

            }
        }

    private void valueInputs()
    {
        if (0 <= value && value <= 10)
        {
            objectRenderer.material = Materialarr[1];
        }
        if (11 <= value && value <= 20)
        {
            objectRenderer.material = Materialarr[2];
        }
        if (21 <= value && value <= 30)
        {
            objectRenderer.material = Materialarr[0];
        }
        if (31 <= value && value <= 40)
        {
            objectRenderer.material = Materialarr[3];
            highLightMat.color = Color.Lerp(endColor, startColor, Mathf.PingPong(Time.time, duration));
        }
        if (41 <= value && value <= 50)
        {
            objectRenderer.material = Materialarr[4];

        }
    }
}
