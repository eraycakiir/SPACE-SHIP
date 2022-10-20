using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverObj : MonoBehaviour
{
    [SerializeField] GameObject gameOverPanel;
    private void Awake()
    {
        if (gameObject.activeSelf)
        {
            gameOverPanel.SetActive(false);
        }
    }
    private void OnEnable()
    {
        GameManager.Instance.OnGameOver += HandleOnGameOver;
    }
    private void OnDisable()
    {
        GameManager.Instance.OnGameOver -= HandleOnGameOver;
    }
    private void HandleOnGameOver()
    {
        if (!gameOverPanel.activeSelf)
        {
            gameOverPanel.SetActive(true);
        }
    }
}
