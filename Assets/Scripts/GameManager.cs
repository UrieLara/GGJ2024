using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public enum GameState
{
    menu,
    inGame,
    gameOver
}
public class GameManager : MonoBehaviour
{
    public GameManager sharedInstance;

    public GameState currentGameState = GameState.menu;

 

    private void Awake()
    {
        if (sharedInstance == null)
        {
            sharedInstance = this;
        }
    }
    void Start()
    {
       
    }

    void Update()
    {
        if (Input.GetButton("Submit") && currentGameState != GameState.inGame)
        {
            StartGame();
        }
    }


    public void StartGame()
    {
        SetGameState(GameState.inGame);

    }

    public void GameOver()
    {
        SetGameState(GameState.gameOver);
    }

    public void BackToMenu()
    {
        SetGameState(GameState.menu);
    }


    void SetGameState(GameState newGameState)
    {
        if (newGameState == GameState.menu)
        {
            //TODO: Al querer volver al menú principal

        }
        else if (newGameState == GameState.inGame)
        {
            SceneManager.LoadScene("Game");
        }
        else if (newGameState == GameState.gameOver)
        {
           //TODO: Cuando se termina el juego

        }

        this.currentGameState = newGameState;
    }

    public void QuitGame()
    {
        #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
        #else
                                            Application.Quit();
        #endif
    }
}
