using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMaxHeap
{
    int[] list = new int[10] { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
    int curIndex = 0;

    public void Add(int num)
    {
        if (curIndex >= list.Length)
        {
            Debug.Log("Array Overflow");
            return;
        }
        list[curIndex] = num;
        SortUp(curIndex);
        curIndex++;
    }

    public int Pop()
    {
        if(curIndex < 0)
        {
            Debug.Log("Array Empty");
            return -1;
        }
        int pop = list[0];
        list[0] = list[--curIndex];
        list[curIndex] = -1;
        SortDown(0);
        return pop;
    }

    void SortUp(int index)
    {
        if (index == 0)
            return;

        int parentIndex = (index - 1) / 2;

        if (list[index] > list[parentIndex])
        {
            int temp = list[index];
            list[index] = list[parentIndex];
            list[parentIndex] = temp;
            SortUp(parentIndex);
        }
    }

    void SortDown(int index)
    {
        int childIndex_l = index * 2 + 1;
        int childIndex_r = index * 2 + 2;

        if (childIndex_l >= curIndex)
            return;

        int childIndex = childIndex_l;
        if (childIndex_r < curIndex && list[childIndex_r] > list[childIndex_l])
            childIndex = childIndex_r;

        if (list[index] < list[childIndex])
        {
            int temp = list[index];
            list[index] = list[childIndex];
            list[childIndex] = temp;
            SortDown(childIndex);
        }
    }

    public void Display()
    {
        string str = "List: ";
        int i = 0;
        while(i < list.Length)
        {
            if (list[i] == -1)
                break;
            str += list[i] + " ";
            i++;
        }
        Debug.Log(str);
    }
}


//public class MaxHeap : MonoBehaviour
//{
//    List<int> list = new List<int>();

//    public void AddNum(int num)
//    {
//        list.Add(num);
//        int index = list.Length - 1;
//        SortUp(index);
//    }

//    public int Pop()
//    {
//        int pop = list[0];
//        list[0] = list[list.Length - 1];
//        list.RemoveAt(list.Length - 1);
//        SortDown(0);
//        return pop;
//    }

//    void SortUp(int index)
//    {
//        if (index == 0)
//            return;

//        int parentIndex = (index - 1) / 2;

//        if (list[index] > list[parentIndex])
//        {
//            int temp = list[index];
//            list[index] = list[parentIndex];
//            list[parentIndex] = temp;
//            SortUp(parentIndex);
//        }
//    }

//    void SortDown(int index)
//    {
//        int childIndex_l = index * 2 + 1;
//        int childIndex_r = index * 2 + 2;

//        if (childIndex_l >= list.Length)
//            return;

//        int childIndex = childIndex_l;
//        if (childIndex_r < list.Length && list[childIndex_r] > list[childIndex_l])
//            childIndex = childIndex_r;

//        if (list[index] < list[childIndex])
//        {
//            int temp = list[index];
//            list[index] = list[childIndex];
//            list[childIndex] = temp;
//            SortDown(childIndex);
//        }
//    }

//    public void Display()
//    {
//        string str = string.Empty;
//        foreach (int num in list)
//            str += num + " ";
//        Debug.Log(str);
//    }
//}