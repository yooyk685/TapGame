using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameInstance : MonoBehaviour {

    static GameInstance _instance = null;

    public static GameInstance Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType(typeof(GameInstance)) as GameInstance;

                if(_instance == null)
                {
                    Debug.LogError("GameInstance dosen't exist");
                }
            }

            return _instance;
        }
    }

}
