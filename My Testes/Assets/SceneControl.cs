using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    [SerializeField] private GameObject panelGameOver;
    public void Restart()
    {
        SceneManager.LoadScene("Scene");

        if (panelGameOver.activeSelf)
        {
            panelGameOver.SetActive(false);
        }
    }
}
