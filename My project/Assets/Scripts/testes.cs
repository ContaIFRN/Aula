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

    int Subtracao(int A, int B)
    {
        return A - B;
    }
}
    
    