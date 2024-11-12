using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    public float targetTime = 120.0f;
    bool startTimer = false;
    public TMP_Text timetext;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (startTimer)
        {
            timetext.text = targetTime.ToString();
            targetTime -= Time.deltaTime;

            if (targetTime <= 0.0f)
            {
                timerEnded();
            }
        }
       

    }

    public void starttime()
    {
        startTimer = true;
    }

    
    void timerEnded()
    {
        
    }

    public void ReloadGame()
    {
        SceneManager.LoadScene("GameScene");
    }

}
