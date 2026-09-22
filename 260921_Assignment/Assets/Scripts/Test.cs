using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    private int[] arr = new int[]{};
    private int[] arr2 = new int[10];
    
    private void Start()
    {
        Debug.Log(arr.Length);
        Debug.Log(arr2.Length);
        Debug.Log(arr.Length);
        Debug.Log(arr2.Length);
        
        Debug.Log($"arr E arr : {arr.Length.Equals(arr.Length)}"); // T
        Debug.Log($"arr E arr : {arr.Length.Equals(0)}"); // T
        Debug.Log($"arr E arr : {!arr.Length.Equals(0)}"); // F
        Debug.Log($"arr E arr2 : {arr.Length.Equals(arr2.Length)}"); // F
        // Debug.Log($"arr[0] E 0 : {arr[0].Equals(0)}");
        Debug.Log($"arr2[0] E 0 : {arr2[0].Equals(0)}"); // T
        
        Debug.Log(arr2.Length);
        Debug.Log(arr2.Length);
        Debug.Log(arr2.Length);
        Debug.Log(arr2.Length);
        
        
    }
}
