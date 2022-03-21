using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    public GameObject enemy;
    public Transform[] points;
    public GameObject nextRoundPanel;
    public static bool enemyInit;

    private float time, roundCurrent, totalEnemiesInst;

    void Start()
    {
        totalEnemiesInst = 5;
        roundCurrent = 0;
        time = 0;
        enemyInit = false;
        nextRoundPanel.SetActive(false);
    }


    void Update()
    {
        NextRound();
        ControllInst();
    }
    private void ControllInst()
    {
        if (totalEnemiesInst > 0)
        {
            EnemyInst();
        }
    }
    private void EnemyInst()
    {
        time += Time.deltaTime;

        if (time >= 2)
        {
            Instantiate(enemy, points[Random.Range(0, points.Length)]
                .transform.position, enemy.transform.rotation);
            
            time = 0;
            totalEnemiesInst -= 1;
            enemyInit = true; // avisa ao player quando o primeiro inimigo é criado
        }
    }

    private void NextRound()
    {
        if (PlayerController.totalEnemyDeadRound >= totalEnemiesInst)
        {
            Time.timeScale = 0;
            nextRoundPanel.SetActive(true);
            print("próxima rodada");
        }
    }

}

public class Enemy : MonoBehaviour
{
    private float _speed, _life;
    private GameObject _target, _obj;

    public Enemy()
    {
    }
    public Enemy(float speed, float life, GameObject target, GameObject obj)
    {
        _speed = speed;
        _life = life;
        _target = target;
        _obj = obj;
    }

    public void ToMove()
    {
        _obj.transform.position = Vector2.MoveTowards(_obj.transform.position,
            _target.transform.position, _speed * Time.deltaTime);
    }

    public void DecrementLife(float damage)
    {
        _life -= damage;
    }

    public bool IsDead()
    {
        if (_life <= 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

