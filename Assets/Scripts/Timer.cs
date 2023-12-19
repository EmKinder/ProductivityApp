using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEditor.Rendering;
//using UnityEngine.TMPro;
public class Timer : MonoBehaviour
{
    [SerializeField] Image imageTimer;
    [SerializeField] TMP_Text textTimer;
    float timer = 0.0f;
    float timerLength = 30.0f;

    float secondTimer = 0.0f;
    float second = 1.0f;
    int timerCount = 0;

    bool playing = false;

    enum TimerMode{Work, Break};
    TimerMode timerMode; 
    // Start is called before the first frame update
    void Start()
    {
        
        timerMode = TimerMode.Work;
    }

    // Update is called once per frame
    void Update(){
        if(playing){
            timer += Time.deltaTime;
            secondTimer += Time.deltaTime;


            if(secondTimer > second){
                if(timer > timerLength){
                    ChangeTimer(timerMode);
                }
                    
                else{
                    imageTimer.fillAmount = timer / timerLength;
                    textTimer.text = GetTimerText(timerLength);
                }
                    
            secondTimer = 0;
            }
        }
    }

    void ChangeTimer(TimerMode mode){
        if(mode == TimerMode.Work){
            timerLength = 25 * 60;
            textTimer.text = "5:00";
            timerMode = TimerMode.Break;
        }
        else{
            timerLength = 5 * 60;
            textTimer.text = "25:00";
            timerMode = TimerMode.Work;
        }
        timer = 0; 
        timerCount = 0;
        imageTimer.fillAmount = 0;
        Debug.Log("Timer Done");

    }

    string GetTimerText(float num){
        float timeRemaining = num - (++timerCount);
        float thisMinutes = Mathf.FloorToInt(timeRemaining / 60);
        float thisSeconds = Mathf.FloorToInt(timeRemaining % 60);
        return string.Format("{0:00}:{1:00}", thisMinutes, thisSeconds);
    }

    public void SetPlayState(bool state){
        playing = state;
    }

    public void ResetTimer(){
        ChangeTimer(TimerMode.Break);
        playing = false;
    }

}
