using UnityEngine;

public class GameStartMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(1);
    }

    public void TriviaStart()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(3);
    }

    public void PedraPapelStart()
    {
        SceneTransitionManager.singleton.GoToSceneAsync(2);
    }
}
