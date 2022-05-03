using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class POO : MonoBehaviour
{
    public class Hero
    {
        //ATRIBUTOS | VARIÁVEIS
        private string _name;
        private float _life;
        private int _power;

        //PROPRIEDADES | EMCAPSULAMENTO
        public string Name { get; set; }
        public float Life { get; set; }
        public int Power { get; set; }

        //CONSTRUTOR
        public Hero() { } // vazio
        public Hero(string name, float life, int power)
        {
            _name = name;
            _life = life;
            _power = power;
        }

        //COMPORTAMENTOS
        public void Attack()
        {
            //faz algo
        }

    }
}

/*
 * As propriedades permitem acessar variáveis privadas de outros scripts
 * Isso faz parte do conceito de Encapsulamento
 * 
 */
