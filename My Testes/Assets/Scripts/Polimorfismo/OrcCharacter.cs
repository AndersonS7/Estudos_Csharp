using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcCharacter : MyCharacter
{
    void Start()
    {
        Say();
    }

    public override void Say()
    {
        Debug.Log("Ola, meu bom e velho amigo...");
    }
}
