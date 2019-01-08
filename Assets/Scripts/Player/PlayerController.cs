using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    PlayerState playerState = new PlayerState();
    GameController gameController;

    private void Awake()
    {
        
    }

    private void Start()
    {
        gameController = FindObjectOfType<GameController>();
    }

    private void Update()
    {
        //Touch();

        Click();
    }

    void Touch()
    {
        Touch touch;

        if(Input.touchCount > 0)
            for(int i=0;i< Input.touchCount;++i)
            {
                touch = Input.GetTouch(i);
                if(touch.phase == TouchPhase.Began)
                {
                    // 해야할 일

                    break;
                }
            }
    }

    void Click()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos3D = Input.mousePosition;
            Vector2 mousePos2D = new Vector2(mousePos3D.x, mousePos3D.y);

            if (gameController.CurrentEnemyObject != null)
                gameController.CurrentEnemyObject.SufferDamage(playerState.attackPower);
        }
    }
}
