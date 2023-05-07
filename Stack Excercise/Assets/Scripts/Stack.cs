using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Stack
{
    private int[] array;
    private int size;
    private int headIndex;

    public Stack(int capacity)
    {
        if (capacity <= 0) throw new ArgumentException();

        array = new int[capacity];

        size = 0;
        headIndex = -1;
    }

    public void Push(int element)
    {
        headIndex++;
        array[headIndex] = element;
        size++;
    }

    public int Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException();

        int element = array[headIndex];
        headIndex--;
        size--;

        return element;
    }

    public int Peek()
    {
        if (IsEmpty()) throw new InvalidOperationException();

        return array[headIndex];
    }

    public bool IsEmpty()
    {
        return size <= 0;
    }
}
