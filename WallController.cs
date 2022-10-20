using SpaceShip.Controllers;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.SearchService;
using UnityEngine;
using UnityEngine.SceneManagement;

public abstract class WallController : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        PlayerController playerController = other.collider.GetComponent<PlayerController>();
        if(playerController != null && playerController.CanMove)
        {
            GameManager.Instance.GameOver();
        }
    }
}
