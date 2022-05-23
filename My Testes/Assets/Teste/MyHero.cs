using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyHero : MonoBehaviour
{
    public string HeroName;
    public string HeroClass;
    public int life;
    public float power;

    public MyHero()
    {

    }
    public MyHero(string newName, string newClass, int newLife, float newPower)
    {
        HeroName = newName;
        HeroClass = newClass;
        life = newLife;
        power = newPower;
    }

    public void ToMove()
    {
        Debug.Log("Estou correndo");
    }

    public virtual void Attack()
    {
        Debug.Log("Atacando");
    }

    public virtual void Defence()
    {
        Debug.Log("Defesa");
    }
}
