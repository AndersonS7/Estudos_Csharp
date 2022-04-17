using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObj : MonoBehaviour
{
    [SerializeField] private List<GameObject> obsPrefabs;
    [SerializeField] private List<Transform> pointsPos;

    void Start()
    {
        for (int i = 0; i < pointsPos.Count; i++)
        {
            Instantiate(obsPrefabs[i].transform, pointsPos[i].position, Quaternion.identity);
            obsPrefabs[2].transform.localScale 
                = new Vector2(transform.localScale.x, -transform.localScale.y);
        }
    }

    void Update()
    {

    }
}
