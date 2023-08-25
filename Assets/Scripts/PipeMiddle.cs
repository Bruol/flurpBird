using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMiddle : MonoBehaviour
{
    public LogicScript logicScript;

    void Start()
    {
        logicScript = GameObject.Find("LogicManager").GetComponent<LogicScript>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        //Debug.Log("Triggered");
        logicScript.incScore(1);
    
    }
}
