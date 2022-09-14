using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayAgainButton : MonoBehaviour
{
    public string sceneName;

    public void GoToNewScene()
    {
        SceneManager.LoadScene(sceneName);
    }
}
