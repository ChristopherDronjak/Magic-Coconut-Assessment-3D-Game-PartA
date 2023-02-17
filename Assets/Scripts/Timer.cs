using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public Text timerT;
    private float start_time;
    public float end_time;
    private float expected_finish_time = 330; //format - 1st number = minutes, 2nd and 3rd numbers = seconds
    private bool finished = false;
    
    void Start()
    {
        start_time = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if(finished)
            return;

         float t = Time.time - start_time;
    
        

        string minutes = ((int) t / 60).ToString();
        string seconds = (t % 60).ToString("f2");

        string timerinfo = string.Format("{0}:{1}", minutes, seconds); 
        timerT.text = timerinfo;     
        end_time = float.Parse(minutes + seconds);
    }


    public void Finish()
    {
        finished = true;
        if(end_time < expected_finish_time)
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
        }
        else
        {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +2);
        }
    }  
}
