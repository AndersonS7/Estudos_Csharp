using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : MonoBehaviour
{
    public string Name;
    public int Level;

    public Orc(string newName, int newLevel)
    {
        Name = newName;
        Level = newLevel;
    }
}
