using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Propriedade : MonoBehaviour
{
    private int n;

    //FORMAS DE DECLARAR A PROPRIEDADE

    /*
    public int N { get; set; }

    public int N { get => n; set => n = value; }
    */

    public int N
    {
        get
        {
            //� poss�vel fazer a��es no retorno da propriedade
            return n / 1; 
        }
        set
        {
            //� poss�vel fazer a��es ao alterar a propriedade
            if (n > 5)
            {
                n = value;
            }
        }
    }

}

//propriedades permitem acessar as vari�veis privadas de outros locais do projeto
