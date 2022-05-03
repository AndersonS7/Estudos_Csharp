using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpTernario : MonoBehaviour
{
    private int life;

    void Start()
    {
        //IF COMUM
        if (life > 0)
        {
            Debug.Log("O player está vivo!");
        }
        else
        {
            Debug.Log("O player está morto!");
        }

        //OPERADOR TERNÁRIO | IF SIMPLIFICADO
        string msg = life > 0 ? "O player está vivo" : "O player está morto";
    }

}
