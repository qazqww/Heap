using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    ArrayMinHeap minHeap = new ArrayMinHeap();
    ArrayMaxHeap maxHeap = new ArrayMaxHeap();

    void Start()
    {
        minHeap.Add(3);
        minHeap.Add(2);
        minHeap.Add(7);
        minHeap.Add(5);
        minHeap.Add(11);
        minHeap.Add(13);
        minHeap.Add(1);
        minHeap.Display();

        Debug.Log(minHeap.Pop());
        minHeap.Display();
        Debug.Log(minHeap.Pop());
        minHeap.Display();
        Debug.Log(minHeap.Pop());
        minHeap.Display();
        Debug.Log(minHeap.Pop());
        minHeap.Display();
        Debug.Log(minHeap.Pop());
        minHeap.Display();
        Debug.Log(minHeap.Pop());
        minHeap.Display();
        Debug.Log(minHeap.Pop());
        minHeap.Display();

        //maxHeap.AddNum(3);
        //maxHeap.AddNum(2);
        //maxHeap.AddNum(7);
        //maxHeap.AddNum(5);
        //maxHeap.AddNum(11);
        //maxHeap.AddNum(13);
        //maxHeap.AddNum(1);
        //maxHeap.Display();

        //Debug.Log(maxHeap.Pop());
        //maxHeap.Display();
        //Debug.Log(maxHeap.Pop());
        //maxHeap.Display();
        //Debug.Log(maxHeap.Pop());
        //maxHeap.Display();
        //Debug.Log(maxHeap.Pop());
        //maxHeap.Display();
        //Debug.Log(maxHeap.Pop());
        //maxHeap.Display();
        //Debug.Log(maxHeap.Pop());
        //maxHeap.Display();
        //Debug.Log(maxHeap.Pop());
        //maxHeap.Display();
    }

    void Update()
    {
        
    }
}
