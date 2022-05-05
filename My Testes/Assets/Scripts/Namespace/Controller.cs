using System.Collections;
using System.Collections.Generic;
using Enemys;
using UnityEngine;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Enemys.Enemies enemy_1 = new Enemys.Enemies();
        Enemys.AnotherEnemies enemy_2 = new Enemys.AnotherEnemies();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
