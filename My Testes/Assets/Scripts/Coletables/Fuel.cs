using UnityEngine;

public class Fuel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            CheckFuelObj(collision);
            Destroy(gameObject);
        }
    }

    private void CheckFuelObj(Collider2D obj)
    {
        float fuel = Random.Range(5, 10);
        float totalFuel = obj.GetComponent<Player>().TotalFuel;
        float currentFuel = obj.GetComponent<Player>().CurrentFuel;

        if (fuel + currentFuel > totalFuel)
        {
            obj.GetComponent<Player>().CurrentFuel = totalFuel;
            obj.GetComponent<Player>().UpdateFuelBar();
        }
        else
        {
            obj.GetComponent<Player>().CurrentFuel += fuel;
            obj.GetComponent<Player>().UpdateFuelBar();
        }
    }
}
