using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    MyHeap newHeap = new MyHeap();

    void Start()
    {
        newHeap.Add(1);
        newHeap.Add(2);
        newHeap.Add(3);
        newHeap.Add(4);
        newHeap.Add(5);
        newHeap.Add(8);
        newHeap.Add(8);

        newHeap.Display();

        Debug.Log(newHeap.Pop());
        Debug.Log(newHeap.Pop());
        Debug.Log(newHeap.Pop());
        Debug.Log(newHeap.Pop());
        Debug.Log(newHeap.Pop());
        Debug.Log(newHeap.Pop());
        Debug.Log(newHeap.Pop());
    }

    void Update()
    {
        
    }
}
