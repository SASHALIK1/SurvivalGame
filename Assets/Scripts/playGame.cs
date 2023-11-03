using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playGame : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Game();
        }
    }
    public void Game()
    {
        SceneManager.LoadScene("MainScene");
    }
}
