using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    [SerializeField] private GameObject panelGameOver;
    [SerializeField] private GameObject panelStart;
    public void Restart()
    {
        SceneManager.LoadScene("Scene");

        if (panelGameOver.activeSelf)
        {
            panelGameOver.SetActive(false);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene("Scene");
    }
}
