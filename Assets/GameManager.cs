
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Playermovement movement;
    public float levelRestartDelay = 2f;

        public void EndGame()
    {
        movement.enabled = false;

        Invoke("RestartLevel", levelRestartDelay);

    }
    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }








}