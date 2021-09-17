using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{

    public void LoadGame()
    {
        SceneManager.LoadScene("GameScene");
        ActivateButton.gameFinished = false;
        Counter.collisions = 0;
        Counter.end = false;
    }
}
