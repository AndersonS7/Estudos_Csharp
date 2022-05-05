using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCharacter : MonoBehaviour
{
    public string charName;
    public float damage;

    public virtual void Say()
    {
        Debug.Log("Olá amigo!");
    }
}
