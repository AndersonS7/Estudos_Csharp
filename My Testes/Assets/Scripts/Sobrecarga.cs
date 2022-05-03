using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sobrecarga
{
    public int Add(int a, int b)
    {
        return a * b;
    }

    public int Add(int a, int b, int c)
    {
        return a * b + c;
    }

    public string Add(string st1, string st2)
    {
        return st1 + " " + st2;
    }
}

public class Teste : MonoBehaviour
{
    Sobrecarga sob = new Sobrecarga();

    private void Start()
    {
        sob.Add(1, 2);
        sob.Add(1, 2, 3);
        sob.Add("T1", "T2");
    }
}

/*
 * A sobrecarga permite usar o mesmo nome para métodos que fazerm coisas diferentes.
 * Pode ser de mesmo tipo ou não
 */