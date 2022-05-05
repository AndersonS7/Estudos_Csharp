using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Taverna : MonoBehaviour
{
    public MyCharacter[] Chars;

    // Start is called before the first frame update
    void Start()
    {
        Chars = new MyCharacter[2];

        Chars[0] = new ManCharacter();
        Chars[1] = new OrcCharacter();

        EnterTavern();
    }

    public void EnterTavern()
    {
        foreach (MyCharacter character in Chars)
        {
            character.Say();
        }
    }
}
