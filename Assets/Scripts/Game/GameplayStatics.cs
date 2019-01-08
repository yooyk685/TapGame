using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameplayStatics : MonoBehaviour {

    static GameController _gameController;
    static PlayerController _playerController;
    static SceneController _sceneController;
    static GameState _gameState;
    static PlayerState _playerState;

    public static GameController gameController
    {
        get
        {
            if (_gameController == null)
            {
                _gameController = FindObjectOfType(typeof(GameController)) as GameController;

                if (_gameController == null)
                {
                    Debug.LogError("GameController dosen't exist");
                }
            }
            return _gameController;
        }
    }
}
