using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject gameOverUI;
    public GameObject rightButton, leftButton;

    private void Start()
    {
        HideTouchButtons();
    }

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            gameOverUI.SetActive(true);
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    void HideTouchButtons()
    {
        if (Application.platform == RuntimePlatform.Android)
        {
            rightButton.SetActive(true);
            leftButton.SetActive(true);
        }
        else
        {
            rightButton.SetActive(false);
            leftButton.SetActive(false);
        }
    }
}
