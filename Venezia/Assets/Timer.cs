using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text timerText;
    public string minutes = "0";
    private float startTime;
    private bool finnished = false;
    // Start is called before the first frame update
    void Start()
    {
        startTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {   
        if(finnished)
            return;
        float t = Time.time-startTime;
        minutes = ((int) t /60).ToString();
        string seconds = (t%60).ToString("f2");
        timerText.text = minutes + ":"+ seconds;
    }
    public void Finnish()
    {   
        finnished = true;
        timerText.color = Color.yellow;
    }
}
