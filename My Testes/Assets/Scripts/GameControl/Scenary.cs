using UnityEngine;

public class Scenary : MonoBehaviour
{
    [SerializeField] private float speed;
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("End"))
        {
            Destroy(gameObject);
        }
    }
}
