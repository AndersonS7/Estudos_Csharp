using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CourotineController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Test");
    }

    IEnumerator Test()
    {
        for (int i = 0; i <= 10; i++)
        {
            Debug.Log(i + " Executou...");
            yield return new WaitForSeconds(1f);//pausa nessa linha
        }

        //*� poss�vel usar quantas pausas achar necess�rio dentro de uma coroutine
        //Debug.Log("Executando corrotina!");
        //yield return new WaitForSeconds(5f); //pausa nessa linha
        //Debug.Log("Executando ap�s 5 segundos!");
    }
}
