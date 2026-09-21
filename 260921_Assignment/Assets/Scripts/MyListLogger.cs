using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyListLogger : MonoBehaviour
{
    private void Start()
    {
        RunOperations();
    }

    private void RunOperations()
    {
        MyList<string> monsters = new MyList<string>();
        
        monsters.Add("슬라임");
        
        
    }
}
