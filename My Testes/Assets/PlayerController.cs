using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Text ammunitionUI;
    public GameObject bullet, target;
    public static int totalEnemyDeadRound;

    private float timeBullet, ammunition;

    void Start()
    {
        totalEnemyDeadRound = 0;
        ammunition = 10;
        timeBullet = 0;
    }


    void Update()
    {
        Rrecharge();
        Shot();
        UpdateUI();
    }

    private void Rrecharge()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ammunition += 1;
        }
    }

    private void Shot()
    {
        timeBullet += Time.deltaTime;

        if (Main.enemyInit && ammunition > 0)
        {
            if (timeBullet >= 1)
            {
                Instantiate(bullet, gameObject.transform.position, bullet.transform.rotation);
                timeBullet = 0;
                ammunition -= 1;
            }
        }
    }

    // atualiza o total de munição que tem no momento
    private void UpdateUI()
    {
        ammunitionUI.text = ammunition.ToString();
    }
}
