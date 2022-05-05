using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heranca : MonoBehaviour
{

}

public class Enemy : Heranca
{
    public float life;
    public string charName;

    //o 'virtual' faz com que seja possível reescrever o método na class que herda dessa class
    public virtual void Attack()
    {
        Debug.Log("Atacando...");
    }
}

public class Hero : Enemy
{
    void Start()
    {
        Attack();
    }

    public override void Attack()
    {
        //o 'override' vai permitir usar o mesmo método da class base, porém sendo reescrita nessa class
    }
}

public class Zombie : Enemy
{
    private void Start()
    {
        Attack();
    }

    public override void Attack()
    {
        //o 'override' vai permitir usar o mesmo método da class base, porém sendo reescrita nessa class
    }
}
