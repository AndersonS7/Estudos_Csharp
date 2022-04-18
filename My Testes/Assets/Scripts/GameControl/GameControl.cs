using UnityEngine.UI;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    [SerializeField] private GameObject startGame;
    [SerializeField] private Text countStartTxt;
    private float countStart;
    private Player player;

    public bool isInitiActive;

    void Awake()
    {
        countStart = 3;
        player = FindObjectOfType<Player>();
    }

    void Update()
    {
        if (isInitiActive)
        {
            StartGame();
        }
    }

    private void StartGame()
    {
        countStart -= Time.deltaTime;
        countStartTxt.text = countStart.ToString("0");

        if (countStart <= 0)
        {
            player.IsPaused = false;
            Destroy(startGame);
            Destroy(gameObject);
        }
    }
}