using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class StackTester : MonoBehaviour
{
    private void Awake()
    {
        //Stack s = new Stack(30);

        //s.Push(1);
        //s.Push(2);
        //s.Push(3);

        //Debug.Log(s);

        //s.Pop();

        //Debug.Log(s);

        //s.Pop();

        //Debug.Log(s);

        Stack<GameObject> s = new Stack<GameObject>(30);

        s.Push(new GameObject("1"));
        s.Push(new GameObject("2"));
        s.Push(new GameObject("3"));

        gameObject.GetComponent<Transform>();

        Debug.Log(s);

        s.Pop();
        s.Pop();

        Debug.Log(s);
    }
}
