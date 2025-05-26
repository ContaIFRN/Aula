using System;
using System.Runtime.Serialization;
using UnityEngine;

public class testes : MonoBehaviour
{
    private int A;
    private int B;
    private int C;


    void Start()
    {
        A = 23;
        B = 11;
        C = A + B;
        C = Soma(A, B);
        Debug.Log(C);
    }


    int Soma(int A, int B)
    {
        return A + B;
    }
}


public class testes1 : MonoBehaviour
{
    private int a;
    private int b;
    private int c;


    void Start()
    {
        a = 11;
        b = 12;
        c = Soma1(a, b);
        Debug.Log(c);
    }

    int Soma1(int a, int b)
    {
        return a + b;
    }
}
    
    