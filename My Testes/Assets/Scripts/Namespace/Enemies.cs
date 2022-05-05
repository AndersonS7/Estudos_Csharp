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
 * o namespace serve para poder guardar várias class dentro de uma coleção
 * e assim pode acessalas por essa coleção
 * muito usado para evitar conflitos de class em grandes projetos (com muitos scripts)
 */
