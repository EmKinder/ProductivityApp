using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

struct ToDoList
{
    public string Name; 
    public List<String> SubTasks;
    public bool Complete; 

    public ToDoList(string name, List<String> subTasks, bool complete){
        this.Name = name; 
        this.SubTasks = subTasks;
        this.Complete = complete;
    }

        public string GetName(){
        return Name; 
    }
    
    public void SetName(string name){
        Name = name;
    }

    public bool GetComplete(){
        return Complete;
    }
    
    public void SetComplete(bool complete){
        Complete = complete; 
    }

    public void AddSubTask(string task){
        SubTasks.Add(task);
    }
}
