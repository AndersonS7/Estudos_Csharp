using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrcController : MonoBehaviour
{
    public List<Orc> OrcList = new List<Orc>();
    public Dictionary<string, Orc> orc = new Dictionary<string, Orc>(); //<chave,valor>

    void Start()
    {
        UsingDictionary();
        //UsingList();
    }

    public void UsingDictionary()
    {
        Orc orc1 = new Orc("Durotan", 50);
        Orc orc2 = new Orc("Draka", 60);
        Orc orc3 = new Orc("Aggralan", 70);

        orc.Add("gurreiro", orc1);
        orc.Add("cozinheiro", orc2);
        orc.Add("mago", orc3);

        Orc orc4 = orc["mago"]; //está acessando o dicionario e fazendo uma cópia do orc3 para o 4
        Orc orc5 = null;

        if (orc.TryGetValue("mago", out orc4))
        {
            Debug.Log("Existe");
        }
        else
        {
            Debug.Log("Não Existe");
        }
    }

    public void UsingList()
    {
        OrcList.Add(new Orc("Durotan", 10));
        OrcList.Add(new Orc("Draka", 20));
        OrcList.Add(new Orc("Aggralan", 30));

        foreach (Orc orc in OrcList)
        {
            Debug.Log(orc.Name);
        }
    }
}
