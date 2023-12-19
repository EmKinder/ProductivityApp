using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TimerControls : MonoBehaviour
{
    [SerializeField] Timer timer; 
    [SerializeField]TMP_Text timerText;
    
    bool currentPlayState = false;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void TimerStart(){
        currentPlayState = !currentPlayState;
        timer.SetPlayState(currentPlayState);
        if(currentPlayState)
            timerText.text = "Pause";
        else{
            timerText.text = "Play";
        }
    }
    
    public void TimerRestart(){
        currentPlayState = false;
        timerText.text = "Start";
        timer.ResetTimer();
    }
}
