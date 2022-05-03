using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encapsulamento : MonoBehaviour
{
    private float life;

    public float Life
    {
        get
        {
            return life;
        }

        set
        {
            life -= value;

            if (life <= 0)
            {
                life = 0;
                Die();
            }
        }
    }

    private void Die()
    {
        // faz algo
    }
}

/*
 * O emcapsulamento serve para fazer o máximo possível com o minimo de código e scripts possíveis
 */
