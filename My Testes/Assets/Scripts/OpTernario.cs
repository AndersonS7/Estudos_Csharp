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
            Debug.Log("O player est� vivo!");
        }
        else
        {
            Debug.Log("O player est� morto!");
        }

        //OPERADOR TERN�RIO | IF SIMPLIFICADO
        string msg = life > 0 ? "O player est� vivo" : "O player est� morto";
    }

}
