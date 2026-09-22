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
        
        Debug.Log(monsters.Count);
        Debug.Log(monsters.Capacity);
        
        monsters.Add("슬라임");
        monsters.Add("슬라임");
        monsters.Add("고블린");
        monsters.Add("고블린");
        monsters.Add("고블린");
        
        Debug.Log(monsters.Count);
        Debug.Log(monsters.Capacity);
    }
}
