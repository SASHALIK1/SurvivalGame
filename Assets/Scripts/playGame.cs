using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playGame : MonoBehaviour
{
    public bool NeedButton;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0) && !NeedButton)
        {
            Game();
        }
    }
    public void Game()
    {
        SceneManager.LoadScene("MainScene");
    }
}
