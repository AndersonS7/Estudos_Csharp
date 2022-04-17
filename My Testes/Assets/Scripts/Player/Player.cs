using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    [Header("VALUES")]
    [SerializeField] private float radius;
    [SerializeField] private float currentFuel;
    [SerializeField] private float totalFuel;
    [SerializeField] private float decrementFuel;

    [Header("COMPONENTS")]
    [SerializeField] private Image fuelSprite;
    [SerializeField] private LayerMask layerObs;
    [SerializeField] private LayerMask layerFuel;
    [SerializeField] private LayerMask layerFinish;
    [SerializeField] private GameObject panelGameOver;
    [SerializeField] private GameObject panelFinish;

    private bool isPaused;
    private bool isInpulse;
    private Rigidbody2D rig;

    public float CurrentFuel { get => currentFuel; set => currentFuel = value; }
    public float TotalFuel { get => totalFuel; set => totalFuel = value; }
    public bool IsPaused { get => isPaused; set => isPaused = value; }

    private void Start()
    {
        isPaused = false;
        CurrentFuel = totalFuel;
        rig = GetComponent<Rigidbody2D>();
        rig.gravityScale = 0;
    }

    private void Update()
    {
        if (!isPaused)
        {
            if (rig.gravityScale == 0)
            {
                rig.gravityScale = 1;
            }

            Victory();
            GameOver();
            CheckInput();
            DecrementFuel();
            //OnMove();
        }   
    }

    private void FixedUpdate()
    {
        if (!isPaused)
        {
            Impulse();
        }
    }
    public void UpdateFuelBar()
    {
        fuelSprite.fillAmount = CurrentFuel / totalFuel;
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
        if (CurrentFuel > 0)
        {
            if (Input.GetMouseButton(0))
            {
                rig.AddForce(Vector2.up * 25f * Time.fixedDeltaTime, ForceMode2D.Impulse);
            }
        }
    }
    private void DecrementFuel()
    {
        if (isInpulse)
        {
            CurrentFuel -= decrementFuel;
            UpdateFuelBar();
        }
    }
    private void GameOver()
    {
        if (DetectCollision(layerObs))
        {
            panelGameOver.SetActive(true);
            Destroy(gameObject);
        }
    }
    private void Victory()
    {
        if (DetectCollision(layerFinish))
        {
            panelFinish.SetActive(true);
            Time.timeScale = 0;
        }
    }
    private bool DetectCollision(LayerMask layer)
    {
        Collider2D hit = Physics2D.OverlapCircle(transform.position, radius, layer);

        if (hit != null)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
