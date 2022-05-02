using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumScript : MonoBehaviour
{
    //o enum é uma coleção de valores constantes
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
                Debug.Log("Direção Norte foi escolhida");
                break;
            case Directions.Sul:
                Debug.Log("Direção Sul foi escolhida");
                break;
            case Directions.Leste:
                Debug.Log("Direção Leste foi escolhida");
                break;
            case Directions.Oeste:
                Debug.Log("Direção Oeste foi escolhida");
                break;
            default:
                break;
        }
    }

    void Update()
    {
        
    }
}
