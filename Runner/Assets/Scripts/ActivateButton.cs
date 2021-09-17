using UnityEngine;
using UnityEngine.UI;

public class ActivateButton : MonoBehaviour
{
    public static bool gameFinished = false;
    public Button playAgainButton;
    public Button quitGameButton;

    
    // Start is called before the first frame update
    void Start()
    {
        quitGameButton.gameObject.SetActive(false);
        playAgainButton.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameFinished)
        {
            quitGameButton.gameObject.SetActive(true);
            playAgainButton.gameObject.SetActive(true);
        }
    }
}
