using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStartMenu : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }

    public void StartGame()
    {
        SceneTransitionManager.singleton.GoToScene(1);
    }


    public void gameCenaNegacaoFinal()
    {
        SceneTransitionManager.singleton.GoToScene(3);
    }

    public void gameCenaNegacao()
    {
        SceneTransitionManager.singleton.GoToScene(2);
    }

    public void gameCenaFinal()
    {
        SceneTransitionManager.singleton.GoToScene(4);
    }

    public void gameCenaTrivia()
    {
        SceneTransitionManager.singleton.GoToScene(5);
    }

    public void gameCenaMenuInicial()
    {
        SceneTransitionManager.singleton.GoToScene(0);
    }


}
