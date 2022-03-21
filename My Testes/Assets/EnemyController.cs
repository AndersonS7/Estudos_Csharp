using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    private GameObject target;

    Enemy enemy;

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player");
        enemy = new Enemy(2, 2, target, gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        if (enemy.IsDead())
        {
            PlayerController.totalEnemyDeadRound += 1;
            Destroy(gameObject);
        }
        enemy.ToMove();
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Bullet"))
        {
            enemy.DecrementLife(1);
        }
    }
}
