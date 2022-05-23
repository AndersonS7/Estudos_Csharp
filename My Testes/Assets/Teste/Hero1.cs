using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero1 : MyHero
{
    private void Start()
    {
        Debug.Log(HeroName);
        Attack();
    }

    public override void Attack()
    {
        Debug.Log("Novo Atack");
    }
}
