using System;

public class Stack<T>
{
    private T[] array;
    private int count;

    private int headIndex => count - 1;
    private int stackCapacity => array.Length;

    private const int defaultCapacity = 10;

    public Stack()
    {
        array = new T[defaultCapacity];

        count = 0;
    }

    public Stack(int capacity)
    {
        if (capacity <= 0) throw new ArgumentException();

        array = new T[capacity];

        count = 0;
    }

    public void Push(T element)
    {
        if (count == stackCapacity)
        {
            T[] tmp = new T[stackCapacity * 2];

            for(int i = 0; i < stackCapacity; i++)
            {
                tmp[i] = array[i];
            }

            array = tmp;
        }

        count++;
        array[headIndex] = element;
    }

    public T Pop()
    {
        if (IsEmpty()) throw new InvalidOperationException();

        T element = array[headIndex];

        count--;

        if (count < stackCapacity / 4)
        {
            T[] tmp = new T[stackCapacity / 2];

            for (int i = 0; i < count; i++)
            {
                tmp[i] = array[i];
            }

            array = tmp;
        }

        return element;
    }

    public T Peek()
    {
        if (IsEmpty()) throw new InvalidOperationException();

        return array[headIndex];
    }

    public bool IsEmpty()
    {
        return count <= 0;
    }

    public override string ToString()
    {
        string result = string.Empty;

        for(int i = 0; i < headIndex; i++)
        {
            if(i == headIndex - 1)
            {
                result += array[i].ToString() + " ";
            }
            else
            {
                result += array[i].ToString() + ", ";
            }
            
        }

        result += array[headIndex].ToString() + "<- head | ";

        result += "Capacity: " + array.Length;

        return result;
    }
}
