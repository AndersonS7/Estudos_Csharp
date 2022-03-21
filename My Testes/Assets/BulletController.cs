using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField]
    private float speed;

    [SerializeField]
    private GameObject target;

    void Start()
    {
        if (GameObject.FindGameObjectWithTag("Enemy") != null)
        {
            target = GameObject.FindGameObjectWithTag("Enemy");
        }

        if (speed == 0)
        {
            speed = 5;
        }
    }

    void Update()
    {
        ToMove();
    }

    private void ToMove()
    {
        transform.position = Vector2.MoveTowards(gameObject.transform.position, 
            target.transform.position, speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
