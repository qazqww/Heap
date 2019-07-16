using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heap : MonoBehaviour
{
    List<int> items = new List<int>();

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void Add(int val)
    {
        items.Add(val);

        int curIndex = items.Count - 1;
        SortUp(curIndex);
    }

    public int Pop()
    {
        int val = -1;

        if (items.Count > 0)
        {
            val = items[0];
            items[0] = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            SortDown(0);
        }

        return val;
    }

    public void SortUp(int curIndex)
    {
        if (curIndex == 0)
            return;

        int parentIndex = (curIndex - 1) / 2;

        if (items[curIndex] < items[parentIndex])    // 부모 노드가 더 클 경우 (바꿈)
        {
            int temp = items[curIndex];
            items[curIndex] = items[parentIndex];
            items[parentIndex] = temp;

            SortUp(parentIndex);
        }
    }

    public void SortDown(int curIndex)
    {
        int leftChild = curIndex * 2 + 1;
        int rightChild = curIndex * 2 + 2;

        if (leftChild >= items.Count)
            return;

        int childIndex = leftChild;
        if (!(rightChild >= items.Count) && items[leftChild] > items[rightChild])
            childIndex = rightChild;

        if(items[childIndex] < items[curIndex])
        {
            int temp = items[curIndex];
            items[curIndex] = items[childIndex];
            items[childIndex] = temp;

            SortDown(childIndex);
        }
    }

    public void Display()
    {
        foreach (int val in items)
            Debug.Log(val);
    }
}