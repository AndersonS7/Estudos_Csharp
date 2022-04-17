using UnityEngine;

public class Scenary : MonoBehaviour
{
    void Update()
    {
        transform.Translate(Vector2.left * 0.5f * Time.deltaTime);
    }
}
