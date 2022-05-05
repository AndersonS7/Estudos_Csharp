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

    //o 'virtual' faz com que seja poss�vel reescrever o m�todo na class que herda dessa class
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
        //o 'override' vai permitir usar o mesmo m�todo da class base, por�m sendo reescrita nessa class
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
        //o 'override' vai permitir usar o mesmo m�todo da class base, por�m sendo reescrita nessa class
    }
}
