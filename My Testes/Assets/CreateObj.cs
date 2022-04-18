using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObj : MonoBehaviour
{
    [SerializeField] private GameObject wallPrefab;
    [SerializeField] private List<Transform> points;
    [SerializeField] private float timeCountLimit;

    private int index;
    private float timeCount;

    void Start()
    {
        timeCount = 0;
        CreatScenary(wallPrefab, points, Random.Range(0, points.Count));
    }

    void Update()
    {
        timeCount += Time.deltaTime;

        if (timeCount >= timeCountLimit)
        {
            index = Random.Range(0, points.Count);

            CreatScenary(wallPrefab, points, index);
            CreatScenary(wallPrefab, points, index);
            timeCount = 0;
        }
    }

    private void CreatScenary(GameObject prefabs, List<Transform> points, int value)
    {
        int index = value;
        switch (index)
        {
            case 0:
                Instantiate(ModifyObj(prefabs, false), points[index].transform.position, Quaternion.identity);
                break;

            case 1:
                Instantiate(ModifyObj(prefabs, 60), points[index].transform.position, Quaternion.identity);
                break;

            case 2:
                Instantiate(ModifyObj(prefabs, true), points[index].transform.position, Quaternion.identity);
                break;

            default:
                break;
        }
    }

    private GameObject ModifyObj(GameObject obj, bool inverse)
    {
        GameObject objTemp = obj;
        int x = Random.Range(2, 4);
        int y = Random.Range(1, 3);

        if (inverse)
        {
            objTemp.transform.localScale = new Vector3(x, -y, 0);
        }
        else
        {
            objTemp.transform.localScale = new Vector3(x, y, 0);
        }

        return objTemp;
    }

    private GameObject ModifyObj(GameObject obj, int percentagem)
    {
        GameObject objTemp = obj;
        int x = Random.Range(2, 4);
        int y = Random.Range(1, 3);

        int auxPercent = Random.Range(1, 100);

        if (auxPercent <= percentagem)
        {
            objTemp.transform.localScale = new Vector3(x, -y, 0);
        }
        else
        {
            objTemp.transform.localScale = new Vector3(x, y, 0);
        }

        return objTemp;
    }
}
