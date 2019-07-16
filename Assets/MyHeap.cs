using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHeap : MonoBehaviour
{
    List<int> list = new List<int>();

    public void Add(int val)
    {
        int curIndex = list.Count;
        list.Add(val);

        SortUp(curIndex);
    }

    public int Pop()
    {
        int val = -1;

        if (list.Count == 0)
            return val;

        val = list[0];
        list[0] = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
        SortDown(0);

        return val;
    }

    void SortUp(int curIndex)
    {
        if (curIndex == 0)
            return;

        int parentIndex = (curIndex - 1) / 2;

        if(list[curIndex] > list[parentIndex])
        {
            int temp = list[curIndex];
            list[curIndex] = list[parentIndex];
            list[parentIndex] = temp;

            SortUp(parentIndex);
        }
    }

    void SortDown(int curIndex)
    {
        int leftChild = curIndex * 2 + 1;
        int rightChild = curIndex * 2 + 2;

        if (leftChild >= list.Count)
            return;

        int childIndex = leftChild;
        if (rightChild < list.Count && list[leftChild] < list[rightChild])
            childIndex = rightChild;

        if(list[curIndex] < list[childIndex])
        {
            int temp = list[curIndex];
            list[curIndex] = list[childIndex];
            list[childIndex] = temp;

            SortDown(childIndex);
        }
    }

    public void Display()
    {
        foreach (int val in list)
            Debug.Log(val);
    }
}
