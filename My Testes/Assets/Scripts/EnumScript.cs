using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumScript : MonoBehaviour
{
    //o enum � uma cole��o de valores constantes
    public enum Directions
    {
        Norte,
        Sul,
        Leste,
        Oeste
    }

    public Directions MyDirection;

    void Start()
    {
        switch (MyDirection)
        {
            case Directions.Norte:
                Debug.Log("Dire��o Norte foi escolhida");
                break;
            case Directions.Sul:
                Debug.Log("Dire��o Sul foi escolhida");
                break;
            case Directions.Leste:
                Debug.Log("Dire��o Leste foi escolhida");
                break;
            case Directions.Oeste:
                Debug.Log("Dire��o Oeste foi escolhida");
                break;
            default:
                break;
        }
    }

    void Update()
    {
        
    }
}
