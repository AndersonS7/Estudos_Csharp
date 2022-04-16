using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    private bool isInpulse;

    [Header("Values")]
    [SerializeField] private float radius;
    [SerializeField] private float totalFuel;
    [SerializeField] private float currentFuel;

    [Header("Components")]
    [SerializeField] private Image fuelSprite;
    [SerializeField] private LayerMask layer;
    [SerializeField] private GameObject panelGameOver;
    private ParticleSystem particleS;
    private Rigidbody2D rig;

    private void Start()
    {
        currentFuel = totalFuel;
        rig = GetComponent<Rigidbody2D>();
        particleS = GetComponentInChildren<ParticleSystem>();
    }

    private void Update()
    {
        DetectCollision();
        CheckInput();
        Fuel();
        OnMove();
    }

    private void FixedUpdate()
    {
        Impulse();
    }

    private void CheckInput()
    {
        if (Input.GetMouseButton(0))
        {
            isInpulse = true;
        }

        if (Input.GetMouseButtonUp(0))
        {
            isInpulse = false;
        }
    }

    private void OnMove()
    {
        transform.Translate(Vector2.right * 1f * Time.deltaTime);
    }

    private void Impulse()
    {
        if (currentFuel > 0)
        {
            if (Input.GetMouseButton(0))
            {
                particleS.Play();
                rig.AddForce(Vector2.up * 25f * Time.fixedDeltaTime, ForceMode2D.Impulse);
            }
        }
    }

    private void Fuel()
    {
        if (isInpulse)
        {
            currentFuel -= 0.05f;
            fuelSprite.fillAmount = currentFuel / totalFuel;
        }
    }

    private void DetectCollision()
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radius, layer);

        if (hit != null)
        {
            panelGameOver.SetActive(true);
            Destroy(gameObject);
        }
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}