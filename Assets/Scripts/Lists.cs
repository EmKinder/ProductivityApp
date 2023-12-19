using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lists : MonoBehaviour
{
    List<ToDoList> lists = new List<ToDoList>();
    public void CreateNewList(string name){
        ToDoList thisList = new ToDoList(name, new List<string>(), false);
        lists.Add(thisList);
        Debug.Log(lists[lists.Count - 1].GetName());
    }
}
