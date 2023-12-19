using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemTime : MonoBehaviour
{

    System.DateTime dt; 
    float timer = 0; 
    float second = 1.0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        dt = System.DateTime.Now;
        timer += Time.deltaTime; 
        if(timer > second){
            Debug.Log(dt);
            timer = 0; 
        }
    }
}
