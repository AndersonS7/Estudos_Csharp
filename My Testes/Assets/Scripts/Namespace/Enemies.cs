using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Enemys
{
    public class Enemies : MonoBehaviour
    {
        public float speed;
        public float lives;
    }

    public class AnotherEnemies : MonoBehaviour
    {
        public float speed;
        public float lives;
    }
}

/*
 * o namespace serve para poder guardar v�rias class dentro de uma cole��o
 * e assim pode acessalas por essa cole��o
 * muito usado para evitar conflitos de class em grandes projetos (com muitos scripts)
 */
