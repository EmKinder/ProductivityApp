using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ListButtons : MonoBehaviour
{
    [SerializeField] TMP_Text inputField;
    [SerializeField] TMP_InputField inputFieldParent;
    [SerializeField] Lists lists;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddTaskOnClick(){
        lists.CreateNewList(inputField.text.ToString());
        inputFieldParent.text = "";
    }
}
